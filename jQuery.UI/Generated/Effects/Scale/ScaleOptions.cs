using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class ScaleOptions {

        /// <summary>
        /// The direction of the effect. Possible values: <code>"both"</code>, <code>"vertical"</code> or <code>"horizontal"</code>.
        /// </summary>
        public string Direction {
            get; set;
        }

        /// <summary>
        /// The easing to use for the effect
        /// </summary>
        public string Easing {
            get; set;
        }

        /// <summary>
        /// The vanishing point.
        /// </summary>
        public Array Origin {
            get; set;
        }

        /// <summary>
        /// The percentage to scale to.
        /// </summary>
        public int Percent {
            get; set;
        }

        /// <summary>
        /// Which areas of the element will be resized: <code>"both"</code>, <code>"box"</code>, <code>"content"</code>. Box resizes the border and padding of the element; content resizes any content inside of the element.
        /// </summary>
        public string Scale {
            get; set;
        }
    }
}
