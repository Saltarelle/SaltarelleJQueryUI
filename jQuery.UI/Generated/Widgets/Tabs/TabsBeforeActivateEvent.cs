using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class TabsBeforeActivateEvent {

        public jQueryObject NewPanel {
            get; set;
        }

        public jQueryObject NewTab {
            get; set;
        }

        public jQueryObject OldPanel {
            get; set;
        }

        public jQueryObject OldTab {
            get; set;
        }
    }
}
