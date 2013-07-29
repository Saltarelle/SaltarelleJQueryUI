using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class ToggleClassOptions {

        /// <summary>
        /// Whether the animation should additionally be applied to all descendants of the matched elements. This feature should be used with caution as the cost of determining which descendants to animate can be very expensive, and grows linearly with the number of descendants.
        /// </summary>
        public bool Children {
            get; set;
        }

        /// <summary>
        /// A function to call once the animation is complete.
        /// </summary>
        public Delegate Complete {
            get; set;
        }

        /// <summary>
        /// A string or number determining how long the animation will run.
        /// </summary>
        public TypeOption<int, string> Duration {
            get; set;
        }

        /// <summary>
        /// A string indicating which <a href="/easings/">easing</a> function to use for the transition.
        /// </summary>
        public string Easing {
            get; set;
        }

        /// <summary>
        /// A Boolean indicating whether to place the animation in the effects queue. If false, the animation will begin immediately. <strong>As of jQuery 1.7</strong>, the queue option can also accept a string, in which case the animation is added to the queue represented by that string.
        /// </summary>
        public TypeOption<bool, string> Queue {
            get; set;
        }
    }
}
