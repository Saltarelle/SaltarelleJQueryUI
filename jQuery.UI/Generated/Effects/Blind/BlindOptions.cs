using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class BlindOptions {

        /// <summary>
        /// <para>The direction the blind will be pulled to hide the element, or the direction from which the element will be revealed.</para><para>Possible Values: <code>up</code>, <code>down</code>, <code>left</code>, <code>right</code>, <code>vertical</code>, <code>horizontal</code>.</para>
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
    }
}
