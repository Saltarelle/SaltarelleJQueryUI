using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class SortableOptions {

        /// <summary>
        /// Defines where the helper that moves with the mouse is being appended to during the drag (for example, to resolve overlap/zIndex issues).
        /// </summary>
        public TypeOption<Element, jQueryObject, string> AppendTo {
            get; set;
        }

        /// <summary>
        /// If defined, the items can be dragged only horizontally or vertically. Possible values: <code>"x"</code>, <code>"y"</code>.
        /// </summary>
        public string Axis {
            get; set;
        }

        /// <summary>
        /// Prevents sorting if you start on elements matching the selector.
        /// </summary>
        public string Cancel {
            get; set;
        }

        /// <summary>
        /// A selector of other sortable elements that the items from this list should be connected to. This is a one-way relationship, if you want the items to be connected in both directions, the <code>connectWith</code> option must be set on both sortable elements.
        /// </summary>
        public string ConnectWith {
            get; set;
        }

        /// <summary>
        /// <para>Defines a bounding box that the sortable items are constrained to while dragging.</para><para>Note: The element specified for containment must have a calculated width and height (though it need not be explicit). For example, if you have <code>float: left</code> sortable children and specify <code>containment: "parent"</code> be sure to have <code>float: left</code> on the sortable/parent container as well or it will have <code>height: 0</code>, causing undefined behavior.</para>
        /// </summary>
        public TypeOption<Element, string> Containment {
            get; set;
        }

        /// <summary>
        /// Defines the cursor that is being shown while sorting.
        /// </summary>
        public string Cursor {
            get; set;
        }

        /// <summary>
        /// Moves the sorting element or helper so the cursor always appears to drag from the same position. Coordinates can be given as a hash using a combination of one or two keys: <code>{ top, left, right, bottom }</code>.
        /// </summary>
        public Box CursorAt {
            get; set;
        }

        /// <summary>
        /// Time in milliseconds to define when the sorting should start. Adding a delay helps preventing unwanted drags when clicking on an element.
        /// </summary>
        public int Delay {
            get; set;
        }

        /// <summary>
        /// Disables the sortable if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// Tolerance, in pixels, for when sorting should start. If specified, sorting will not start until after mouse is dragged beyond distance. Can be used to allow for clicks on elements within a handle.
        /// </summary>
        public int Distance {
            get; set;
        }

        /// <summary>
        /// If <code>false</code>, items from this sortable can't be dropped on an empty connect sortable (see the <a href="#option-connectWith"><code>connectWith</code></a> option.
        /// </summary>
        public bool DropOnEmpty {
            get; set;
        }

        /// <summary>
        /// If <code>true</code>, forces the helper to have a size.
        /// </summary>
        public bool ForceHelperSize {
            get; set;
        }

        /// <summary>
        /// If true, forces the placeholder to have a size.
        /// </summary>
        public bool ForcePlaceholderSize {
            get; set;
        }

        /// <summary>
        /// Snaps the sorting element or helper to a grid, every x and y pixels. Array values: <code>[ x, y ]</code>.
        /// </summary>
        public Array Grid {
            get; set;
        }

        /// <summary>
        /// Restricts sort start click to the specified element.
        /// </summary>
        public TypeOption<Element, string> Handle {
            get; set;
        }

        /// <summary>
        /// Allows for a helper element to be used for dragging display.
        /// </summary>
        public TypeOption<Delegate, string> Helper {
            get; set;
        }

        /// <summary>
        /// Specifies which items inside the element should be sortable.
        /// </summary>
        public string Items {
            get; set;
        }

        /// <summary>
        /// Defines the opacity of the helper while sorting. From <code>0.01</code> to <code>1</code>.
        /// </summary>
        public int Opacity {
            get; set;
        }

        /// <summary>
        /// A class name that gets applied to the otherwise white space.
        /// </summary>
        public string Placeholder {
            get; set;
        }

        /// <summary>
        /// Whether the sortable items should revert to their new positions using a smooth animation.
        /// </summary>
        public TypeOption<bool, int> Revert {
            get; set;
        }

        /// <summary>
        /// If set to true, the page scrolls when coming to an edge.
        /// </summary>
        public bool Scroll {
            get; set;
        }

        /// <summary>
        /// Defines how near the mouse must be to an edge to start scrolling.
        /// </summary>
        public int ScrollSensitivity {
            get; set;
        }

        /// <summary>
        /// The speed at which the window should scroll once the mouse pointer gets within the <a href="#option-scrollSensitivity"><code>scrollSensitivity</code></a> distance.
        /// </summary>
        public int ScrollSpeed {
            get; set;
        }

        /// <summary>
        /// Specifies which mode to use for testing whether the item being moved is hovering over another item. Possible values:<ul><li><code>"intersect"</code>: The item overlaps the other item by at least 50%.</li><li><code>"pointer"</code>: The mouse pointer overlaps the other item.</li></ul>
        /// </summary>
        public string Tolerance {
            get; set;
        }

        /// <summary>
        /// Z-index for element/helper while being sorted.
        /// </summary>
        public int ZIndex {
            get; set;
        }

        /// <summary>
        /// This event is triggered when using connected lists, every connected list on drag start receives it.
        /// </summary>
        [ScriptName("activate")]
        public jQueryUIEventHandler<SortableActivateEvent> OnActivate {
             get; set;
        }

        /// <summary>
        /// This event is triggered when sorting stops, but when the placeholder/helper is still available.
        /// </summary>
        [ScriptName("beforeStop")]
        public jQueryUIEventHandler<SortableBeforeStopEvent> OnBeforeStop {
             get; set;
        }

        /// <summary>
        /// This event is triggered during sorting, but only when the DOM position has changed.
        /// </summary>
        [ScriptName("change")]
        public jQueryUIEventHandler<SortableChangeEvent> OnChange {
             get; set;
        }

        /// <summary>
        /// Triggered when the sortable is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// This event is triggered when sorting was stopped, is propagated to all possible connected lists.
        /// </summary>
        [ScriptName("deactivate")]
        public jQueryUIEventHandler<SortableDeactivateEvent> OnDeactivate {
             get; set;
        }

        /// <summary>
        /// <para>This event is triggered when a sortable item is moved away from a sortable list.</para><para><em>Note: This event is also triggered when a sortable item is dropped.</em></para>
        /// </summary>
        [ScriptName("out")]
        public jQueryUIEventHandler<SortableOutEvent> OnOut {
             get; set;
        }

        /// <summary>
        /// This event is triggered when a sortable item is moved into a sortable list.
        /// </summary>
        [ScriptName("over")]
        public jQueryUIEventHandler<SortableOverEvent> OnOver {
             get; set;
        }

        /// <summary>
        /// This event is triggered when a connected sortable list has received an item from another list.
        /// </summary>
        [ScriptName("receive")]
        public jQueryUIEventHandler<SortableReceiveEvent> OnReceive {
             get; set;
        }

        /// <summary>
        /// This event is triggered when a sortable item has been dragged out from the list and into another.
        /// </summary>
        [ScriptName("remove")]
        public jQueryUIEventHandler<SortableRemoveEvent> OnRemove {
             get; set;
        }

        /// <summary>
        /// This event is triggered during sorting.
        /// </summary>
        [ScriptName("sort")]
        public jQueryUIEventHandler<SortableSortEvent> OnSort {
             get; set;
        }

        /// <summary>
        /// This event is triggered when sorting starts.
        /// </summary>
        [ScriptName("start")]
        public jQueryUIEventHandler<SortableStartEvent> OnStart {
             get; set;
        }

        /// <summary>
        /// This event is triggered when sorting has stopped.
        /// </summary>
        [ScriptName("stop")]
        public jQueryUIEventHandler<SortableStopEvent> OnStop {
             get; set;
        }

        /// <summary>
        /// This event is triggered when the user stopped sorting and the DOM position has changed.
        /// </summary>
        [ScriptName("update")]
        public jQueryUIEventHandler<SortableUpdateEvent> OnUpdate {
             get; set;
        }
    }
}
