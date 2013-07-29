using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class ProgressBarOptions {

        /// <summary>
        /// Disables the progressbar if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// The maximum value of the progressbar.
        /// </summary>
        public int Max {
            get; set;
        }

        /// <summary>
        /// The value of the progressbar.
        /// </summary>
        public TypeOption<bool, int> Value {
            get; set;
        }

        /// <summary>
        /// Triggered when the value of the progressbar changes.
        /// </summary>
        [ScriptName("change")]
        public jQueryUIEventHandler<object> OnChange {
             get; set;
        }

        /// <summary>
        /// Triggered when the value of the progressbar reaches the maximum value.
        /// </summary>
        [ScriptName("complete")]
        public jQueryUIEventHandler<object> OnComplete {
             get; set;
        }

        /// <summary>
        /// Triggered when the progressbar is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }
    }
}
