using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    public static class InteractionExtensions {

        /// <summary>
        /// Allow elements to be moved using the mouse.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("draggable")]
        public static DraggableObject Draggable(this jQueryObject q) {
            return null;
        }


        /// <summary>
        /// Allow elements to be moved using the mouse.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("draggable")]
        public static DraggableObject Draggable(this jQueryObject q, DraggableOptions options) {
            return null;
        }


        /// <summary>
        /// Create targets for draggable elements.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("droppable")]
        public static DroppableObject Droppable(this jQueryObject q) {
            return null;
        }


        /// <summary>
        /// Create targets for draggable elements.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("droppable")]
        public static DroppableObject Droppable(this jQueryObject q, DroppableOptions options) {
            return null;
        }


        /// <summary>
        /// The base interaction layer.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("mouse")]
        public static MouseObject Mouse(this jQueryObject q) {
            return null;
        }


        /// <summary>
        /// The base interaction layer.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("mouse")]
        public static MouseObject Mouse(this jQueryObject q, MouseOptions options) {
            return null;
        }


        /// <summary>
        /// Change the size of an element using the mouse.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("resizable")]
        public static ResizableObject Resizable(this jQueryObject q) {
            return null;
        }


        /// <summary>
        /// Change the size of an element using the mouse.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("resizable")]
        public static ResizableObject Resizable(this jQueryObject q, ResizableOptions options) {
            return null;
        }


        /// <summary>
        /// Use the mouse to select elements, individually or in a group.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("selectable")]
        public static SelectableObject Selectable(this jQueryObject q) {
            return null;
        }


        /// <summary>
        /// Use the mouse to select elements, individually or in a group.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("selectable")]
        public static SelectableObject Selectable(this jQueryObject q, SelectableOptions options) {
            return null;
        }


        /// <summary>
        /// Reorder elements in a list or grid using the mouse.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("sortable")]
        public static SortableObject Sortable(this jQueryObject q) {
            return null;
        }


        /// <summary>
        /// Reorder elements in a list or grid using the mouse.
        /// </summary>
        [InstanceMethodOnFirstArgument]
        [ScriptName("sortable")]
        public static SortableObject Sortable(this jQueryObject q, SortableOptions options) {
            return null;
        }

    }
}
