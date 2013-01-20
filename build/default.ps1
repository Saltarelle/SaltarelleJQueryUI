Framework "4.0x86"

properties {
	$baseDir = Resolve-Path ".."
	$buildtoolsDir = Resolve-Path "."
	$outDir = "$(Resolve-Path "".."")\bin"
	$configuration = "Debug"
	$releaseTagPattern = "release-(.*)"
	$skipTests = $false
	$noAsync = $false
	$autoVersion = $true
}

Function Get-DotNetVersion($RawVersion) {
	Return New-Object System.Version(($RawVersion -Replace "-.*$","")) # Remove any pre-release information
}

Function Get-DependencyVersion($RawVersion) {
	$netVersion = Get-DotNetVersion -RawVersion $RawVersion
	Return New-Object System.Version($netVersion.Major, $netVersion.Minor)
}

Task default -Depends Build

Task Clean {
	if (Test-Path $outDir) {
		rm -Recurse -Force "$outDir" >$null
	}
	md "$outDir" >$null
}

Task Generate-Source -Depends Determine-Version {
	Exec { msbuild "$baseDir\Generator.sln" /verbosity:minimal /p:"Configuration=$configuration" }
	rmdir -Force -Recurse -ErrorAction SilentlyContinue "$baseDir\jQuery.UI\Generated" | Out-Null
	Exec { & "$baseDir\Generator\bin\Saltarelle.jQueryUI.Generator.exe" "$baseDir\api.jqueryui.com\entries" "$baseDir\jQuery.UI\Generated" | Out-Null }
	Generate-VersionFile -Path "$baseDir\jQuery.UI\Properties\Version.cs" -Version $script:Version
}

Task Build-Library -Depends Clean, Generate-Source {
	Exec { msbuild "$baseDir\jQuery.UI.sln" /verbosity:minimal /p:"Configuration=$configuration" }
}

Task Build-NuGetPackages -Depends Determine-Version, Build-Library {
	$config = [xml](Get-Content $baseDir\jQuery.UI\packages.config)
	$runtimeVersion = $config.SelectSingleNode("//package[@id='Saltarelle.Runtime']/@version").Value
	$webVersion = $config.SelectSingleNode("//package[@id='Saltarelle.Web']/@version").Value
	$jQueryVersion = $config.SelectSingleNode("//package[@id='Saltarelle.jQuery']/@version").Value

@"
<package xmlns="http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd">
	<metadata>
		<id>Saltarelle.jQuery.UI</id>
		<version>$script:Version</version>
		<title>Metadata required to use jQuery UI with the Saltarelle C# to JavaScript compiler</title>
		<description>This package contains the required metadata to use jQuery UI with the Saltarelle C# to JavaScript compiler. It is a slightly modified version of the jQuery import library from the Script# project by Nikhil Kothari (https://github.com/nikhilk/scriptsharp).</description>
		<licenseUrl>http://www.apache.org/licenses/LICENSE-2.0.txt</licenseUrl>
		<authors>Ivaylo Gochkov, Erik Källén</authors>
		<projectUrl>http://www.saltarelle-compiler.com</projectUrl>
		<tags>compiler c# javascript web jQuery jQueryUI</tags>
		<dependencies>
			<dependency id="Saltarelle.Runtime" version="$(Get-DependencyVersion $runtimeVersion)"/>
			<dependency id="Saltarelle.Web" version="$(Get-DependencyVersion $webVersion)"/>
			<dependency id="Saltarelle.jQuery" version="$(Get-DependencyVersion $jQueryVersion)"/>
		</dependencies>
	</metadata>
	<files>
		<file src="$baseDir\License.txt" target=""/>
		<file src="$baseDir\jQuery.UI\bin\Saltarelle.jQuery.UI.dll" target="lib"/>
		<file src="$baseDir\jQuery.UI\bin\Saltarelle.jQuery.UI.xml" target="lib"/>
		<file src="$baseDir\jQuery.UI\jquery-ui*.js" target=""/>
	</files>
</package>
"@ | Out-File -Encoding UTF8 "$outDir\jQuery.UI.nuspec"

	Exec { & "$buildtoolsDir\nuget.exe" pack "$outDir\jQuery.UI.nuspec" -NoPackageAnalysis -OutputDirectory "$outDir" }
}

Task Build -Depends Build-NuGetPackages {
}

Function Determine-PathVersion($RefCommit, $RefVersion, $Path) {
	if ($autoVersion) {
		$RefVersion = New-Object System.Version(($RefVersion -Replace "-.*$",""))
		if ($RefVersion.Build -lt 0) {
			$RefVersion = New-Object System.Version($RefVersion.Major, $RefVersion.Minor, 0)
		}
	
		$revision = ((git log "$RefCommit..HEAD" --pretty=format:"%H" -- (@($Path) | % { """$_""" })) | Measure-Object).Count # Number of commits since our reference commit
		if ($revision -gt 0) {
			Return New-Object System.Version($RefVersion.Major, $RefVersion.Minor, $RefVersion.Build, $revision)
		}
	}

	$RefVersion
}

Function Determine-Ref {
	$refcommit = % {
	(git log --decorate=full --simplify-by-decoration --pretty=oneline HEAD |           # Append items from the log
		Select-String '\(' |                                                            # Only include entries with names
		% { ($_ -replace "^[^(]*\(([^)]*)\).*$","`$1" -replace " ", "").Split(',') } |  # Select only the names, one line per name, delete spaces
		Select-String "^tag:$releaseTagPattern`$" |                                     # Only tags of interest
		% { $_ -replace "^tag:","" }                                                    # Remove the tag: prefix
	) } { git log --reverse --pretty=format:%H | Select-Object -First 1 } |             # Add the oldest commit as a fallback
	Select-Object -First 1
	
	If ($refcommit | Select-String "^$releaseTagPattern`$") {
		$refVersion = $refcommit -replace "^$releaseTagPattern`$","`$1"
	}
	else {
		$refVersion = "0.0.0"
	}

	($refcommit, $refVersion)
}

Task Determine-Version {
	if (-not $autoVersion) {
		if ((git log -1 --decorate=full --simplify-by-decoration --pretty=oneline HEAD |
			 Select-String '\(' |
			 % { ($_ -replace "^[^(]*\(([^)]*)\).*$","`$1" -replace " ", "").Split(',') } |
			 Select-String "^tag:$releaseTagPattern`$" |
			 % { $_ -replace "^tag:","" } |
			 Measure-Object
			).Count -eq 0) {
			
			Throw "The most recent commit must be tagged when not using auto-versioning"
		}
	}

	$refs = Determine-Ref
	$script:Version = Determine-PathVersion -RefCommit $refs[0] -RefVersion $refs[1] -Path "$baseDir"

	"Version: $script:Version"
}

Function Generate-VersionFile($Path, $Version) {
	$Version = Get-DotNetVersion -RawVersion $Version
@"
[assembly: System.Reflection.AssemblyVersion("$($Version.Major).$($Version.Minor).0.0")]
[assembly: System.Reflection.AssemblyFileVersion("$Version")]
"@ | Out-File $Path -Encoding "UTF8"
}
