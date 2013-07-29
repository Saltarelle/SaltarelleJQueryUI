using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class PulsateOptions {

        /// <summary>
        /// The easing to use for the effect
        /// </summary>
        public string Easing {
            get; set;
        }

        /// <summary>
        /// The number of times the element should pulse. An extra half pulse is added for hide/show.
        /// </summary>
        public int Times {
            get; set;
        }
    }
}
