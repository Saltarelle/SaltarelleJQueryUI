using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class SliderSlideEvent {

        public jQueryObject Handle {
            get; set;
        }

        public int Value {
            get; set;
        }

        public Array Values {
            get; set;
        }
    }
}
