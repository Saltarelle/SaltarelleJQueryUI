using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Customizable, themeable tooltips, replacing native tooltips.
    /// </summary>
    /// <remarks>
    /// <para>Tooltip replaces native tooltips, making them themeable as well as allowing various customizations:</para><ul><li>Display other content than just the title, like inline footnotes or extra content retrieved via Ajax.</li><li>Customize the positioning, e.g., to center the tooltip above elements.</li><li>Add extra styling to customize the appearance, for warning or error fields.</li></ul><para>A fade animation is used by default to show and hide the tooltip, making the appearance a bit more organic, compared to just toggling the visibility. This can be customized with the <a href="#option-show"><code>show</code></a> and <a href="#option-hide"><code>hide</code></a> options.</para><para>The <a href="#option-items"><code>items</code></a> and <a href="#option-content"><code>content</code></a> options need to stay in-sync. If you change one of them, you need to change the other.</para><para>In general, disabled elements do not trigger any DOM events. Therefore, it is not possible to properly control tooltips for disabled elements, since we need to listen to events to determine when to show and hide the tooltip. As a result, jQuery UI does not guarantee any level of support for tooltips attached to disabled elements. Unfortunately, this means that if you require tooltips on disabled elements, you may end up with a mixture of native tooltips and jQuery UI tooltips.</para><div><h3 id="theming">Theming</h3><para>The tooltip widget uses the <a href="/theming/css-framework">jQuery UI CSS framework</a> to style its look and feel. If tooltip specific styling is needed, the following CSS class names can be used:</para></div><ul><li><code>ui-tooltip</code>: The outer container for the tooltip.<ul><li><code>ui-tooltip-content</code>: The content of the tooltip.</li></ul></li></ul><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/position/">Position</a></li><li><a href="/category/effects-core/">Effects Core</a> (optional; for use with the <a href="#option-show"><code>show</code></a> and <a href="#option-hide"><code>hide</code></a> options)</li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class TooltipObject {

        private TooltipObject() {
        }

        /// <summary>
        /// Closes a tooltip. This is only intended to be called for non-delegated tooltips.
        /// </summary>
        [InlineCode("{this}.tooltip('close')")]
        public void Close() {
        }


        /// <summary>
        /// Removes the tooltip functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.tooltip('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the tooltip.
        /// </summary>
        [InlineCode("{this}.tooltip('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the tooltip.
        /// </summary>
        [InlineCode("{this}.tooltip('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Programmatically open a tooltip. This is only intended to be called for non-delegated tooltips.
        /// </summary>
        [InlineCode("{this}.tooltip('open')")]
        public void Open() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.tooltip('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current tooltip options hash.
        /// </summary>
        [InlineCode("{this}.tooltip('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the tooltip option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.tooltip('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the tooltip.
        /// </summary>
        [InlineCode("{this}.tooltip('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the tooltip.
        /// </summary>
        [InlineCode("{this}.tooltip('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// <para>The content of the tooltip.</para><para><em>When changing this option, you likely need to also change the <a href="#option-items"><code>items</code></a> option.</em></para>
        /// </summary>
        public TypeOption<Delegate, string> Content {
            [InlineCode("{this}.tooltip('option', 'content')")]
            get;
            [InlineCode("{this}.tooltip('option', 'content', {value})")]
            set;
        }


        /// <summary>
        /// Disables the tooltip if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.tooltip('option', 'disabled')")]
            get;
            [InlineCode("{this}.tooltip('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// If and how to animate the hiding of the tooltip.
        /// </summary>
        public TypeOption<bool, int, object, string> Hide {
            [InlineCode("{this}.tooltip('option', 'hide')")]
            get;
            [InlineCode("{this}.tooltip('option', 'hide', {value})")]
            set;
        }


        /// <summary>
        /// <para>A selector indicating which items should show tooltips. Customize if you're using something other then the title attribute for the tooltip content, or if you need a different selector for event delegation.</para><para><em>When changing this option, you likely need to also change the <a href="#option-content"><code>content</code></a> option.</em></para>
        /// </summary>
        public string Items {
            [InlineCode("{this}.tooltip('option', 'items')")]
            get;
            [InlineCode("{this}.tooltip('option', 'items', {value})")]
            set;
        }


        /// <summary>
        /// <para>Identifies the position of the tooltip in relation to the associated target element. The <code>of</code> option defaults to the target element, but you can specify another element to position against. You can refer to the <a href="/position">jQuery UI Position</a> utility for more details about the various options.</para>
        /// </summary>
        public object Position {
            [InlineCode("{this}.tooltip('option', 'position')")]
            get;
            [InlineCode("{this}.tooltip('option', 'position', {value})")]
            set;
        }


        /// <summary>
        /// If and how to animate the showing of the tooltip.
        /// </summary>
        public TypeOption<bool, int, object, string> Show {
            [InlineCode("{this}.tooltip('option', 'show')")]
            get;
            [InlineCode("{this}.tooltip('option', 'show', {value})")]
            set;
        }


        /// <summary>
        /// A class to add to the widget, can be used to display various tooltip types, like warnings or errors.<para>This may get replaced by the <a href="http://bugs.jqueryui.com/ticket/7053">classes option</a>.</para>
        /// </summary>
        public string TooltipClass {
            [InlineCode("{this}.tooltip('option', 'tooltipClass')")]
            get;
            [InlineCode("{this}.tooltip('option', 'tooltipClass', {value})")]
            set;
        }


        /// <summary>
        /// Whether the tooltip should track (follow) the mouse.
        /// </summary>
        public bool Track {
            [InlineCode("{this}.tooltip('option', 'track')")]
            get;
            [InlineCode("{this}.tooltip('option', 'track', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when a tooltip is closed, triggered on <code>focusout</code> or <code>mouseleave</code>.
        /// </summary>
        public event jQueryUIEventHandler<TooltipCloseEvent> OnClose {
            [InlineCode("{this}.bind('tooltipclose', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('tooltipclose', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the tooltip is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('tooltipcreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('tooltipcreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when a tooltip is shown, triggered on <code>focusin</code> or <code>mouseover</code>.
        /// </summary>
        public event jQueryUIEventHandler<TooltipOpenEvent> OnOpen {
            [InlineCode("{this}.bind('tooltipopen', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('tooltipopen', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(TooltipObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator TooltipObject(jQueryObject o) {
            return null;
        }
    }
}
