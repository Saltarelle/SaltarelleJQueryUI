using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class HighlightOptions {

        /// <summary>
        /// The background color used during the animation.
        /// </summary>
        public string Color {
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
