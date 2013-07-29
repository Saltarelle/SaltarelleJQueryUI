using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class DialogDragEvent {

        public object Offset {
            get; set;
        }

        public object Position {
            get; set;
        }
    }
}
