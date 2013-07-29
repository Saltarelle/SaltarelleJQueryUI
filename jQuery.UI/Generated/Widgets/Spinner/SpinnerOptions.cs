using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class SpinnerOptions {

        /// <summary>
        /// Sets the culture to use for parsing and formatting the value. If <code>null</code>, the currently set culture in <code>Globalize</code> is used, see <a href="https://github.com/jquery/globalize">Globalize docs</a> for available cultures. Only relevant if the <a href="#option-numberFormat"><code>numberFormat</code></a> option is set. Requires <a href="https://github.com/jquery/globalize">Globalize</a> to be included.
        /// </summary>
        public string Culture {
            get; set;
        }

        /// <summary>
        /// Disables the spinner if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// Icons to use for buttons, matching an icon defined by the jQuery UI CSS Framework.<ul><li>up (string, default: "ui-icon-triangle-1-n")</li><li>down (string, default: "ui-icon-triangle-1-s")</li></ul>
        /// </summary>
        public object Icons {
            get; set;
        }

        /// <summary>
        /// Controls the number of steps taken when holding down a spin button.
        /// </summary>
        public TypeOption<bool, Delegate> Incremental {
            get; set;
        }

        /// <summary>
        /// The maximum allowed value. The element's <code>max</code> attribute is used if it exists and the option is not explicitly set. If <code>null</code>, there is no maximum enforced.
        /// </summary>
        public TypeOption<int, string> Max {
            get; set;
        }

        /// <summary>
        /// The minimum allowed value. The element's <code>min</code> attribute is used if it exists and the option is not explicitly set. If <code>null</code>, there is no minimum enforced.
        /// </summary>
        public TypeOption<int, string> Min {
            get; set;
        }

        /// <summary>
        /// Format of numbers passed to  <a href="https://github.com/jquery/globalize"><code>Globalize</code></a>, if available. Most common are <code>"n"</code> for a decimal number and <code>"C"</code> for a currency value. Also see the <a href="#option-culture"><code>culture</code></a> option.
        /// </summary>
        public string NumberFormat {
            get; set;
        }

        /// <summary>
        /// The number of steps to take when paging via the <a href="#method-pageUp"><code>pageUp</code></a>/<a href="#method-pageDown"><code>pageDown</code></a> methods.
        /// </summary>
        public int Page {
            get; set;
        }

        /// <summary>
        /// The size of the step to take when spinning via buttons or via the <a href="#method-stepUp"><code>stepUp()</code></a>/<a href="#method-stepDown"><code>stepDown()</code></a> methods. The element's <code>step</code> attribute is used if it exists and the option is not explicitly set.
        /// </summary>
        public TypeOption<int, string> Step {
            get; set;
        }

        /// <summary>
        /// Triggered when the value of the spinner has changed and the input is no longer focused.
        /// </summary>
        [ScriptName("change")]
        public jQueryUIEventHandler<object> OnChange {
             get; set;
        }

        /// <summary>
        /// Triggered when the spinner is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// Triggered during increment/decrement (to determine direction of spin compare current value with <code>ui.value</code>).<para>Can be canceled, preventing the value from being updated.</para>
        /// </summary>
        [ScriptName("spin")]
        public jQueryUIEventHandler<SpinnerSpinEvent> OnSpin {
             get; set;
        }

        /// <summary>
        /// Triggered before a spin. Can be canceled, preventing the spin from occurring.
        /// </summary>
        [ScriptName("start")]
        public jQueryUIEventHandler<object> OnStart {
             get; set;
        }

        /// <summary>
        /// Triggered after a spin.
        /// </summary>
        [ScriptName("stop")]
        public jQueryUIEventHandler<object> OnStop {
             get; set;
        }
    }
}
