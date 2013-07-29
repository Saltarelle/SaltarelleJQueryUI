using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Display status of a determinate or indeterminate process.
    /// </summary>
    /// <remarks>
    /// <para>The progress bar is designed to display the current percent complete for a process. The bar is coded to be flexibly sized through CSS and will scale to fit inside its parent container by default.</para><para>A determinate progress bar should only be used in situations where the system can accurately update the current status. A determinate progress bar should never fill from left to right, then loop back to empty for a single process — if the actual status cannot be calculated, an indeterminate progress bar should be used to provide user feedback.</para><div><h3 id="theming">Theming</h3><para>The progressbar widget uses the <a href="/theming/css-framework">jQuery UI CSS framework</a> to style its look and feel. If progressbar specific styling is needed, the following CSS class names can be used:</para></div><ul><li><code>ui-progressbar</code>: The outer container of the progressbar. This element will additionally have a class of <code>ui-progressbar-indeterminate</code> for indeterminate progressbars.<ul><li><code>ui-progressbar-value</code>: The element that represents the filled portion of the progressbar.<ul><li><code>ui-progressbar-overlay</code>: Overlay used to display an animation for indeterminate progressbars.</li></ul></li></ul></li></ul><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class ProgressBarObject {

        private ProgressBarObject() {
        }

        /// <summary>
        /// Removes the progressbar functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.progressbar('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the progressbar.
        /// </summary>
        [InlineCode("{this}.progressbar('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the progressbar.
        /// </summary>
        [InlineCode("{this}.progressbar('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.progressbar('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current progressbar options hash.
        /// </summary>
        [InlineCode("{this}.progressbar('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the progressbar option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.progressbar('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the progressbar.
        /// </summary>
        [InlineCode("{this}.progressbar('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Gets the current value of the progressbar.
        /// </summary>
        [InlineCode("{this}.progressbar('value')")]
        public void Value() {
        }


        /// <summary>
        /// Sets the current value of the progressbar.
        /// </summary>
        [InlineCode("{this}.progressbar('value', {value})")]
        public void Value(TypeOption<bool, int> value) {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the progressbar.
        /// </summary>
        [InlineCode("{this}.progressbar('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Disables the progressbar if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.progressbar('option', 'disabled')")]
            get;
            [InlineCode("{this}.progressbar('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// The maximum value of the progressbar.
        /// </summary>
        public int Max {
            [InlineCode("{this}.progressbar('option', 'max')")]
            get;
            [InlineCode("{this}.progressbar('option', 'max', {value})")]
            set;
        }


        /// <summary>
        /// The value of the progressbar.
        /// </summary>
        public TypeOption<bool, int> OptionValue {
            [InlineCode("{this}.progressbar('option', 'value')")]
            get;
            [InlineCode("{this}.progressbar('option', 'value', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when the value of the progressbar changes.
        /// </summary>
        public event jQueryUIEventHandler<object> OnChange {
            [InlineCode("{this}.bind('progressbarchange', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('progressbarchange', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the value of the progressbar reaches the maximum value.
        /// </summary>
        public event jQueryUIEventHandler<object> OnComplete {
            [InlineCode("{this}.bind('progressbarcomplete', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('progressbarcomplete', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the progressbar is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('progressbarcreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('progressbarcreate', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(ProgressBarObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator ProgressBarObject(jQueryObject o) {
            return null;
        }
    }
}
