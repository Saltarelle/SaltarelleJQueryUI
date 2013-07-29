using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class FoldOptions {

        /// <summary>
        /// The easing to use for the effect
        /// </summary>
        public string Easing {
            get; set;
        }

        /// <summary>
        /// Whether the horizontal direction happens first when hiding. Remember, showing inverts hiding.
        /// </summary>
        public bool HorizFirst {
            get; set;
        }

        /// <summary>
        /// The size of the "folded" element.
        /// </summary>
        public TypeOption<int, string> Size {
            get; set;
        }
    }
}
