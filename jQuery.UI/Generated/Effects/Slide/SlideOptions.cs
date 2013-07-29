using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class SlideOptions {

        /// <summary>
        /// The direction of the effect. Possible values: <code>"left"</code>, <code>"right"</code>, <code>"up"</code>, <code>"down"</code>.
        /// </summary>
        public string Direction {
            get; set;
        }

        /// <summary>
        /// The distance of the effect. Defaults to either the height or width of the elemenet depending on the <code>direction</code> argument. Can be set to any integer less than the width/height of the element.
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
    }
}
