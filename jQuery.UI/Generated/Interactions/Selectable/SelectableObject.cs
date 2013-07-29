using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    /// <summary>
    /// Use the mouse to select elements, individually or in a group.
    /// </summary>
    /// <remarks>
    /// <para>The jQuery UI Selectable plugin allows for elements to be selected by dragging a box (sometimes called a lasso) with the mouse over the elements. Elements can also be selected via click or drag while holding the ctrl/meta key, allowing for multiple (non-contiguous) selections.</para><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/mouse/">Mouse Interaction</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class SelectableObject {

        private SelectableObject() {
        }

        /// <summary>
        /// Removes the selectable functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.selectable('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the selectable.
        /// </summary>
        [InlineCode("{this}.selectable('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the selectable.
        /// </summary>
        [InlineCode("{this}.selectable('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.selectable('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current selectable options hash.
        /// </summary>
        [InlineCode("{this}.selectable('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the selectable option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.selectable('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the selectable.
        /// </summary>
        [InlineCode("{this}.selectable('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Refresh the position and size of each selectee element. This method can be used to manually recalculate the position and size of each selectee when the <a href="#option-autoRefresh"><code>autoRefresh</code></a> option is set to <code>false</code>.
        /// </summary>
        [InlineCode("{this}.selectable('refresh')")]
        public void Refresh() {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the selectable.
        /// </summary>
        [InlineCode("{this}.selectable('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Which element the selection helper (the lasso) should be appended to.
        /// </summary>
        public string AppendTo {
            [InlineCode("{this}.selectable('option', 'appendTo')")]
            get;
            [InlineCode("{this}.selectable('option', 'appendTo', {value})")]
            set;
        }


        /// <summary>
        /// This determines whether to refresh (recalculate) the position and size of each selectee at the beginning of each select operation. If you have many items, you may want to set this to false and call the <a href="#method-refresh"><code>refresh()</code></a> method manually.
        /// </summary>
        public bool AutoRefresh {
            [InlineCode("{this}.selectable('option', 'autoRefresh')")]
            get;
            [InlineCode("{this}.selectable('option', 'autoRefresh', {value})")]
            set;
        }


        /// <summary>
        /// Prevents selecting if you start on elements matching the selector.
        /// </summary>
        public string Cancel {
            [InlineCode("{this}.selectable('option', 'cancel')")]
            get;
            [InlineCode("{this}.selectable('option', 'cancel', {value})")]
            set;
        }


        /// <summary>
        /// Time in milliseconds to define when the selecting should start. This helps prevent unwanted selections when clicking on an element.
        /// </summary>
        public int Delay {
            [InlineCode("{this}.selectable('option', 'delay')")]
            get;
            [InlineCode("{this}.selectable('option', 'delay', {value})")]
            set;
        }


        /// <summary>
        /// Disables the selectable if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.selectable('option', 'disabled')")]
            get;
            [InlineCode("{this}.selectable('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// Tolerance, in pixels, for when selecting should start. If specified, selecting will not start until the mouse has been dragged beyond the specified distance.
        /// </summary>
        public int Distance {
            [InlineCode("{this}.selectable('option', 'distance')")]
            get;
            [InlineCode("{this}.selectable('option', 'distance', {value})")]
            set;
        }


        /// <summary>
        /// The matching child elements will be made selectees (able to be selected).
        /// </summary>
        public string Filter {
            [InlineCode("{this}.selectable('option', 'filter')")]
            get;
            [InlineCode("{this}.selectable('option', 'filter', {value})")]
            set;
        }


        /// <summary>
        /// Specifies which mode to use for testing whether the lasso should select an item. Possible values:<ul><li><code>"fit"</code>: Lasso overlaps the item entirely.</li><li><code>"touch"</code>: Lasso overlaps the item by any amount.</li></ul>
        /// </summary>
        public string Tolerance {
            [InlineCode("{this}.selectable('option', 'tolerance')")]
            get;
            [InlineCode("{this}.selectable('option', 'tolerance', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when the selectable is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('selectablecreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('selectablecreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered at the end of the select operation, on each element added to the selection.
        /// </summary>
        public event jQueryUIEventHandler<SelectableSelectedEvent> OnSelected {
            [InlineCode("{this}.bind('selectableselected', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('selectableselected', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered during the select operation, on each element added to the selection.
        /// </summary>
        public event jQueryUIEventHandler<SelectableSelectingEvent> OnSelecting {
            [InlineCode("{this}.bind('selectableselecting', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('selectableselecting', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered at the beginning of the select operation.
        /// </summary>
        public event jQueryUIEventHandler<object> OnStart {
            [InlineCode("{this}.bind('selectablestart', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('selectablestart', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered at the end of the select operation.
        /// </summary>
        public event jQueryUIEventHandler<object> OnStop {
            [InlineCode("{this}.bind('selectablestop', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('selectablestop', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered at the end of the select operation, on each element removed from the selection.
        /// </summary>
        public event jQueryUIEventHandler<SelectableUnselectedEvent> OnUnselected {
            [InlineCode("{this}.bind('selectableunselected', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('selectableunselected', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered during the select operation, on each element removed from the selection.
        /// </summary>
        public event jQueryUIEventHandler<SelectableUnselectingEvent> OnUnselecting {
            [InlineCode("{this}.bind('selectableunselecting', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('selectableunselecting', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(SelectableObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator SelectableObject(jQueryObject o) {
            return null;
        }
    }
}
