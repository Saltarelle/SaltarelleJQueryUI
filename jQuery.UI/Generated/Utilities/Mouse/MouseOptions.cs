using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class MouseOptions {

        /// <summary>
        /// Prevents interactions from starting on specified elements.
        /// </summary>
        public string Cancel {
            get; set;
        }

        /// <summary>
        /// Time in milliseconds after mousedown until the interaction should start. This option can be used to prevent unwanted interactions when clicking on an element.
        /// </summary>
        public int Delay {
            get; set;
        }

        /// <summary>
        /// Distance in pixels after mousedown the mouse must move before the interaction should start. This option can be used to prevent unwanted interactions when clicking on an element.
        /// </summary>
        public int Distance {
            get; set;
        }
    }
}
