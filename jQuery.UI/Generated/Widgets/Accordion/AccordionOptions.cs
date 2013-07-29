using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class AccordionOptions {

        /// <summary>
        /// Which panel is currently open.
        /// </summary>
        public TypeOption<bool, int> Active {
            get; set;
        }

        /// <summary>
        /// If and how to animate changing panels.
        /// </summary>
        public TypeOption<bool, int, object, string> Animate {
            get; set;
        }

        /// <summary>
        /// Whether all the sections can be closed at once. Allows collapsing the active section.
        /// </summary>
        public bool Collapsible {
            get; set;
        }

        /// <summary>
        /// Disables the accordion if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// The event that accordion headers will react to in order to activate the associated panel. Multiple events can be specified, separated by a space.
        /// </summary>
        public string Event {
            get; set;
        }

        /// <summary>
        /// <para>Selector for the header element, applied via <code>.find()</code> on the main accordion element. Content panels must be the sibling immediately after their associated headers.</para>
        /// </summary>
        public string Header {
            get; set;
        }

        /// <summary>
        /// <para>Controls the height of the accordion and each panel. Possible values:</para><ul><li><code>"auto"</code>: All panels will be set to the height of the tallest panel.</li><li><code>"fill"</code>: Expand to the available height based on the accordion's parent height.</li><li><code>"content"</code>: Each panel will be only as tall as its content.</li></ul>
        /// </summary>
        public string HeightStyle {
            get; set;
        }

        /// <summary>
        /// <para>Icons to use for headers, matching <a href="/theming/icons/">an icon provided by the jQuery UI CSS Framework</a>. Set to <code>false</code> to have no icons displayed.</para><ul><li>header (string, default: "ui-icon-triangle-1-e")</li><li>activeHeader (string, default: "ui-icon-triangle-1-s")</li></ul>
        /// </summary>
        public object Icons {
            get; set;
        }

        /// <summary>
        /// Triggered after a panel has been activated (after animation completes). If the accordion was previously collapsed, <code>ui.oldHeader</code> and <code>ui.oldPanel</code> will be empty jQuery objects. If the accordion is collapsing, <code>ui.newHeader</code> and <code>ui.newPanel</code> will be empty jQuery objects.
        /// </summary>
        [ScriptName("activate")]
        public jQueryUIEventHandler<AccordionActivateEvent> OnActivate {
             get; set;
        }

        /// <summary>
        /// Triggered directly before a panel is activated. Can be canceled to prevent the panel from activating. If the accordion is currently collapsed, <code>ui.oldHeader</code> and <code>ui.oldPanel</code> will be empty jQuery objects. If the accordion is collapsing, <code>ui.newHeader</code> and <code>ui.newPanel</code> will be empty jQuery objects.
        /// </summary>
        [ScriptName("beforeActivate")]
        public jQueryUIEventHandler<AccordionBeforeActivateEvent> OnBeforeActivate {
             get; set;
        }

        /// <summary>
        /// Triggered when the accordion is created. If the accordion is collapsed, <code>ui.header</code> and <code>ui.panel</code> will be empty jQuery objects.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<AccordionCreateEvent> OnCreate {
             get; set;
        }
    }
}
