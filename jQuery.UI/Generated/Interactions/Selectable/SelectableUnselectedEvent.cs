using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class SelectableUnselectedEvent {

        public Element Unselected {
            get; set;
        }
    }
}
