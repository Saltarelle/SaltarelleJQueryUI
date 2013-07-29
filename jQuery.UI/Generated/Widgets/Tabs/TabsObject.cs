using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// A single content area with multiple panels, each associated with a header in a list.
    /// </summary>
    /// <remarks>
    /// <para>Tabs are generally used to break content into multiple sections that can be swapped to save space, much like an accordion.</para><para>The content for each tab panel can be defined in-page or can be loaded via Ajax; both are handled automatically based on the <code>href</code> of the anchor associated with the tab. By default tabs are activated on click, but the events can be changed to hover via the <a href="#option-event"><code>event</code></a> option.</para><h3>Keyboard interaction</h3><para>When focus is on a tab, the following key commands are available:</para><ul><li>UP/LEFT: Move focus to the previous tab. If on first tab, moves focus to last tab. Activate focused tab after a short delay.</li><li>DOWN/RIGHT: Move focus to the next tab. If on last tab, moves focus to first tab. Activate focused tab after a short delay.</li><li>HOME: Move focus to the first tab. Activate focused tab after a short delay.</li><li>END: Move focus to the last tab. Activate focused tab after a short delay.</li><li>SPACE: Activate panel associated with focused tab.</li><li>ENTER: Activate or toggle panel associated with focused tab.</li><li>ALT+PAGE UP: Move focus to the previous tab and immediately activate.</li><li>ALT+PAGE DOWN: Move focus to the next tab and immediately activate.</li></ul><para>When focus is in a panel, the following key commands are available:</para><ul><li>CTRL+UP: Move focus to associated tab.</li><li>ALT+PAGE UP: Move focus to the previous tab and immediately activate.</li><li>ALT+PAGE DOWN: Move focus to the next tab and immediately activate.</li></ul><div><h3 id="theming">Theming</h3><para>The tabs widget uses the <a href="/theming/css-framework">jQuery UI CSS framework</a> to style its look and feel. If tabs specific styling is needed, the following CSS class names can be used:</para></div><ul><li><code>ui-tabs</code>: The outer container of the tabs. This element will additionally have a class of <code>ui-tabs-collapsible</code> when the <a href="#option-collapsible"><code>collapsible</code></a> option is set.<ul><li><code>ui-tabs-nav</code>: The list of tabs.<ul><li>The active list item in the nav will have a <code>ui-tabs-active</code> class. Any list item whose associated content is loading via an Ajax call will have a <code>ui-tabs-loading</code> class.<ul><li><code>ui-tabs-anchor</code>: The anchors used to switch panels.</li></ul></li></ul></li><li><code>ui-tabs-panel</code>: The panels associated with the tabs. Only the panel whose corresponding tab is active will be visible.</li></ul></li></ul><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/category/effects-core/">Effects Core</a> (optional; for use with the <a href="#option-show"><code>show</code></a> and <a href="#option-hide"><code>hide</code></a> options)</li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class TabsObject {

        private TabsObject() {
        }

        /// <summary>
        /// Removes the tabs functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.tabs('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables all tabs.
        /// </summary>
        [InlineCode("{this}.tabs('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Disables a tab. The selected tab cannot be disabled. To disable more than one tab at once, set the <a href="#option-disabled"><code>disabled</code></a> option: <code>$( "#tabs" ).tabs( "option", "disabled", [ 1, 2, 3 ] )</code>.
        /// </summary>
        [InlineCode("{this}.tabs('disable', {index})")]
        public void Disable(TypeOption<int, string> index) {
        }


        /// <summary>
        /// Enables all tabs.
        /// </summary>
        [InlineCode("{this}.tabs('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Enables a tab. To enable more than one tab at once reset the disabled property like: <code>$( "#example" ).tabs( "option", "disabled", [] );</code>.
        /// </summary>
        [InlineCode("{this}.tabs('enable', {index})")]
        public void Enable(TypeOption<int, string> index) {
        }


        /// <summary>
        /// Loads the panel content of a remote tab.
        /// </summary>
        [InlineCode("{this}.tabs('load', {index})")]
        public void Load(TypeOption<int, string> index) {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.tabs('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current tabs options hash.
        /// </summary>
        [InlineCode("{this}.tabs('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the tabs option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.tabs('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the tabs.
        /// </summary>
        [InlineCode("{this}.tabs('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Process any tabs that were added or removed directly in the DOM and recompute the height of the tab panels. Results depend on the content and the <a href="#option-heightStyle"><code>heightStyle</code></a> option.
        /// </summary>
        [InlineCode("{this}.tabs('refresh')")]
        public void Refresh() {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the tabs.
        /// </summary>
        [InlineCode("{this}.tabs('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Which panel is currently open.
        /// </summary>
        public TypeOption<bool, int> Active {
            [InlineCode("{this}.tabs('option', 'active')")]
            get;
            [InlineCode("{this}.tabs('option', 'active', {value})")]
            set;
        }


        /// <summary>
        /// When set to <code>true</code>, the active panel can be closed.
        /// </summary>
        public bool Collapsible {
            [InlineCode("{this}.tabs('option', 'collapsible')")]
            get;
            [InlineCode("{this}.tabs('option', 'collapsible', {value})")]
            set;
        }


        /// <summary>
        /// Which tabs are disabled.
        /// </summary>
        public TypeOption<Array, bool> Disabled {
            [InlineCode("{this}.tabs('option', 'disabled')")]
            get;
            [InlineCode("{this}.tabs('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// The type of event that the tabs should react to in order to activate the tab. To activate on hover, use <code>"mouseover"</code>.
        /// </summary>
        public string Event {
            [InlineCode("{this}.tabs('option', 'event')")]
            get;
            [InlineCode("{this}.tabs('option', 'event', {value})")]
            set;
        }


        /// <summary>
        /// Controls the height of the tabs widget and each panel. Possible values:<ul><li><code>"auto"</code>: All panels will be set to the height of the tallest panel.</li><li><code>"fill"</code>: Expand to the available height based on the tabs' parent height.</li><li><code>"content"</code>: Each panel will be only as tall as its content.</li></ul>
        /// </summary>
        public string HeightStyle {
            [InlineCode("{this}.tabs('option', 'heightStyle')")]
            get;
            [InlineCode("{this}.tabs('option', 'heightStyle', {value})")]
            set;
        }


        /// <summary>
        /// If and how to animate the hiding of the tabs.
        /// </summary>
        public TypeOption<bool, int, object, string> Hide {
            [InlineCode("{this}.tabs('option', 'hide')")]
            get;
            [InlineCode("{this}.tabs('option', 'hide', {value})")]
            set;
        }


        /// <summary>
        /// If and how to animate the showing of the tabs.
        /// </summary>
        public TypeOption<bool, int, object, string> Show {
            [InlineCode("{this}.tabs('option', 'show')")]
            get;
            [InlineCode("{this}.tabs('option', 'show', {value})")]
            set;
        }


        /// <summary>
        /// Triggered after a tab has been activated (after animation completes). If the tabs were previously collapsed, <code>ui.oldTab</code> and <code>ui.oldPanel</code> will be empty jQuery objects. If the tabs are collapsing, <code>ui.newTab</code> and <code>ui.newPanel</code> will be empty jQuery objects.
        /// </summary>
        public event jQueryUIEventHandler<TabsActivateEvent> OnActivate {
            [InlineCode("{this}.bind('tabsactivate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('tabsactivate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered immediately before a tab is activated. Can be canceled to prevent the tab from activating. If the tabs are currently collapsed, <code>ui.oldTab</code> and <code>ui.oldPanel</code> will be empty jQuery objects. If the tabs are collapsing, <code>ui.newTab</code> and <code>ui.newPanel</code> will be empty jQuery objects.
        /// </summary>
        public event jQueryUIEventHandler<TabsBeforeActivateEvent> OnBeforeActivate {
            [InlineCode("{this}.bind('tabsbeforeactivate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('tabsbeforeactivate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// <para>Triggered when a remote tab is about to be loaded, after the <a href="#event-beforeActivate"><code>beforeActivate</code></a> event. Can be canceled to prevent the tab panel from loading content; though the panel will still be activated. This event is triggered just before the Ajax request is made, so modifications can be made to <code>ui.jqXHR</code> and <code>ui.ajaxSettings</code>.</para><para><em>Note: Although <code>ui.ajaxSettings</code> is provided and can be modified, some of these settings have already been processed by jQuery. For example, <a href="http://api.jquery.com/jQuery.ajaxPrefilter/">prefilters</a> have been applied, <code>data</code> has been processed, and <code>type</code> has been determined. The <code>beforeLoad</code> event occurs at the same time, and therefore has the same restrictions, as the <code>beforeSend</code> callback from <a href="http://api.jquery.com/jQuery.ajax/"><code>jQuery.ajax()</code></a>.</em></para>
        /// </summary>
        public event jQueryUIEventHandler<TabsBeforeLoadEvent> OnBeforeLoad {
            [InlineCode("{this}.bind('tabsbeforeload', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('tabsbeforeload', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the tabs are created. If the tabs are collapsed, <code>ui.tab</code> and <code>ui.panel</code> will be empty jQuery objects.
        /// </summary>
        public event jQueryUIEventHandler<TabsCreateEvent> OnCreate {
            [InlineCode("{this}.bind('tabscreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('tabscreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered after a remote tab has been loaded.
        /// </summary>
        public event jQueryUIEventHandler<TabsLoadEvent> OnLoad {
            [InlineCode("{this}.bind('tabsload', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('tabsload', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(TabsObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator TabsObject(jQueryObject o) {
            return null;
        }
    }
}
