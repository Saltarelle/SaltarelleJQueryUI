using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class AutoCompleteResponseEvent {

        public Array Content {
            get; set;
        }
    }
}
