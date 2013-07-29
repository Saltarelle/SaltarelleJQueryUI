using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class ButtonOptions {

        /// <summary>
        /// Disables the button if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// <para>Icons to display, with or without text (see <a href="#option-text"><code>text</code></a> option). By default, the primary icon is displayed on the left of the label text and the secondary is displayed on the right. The positioning can be controlled via CSS.</para><para>The value for the <code>primary</code> and <code>secondary</code> properties must match <a href="/theming/icons/">an icon class name</a>, e.g., <code>"ui-icon-gear"</code>. For using only one icon: <code>icons: { primary: "ui-icon-locked" }</code>. For using two icons: <code>icons: { primary: "ui-icon-gear", secondary: "ui-icon-triangle-1-s" }</code>.</para>
        /// </summary>
        public object Icons {
            get; set;
        }

        /// <summary>
        /// Text to show in the button. When not specified (<code>null</code>), the element's HTML content is used, or its <code>value</code> attribute if the element is an input element of type submit or reset, or the HTML content of the associated label element if the element is an input of type radio or checkbox.
        /// </summary>
        public string Label {
            get; set;
        }

        /// <summary>
        /// Whether to show the label. When set to <code>false</code> no text will be displayed, but the <a href="#options-icons"><code>icons</code></a> option must be enabled, otherwise the <code>text</code> option will be ignored.
        /// </summary>
        public bool Text {
            get; set;
        }

        /// <summary>
        /// Triggered when the button is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }
    }
}
