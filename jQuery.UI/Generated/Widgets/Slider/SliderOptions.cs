using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class SliderOptions {

        /// <summary>
        /// Whether to slide the handle smoothly when the user clicks on the slider track. Also accepts any valid <a href="//api.jquery.com/animate/#duration">animation duration</a>.
        /// </summary>
        public TypeOption<bool, int, string> Animate {
            get; set;
        }

        /// <summary>
        /// Disables the slider if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// The maximum value of the slider.
        /// </summary>
        public int Max {
            get; set;
        }

        /// <summary>
        /// The minimum value of the slider.
        /// </summary>
        public int Min {
            get; set;
        }

        /// <summary>
        /// Determines whether the slider handles move horizontally (min on left, max on right) or vertically (min on bottom, max on top). Possible values: <code>"horizontal"</code>, <code>"vertical"</code>.
        /// </summary>
        public string Orientation {
            get; set;
        }

        /// <summary>
        /// Whether the slider represents a range.
        /// </summary>
        public TypeOption<bool, string> Range {
            get; set;
        }

        /// <summary>
        /// Determines the size or amount of each interval or step the slider takes between the min and max. The full specified value range of the slider (max - min) should be evenly divisible by the step.
        /// </summary>
        public int Step {
            get; set;
        }

        /// <summary>
        /// Determines the value of the slider, if there's only one handle. If there is more than one handle, determines the value of the first handle.
        /// </summary>
        public int Value {
            get; set;
        }

        /// <summary>
        /// This option can be used to specify multiple handles. If the <a href="#option-range"><code>range</code></a> option is set to <code>true</code>, the length of <code>values</code> should be 2.
        /// </summary>
        public Array Values {
            get; set;
        }

        /// <summary>
        /// Triggered after the user slides a handle, if the value has changed; or if the value is changed programmatically via the <a href="#method-value"><code>value</code></a> method.
        /// </summary>
        [ScriptName("change")]
        public jQueryUIEventHandler<SliderChangeEvent> OnChange {
             get; set;
        }

        /// <summary>
        /// Triggered when the slider is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// Triggered on every mouse move during slide. The value provided in the event as <code>ui.value</code> represents the value that the handle will have as a result of the current movement. Canceling the event will prevent the handle from moving and the handle will continue to have its previous value.
        /// </summary>
        [ScriptName("slide")]
        public jQueryUIEventHandler<SliderSlideEvent> OnSlide {
             get; set;
        }

        /// <summary>
        /// Triggered when the user starts sliding.
        /// </summary>
        [ScriptName("start")]
        public jQueryUIEventHandler<SliderStartEvent> OnStart {
             get; set;
        }

        /// <summary>
        /// Triggered after the user slides a handle.
        /// </summary>
        [ScriptName("stop")]
        public jQueryUIEventHandler<SliderStopEvent> OnStop {
             get; set;
        }
    }
}
