using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class MenuFocusEvent {

        public jQueryObject Item {
            get; set;
        }
    }
}
