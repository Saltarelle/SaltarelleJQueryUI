using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class Size {
        public int Width { get; set; }
        public int Height { get; set; }

        public Size(int width, int height) {
        }
    }
}
