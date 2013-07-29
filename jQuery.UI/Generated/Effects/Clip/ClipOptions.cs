using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class ClipOptions {

        /// <summary>
        /// <para>The plane in which the clip effect will hide or show its element.</para><para><code>vertical</code> clips the top and bottom edges, while <code>horizontal</code> clips the right and left edges.</para>
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
