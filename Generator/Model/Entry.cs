﻿// Entry.cs
// jQueryUIGenerator/Model
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

namespace Saltarelle.JQueryUI.Generator.Model {
	public class Entry {
		public string[] Categories { get; set; }

		public string Created { get; set; }

		public string Description { get; set; }

		public string EventPrefix { get; set; }

		public IList<Event> Events { get; set; }

		public Example Example { get;  set; }

		public string LongDescription { get; set; }

		public IList<Method> Methods { get; set; }

		public IList<Property> Properties { get; set; }

		public string Name { get; set; }

		public IList<Option> Options { get; set; }

		public string Type { get; set; }

		public IList<Argument> Arguments { get; set; }

		internal Entry Clone() {
			return (Entry)MemberwiseClone();
		}
	}
}
