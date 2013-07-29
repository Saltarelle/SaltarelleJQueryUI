using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class SortableActivateEvent {

        public jQueryObject Helper {
            get; set;
        }

        public jQueryObject Item {
            get; set;
        }

        public jQueryPosition Offset {
            get; set;
        }

        public jQueryPosition OriginalPosition {
            get; set;
        }

        public jQueryPosition Position {
            get; set;
        }

        public jQueryObject Sender {
            get; set;
        }
    }
}
