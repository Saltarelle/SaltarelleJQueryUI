using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class TransferOptions {

        /// <summary>
        /// argumental class name the transfer element will receive.
        /// </summary>
        public string ClassName {
            get; set;
        }

        /// <summary>
        /// The easing to use for the effect
        /// </summary>
        public string Easing {
            get; set;
        }

        /// <summary>
        /// jQuery selector, the element to transfer to.
        /// </summary>
        public string To {
            get; set;
        }
    }
}
