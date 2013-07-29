using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class ShakeOptions {

        /// <summary>
        /// A value of <code>"left"</code> or <code>"right"</code> will shake the element horizontally, and a value of <code>"up"</code> or <code>"down"</code> will shake the element vertically. The value specifies which direction the element should move along the axis for the first step of the effect.
        /// </summary>
        public string Direction {
            get; set;
        }

        /// <summary>
        /// Distance to shake.
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
        /// Times to shake.
        /// </summary>
        public int Times {
            get; set;
        }
    }
}
