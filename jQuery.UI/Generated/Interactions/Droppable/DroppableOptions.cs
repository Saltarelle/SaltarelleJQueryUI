using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class DroppableOptions {

        /// <summary>
        /// Controls which draggable elements are accepted by the droppable.
        /// </summary>
        public TypeOption<Delegate, string> Accept {
            get; set;
        }

        /// <summary>
        /// If specified, the class will be added to the droppable while an acceptable draggable is being dragged.
        /// </summary>
        public string ActiveClass {
            get; set;
        }

        /// <summary>
        /// If set to <code>false</code>, will prevent the <code>ui-droppable</code> class from being added. This may be desired as a performance optimization when calling <code>.droppable()</code> init on hundreds of elements.
        /// </summary>
        public bool AddClasses {
            get; set;
        }

        /// <summary>
        /// Disables the droppable if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// By default, when an element is dropped on nested droppables, each droppable will receive the element. However, by setting this option to <code>true</code>, any parent droppables will not receive the element.
        /// </summary>
        public bool Greedy {
            get; set;
        }

        /// <summary>
        /// If specified, the class will be added to the droppable while an acceptable draggable is being hovered over the droppable.
        /// </summary>
        public string HoverClass {
            get; set;
        }

        /// <summary>
        /// Used to group sets of draggable and droppable items, in addition to the <a href="#option-accept"><code>accept</code></a> option. A draggable with the same scope value as a droppable will be accepted.
        /// </summary>
        public string Scope {
            get; set;
        }

        /// <summary>
        /// Specifies which mode to use for testing whether a draggable is hovering over a droppable. Possible values:<ul><li><code>"fit"</code>: Draggable overlaps the droppable entirely.</li><li><code>"intersect"</code>: Draggable overlaps the droppable at least 50% in both directions.</li><li><code>"pointer"</code>: Mouse pointer overlaps the droppable.</li><li><code>"touch"</code>: Draggable overlaps the droppable any amount.</li></ul>
        /// </summary>
        public string Tolerance {
            get; set;
        }

        /// <summary>
        /// Triggered when an accepted draggable starts dragging. This can be useful if you want to make the droppable "light up" when it can be dropped on.
        /// </summary>
        [ScriptName("activate")]
        public jQueryUIEventHandler<DroppableActivateEvent> OnActivate {
             get; set;
        }

        /// <summary>
        /// Triggered when the droppable is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// Triggered when an accepted draggable stops dragging.
        /// </summary>
        [ScriptName("deactivate")]
        public jQueryUIEventHandler<DroppableDeactivateEvent> OnDeactivate {
             get; set;
        }

        /// <summary>
        /// Triggered when an accepted draggable is dropped on the droppable (based on the<a href="#option-tolerance"><code>tolerance</code></a> option).
        /// </summary>
        [ScriptName("drop")]
        public jQueryUIEventHandler<DroppableDropEvent> OnDrop {
             get; set;
        }

        /// <summary>
        /// Triggered when an accepted draggable is dragged out of the droppable (based on the<a href="#option-tolerance"><code>tolerance</code></a> option).
        /// </summary>
        [ScriptName("out")]
        public jQueryUIEventHandler<object> OnOut {
             get; set;
        }

        /// <summary>
        /// Triggered when an accepted draggable is dragged over the droppable (based on the<a href="#option-tolerance"><code>tolerance</code></a> option).
        /// </summary>
        [ScriptName("over")]
        public jQueryUIEventHandler<DroppableOverEvent> OnOver {
             get; set;
        }
    }
}
