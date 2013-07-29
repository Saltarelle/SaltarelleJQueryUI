using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class SizeOptions {

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
        /// Which areas of the element will be resized: <code>"both"</code>, <code>"box"</code>, <code>"content"</code>. Box resizes the border and padding of the element; content resizes any content inside of the element.
        /// </summary>
        public string Scale {
            get; set;
        }

        /// <summary>
        /// Height and width to resize to.
        /// </summary>
        public object To {
            get; set;
        }
    }
}
