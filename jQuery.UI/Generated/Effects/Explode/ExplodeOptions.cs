using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class ExplodeOptions {

        /// <summary>
        /// The easing to use for the effect
        /// </summary>
        public string Easing {
            get; set;
        }

        /// <summary>
        /// The number of pieces to explode, should be a perfect square, any other values are rounded to the nearest square.
        /// </summary>
        public int Pieces {
            get; set;
        }
    }
}
