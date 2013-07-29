using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class DraggableStopEvent {

        public jQueryObject Helper {
            get; set;
        }

        public jQueryPosition Offset {
            get; set;
        }

        public jQueryPosition Position {
            get; set;
        }
    }
}
