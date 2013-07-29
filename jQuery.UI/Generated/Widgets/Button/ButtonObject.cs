using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Themable buttons and button sets.
    /// </summary>
    /// <remarks>
    /// <para>Button enhances standard form elements like buttons, inputs and anchors to themable buttons with appropiate hover and active styles.</para><para>In addition to basic push buttons, radio buttons and checkboxes (inputs of type radio and checkbox) can be converted to buttons. Their associated label is styled to appear as the button, while the underlying input is updated on click. For the association to work properly, give the input an <code>id</code> attribute, and refer to that in the label's <code>for</code> attribute. Don't nest the input inside the label, as that <a href="http://www.paciellogroup.com/blog/2011/07/html5-accessibility-chops-form-control-labeling/">causes accessbility problems</a>.</para><para>In order to group radio buttons, Button also provides an additional widget, called Buttonset. Buttonset is used by selecting a container element (which contains the radio buttons) and calling <code>.buttonset()</code>. Buttonset will also provide visual grouping, and therefore should be used whenever you have a group of buttons. It works by selecting all descendants and applying <code>.button()</code> to them. You can enable and disable a button set, which will enable and disable all contained buttons. Destroying a button set also calls each button's <code>destroy</code> method.</para><para>When using an input of type button, submit or reset, support is limited to plain text labels with no icons.</para><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class ButtonObject {

        private ButtonObject() {
        }

        /// <summary>
        /// Removes the button functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.button('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the button.
        /// </summary>
        [InlineCode("{this}.button('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the button.
        /// </summary>
        [InlineCode("{this}.button('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.button('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current button options hash.
        /// </summary>
        [InlineCode("{this}.button('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the button option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.button('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the button.
        /// </summary>
        [InlineCode("{this}.button('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Refreshes the visual state of the button. Useful for updating button state after the native element's checked or disabled state is changed programmatically.
        /// </summary>
        [InlineCode("{this}.button('refresh')")]
        public void Refresh() {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the button.
        /// </summary>
        [InlineCode("{this}.button('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Disables the button if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.button('option', 'disabled')")]
            get;
            [InlineCode("{this}.button('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// Icons to display, with or without text (see <a href="#option-text"><code>text</code></a> option). By default, the primary icon is displayed on the left of the label text and the secondary is displayed on the right. The positioning can be controlled via CSS. The value for the <code>primary</code> and <code>secondary</code> properties must be a class name, e.g., <code>"ui-icon-gear"</code>. For using only one icon: <code>icons: { primary: "ui-icon-locked" }</code>. For using two icons: <code>icons: { primary: "ui-icon-gear", secondary: "ui-icon-triangle-1-s" }</code>.
        /// </summary>
        public object Icons {
            [InlineCode("{this}.button('option', 'icons')")]
            get;
            [InlineCode("{this}.button('option', 'icons', {value})")]
            set;
        }


        /// <summary>
        /// Text to show in the button. When not specified (<code>null</code>), the element's HTML content is used, or its <code>value</code> attribute if the element is an input element of type submit or reset, or the HTML content of the associated label element if the element is an input of type radio or checkbox.
        /// </summary>
        public string Label {
            [InlineCode("{this}.button('option', 'label')")]
            get;
            [InlineCode("{this}.button('option', 'label', {value})")]
            set;
        }


        /// <summary>
        /// Whether to show the label. When set to <code>false</code> no text will be displayed, but the <a href="#options-icons"><code>icons</code></a> option must be enabled, otherwise the <code>text</code> option will be ignored.
        /// </summary>
        public bool Text {
            [InlineCode("{this}.button('option', 'text')")]
            get;
            [InlineCode("{this}.button('option', 'text', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when the button is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('buttoncreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('buttoncreate', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(ButtonObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator ButtonObject(jQueryObject o) {
            return null;
        }
    }
}
