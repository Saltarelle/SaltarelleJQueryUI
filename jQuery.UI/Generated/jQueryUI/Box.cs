using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI {

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
}
