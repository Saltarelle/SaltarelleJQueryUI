using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class TabsOptions {

        /// <summary>
        /// Which panel is currently open.
        /// </summary>
        public TypeOption<bool, int> Active {
            get; set;
        }

        /// <summary>
        /// When set to <code>true</code>, the active panel can be closed.
        /// </summary>
        public bool Collapsible {
            get; set;
        }

        /// <summary>
        /// Which tabs are disabled.
        /// </summary>
        public TypeOption<Array, bool> Disabled {
            get; set;
        }

        /// <summary>
        /// The type of event that the tabs should react to in order to activate the tab. To activate on hover, use <code>"mouseover"</code>.
        /// </summary>
        public string Event {
            get; set;
        }

        /// <summary>
        /// Controls the height of the tabs widget and each panel. Possible values:<ul><li><code>"auto"</code>: All panels will be set to the height of the tallest panel.</li><li><code>"fill"</code>: Expand to the available height based on the tabs' parent height.</li><li><code>"content"</code>: Each panel will be only as tall as its content.</li></ul>
        /// </summary>
        public string HeightStyle {
            get; set;
        }

        /// <summary>
        /// If and how to animate the hiding of the tabs.
        /// </summary>
        public TypeOption<bool, int, object, string> Hide {
            get; set;
        }

        /// <summary>
        /// If and how to animate the showing of the tabs.
        /// </summary>
        public TypeOption<bool, int, object, string> Show {
            get; set;
        }

        /// <summary>
        /// Triggered after a tab has been activated (after animation completes). If the tabs were previously collapsed, <code>ui.oldTab</code> and <code>ui.oldPanel</code> will be empty jQuery objects. If the tabs are collapsing, <code>ui.newTab</code> and <code>ui.newPanel</code> will be empty jQuery objects.
        /// </summary>
        [ScriptName("activate")]
        public jQueryUIEventHandler<TabsActivateEvent> OnActivate {
             get; set;
        }

        /// <summary>
        /// Triggered directly after a tab is activated. Can be canceled to prevent the tab from activating. If the tabs are currently collapsed, <code>ui.oldTab</code> and <code>ui.oldPanel</code> will be empty jQuery objects. If the tabs are collapsing, <code>ui.newTab</code> and <code>ui.newPanel</code> will be empty jQuery objects.
        /// </summary>
        [ScriptName("beforeActivate")]
        public jQueryUIEventHandler<TabsBeforeActivateEvent> OnBeforeActivate {
             get; set;
        }

        /// <summary>
        /// Triggered when a remote tab is about to be loaded, after the <a href="#event-beforeActivate"><code>beforeActivate</code></a> event. Can be canceled to prevent the tab panel from loading content; though the panel will still be activated. This event is triggered just before the Ajax request is made, so modifications can be made to <code>ui.jqXHR</code> and <code>ui.ajaxSettings</code>.
        /// </summary>
        [ScriptName("beforeLoad")]
        public jQueryUIEventHandler<TabsBeforeLoadEvent> OnBeforeLoad {
             get; set;
        }

        /// <summary>
        /// Triggered when the tabs are created. If the tabs are collapsed, <code>ui.tab</code> and <code>ui.panel</code> will be empty jQuery objects.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<TabsCreateEvent> OnCreate {
             get; set;
        }

        /// <summary>
        /// Triggered after a remote tab has been loaded.
        /// </summary>
        [ScriptName("load")]
        public jQueryUIEventHandler<TabsLoadEvent> OnLoad {
             get; set;
        }
    }
}
