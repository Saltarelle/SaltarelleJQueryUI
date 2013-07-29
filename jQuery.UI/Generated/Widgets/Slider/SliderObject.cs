using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Drag a handle to select a numeric value.
    /// </summary>
    /// <remarks>
    /// <para>The jQuery UI Slider plugin makes selected elements into sliders. There are various options such as multiple handles and ranges. The handle can be moved with the mouse or the arrow keys.</para><para>The slider widget will create handle elements with the class <code>ui-slider-handle</code> on initialization. You can specify custom handle elements by creating and appending the elements and adding the <code>ui-slider-handle</code> class before initialization. It will only create the number of handles needed to match the length of <a href="#option-value"><code>value</code></a>/<a href="#option-values"><code>values</code></a>. For example, if you specify <code>values: [ 1, 5, 18 ]</code> and create one custom handle, the plugin will create the other two.</para><div><h3 id="theming">Theming</h3><para>The slider widget uses the <a href="/theming/css-framework">jQuery UI CSS framework</a> to style its look and feel. If slider specific styling is needed, the following CSS class names can be used:</para></div><ul><li><code>ui-slider</code>: The track of the slider control. This element will additionally have a class name of <code>ui-slider-horizontal</code> or <code>ui-slider-vertical</code> depending on the <a href="#option-orientation"><code>orientation</code></a> of the slider.<ul><li><code>ui-slider-handle</code>: The slider handles.</li><li><code>ui-slider-range</code>: The selected range used when the <a href="#option-range"><code>range</code></a> option is set. This element can additionally have a class of <code>ui-slider-range-min</code> or <code>ui-slider-range-max</code> if the <code>range</code> option is set to <code>"min"</code> or <code>"max"</code> respectively.</li></ul></li></ul><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/mouse/">Mouse Interaction</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class SliderObject {

        private SliderObject() {
        }

        /// <summary>
        /// Removes the slider functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.slider('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the slider.
        /// </summary>
        [InlineCode("{this}.slider('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the slider.
        /// </summary>
        [InlineCode("{this}.slider('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.slider('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current slider options hash.
        /// </summary>
        [InlineCode("{this}.slider('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the slider option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.slider('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the slider.
        /// </summary>
        [InlineCode("{this}.slider('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Get the value of the slider.
        /// </summary>
        [InlineCode("{this}.slider('value')")]
        public int Value() {
                return 0;
        }


        /// <summary>
        /// Set the value of the slider.
        /// </summary>
        [InlineCode("{this}.slider('value', {value})")]
        public void Value(int value) {
        }


        /// <summary>
        /// Get the value for all handles.
        /// </summary>
        [InlineCode("{this}.slider('values')")]
        public Array Values() {
                return null;
        }


        /// <summary>
        /// Get the value for the specified handle.
        /// </summary>
        [InlineCode("{this}.slider('values', {index})")]
        public int Values(int index) {
                return 0;
        }


        /// <summary>
        /// Set the value for the specified handle.
        /// </summary>
        [InlineCode("{this}.slider('values', {index}, {value})")]
        public void Values(int index, int value) {
        }


        /// <summary>
        /// Set the value for all handles.
        /// </summary>
        [InlineCode("{this}.slider('values', {values})")]
        public void Values(Array values) {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the slider.
        /// </summary>
        [InlineCode("{this}.slider('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Whether to slide the handle smoothly when the user clicks on the slider track. Also accepts any valid <a href="//api.jquery.com/animate/#duration">animation duration</a>.
        /// </summary>
        public TypeOption<bool, int, string> Animate {
            [InlineCode("{this}.slider('option', 'animate')")]
            get;
            [InlineCode("{this}.slider('option', 'animate', {value})")]
            set;
        }


        /// <summary>
        /// Disables the slider if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.slider('option', 'disabled')")]
            get;
            [InlineCode("{this}.slider('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// The maximum value of the slider.
        /// </summary>
        public int Max {
            [InlineCode("{this}.slider('option', 'max')")]
            get;
            [InlineCode("{this}.slider('option', 'max', {value})")]
            set;
        }


        /// <summary>
        /// The minimum value of the slider.
        /// </summary>
        public int Min {
            [InlineCode("{this}.slider('option', 'min')")]
            get;
            [InlineCode("{this}.slider('option', 'min', {value})")]
            set;
        }


        /// <summary>
        /// Determines whether the slider handles move horizontally (min on left, max on right) or vertically (min on bottom, max on top). Possible values: <code>"horizontal"</code>, <code>"vertical"</code>.
        /// </summary>
        public string Orientation {
            [InlineCode("{this}.slider('option', 'orientation')")]
            get;
            [InlineCode("{this}.slider('option', 'orientation', {value})")]
            set;
        }


        /// <summary>
        /// Whether the slider represents a range.
        /// </summary>
        public TypeOption<bool, string> Range {
            [InlineCode("{this}.slider('option', 'range')")]
            get;
            [InlineCode("{this}.slider('option', 'range', {value})")]
            set;
        }


        /// <summary>
        /// Determines the size or amount of each interval or step the slider takes between the min and max. The full specified value range of the slider (max - min) should be evenly divisible by the step.
        /// </summary>
        public int Step {
            [InlineCode("{this}.slider('option', 'step')")]
            get;
            [InlineCode("{this}.slider('option', 'step', {value})")]
            set;
        }


        /// <summary>
        /// Determines the value of the slider, if there's only one handle. If there is more than one handle, determines the value of the first handle.
        /// </summary>
        public int OptionValue {
            [InlineCode("{this}.slider('option', 'value')")]
            get;
            [InlineCode("{this}.slider('option', 'value', {value})")]
            set;
        }


        /// <summary>
        /// This option can be used to specify multiple handles. If the <a href="#option-range"><code>range</code></a> option is set to <code>true</code>, the length of <code>values</code> should be 2.
        /// </summary>
        public Array OptionValues {
            [InlineCode("{this}.slider('option', 'values')")]
            get;
            [InlineCode("{this}.slider('option', 'values', {value})")]
            set;
        }


        /// <summary>
        /// Triggered after the user slides a handle, if the value has changed; or if the value is changed programmatically via the <a href="#method-value"><code>value</code></a> method.
        /// </summary>
        public event jQueryUIEventHandler<SliderChangeEvent> OnChange {
            [InlineCode("{this}.bind('slidechange', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('slidechange', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the slider is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('slidecreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('slidecreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered on every mouse move during slide. The value provided in the event as <code>ui.value</code> represents the value that the handle will have as a result of the current movement. Canceling the event will prevent the handle from moving and the handle will continue to have its previous value.
        /// </summary>
        public event jQueryUIEventHandler<SliderSlideEvent> OnSlide {
            [InlineCode("{this}.bind('slideslide', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('slideslide', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the user starts sliding.
        /// </summary>
        public event jQueryUIEventHandler<SliderStartEvent> OnStart {
            [InlineCode("{this}.bind('slidestart', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('slidestart', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered after the user slides a handle.
        /// </summary>
        public event jQueryUIEventHandler<SliderStopEvent> OnStop {
            [InlineCode("{this}.bind('slidestop', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('slidestop', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(SliderObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator SliderObject(jQueryObject o) {
            return null;
        }
    }
}
