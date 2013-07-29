using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class TooltipOptions {

        /// <summary>
        /// <para>The content of the tooltip.</para><para><em>When changing this option, you likely need to also change the <a href="#option-items"><code>items</code></a> option.</em></para>
        /// </summary>
        public TypeOption<Delegate, string> Content {
            get; set;
        }

        /// <summary>
        /// Disables the tooltip if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// If and how to animate the hiding of the tooltip.
        /// </summary>
        public TypeOption<bool, int, object, string> Hide {
            get; set;
        }

        /// <summary>
        /// <para>A selector indicating which items should show tooltips. Customize if you're using something other then the title attribute for the tooltip content, or if you need a different selector for event delegation.</para><para><em>When changing this option, you likely need to also change the <a href="#option-content"><code>content</code></a> option.</em></para>
        /// </summary>
        public string Items {
            get; set;
        }

        /// <summary>
        /// <para>Configuration for the Position utility. The <code>of</code> property defaults to the target element, but can also be overriden.</para><para><em>Note: In 1.9.0, the default value was <code>{ my: "left+15 center", at: "right center", collision: "flipfit" }</code>, but this was changed to more closely match native tooltip positioning.</em></para>
        /// </summary>
        public object Position {
            get; set;
        }

        /// <summary>
        /// If and how to animate the showing of the tooltip.
        /// </summary>
        public TypeOption<bool, int, object, string> Show {
            get; set;
        }

        /// <summary>
        /// A class to add to the widget, can be used to display various tooltip types, like warnings or errors.<para>This may get replaced by the <a href="http://bugs.jqueryui.com/ticket/7053">classes option</a>.</para>
        /// </summary>
        public string TooltipClass {
            get; set;
        }

        /// <summary>
        /// Whether the tooltip should track (follow) the mouse.
        /// </summary>
        public bool Track {
            get; set;
        }

        /// <summary>
        /// Triggered when a tooltip is closed, triggered on <code>focusout</code> or <code>mouseleave</code>.
        /// </summary>
        [ScriptName("close")]
        public jQueryUIEventHandler<TooltipCloseEvent> OnClose {
             get; set;
        }

        /// <summary>
        /// Triggered when the tooltip is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// Triggered when a tooltip is shown, triggered on <code>focusin</code> or <code>mouseover</code>.
        /// </summary>
        [ScriptName("open")]
        public jQueryUIEventHandler<TooltipOpenEvent> OnOpen {
             get; set;
        }
    }
}
