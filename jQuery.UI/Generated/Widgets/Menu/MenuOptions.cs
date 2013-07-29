using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class MenuOptions {

        /// <summary>
        /// Disables the menu if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// Icons to use for submenus, matching an icon defined by the jQuery UI CSS Framework.<ul><li>submenu (string, default: "ui-icon-carat-1-e")</li></ul>
        /// </summary>
        public object Icons {
            get; set;
        }

        /// <summary>
        /// Selector for the elements that serve as the menu container, including sub-menus.
        /// </summary>
        public string Menus {
            get; set;
        }

        /// <summary>
        /// Identifies the position of submenus in relation to the associated parent menu item. The <code>of</code> option defaults to the parent menu item, but you can specify another element to position against. You can refer to the <a href="/position/">jQuery UI Position</a> utility for more details about the various options.
        /// </summary>
        public object Position {
            get; set;
        }

        /// <summary>
        /// Customize the ARIA roles used for the menu and menu items. The default uses <code>"menuitem"</code> for items. Setting the <code>role</code> option to <code>"listbox"</code> will use <code>"option"</code> for items. If set to <code>null</code>, no roles will be set, which is useful if the menu is being controlled by another element that is maintaining focus.
        /// </summary>
        public string Role {
            get; set;
        }

        /// <summary>
        /// Triggered when the menu loses focus.
        /// </summary>
        [ScriptName("blur")]
        public jQueryUIEventHandler<MenuBlurEvent> OnBlur {
             get; set;
        }

        /// <summary>
        /// Triggered when the menu is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// Triggered when a menu gains focus or when any menu item is activated.
        /// </summary>
        [ScriptName("focus")]
        public jQueryUIEventHandler<MenuFocusEvent> OnFocus {
             get; set;
        }

        /// <summary>
        /// Triggered when a menu item is selected.
        /// </summary>
        [ScriptName("select")]
        public jQueryUIEventHandler<MenuSelectEvent> OnSelect {
             get; set;
        }
    }
}
