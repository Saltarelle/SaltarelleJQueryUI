using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class ResizableStopEvent {

        public jQueryObject Element {
            get; set;
        }

        public jQueryObject Helper {
            get; set;
        }

        public jQueryObject OriginalElement {
            get; set;
        }

        public jQueryPosition OriginalPosition {
            get; set;
        }

        public Size OriginalSize {
            get; set;
        }

        public jQueryPosition Position {
            get; set;
        }

        public Size Size {
            get; set;
        }
    }
}
