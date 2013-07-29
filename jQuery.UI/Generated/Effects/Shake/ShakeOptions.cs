using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class ShakeOptions {

        /// <summary>
        /// The direction of the effect. Possible values: <code>"left"</code>, <code>"right"</code>, <code>"up"</code>, <code>"down"</code>.
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
