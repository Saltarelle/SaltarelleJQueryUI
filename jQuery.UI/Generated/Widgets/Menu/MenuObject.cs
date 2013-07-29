using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Themeable menu with mouse and keyboard interactions for navigation.
    /// </summary>
    /// <remarks>
    /// <para>A menu can be created from any valid markup as long as the elements have a strict parent/child relationship and each menu item has an anchor. The most commonly used element is the unordered list (<code>&lt;ul&gt;</code>):</para><c><code><ul id="menu"><li><a href="#">Item 1</a></li><li><a href="#">Item 2</a></li><li><a href="#">Item 3</a><ul><li><a href="#">Item 3-1</a></li><li><a href="#">Item 3-2</a></li><li><a href="#">Item 3-3</a></li><li><a href="#">Item 3-4</a></li><li><a href="#">Item 3-5</a></li></ul></li><li><a href="#">Item 4</a></li><li><a href="#">Item 5</a></li></ul></code></c><para>If you use a structure other than <code>&lt;ul&gt;</code>/<code>&lt;li&gt;</code>, including using the same element for the menu and the menu items, use the <a href="#option-menus"><code>menus</code></a> option to specify a way to differentiate the two elements, e.g., <code>menus: "div.menuElement"</code>.</para><para>Any menu item can be disabled by adding the <code>ui-state-disabled</code> class to that element.</para><h3 id="icons">Icons</h3><para>To add icons to the menu, include them in the markup:</para><c><code><ul id="menu"><li><a href="#"><span class="ui-icon ui-icon-disk"></span>Save</a></li></ul></code></c><para>Menu automatically adds the necessary padding to items without icons.</para><h3 id="dividers">Dividers</h3><para>Divider elements can be created by including unlinked menu items that contain only spaces and/or dashes:</para><c><code><ul id="menu"><li><a href="#">Item 1</a></li><li>-</li><li><a href="#">Item 2</a></li></ul></code></c><h3>Keyboard interaction</h3><ul><li>ENTER/SPACE: Invoke the focused menu item's action, which may be opening a submenu.</li><li>UP: Move focus to the previous menu item.</li><li>DOWN: Move focus to the next menu item.</li><li>RIGHT: Open the submenu, if available.</li><li>LEFT: Close the current submenu and move focus to the parent menu item. If not in a submenu, do nothing.</li><li>ESCAPE: Close the current submenu and move focus to the parent menu item. If not in a submenu, do nothing.</li></ul><para>Typing a letter moves focus to the first item whose title starts with that character. Repeating the same character cycles through matching items. Typing more characters within the one second timer matches those characters.</para><para>Disabled items can receive keyboard focus, but do not allow any other interaction.</para><div><h3 id="theming">Theming</h3><para>The menu widget uses the <a href="/theming/css-framework">jQuery UI CSS framework</a> to style its look and feel. If menu specific styling is needed, the following CSS class names can be used:</para></div><ul><li><code>ui-menu</code>: The outer container of the menu. This element will additionally have a <code>ui-menu-icons</code> class if the menu contains icons.<ul><li><code>ui-menu-item</code>: The container for individual menu items.<ul><li><code>ui-menu-icon</code>: The submenu icons set via the <a href="#option-icons"><code>icons</code></a> option.</li></ul></li><li><code>ui-menu-divider</code>: Divider elements between menu items.</li></ul></li></ul><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/position/">Position</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class MenuObject {

        private MenuObject() {
        }

        /// <summary>
        /// Removes focus from a menu, resets any active element styles and triggers the menu's <a href="event-blur"><code>blur</code></a> event.
        /// </summary>
        [InlineCode("{this}.menu('blur', {event})")]
        public void Blur(jQueryEvent @event) {
        }


        /// <summary>
        /// Closes the currently active sub-menu.
        /// </summary>
        [InlineCode("{this}.menu('collapse', {event})")]
        public void Collapse(jQueryEvent @event) {
        }


        /// <summary>
        /// Closes all open sub-menus.
        /// </summary>
        [InlineCode("{this}.menu('collapseAll', {event}, {all})")]
        public void CollapseAll(jQueryEvent @event, bool all) {
        }


        /// <summary>
        /// Removes the menu functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.menu('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the menu.
        /// </summary>
        [InlineCode("{this}.menu('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the menu.
        /// </summary>
        [InlineCode("{this}.menu('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Opens the sub-menu below the currently active item, if one exists.
        /// </summary>
        [InlineCode("{this}.menu('expand', {event})")]
        public void Expand(jQueryEvent @event) {
        }


        /// <summary>
        /// Activates a particular menu item, begins opening any sub-menu if present and triggers the menu's <a href="#event-focus"><code>focus</code></a> event.
        /// </summary>
        [InlineCode("{this}.menu('focus', {event}, {item})")]
        public void Focus(jQueryEvent @event, jQueryObject item) {
        }


        /// <summary>
        /// Returns a boolean value stating whether or not the currently active item is the first item in the menu.
        /// </summary>
        [InlineCode("{this}.menu('isFirstItem')")]
        public void IsFirstItem() {
        }


        /// <summary>
        /// Returns a boolean value stating whether or not the currently active item is the last item in the menu.
        /// </summary>
        [InlineCode("{this}.menu('isLastItem')")]
        public void IsLastItem() {
        }


        /// <summary>
        /// Moves active state to next menu item.
        /// </summary>
        [InlineCode("{this}.menu('next', {event})")]
        public void Next(jQueryEvent @event) {
        }


        /// <summary>
        /// Moves active state to first menu item below the bottom of a scrollable menu or the last item if not scrollable.
        /// </summary>
        [InlineCode("{this}.menu('nextPage', {event})")]
        public void NextPage(jQueryEvent @event) {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.menu('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current menu options hash.
        /// </summary>
        [InlineCode("{this}.menu('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the menu option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.menu('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the menu.
        /// </summary>
        [InlineCode("{this}.menu('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Moves active state to previous menu item.
        /// </summary>
        [InlineCode("{this}.menu('previous', {event})")]
        public void Previous(jQueryEvent @event) {
        }


        /// <summary>
        /// Moves active state to first menu item above the top of a scrollable menu or the first item if not scrollable.
        /// </summary>
        [InlineCode("{this}.menu('previousPage', {event})")]
        public void PreviousPage(jQueryEvent @event) {
        }


        /// <summary>
        /// Initializes sub-menus and menu items that have not already been initialized. New menu items, including sub-menus can be added to the menu or all of the contents of the menu can be replaced and then initialized with the <code>refresh()</code> method.
        /// </summary>
        [InlineCode("{this}.menu('refresh')")]
        public void Refresh() {
        }


        /// <summary>
        /// Selects the currently active menu item, collapses all sub-menus and triggers the menu's <a href="#event-select"><code>select</code></a> event.
        /// </summary>
        [InlineCode("{this}.menu('select', {event})")]
        public void Select(jQueryEvent @event) {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the menu.
        /// </summary>
        [InlineCode("{this}.menu('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Disables the menu if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.menu('option', 'disabled')")]
            get;
            [InlineCode("{this}.menu('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// Icons to use for submenus, matching <a href="/theming/icons/">an icon provided by the jQuery UI CSS Framework</a>.<ul><li>submenu (string, default: "ui-icon-carat-1-e")</li></ul>
        /// </summary>
        public object Icons {
            [InlineCode("{this}.menu('option', 'icons')")]
            get;
            [InlineCode("{this}.menu('option', 'icons', {value})")]
            set;
        }


        /// <summary>
        /// <para>Selector for the elements that serve as the menu container, including sub-menus.</para><div class="warning"><strong>Note:</strong> The <code>menus</code> option should not be changed after initialization. Existing submenus will not be updated.</div>
        /// </summary>
        public string Menus {
            [InlineCode("{this}.menu('option', 'menus')")]
            get;
            [InlineCode("{this}.menu('option', 'menus', {value})")]
            set;
        }


        /// <summary>
        /// Identifies the position of submenus in relation to the associated parent menu item. The <code>of</code> option defaults to the parent menu item, but you can specify another element to position against. You can refer to the <a href="/position/">jQuery UI Position</a> utility for more details about the various options.
        /// </summary>
        public object Position {
            [InlineCode("{this}.menu('option', 'position')")]
            get;
            [InlineCode("{this}.menu('option', 'position', {value})")]
            set;
        }


        /// <summary>
        /// <para>Customize the ARIA roles used for the menu and menu items. The default uses <code>"menuitem"</code> for items. Setting the <code>role</code> option to <code>"listbox"</code> will use <code>"option"</code> for items. If set to <code>null</code>, no roles will be set, which is useful if the menu is being controlled by another element that is maintaining focus.</para><div class="warning"><strong>Note:</strong> The <code>role</code> option should not be changed after initialization. Existing (sub)menus and menu items will not be updated.</div>
        /// </summary>
        public string Role {
            [InlineCode("{this}.menu('option', 'role')")]
            get;
            [InlineCode("{this}.menu('option', 'role', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when the menu loses focus.
        /// </summary>
        public event jQueryUIEventHandler<MenuBlurEvent> OnBlur {
            [InlineCode("{this}.bind('menublur', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('menublur', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the menu is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('menucreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('menucreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when a menu gains focus or when any menu item is activated.
        /// </summary>
        public event jQueryUIEventHandler<MenuFocusEvent> OnFocus {
            [InlineCode("{this}.bind('menufocus', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('menufocus', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when a menu item is selected.
        /// </summary>
        public event jQueryUIEventHandler<MenuSelectEvent> OnSelect {
            [InlineCode("{this}.bind('menuselect', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('menuselect', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(MenuObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator MenuObject(jQueryObject o) {
            return null;
        }
    }
}
