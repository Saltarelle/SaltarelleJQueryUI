using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    /// <summary>
    /// Allow elements to be moved using the mouse.
    /// </summary>
    /// <remarks>
    /// <para>Make the selected elements draggable by mouse. If you want not just drag, but drag &amp; drop, see the <a href="/droppable/">jQuery UI Droppable plugin</a>, which provides a drop target for draggables.</para><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/mouse/">Mouse Interaction</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class DraggableObject {

        private DraggableObject() {
        }

        /// <summary>
        /// Removes the draggable functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.draggable('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the draggable.
        /// </summary>
        [InlineCode("{this}.draggable('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the draggable.
        /// </summary>
        [InlineCode("{this}.draggable('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.draggable('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current draggable options hash.
        /// </summary>
        [InlineCode("{this}.draggable('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the draggable option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.draggable('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the draggable.
        /// </summary>
        [InlineCode("{this}.draggable('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the draggable.
        /// </summary>
        [InlineCode("{this}.draggable('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// If set to <code>false</code>, will prevent the <code>ui-draggable</code> class from being added. This may be desired as a performance optimization when calling <code>.draggable()</code> on hundreds of elements.
        /// </summary>
        public bool AddClasses {
            [InlineCode("{this}.draggable('option', 'addClasses')")]
            get;
            [InlineCode("{this}.draggable('option', 'addClasses', {value})")]
            set;
        }


        /// <summary>
        /// Which element the draggable helper should be appended to while dragging.
        /// </summary>
        public TypeOption<Element, jQueryObject, string> AppendTo {
            [InlineCode("{this}.draggable('option', 'appendTo')")]
            get;
            [InlineCode("{this}.draggable('option', 'appendTo', {value})")]
            set;
        }


        /// <summary>
        /// Constrains dragging to either the horizontal (x) or vertical (y) axis. Possible values: <code>"x"</code>, <code>"y"</code>.
        /// </summary>
        public string Axis {
            [InlineCode("{this}.draggable('option', 'axis')")]
            get;
            [InlineCode("{this}.draggable('option', 'axis', {value})")]
            set;
        }


        /// <summary>
        /// Prevents dragging from starting on specified elements.
        /// </summary>
        public string Cancel {
            [InlineCode("{this}.draggable('option', 'cancel')")]
            get;
            [InlineCode("{this}.draggable('option', 'cancel', {value})")]
            set;
        }


        /// <summary>
        /// Allows the draggable to be dropped onto the specified sortables. If this option is used, a draggable can be dropped onto a sortable list and then becomes part of it. Note: The <a href="#option-helper"><code>helper</code></a> option must be set to <code>"clone"</code> in order to work flawlessly. Requires the <a href="/sortable/">jQuery UI Sortable plugin</a> to be included.
        /// </summary>
        public string ConnectToSortable {
            [InlineCode("{this}.draggable('option', 'connectToSortable')")]
            get;
            [InlineCode("{this}.draggable('option', 'connectToSortable', {value})")]
            set;
        }


        /// <summary>
        /// Constrains dragging to within the bounds of the specified element or region.
        /// </summary>
        public TypeOption<Array, Element, string> Containment {
            [InlineCode("{this}.draggable('option', 'containment')")]
            get;
            [InlineCode("{this}.draggable('option', 'containment', {value})")]
            set;
        }


        /// <summary>
        /// The CSS cursor during the drag operation.
        /// </summary>
        public string Cursor {
            [InlineCode("{this}.draggable('option', 'cursor')")]
            get;
            [InlineCode("{this}.draggable('option', 'cursor', {value})")]
            set;
        }


        /// <summary>
        /// Sets the offset of the dragging helper relative to the mouse cursor. Coordinates can be given as a hash using a combination of one or two keys: <code>{ top, left, right, bottom }</code>.
        /// </summary>
        public Box CursorAt {
            [InlineCode("{this}.draggable('option', 'cursorAt')")]
            get;
            [InlineCode("{this}.draggable('option', 'cursorAt', {value})")]
            set;
        }


        /// <summary>
        /// Time in milliseconds after mousedown until dragging should start. This option can be used to prevent unwanted drags when clicking on an element.
        /// </summary>
        public int Delay {
            [InlineCode("{this}.draggable('option', 'delay')")]
            get;
            [InlineCode("{this}.draggable('option', 'delay', {value})")]
            set;
        }


        /// <summary>
        /// Disables the draggable if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.draggable('option', 'disabled')")]
            get;
            [InlineCode("{this}.draggable('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// Distance in pixels after mousedown the mouse must move before dragging should start. This option can be used to prevent unwanted drags when clicking on an element.
        /// </summary>
        public int Distance {
            [InlineCode("{this}.draggable('option', 'distance')")]
            get;
            [InlineCode("{this}.draggable('option', 'distance', {value})")]
            set;
        }


        /// <summary>
        /// Snaps the dragging helper to a grid, every x and y pixels. The array must be of the form <code>[ x, y ]</code>.
        /// </summary>
        public Array Grid {
            [InlineCode("{this}.draggable('option', 'grid')")]
            get;
            [InlineCode("{this}.draggable('option', 'grid', {value})")]
            set;
        }


        /// <summary>
        /// If specified, restricts dragging from starting unless the mousedown occurs on the specified element(s). Only elements that descend from the draggable element are permitted.
        /// </summary>
        public TypeOption<Element, string> Handle {
            [InlineCode("{this}.draggable('option', 'handle')")]
            get;
            [InlineCode("{this}.draggable('option', 'handle', {value})")]
            set;
        }


        /// <summary>
        /// Allows for a helper element to be used for dragging display.
        /// </summary>
        public TypeOption<Delegate, string> Helper {
            [InlineCode("{this}.draggable('option', 'helper')")]
            get;
            [InlineCode("{this}.draggable('option', 'helper', {value})")]
            set;
        }


        /// <summary>
        /// Prevent iframes from capturing the mousemove events during a drag. Useful in combination with the <a href="#option-cursorAt"><code>cursorAt</code></a> option, or in any case where the mouse cursor may not be over the helper.
        /// </summary>
        public TypeOption<bool, string> IframeFix {
            [InlineCode("{this}.draggable('option', 'iframeFix')")]
            get;
            [InlineCode("{this}.draggable('option', 'iframeFix', {value})")]
            set;
        }


        /// <summary>
        /// Opacity for the helper while being dragged.
        /// </summary>
        public int Opacity {
            [InlineCode("{this}.draggable('option', 'opacity')")]
            get;
            [InlineCode("{this}.draggable('option', 'opacity', {value})")]
            set;
        }


        /// <summary>
        /// If set to <code>true</code>, all droppable positions are calculated on every mousemove.<em>Caution: This solves issues on highly dynamic pages, but dramatically decreases performance.</em>
        /// </summary>
        public bool RefreshPositions {
            [InlineCode("{this}.draggable('option', 'refreshPositions')")]
            get;
            [InlineCode("{this}.draggable('option', 'refreshPositions', {value})")]
            set;
        }


        /// <summary>
        /// Whether the element should revert to its start position when dragging stops.
        /// </summary>
        public TypeOption<bool, string> Revert {
            [InlineCode("{this}.draggable('option', 'revert')")]
            get;
            [InlineCode("{this}.draggable('option', 'revert', {value})")]
            set;
        }


        /// <summary>
        /// The duration of the revert animation, in milliseconds. Ignored if the <a href="#option-revert"><code>revert</code></a> option is <code>false</code>.
        /// </summary>
        public int RevertDuration {
            [InlineCode("{this}.draggable('option', 'revertDuration')")]
            get;
            [InlineCode("{this}.draggable('option', 'revertDuration', {value})")]
            set;
        }


        /// <summary>
        /// Used to group sets of draggable and droppable items, in addition to droppable's <a href="/droppable#option-accept"><code>accept</code></a> option. A draggable with the same <code>scope</code> value as a droppable will be accepted by the droppable.
        /// </summary>
        public string Scope {
            [InlineCode("{this}.draggable('option', 'scope')")]
            get;
            [InlineCode("{this}.draggable('option', 'scope', {value})")]
            set;
        }


        /// <summary>
        /// If set to <code>true</code>, container auto-scrolls while dragging.
        /// </summary>
        public bool Scroll {
            [InlineCode("{this}.draggable('option', 'scroll')")]
            get;
            [InlineCode("{this}.draggable('option', 'scroll', {value})")]
            set;
        }


        /// <summary>
        /// Distance in pixels from the edge of the viewport after which the viewport should scroll. Distance is relative to pointer, not the draggable. Ignored if the <a href="#option-scroll"><code>scroll</code></a> option is <code>false</code>.
        /// </summary>
        public int ScrollSensitivity {
            [InlineCode("{this}.draggable('option', 'scrollSensitivity')")]
            get;
            [InlineCode("{this}.draggable('option', 'scrollSensitivity', {value})")]
            set;
        }


        /// <summary>
        /// The speed at which the window should scroll once the mouse pointer gets within the <a href="#option-scrollSensitivity"><code>scrollSensitivity</code></a> distance. Ignored if the <a href="#option-scroll"><code>scroll</code></a> option is <code>false</code>.
        /// </summary>
        public int ScrollSpeed {
            [InlineCode("{this}.draggable('option', 'scrollSpeed')")]
            get;
            [InlineCode("{this}.draggable('option', 'scrollSpeed', {value})")]
            set;
        }


        /// <summary>
        /// Whether the element should snap to other elements.
        /// </summary>
        public TypeOption<bool, string> Snap {
            [InlineCode("{this}.draggable('option', 'snap')")]
            get;
            [InlineCode("{this}.draggable('option', 'snap', {value})")]
            set;
        }


        /// <summary>
        /// Determines which edges of snap elements the draggable will snap to. Ignored if the <a href="#option-snap"><code>snap</code></a> option is <code>false</code>. Possible values: <code>"inner"</code>, <code>"outer"</code>, <code>"both"</code>.
        /// </summary>
        public string SnapMode {
            [InlineCode("{this}.draggable('option', 'snapMode')")]
            get;
            [InlineCode("{this}.draggable('option', 'snapMode', {value})")]
            set;
        }


        /// <summary>
        /// The distance in pixels from the snap element edges at which snapping should occur. Ignored if the <a href="#option-snap"><code>snap</code></a> option is <code>false</code>.
        /// </summary>
        public int SnapTolerance {
            [InlineCode("{this}.draggable('option', 'snapTolerance')")]
            get;
            [InlineCode("{this}.draggable('option', 'snapTolerance', {value})")]
            set;
        }


        /// <summary>
        /// Controls the z-index of the set of elements that match the selector, always brings the currently dragged item to the front. Very useful in things like window managers.
        /// </summary>
        public string Stack {
            [InlineCode("{this}.draggable('option', 'stack')")]
            get;
            [InlineCode("{this}.draggable('option', 'stack', {value})")]
            set;
        }


        /// <summary>
        /// Z-index for the helper while being dragged.
        /// </summary>
        public int ZIndex {
            [InlineCode("{this}.draggable('option', 'zIndex')")]
            get;
            [InlineCode("{this}.draggable('option', 'zIndex', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when the draggable is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('dragcreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dragcreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered while the mouse is moved during the dragging.
        /// </summary>
        public event jQueryUIEventHandler<DraggableDragEvent> OnDrag {
            [InlineCode("{this}.bind('dragdrag', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dragdrag', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when dragging starts.
        /// </summary>
        public event jQueryUIEventHandler<DraggableStartEvent> OnStart {
            [InlineCode("{this}.bind('dragstart', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dragstart', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when dragging stops.
        /// </summary>
        public event jQueryUIEventHandler<DraggableStopEvent> OnStop {
            [InlineCode("{this}.bind('dragstop', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dragstop', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(DraggableObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator DraggableObject(jQueryObject o) {
            return null;
        }
    }
}
