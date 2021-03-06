﻿// Generator.cs
// jQueryUIGenerator
//
// Copyright 2012 Ivaylo Gochkov
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Saltarelle.JQueryUI.Generator.Model;

namespace Saltarelle.JQueryUI.Generator {
	/// <summary>
	/// Script# jQueryUI API generator
	/// </summary>
	public partial class Generator {
		private string DestinationPath;
		private TextWriter Messages;

		/// <summary>
		/// Creates a generator of ScriptSharp jQueryUI library.
		/// </summary>
		/// <param name="destinationPath">Location of the generated files.</param>
		/// <param name="messageStream">A message stream.</param>
		public Generator(string destinationPath, TextWriter messageStream = null) {
			Debug.Assert(!string.IsNullOrEmpty(destinationPath), "Destination path is not specified.");

			DestinationPath = destinationPath;
			Messages = messageStream ?? TextWriter.Null;
		}

		/// <summary>
		/// Generates SriptSharp files
		/// </summary>
		/// <param name="entries">List of jQueryUI entries.</param>
		public void Render(IList<Entry> entries) {
			if (entries == null) {
				return;
			}

			DirectoryInfo destination = new DirectoryInfo(DestinationPath);
			if (destination.Exists) {
				destination.Delete(true);
			}

			foreach (Entry entry in entries.Where(e => e.Type != "selector" && e.Name != "jQuery.ui.mouse" && e.Name != "jQuery.widget")) {
				Messages.WriteLine("Generating " + Path.Combine(DestinationPath, Utils.PascalCase(entry.Name)));

				RenderEntry(entry);
			}

			Messages.WriteLine("Generating jQueryUI base files.");
			RenderEventHandler();
			RenderBox();
			RenderSize();
			RenderEffectExtensionMethods(entries.Where(e => e.Type == "effect"));
			RenderInteractionOrWidgetExtensionMethods("Interaction", entries.Where(e => e.Categories.Contains("interactions") && e.Name != "jQuery.ui.mouse"));
			RenderInteractionOrWidgetExtensionMethods("Widget", entries.Where(e => e.Categories.Contains("widgets") && e.Name != "jQuery.Widget" && e.Name != "jQuery.widget"));
			RenderExtensionMethods(entries.Where(e => e.Type == "method"));
			RenderProperties(entries.Where(e => e.Type == "property"));
		}

		private void RenderEntry(Entry entry) {
			if (entry == null) {
				return;
			}

			if (entry.Name != "position" && entry.Type != "effect" && entry.Type != "method" && entry.Type != "property" && entry.Name != "jQuery.Widget") {
				RenderObject(entry);
			}
			if (((entry.Type != "method" && entry.Type != "property") || (entry.Name != "effect" && entry.Name != "show" && entry.Name != "hide" && entry.Name != "toggle")) && entry.Name != "jQuery.Widget") {
				RenderOptions(entry);
			}
			RenderEvents(entry);
		}

		private void RenderObject(Entry entry) {
			string className = Utils.PascalCase(entry.Name) + @"Object";

			string content =
@"using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace {5} {{

    /// <summary>
    /// {1}
    /// </summary>
    /// <remarks>
    /// {2}
    /// </remarks>
    [Imported]
    [IgnoreNamespace]{4}
    public sealed class {0} {{

        private {0}() {{
        }}{3}

        [ScriptSkip]
        public static explicit operator jQueryObject({0} o) {{
            return null;
        }}

        [ScriptSkip]
        public static explicit operator {0}(jQueryObject o) {{
            return null;
        }}
    }}
}}";
			StringBuilder methodsContent = new StringBuilder();

