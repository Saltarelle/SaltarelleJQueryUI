using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class DraggableOptions {

        /// <summary>
        /// If set to <code>false</code>, will prevent the <code>ui-draggable</code> class from being added. This may be desired as a performance optimization when calling <code>.draggable()</code> on hundreds of elements.
        /// </summary>
        public bool AddClasses {
            get; set;
        }

        /// <summary>
        /// Which element the draggable helper should be appended to while dragging.
        /// </summary>
        public TypeOption<Element, jQueryObject, string> AppendTo {
            get; set;
        }

        /// <summary>
        /// Constrains dragging to either the horizontal (x) or vertical (y) axis. Possible values: <code>"x"</code>, <code>"y"</code>.
        /// </summary>
        public string Axis {
            get; set;
        }

        /// <summary>
        /// Prevents dragging from starting on specified elements.
        /// </summary>
        public string Cancel {
            get; set;
        }

        /// <summary>
        /// Allows the draggable to be dropped onto the specified sortables. If this option is used, a draggable can be dropped onto a sortable list and then becomes part of it. Note: The <a href="#option-helper"><code>helper</code></a> option must be set to <code>"clone"</code> in order to work flawlessly. Requires the <a href="/sortable/">jQuery UI Sortable plugin</a> to be included.
        /// </summary>
        public string ConnectToSortable {
            get; set;
        }

        /// <summary>
        /// Constrains dragging to within the bounds of the specified element or region.
        /// </summary>
        public TypeOption<Array, Element, string> Containment {
            get; set;
        }

        /// <summary>
        /// The CSS cursor during the drag operation.
        /// </summary>
        public string Cursor {
            get; set;
        }

        /// <summary>
        /// Sets the offset of the dragging helper relative to the mouse cursor. Coordinates can be given as a hash using a combination of one or two keys: <code>{ top, left, right, bottom }</code>.
        /// </summary>
        public Box CursorAt {
            get; set;
        }

        /// <summary>
        /// Time in milliseconds after mousedown until dragging should start. This option can be used to prevent unwanted drags when clicking on an element.
        /// </summary>
        public int Delay {
            get; set;
        }

        /// <summary>
        /// Disables the draggable if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// Distance in pixels after mousedown the mouse must move before dragging should start. This option can be used to prevent unwanted drags when clicking on an element.
        /// </summary>
        public int Distance {
            get; set;
        }

        /// <summary>
        /// Snaps the dragging helper to a grid, every x and y pixels. The array must be of the form <code>[ x, y ]</code>.
        /// </summary>
        public Array Grid {
            get; set;
        }

        /// <summary>
        /// If specified, restricts dragging from starting unless the mousedown occurs on the specified element(s).
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
        /// Prevent iframes from capturing the mousemove events during a drag. Useful in combination with the <a href="#option-cursorAt"><code>cursorAt</code></a> option, or in any case where the mouse cursor may not be over the helper.
        /// </summary>
        public TypeOption<bool, string> IframeFix {
            get; set;
        }

        /// <summary>
        /// Opacity for the helper while being dragged.
        /// </summary>
        public int Opacity {
            get; set;
        }

        /// <summary>
        /// If set to <code>true</code>, all droppable positions are calculated on every mousemove.<em>Caution: This solves issues on highly dynamic pages, but dramatically decreases performance.</em>
        /// </summary>
        public bool RefreshPositions {
            get; set;
        }

        /// <summary>
        /// Whether the element should revert to its start position when dragging stops.
        /// </summary>
        public TypeOption<bool, string> Revert {
            get; set;
        }

        /// <summary>
        /// The duration of the revert animation, in milliseconds. Ignored if the <a href="#option-revert"><code>revert</code></a> option is <code>false</code>.
        /// </summary>
        public int RevertDuration {
            get; set;
        }

        /// <summary>
        /// Used to group sets of draggable and droppable items, in addition to droppable's <a href="/droppable#option-accept"><code>accept</code></a> option. A draggable with the same <code>scope</code> value as a droppable will be accepted by the droppable.
        /// </summary>
        public string Scope {
            get; set;
        }

        /// <summary>
        /// If set to <code>true</code>, container auto-scrolls while dragging.
        /// </summary>
        public bool Scroll {
            get; set;
        }

        /// <summary>
        /// Distance in pixels from the edge of the viewport after which the viewport should scroll. Distance is relative to pointer, not the draggable. Ignored if the <a href="#option-scroll"><code>scroll</code></a> option is <code>false</code>.
        /// </summary>
        public int ScrollSensitivity {
            get; set;
        }

        /// <summary>
        /// The speed at which the window should scroll once the mouse pointer gets within the <a href="#option-scrollSensitivity"><code>scrollSensitivity</code></a> distance. Ignored if the <a href="#option-scroll"><code>scroll</code></a> option is <code>false</code>.
        /// </summary>
        public int ScrollSpeed {
            get; set;
        }

        /// <summary>
        /// Whether the element should snap to other elements.
        /// </summary>
        public TypeOption<bool, string> Snap {
            get; set;
        }

        /// <summary>
        /// Determines which edges of snap elements the draggable will snap to. Ignored if the <a href="#option-snap"><code>snap</code></a> option is <code>false</code>. Possible values: <code>"inner"</code>, <code>"outer"</code>, <code>"both"</code>.
        /// </summary>
        public string SnapMode {
            get; set;
        }

        /// <summary>
        /// The distance in pixels from the snap element edges at which snapping should occur. Ignored if the <a href="#option-snap"><code>snap</code></a> option is <code>false</code>.
        /// </summary>
        public int SnapTolerance {
            get; set;
        }

        /// <summary>
        /// Controls the z-index of the set of elements that match the selector, always brings the currently dragged item to the front. Very useful in things like window managers.
        /// </summary>
        public string Stack {
            get; set;
        }

        /// <summary>
        /// Z-index for the helper while being dragged.
        /// </summary>
        public int ZIndex {
            get; set;
        }

        /// <summary>
        /// Triggered when the draggable is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// Triggered while the mouse is moved during the dragging.
        /// </summary>
        [ScriptName("drag")]
        public jQueryUIEventHandler<DraggableDragEvent> OnDrag {
             get; set;
        }

        /// <summary>
        /// Triggered when dragging starts.
        /// </summary>
        [ScriptName("start")]
        public jQueryUIEventHandler<DraggableStartEvent> OnStart {
             get; set;
        }

        /// <summary>
        /// Triggered when dragging stops.
        /// </summary>
        [ScriptName("stop")]
        public jQueryUIEventHandler<DraggableStopEvent> OnStop {
             get; set;
        }
    }
}
