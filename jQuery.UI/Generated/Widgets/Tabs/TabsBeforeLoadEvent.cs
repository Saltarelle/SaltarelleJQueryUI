using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class TabsBeforeLoadEvent {

        public object AjaxSettings {
            get; set;
        }

        public jQueryXmlHttpRequest JqXHR {
            get; set;
        }

        public jQueryObject Panel {
            get; set;
        }

        public jQueryObject Tab {
            get; set;
        }
    }
}
