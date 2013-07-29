using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class TabsLoadEvent {

        public jQueryObject Panel {
            get; set;
        }

        public jQueryObject Tab {
            get; set;
        }
    }
}
