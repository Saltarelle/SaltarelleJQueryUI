using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class AccordionActivateEvent {

        public jQueryObject NewHeader {
            get; set;
        }

        public jQueryObject NewPanel {
            get; set;
        }

        public jQueryObject OldHeader {
            get; set;
        }

        public jQueryObject OldPanel {
            get; set;
        }
    }
}
