using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    /// <summary>
    /// Create targets for draggable elements.
    /// </summary>
    /// <remarks>
    /// <para>The jQuery UI Droppable plugin makes selected elements droppable (meaning they accept being dropped on by <a href="/draggable/">draggables</a>). You can specify which draggables each will accept.</para><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/mouse/">Mouse Interaction</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class DroppableObject {

        private DroppableObject() {
        }

        /// <summary>
        /// Removes the droppable functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.droppable('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the droppable.
        /// </summary>
        [InlineCode("{this}.droppable('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the droppable.
        /// </summary>
        [InlineCode("{this}.droppable('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.droppable('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current droppable options hash.
        /// </summary>
        [InlineCode("{this}.droppable('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the droppable option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.droppable('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the droppable.
        /// </summary>
        [InlineCode("{this}.droppable('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the droppable.
        /// </summary>
        [InlineCode("{this}.droppable('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Controls which draggable elements are accepted by the droppable.
        /// </summary>
        public TypeOption<Delegate, string> Accept {
            [InlineCode("{this}.droppable('option', 'accept')")]
            get;
            [InlineCode("{this}.droppable('option', 'accept', {value})")]
            set;
        }


        /// <summary>
        /// If specified, the class will be added to the droppable while an acceptable draggable is being dragged.
        /// </summary>
        public string ActiveClass {
            [InlineCode("{this}.droppable('option', 'activeClass')")]
            get;
            [InlineCode("{this}.droppable('option', 'activeClass', {value})")]
            set;
        }


        /// <summary>
        /// If set to <code>false</code>, will prevent the <code>ui-droppable</code> class from being added. This may be desired as a performance optimization when calling <code>.droppable()</code> init on hundreds of elements.
        /// </summary>
        public bool AddClasses {
            [InlineCode("{this}.droppable('option', 'addClasses')")]
            get;
            [InlineCode("{this}.droppable('option', 'addClasses', {value})")]
            set;
        }


        /// <summary>
        /// Disables the droppable if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.droppable('option', 'disabled')")]
            get;
            [InlineCode("{this}.droppable('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// By default, when an element is dropped on nested droppables, each droppable will receive the element. However, by setting this option to <code>true</code>, any parent droppables will not receive the element.
        /// </summary>
        public bool Greedy {
            [InlineCode("{this}.droppable('option', 'greedy')")]
            get;
            [InlineCode("{this}.droppable('option', 'greedy', {value})")]
            set;
        }


        /// <summary>
        /// If specified, the class will be added to the droppable while an acceptable draggable is being hovered over the droppable.
        /// </summary>
        public string HoverClass {
            [InlineCode("{this}.droppable('option', 'hoverClass')")]
            get;
            [InlineCode("{this}.droppable('option', 'hoverClass', {value})")]
            set;
        }


        /// <summary>
        /// Used to group sets of draggable and droppable items, in addition to the <a href="#option-accept"><code>accept</code></a> option. A draggable with the same scope value as a droppable will be accepted.
        /// </summary>
        public string Scope {
            [InlineCode("{this}.droppable('option', 'scope')")]
            get;
            [InlineCode("{this}.droppable('option', 'scope', {value})")]
            set;
        }


        /// <summary>
        /// Specifies which mode to use for testing whether a draggable is hovering over a droppable. Possible values:<ul><li><code>"fit"</code>: Draggable overlaps the droppable entirely.</li><li><code>"intersect"</code>: Draggable overlaps the droppable at least 50% in both directions.</li><li><code>"pointer"</code>: Mouse pointer overlaps the droppable.</li><li><code>"touch"</code>: Draggable overlaps the droppable any amount.</li></ul>
        /// </summary>
        public string Tolerance {
            [InlineCode("{this}.droppable('option', 'tolerance')")]
            get;
            [InlineCode("{this}.droppable('option', 'tolerance', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when an accepted draggable starts dragging. This can be useful if you want to make the droppable "light up" when it can be dropped on.
        /// </summary>
        public event jQueryUIEventHandler<DroppableActivateEvent> OnActivate {
            [InlineCode("{this}.bind('dropactivate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dropactivate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the droppable is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('dropcreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dropcreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when an accepted draggable stops dragging.
        /// </summary>
        public event jQueryUIEventHandler<DroppableDeactivateEvent> OnDeactivate {
            [InlineCode("{this}.bind('dropdeactivate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dropdeactivate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when an accepted draggable is dropped on the droppable (based on the<a href="#option-tolerance"><code>tolerance</code></a> option).
        /// </summary>
        public event jQueryUIEventHandler<DroppableDropEvent> OnDrop {
            [InlineCode("{this}.bind('dropdrop', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dropdrop', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when an accepted draggable is dragged out of the droppable (based on the<a href="#option-tolerance"><code>tolerance</code></a> option).
        /// </summary>
        public event jQueryUIEventHandler<object> OnOut {
            [InlineCode("{this}.bind('dropout', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dropout', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when an accepted draggable is dragged over the droppable (based on the<a href="#option-tolerance"><code>tolerance</code></a> option).
        /// </summary>
        public event jQueryUIEventHandler<DroppableOverEvent> OnOver {
            [InlineCode("{this}.bind('dropover', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dropover', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(DroppableObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator DroppableObject(jQueryObject o) {
            return null;
        }
    }
}