			foreach (var method in entry.Methods.OrderBy(m => m.Name)) {
				methodsContent.AppendLine();
				methodsContent.AppendLine();
				methodsContent.AppendLine("        /// <summary>");
				methodsContent.AppendLine("        /// " + Utils.FormatXmlComment(method.Description.Replace("<entryname />", entry.Name)));
				methodsContent.AppendLine("        /// </summary>");
				methodsContent.AppendLine("        [InlineCode(\"{this}." + entry.Name + "('" + method.Name + "'" + string.Join("", method.Arguments.Select(a => ", {" + a.Name + "}")) + ")\")]");

				methodsContent.Append("        public " + (string.IsNullOrEmpty(method.ReturnType) ? "void" : Utils.MapDataType(method.ReturnType, className, "")) + " " + Utils.PascalCase(method.Name) + "(");
				List<string> args = new List<string>();
				foreach (Argument arg in method.Arguments) {
					args.Add(Utils.MapDataType(arg.Type, className, arg.Description) + " " + (arg.Name == "event" ? "@event" : arg.Name));
				}
				methodsContent.AppendLine(string.Join(", ", args) + ") {");
				if (!string.IsNullOrEmpty(method.ReturnType)) {
					methodsContent.AppendLine("                return " + Utils.GetDefaultValue(method.ReturnType) + ";");
				}
				methodsContent.AppendLine("        }");
			}

			foreach (var option in entry.Options
				                        .OrderBy(o => o.Name)
				                        .GroupBy(o => o.Name)) {
				string name = (entry.Methods.Any(m => m.Name == option.Key) ? "Option" : "") + Utils.PascalCase(option.Key);
				string description = option.Min(o => o.Description);
				methodsContent.AppendLine();
				methodsContent.AppendLine();
				if (!string.IsNullOrEmpty(description)) {
					methodsContent.AppendLine("        /// <summary>");
					methodsContent.AppendLine("        /// " + Utils.FormatXmlComment(description.Replace("<entryname />", entry.Name)));
					methodsContent.AppendLine("        /// </summary>");
				}
				methodsContent.AppendLine("        public " + Utils.MapDataType(option.Select(o => o.Type), className, option.Min(o => o.Description)) + " " + name + " {");
				methodsContent.AppendLine("            [InlineCode(\"{this}." + entry.Name + "('option', '" + option.Key + "')\")]");
				methodsContent.AppendLine("            get;");
				methodsContent.AppendLine("            [InlineCode(\"{this}." + entry.Name + "('option', '" + option.Key + "', {value})\")]");
				methodsContent.AppendLine("            set;");
				methodsContent.AppendLine("        }");
			}

			foreach (Event @event in entry.Events.OrderBy(e => e.Name)) {
				string eventType;
				if (@event.Arguments.All(a => a.Properties.Count == 0)) {
					eventType = "jQueryUIEventHandler<object>";
				}
				else {
					eventType = "jQueryUIEventHandler<" + Utils.PascalCase(entry.Name) + Utils.PascalCase(@event.Name) + "Event" + ">";
				}

				methodsContent.AppendLine();
				methodsContent.AppendLine();
				methodsContent.AppendLine("        /// <summary>");
				methodsContent.AppendLine("        /// " + Utils.FormatXmlComment(@event.Description.Replace("<entryname />", entry.Name)));
				methodsContent.AppendLine("        /// </summary>");
				methodsContent.AppendLine("        public event " + eventType + " On" + Utils.PascalCase(@event.Name) + " {");
				methodsContent.AppendLine("            [InlineCode(\"{this}.bind('" + entry.EventPrefix + @event.Name.ToLower() + "', {value})\")]");
				methodsContent.AppendLine("            add {");
				methodsContent.AppendLine("            }");
				methodsContent.AppendLine("            [InlineCode(\"{this}.unbind('" + entry.EventPrefix + @event.Name.ToLower() + "', {value})\")]");
				methodsContent.AppendLine("            remove {");
				methodsContent.AppendLine("            }");
				methodsContent.AppendLine("        }");
			}

			string formatedContent = string.Format(content,
			                                       className,
			                                       Utils.FormatXmlComment(entry.Description.Replace("<entryname />", entry.Name)),
			                                       Utils.FormatXmlComment(entry.LongDescription.Replace("<entryname />", entry.Name)),
			                                       methodsContent.ToString(),
			                                       string.Empty,
			                                       Utils.GetNamespace(entry));

