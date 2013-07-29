using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class BounceOptions {

        /// <summary>
        /// The distance of the largest "bounce" in pixels.
        /// </summary>
        public int Distance {
            get; set;
        }

        /// <summary>
        /// The easing to use for the effect
        /// </summary>
        public string Easing {
            get; set;
        }

        /// <summary>
        /// The number of times the element will bounce. When used with hide or show, there is an extra "half" bounce for the fade in/out.
        /// </summary>
        public int Times {
            get; set;
        }
    }
}
