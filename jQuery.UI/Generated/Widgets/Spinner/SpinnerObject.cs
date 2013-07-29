using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Enhance a text input for entering numeric values, with up/down buttons and arrow key handling.
    /// </summary>
    /// <remarks>
    /// <para>Spinner, or number stepper, widget is perfect for handling all kinds of numeric input. It allow users to type a value directly or modify an existing value by spinning with the keyboard, mouse or scrollwheel. When combined with Globalize, you can even spin currencies and dates in a variety of locales.</para><para>Spinner wraps a text input, adds two buttons to increment and decrement the current value, along with handling key events for the same purpose. It delegates to <a href="https://github.com/jquery/globalize">Globalize</a> for number formatting and parsing.</para><h3>Keyboard interaction</h3><ul><li>UP: Increment the value by one step.</li><li>DOWN: Decrement the value by one step.</li><li>PAGE UP: Increment the value by one page.</li><li>PAGE DOWN: Decrement the value by one page.</li></ul><para>Focus stays in the text field, even after using the mouse to click one of the spin buttons.</para><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/button/">Button</a></li><li><a href="https://github.com/jquery/globalize">Globalize</a> (external, optional; for use with the <a href="#option-culture"><code>culture</code></a> and <a href="#option-numberFormat"><code>numberFormat</code></a> options)</li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class SpinnerObject {

        private SpinnerObject() {
        }

        /// <summary>
        /// Removes the spinner functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.spinner('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the spinner.
        /// </summary>
        [InlineCode("{this}.spinner('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the spinner.
        /// </summary>
        [InlineCode("{this}.spinner('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.spinner('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current spinner options hash.
        /// </summary>
        [InlineCode("{this}.spinner('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the spinner option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.spinner('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the spinner.
        /// </summary>
        [InlineCode("{this}.spinner('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Decrements the value by the specified number of pages, as defined by the <a href="#option-page"><code>page</code></a> option. Without the parameter, a single page is decremented.
        /// </summary>
        [InlineCode("{this}.spinner('pageDown', {pages})")]
        public void PageDown(int pages) {
        }


        /// <summary>
        /// Increments the value by the specified number of pages, as defined by the <a href="#option-page"><code>page</code></a> option. Without the parameter, a single page is incremented.
        /// </summary>
        [InlineCode("{this}.spinner('pageUp', {pages})")]
        public void PageUp(int pages) {
        }


        /// <summary>
        /// Decrements the value by the specified number of steps. Without the parameter, a single step is decremented.<para>If the resulting value is above the max, below the min, or reuslts in a step mismatch, the value will be adjusted to the closest valid value.</para>
        /// </summary>
        [InlineCode("{this}.spinner('stepDown', {steps})")]
        public void StepDown(int steps) {
        }


        /// <summary>
        /// Increments the value by the specified number of steps. Without the parameter, a single step is incremented.<para>If the resulting value is above the max, below the min, or reuslts in a step mismatch, the value will be adjusted to the closest valid value.</para>
        /// </summary>
        [InlineCode("{this}.spinner('stepUp', {steps})")]
        public void StepUp(int steps) {
        }


        /// <summary>
        /// Gets the current value as a number. The value is parsed based on the <a href="#option-numberFormat"><code>numberFormat</code></a> and <a href="#option-culture"><code>culture</code></a> options.
        /// </summary>
        [InlineCode("{this}.spinner('value')")]
        public int Value() {
                return 0;
        }


        /// <summary>
        /// 
        /// </summary>
        [InlineCode("{this}.spinner('value', {value})")]
        public void Value(TypeOption<int, string> value) {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the spinner.
        /// </summary>
        [InlineCode("{this}.spinner('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Sets the culture to use for parsing and formatting the value. If <code>null</code>, the currently set culture in <code>Globalize</code> is used, see <a href="https://github.com/jquery/globalize">Globalize docs</a> for available cultures. Only relevant if the <a href="#option-numberFormat"><code>numberFormat</code></a> option is set. Requires <a href="https://github.com/jquery/globalize">Globalize</a> to be included.
        /// </summary>
        public string Culture {
            [InlineCode("{this}.spinner('option', 'culture')")]
            get;
            [InlineCode("{this}.spinner('option', 'culture', {value})")]
            set;
        }


        /// <summary>
        /// Disables the spinner if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.spinner('option', 'disabled')")]
            get;
            [InlineCode("{this}.spinner('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// Icons to use for buttons, matching an icon defined by the jQuery UI CSS Framework.<ul><li>up (string, default: "ui-icon-triangle-1-n")</li><li>down (string, default: "ui-icon-triangle-1-s")</li></ul>
        /// </summary>
        public object Icons {
            [InlineCode("{this}.spinner('option', 'icons')")]
            get;
            [InlineCode("{this}.spinner('option', 'icons', {value})")]
            set;
        }


        /// <summary>
        /// Controls the number of steps taken when holding down a spin button.
        /// </summary>
        public TypeOption<bool, Delegate> Incremental {
            [InlineCode("{this}.spinner('option', 'incremental')")]
            get;
            [InlineCode("{this}.spinner('option', 'incremental', {value})")]
            set;
        }


        /// <summary>
        /// The maximum allowed value. The element's <code>max</code> attribute is used if it exists and the option is not explicitly set. If <code>null</code>, there is no maximum enforced.
        /// </summary>
        public TypeOption<int, string> Max {
            [InlineCode("{this}.spinner('option', 'max')")]
            get;
            [InlineCode("{this}.spinner('option', 'max', {value})")]
            set;
        }


        /// <summary>
        /// The minimum allowed value. The element's <code>min</code> attribute is used if it exists and the option is not explicitly set. If <code>null</code>, there is no minimum enforced.
        /// </summary>
        public TypeOption<int, string> Min {
            [InlineCode("{this}.spinner('option', 'min')")]
            get;
            [InlineCode("{this}.spinner('option', 'min', {value})")]
            set;
        }


        /// <summary>
        /// Format of numbers passed to  <a href="https://github.com/jquery/globalize"><code>Globalize</code></a>, if available. Most common are <code>"n"</code> for a decimal number and <code>"C"</code> for a currency value. Also see the <a href="#option-culture"><code>culture</code></a> option.
        /// </summary>
        public string NumberFormat {
            [InlineCode("{this}.spinner('option', 'numberFormat')")]
            get;
            [InlineCode("{this}.spinner('option', 'numberFormat', {value})")]
            set;
        }


        /// <summary>
        /// The number of steps to take when paging via the <a href="#method-pageUp"><code>pageUp</code></a>/<a href="#method-pageDown"><code>pageDown</code></a> methods.
        /// </summary>
        public int Page {
            [InlineCode("{this}.spinner('option', 'page')")]
            get;
            [InlineCode("{this}.spinner('option', 'page', {value})")]
            set;
        }


        /// <summary>
        /// The size of the step to take when spinning via buttons or via the <a href="#method-stepUp"><code>stepUp()</code></a>/<a href="#method-stepDown"><code>stepDown()</code></a> methods. The element's <code>step</code> attribute is used if it exists and the option is not explicitly set.
        /// </summary>
        public TypeOption<int, string> Step {
            [InlineCode("{this}.spinner('option', 'step')")]
            get;
            [InlineCode("{this}.spinner('option', 'step', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when the value of the spinner has changed and the input is no longer focused.
        /// </summary>
        public event jQueryUIEventHandler<object> OnChange {
            [InlineCode("{this}.bind('spinchange', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('spinchange', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the spinner is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('spincreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('spincreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered during increment/decrement (to determine direction of spin compare current value with <code>ui.value</code>).<para>Can be canceled, preventing the value from being updated.</para>
        /// </summary>
        public event jQueryUIEventHandler<SpinnerSpinEvent> OnSpin {
            [InlineCode("{this}.bind('spinspin', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('spinspin', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered before a spin. Can be canceled, preventing the spin from occurring.
        /// </summary>
        public event jQueryUIEventHandler<object> OnStart {
            [InlineCode("{this}.bind('spinstart', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('spinstart', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered after a spin.
        /// </summary>
        public event jQueryUIEventHandler<object> OnStop {
            [InlineCode("{this}.bind('spinstop', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('spinstop', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(SpinnerObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator SpinnerObject(jQueryObject o) {
            return null;
        }
    }
}
