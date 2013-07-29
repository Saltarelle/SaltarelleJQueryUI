using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class DialogResizeStartEvent {

        public object OriginalPosition {
            get; set;
        }

        public object OriginalSize {
            get; set;
        }

        public object Position {
            get; set;
        }

        public object Size {
            get; set;
        }
    }
}