			Utils.CreateFile(Path.Combine(DestinationPath, Utils.PascalCase(entry.Categories[0]), Utils.PascalCase(entry.Name)), className, formatedContent);
		}

		private void RenderOptions(Entry entry) {
			if (entry.Events.Count == 0 && entry.Options.Count == 0) {
				return;
			}

			string className = Utils.PascalCase(entry.Name) + @"Options";

			string content =
@"using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace {3} {{

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class {0} {{
{1}{2}    }}
}}";
			StringBuilder eventsContent = new StringBuilder();

			foreach (Event @event in entry.Events.OrderBy(e => e.Name)) {
				if (!string.IsNullOrEmpty(@event.Description)) {
					eventsContent.Append(
@"
        /// <summary>
        /// " + Utils.FormatXmlComment(@event.Description.Replace("<entryname />", entry.Name)) + @"
        /// </summary>");
				}

				string eventType;
				if (@event.Arguments.All(a => a.Properties.Count == 0)) {
					eventType = "jQueryUIEventHandler<object>";
				} else {
					eventType = "jQueryUIEventHandler<" + Utils.PascalCase(entry.Name) + Utils.PascalCase(@event.Name) + "Event" + ">";
				}

				eventsContent.AppendLine(
@"
        [ScriptName(""" + @event.Name + @""")]
        public " + eventType + " On" + Utils.PascalCase(@event.Name) + @" {
             get; set;
        }");
            }

			StringBuilder optionsContent = new StringBuilder();

			foreach (var option in entry.Options
											.OrderBy(o => o.Name)
											.GroupBy(o => o.Name)) {
				if (!string.IsNullOrEmpty(option.Min(o => o.Description))) {
					optionsContent.Append(
@"
        /// <summary>
        /// " + Utils.FormatXmlComment(option.Min(o => o.Description).Replace("<entryname />", entry.Name)) + @"
        /// </summary>");
				}

				optionsContent.AppendLine(@"
        public " + Utils.MapDataType(option.Select(o => o.Type), className, option.Min(o => o.Description)) + @" " + Utils.PascalCase(option.Key) + @" {
            get; set;
        }");
			}

			Utils.CreateFile(Path.Combine(DestinationPath, entry.Categories[0] == "methods" ? "." : Utils.PascalCase(entry.Categories[0]), Utils.PascalCase(entry.Name)),
			                 className,
			                 string.Format(content,
			                               className,
			                               optionsContent,
			                               eventsContent,
			                               Utils.GetNamespace(entry)));
		}

		private void RenderEvents(Entry entry) {
			if (entry.Events.Count == 0) {
				return;
			}

			string content =
@"using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace {2} {{

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class {0} {{{1}
    }}
}}";
			string property = @"

        public {1} {0} {{
            get; set;
        }}";

			foreach (var @event in entry.Events.OrderBy(e => e.Name)) {
				string eventType = Utils.PascalCase(entry.Name) + Utils.PascalCase(@event.Name);

				foreach (Argument arg in @event.Arguments) {
					if (arg.Name != "ui" || arg.Properties.Count == 0)
						continue;

					string className = Utils.PascalCase(eventType) + "Event";

					StringBuilder properties = new StringBuilder();

					foreach (Property prop in arg.Properties.OrderBy(p => p.Name)) {
						properties.Append(string.Format(property, Utils.PascalCase(prop.Name), Utils.MapDataType(prop.Type, className, prop.Description)));
					}

					Utils.CreateFile(Path.Combine(DestinationPath, Utils.PascalCase(entry.Categories[0]), Utils.PascalCase(entry.Name)),
					                 className,
					                 string.Format(content, className, properties.ToString(), Utils.GetNamespace(entry)));
				}
			}
		}

		private void RenderEffectExtensionMethods(IEnumerable<Entry> effects) {
			string content =
@"using System;
using System.Threading.Tasks;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {{

    [Imported]
    [IgnoreNamespace]
    public static class EffectExtensions {{{0}
    }}
}}";

			var methods = new StringBuilder();
			foreach (var effect in effects) {
				foreach (var facet in new[] { "", "show", "hide", "toggle" }) {
					methods.AppendLine();
					methods.AppendLine();
					methods.AppendLine("        /// <summary>");
					methods.AppendLine("        /// " + Utils.FormatXmlComment(effect.Description.Replace("<entryname />", effect.Name)));
					methods.AppendLine("        /// </summary>");
					methods.AppendLine("        [InlineCode(\"{q}." + (facet == "" ? "effect" : facet) + "('" + effect.Name + "', {options}, {duration}, {callback})\")]");
					methods.AppendLine("        public static jQueryObject " + Utils.PascalCase(facet) + Utils.PascalCase(effect.Name) + "(this jQueryObject q, " + Utils.PascalCase(effect.Name) + "Options options = null, TypeOption<int, string> duration = null, Action callback = null) {");
					methods.AppendLine("            return null;");
					methods.AppendLine("        }");

					methods.AppendLine();
					methods.AppendLine();
					methods.AppendLine("        /// <summary>");
					methods.AppendLine("        /// " + Utils.FormatXmlComment(effect.Description.Replace("<entryname />", effect.Name)));
					methods.AppendLine("        /// </summary>");
					methods.AppendLine("        [InlineCode(\"{$System.Threading.Tasks.Task}.fromDoneCallback({q}, '" + (facet == "" ? "effect" : facet) + "', -1, '" + effect.Name + "', {options}, {duration})\")]");
					methods.AppendLine("        public static Task " + Utils.PascalCase(facet) + Utils.PascalCase(effect.Name) + "Task(this jQueryObject q, " + Utils.PascalCase(effect.Name) + "Options options = null, TypeOption<int, string> duration = null) {");
					methods.AppendLine("            return null;");
					methods.AppendLine("        }");
				}
			}

			Utils.CreateFile(Path.Combine(DestinationPath, "Effects"), "EffectExtensions", string.Format(content, methods.ToString()));
		}

		private void RenderInteractionOrWidgetExtensionMethods(string category, IEnumerable<Entry> interactions) {
			string content =
@"using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.{0}s {{

    [Imported]
    [IgnoreNamespace]
    public static class {0}Extensions {{{1}
    }}
}}";

			var methods = new StringBuilder();
			foreach (var inter in interactions) {
				methods.AppendLine()
				       .AppendLine()
				       .AppendLine("        /// <summary>")
				       .AppendLine("        /// " + Utils.FormatXmlComment(inter.Description.Replace("<entryname />", inter.Name)))
				       .AppendLine("        /// </summary>")
				       .AppendLine("        [InstanceMethodOnFirstArgument]")
				       .AppendLine("        [ScriptName(\"" + inter.Name + "\")]")
				       .AppendLine("        public static " + Utils.PascalCase(inter.Name) + "Object " + Utils.PascalCase(inter.Name) + "(this jQueryObject q) {")
				       .AppendLine("            return null;")
				       .AppendLine("        }")
				       .AppendLine()
				       .AppendLine()
				       .AppendLine("        /// <summary>")
				       .AppendLine("        /// " + Utils.FormatXmlComment(inter.Description.Replace("<entryname />", inter.Name)))
				       .AppendLine("        /// </summary>")
				       .AppendLine("        [InstanceMethodOnFirstArgument]")
				       .AppendLine("        [ScriptName(\"" + inter.Name + "\")]")
				       .AppendLine("        public static " + Utils.PascalCase(inter.Name) + "Object " + Utils.PascalCase(inter.Name) + "(this jQueryObject q, " + Utils.PascalCase(inter.Name) + "Options options) {")
				       .AppendLine("            return null;")
				       .AppendLine("        }");
			}

			Utils.CreateFile(Path.Combine(DestinationPath, category + "s"), category + "Extensions", string.Format(content, category, methods.ToString()));
		}

		private void RenderExtensionMethods(IEnumerable<Entry> entries) {
			string content =
@"using System;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Effects;

namespace jQueryApi.UI {{

    [Imported]
    [IgnoreNamespace]
    public static class jQueryUIExtensions {{{0}
    }}
}}";
			var methods = new StringBuilder();

			foreach (var entry in entries.Where(e => e.Name != "effect" && e.Name != "show" && e.Name != "hide" && e.Name != "toggle" && e.Name != "jQuery.widget")) {
				methods.AppendLine();
				methods.AppendLine();
				methods.AppendLine("        /// <summary>");
				methods.AppendLine("        /// " + Utils.FormatXmlComment(entry.Description.Replace("<entryname />", entry.Name)));
				methods.AppendLine("        /// </summary>");
				methods.AppendLine("        [InstanceMethodOnFirstArgument]");
				methods.Append(    "        public static jQueryObject " + Utils.PascalCase(entry.Name) + "(this jQueryObject q");
				foreach (var arg in entry.Arguments) {
					methods.Append(", ");
					if (arg.Name == "options")
						methods.Append(Utils.PascalCase(entry.Name) + "Options");
					else
						methods.Append(Utils.MapDataType(arg.Type, null, ""));
					methods.Append(" ").Append(Utils.EnsureValidCSharpIdentifier(arg.Name));
				}
				methods.AppendLine(") {");
				methods.AppendLine("            return null;");
				methods.AppendLine("        }");

				Utils.CreateFile(DestinationPath, "jQueryUIExtensions", string.Format(content, methods.ToString()));
			}
		}

		private void RenderProperties(IEnumerable<Entry> entries) {
			foreach (var entry in entries) {
				var parts = entry.Name.Split('.');
				var nmspace = string.Join(".", parts.Take(parts.Length - 1));
				var name = parts[parts.Length - 1];

				string content =
@"using System;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi.UI.Effects;

namespace jQueryApi.UI {{
    [Imported]
    [ScriptNamespace(""{0}"")]
    [ScriptName(""{1}"")]
    public static class {2} {{
{3}
    }}
}}";
				var properties = new StringBuilder();
				foreach (var prop in entry.Properties) {
					if (!string.IsNullOrWhiteSpace(prop.Description)) {
						properties.AppendLine("        /// <summary>")
						          .AppendLine("        /// " + Utils.FormatXmlComment(entry.Description.Replace("<entryname />", entry.Name)))
						          .AppendLine("        /// </summary>");
					}

					properties.AppendLine(string.Format("        [IntrinsicProperty, ScriptName(\"{0}\")]", prop.Name))
					          .AppendLine(string.Format("        public static {0} {1} {{ get; set; }}", Utils.MapDataType(prop.Type, null, ""), Utils.PascalCase(prop.Name)))
					          .AppendLine();
				}

				Utils.CreateFile(DestinationPath, Utils.PascalCase(name), string.Format(content, nmspace, name, Utils.PascalCase(name), properties));
			}
		}

		private void RenderEventHandler() {
			string className = "jQueryUIEventHandler";

			string content =
@"using System.Runtime.CompilerServices;

namespace " + Utils.GetNamespace(null) + @" {
    public delegate void " + className + @"<in T>(jQueryEvent e, T uiEvent);
}";

			Utils.CreateFile(Path.Combine(DestinationPath, "jQueryUI"), className, content);
		}

		private void RenderBox() {
			string content =
@"using System;
using System.Runtime.CompilerServices;

namespace " + Utils.GetNamespace(null) + @" {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class Box {
        public int? Left { get; set; }
        public int? Top { get; set; }
        public int? Right { get; set; }
        public int? Bottom { get; set; }

        public Box() {
        }

        public Box(int? left = null, int? top = null, int? right = null, int? bottom = null) {
        }
    }
}";

			Utils.CreateFile(Path.Combine(DestinationPath, "jQueryUI"), "Box", content);
		}

		private void RenderSize() {
			string content =
@"using System;
using System.Runtime.CompilerServices;

namespace " + Utils.GetNamespace(null) + @" {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class Size {
        public int Width { get; set; }
        public int Height { get; set; }

        public Size(int width, int height) {
        }
    }
}";

			Utils.CreateFile(Path.Combine(DestinationPath, "jQueryUI"), "Size", content);
		}
	}
}
