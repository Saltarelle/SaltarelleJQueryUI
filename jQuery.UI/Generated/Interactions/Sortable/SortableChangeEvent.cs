using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class SortableChangeEvent {

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

        public jQueryObject Placeholder {
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
