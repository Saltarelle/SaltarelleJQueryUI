using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Convert a pair of headers and content panels into an accordion.
    /// </summary>
    /// <remarks>
    /// <para>The markup of your accordion container needs pairs of headers and content panels:</para><c><code data-linenum="true"><div id="accordion"><h3>First header</h3><div>First content panel</div><h3>Second header</h3><div>Second content panel</div></div></code></c><para>Accordions support arbitrary markup, but each content panel must always be the next sibling after its associated header. See the <a href="#option-header"><code>header</code></a> option for information on how to use custom markup structures.</para><para>The panels can be activated programmatically by setting the <a href="#option-active"><code>active</code></a> option.</para><h3>Keyboard interaction</h3><para>When focus is on a header, the following key commands are available:</para><ul><li>UP/LEFT - Move focus to the previous header. If on first header, moves focus to last header.</li><li>DOWN/RIGHT - Move focus to the next header. If on last header, moves focus to first header.</li><li>HOME - Move focus to the first header.</li><li>END - Move focus to the last header.</li><li>SPACE/ENTER - Activate panel associated with focused header.</li></ul><para>When focus is in a panel:</para><ul><li>CTRL+UP: Move focus to associated header.</li></ul><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/category/effects-core/">Effects Core</a> (optional; for use with the <a href="#option-animate"><code>animate</code></a> option)</li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class AccordionObject {

        private AccordionObject() {
        }

        /// <summary>
        /// Removes the accordion functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.accordion('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the accordion.
        /// </summary>
        [InlineCode("{this}.accordion('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the accordion.
        /// </summary>
        [InlineCode("{this}.accordion('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.accordion('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current accordion options hash.
        /// </summary>
        [InlineCode("{this}.accordion('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the accordion option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.accordion('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the accordion.
        /// </summary>
        [InlineCode("{this}.accordion('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Recompute the height of the accordion panels. Results depend on the content and the <a href="#option-heightStyle"><code>heightStyle</code></a> option.
        /// </summary>
        [InlineCode("{this}.accordion('refresh')")]
        public void Refresh() {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the accordion.
        /// </summary>
        [InlineCode("{this}.accordion('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Which panel is currently open.
        /// </summary>
        public TypeOption<bool, int> Active {
            [InlineCode("{this}.accordion('option', 'active')")]
            get;
            [InlineCode("{this}.accordion('option', 'active', {value})")]
            set;
        }


        /// <summary>
        /// If and how to animate changing panels.
        /// </summary>
        public TypeOption<bool, int, object, string> Animate {
            [InlineCode("{this}.accordion('option', 'animate')")]
            get;
            [InlineCode("{this}.accordion('option', 'animate', {value})")]
            set;
        }


        /// <summary>
        /// Whether all the sections can be closed at once. Allows collapsing the active section.
        /// </summary>
        public bool Collapsible {
            [InlineCode("{this}.accordion('option', 'collapsible')")]
            get;
            [InlineCode("{this}.accordion('option', 'collapsible', {value})")]
            set;
        }


        /// <summary>
        /// Disables the accordion if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.accordion('option', 'disabled')")]
            get;
            [InlineCode("{this}.accordion('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// The event that accordion headers will react to in order to activate the associated panel. Multiple events can be specificed, separated by a space.
        /// </summary>
        public string Event {
            [InlineCode("{this}.accordion('option', 'event')")]
            get;
            [InlineCode("{this}.accordion('option', 'event', {value})")]
            set;
        }


        /// <summary>
        /// <para>Selector for the header element, applied via <code>.find()</code> on the main accordion element. Content panels must be the sibling immedately after their associated headers.</para>
        /// </summary>
        public string Header {
            [InlineCode("{this}.accordion('option', 'header')")]
            get;
            [InlineCode("{this}.accordion('option', 'header', {value})")]
            set;
        }


        /// <summary>
        /// <para>Controls the height of the accordion and each panel. Possible values:</para><ul><li><code>"auto"</code>: All panels will be set to the height of the tallest panel.</li><li><code>"fill"</code>: Expand to the available height based on the accordion's parent height.</li><li><code>"content"</code>: Each panel will be only as tall as its content.</li></ul>
        /// </summary>
        public string HeightStyle {
            [InlineCode("{this}.accordion('option', 'heightStyle')")]
            get;
            [InlineCode("{this}.accordion('option', 'heightStyle', {value})")]
            set;
        }


        /// <summary>
        /// <para>Icons to use for headers, matching an icon defined by the jQuery UI CSS Framework. Set to <code>false</code> to have no icons displayed.</para><ul><li>header (string, default: "ui-icon-triangle-1-e")</li><li>activeHeader (string, default: "ui-icon-triangle-1-s")</li></ul>
        /// </summary>
        public object Icons {
            [InlineCode("{this}.accordion('option', 'icons')")]
            get;
            [InlineCode("{this}.accordion('option', 'icons', {value})")]
            set;
        }


        /// <summary>
        /// Triggered after a panel has been activated (after animation completes). If the accordion was previously collapsed, <code>ui.oldHeader</code> and <code>ui.oldPanel</code> will be empty jQuery objects. If the accordion is collapsing, <code>ui.newHeader</code> and <code>ui.newPanel</code> will be empty jQuery objects.
        /// </summary>
        public event jQueryUIEventHandler<AccordionActivateEvent> OnActivate {
            [InlineCode("{this}.bind('accordionactivate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('accordionactivate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered directly before a panel is activated. Can be canceled to prevent the panel from activating. If the accordion is currently collapsed, <code>ui.oldHeader</code> and <code>ui.oldPanel</code> will be empty jQuery objects. If the accordion is collapsing, <code>ui.newHeader</code> and <code>ui.newPanel</code> will be empty jQuery objects.
        /// </summary>
        public event jQueryUIEventHandler<AccordionBeforeActivateEvent> OnBeforeActivate {
            [InlineCode("{this}.bind('accordionbeforeactivate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('accordionbeforeactivate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the accordion is created. If the accordion is collapsed, <code>ui.header</code> and <code>ui.panel</code> will be empty jQuery objects.
        /// </summary>
        public event jQueryUIEventHandler<AccordionCreateEvent> OnCreate {
            [InlineCode("{this}.bind('accordioncreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('accordioncreate', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(AccordionObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator AccordionObject(jQueryObject o) {
            return null;
        }
    }
}
