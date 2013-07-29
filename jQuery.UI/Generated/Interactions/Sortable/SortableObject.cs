using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    /// <summary>
    /// Reorder elements in a list or grid using the mouse.
    /// </summary>
    /// <remarks>
    /// <para>The jQuery UI Sortable plugin makes selected elements sortable by dragging with the mouse.</para><para><em>Note: In order to sort table rows, the <code>tbody</code> must be made sortable, not the <code>table</code>.</em></para><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/mouse/">Mouse Interaction</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class SortableObject {

        private SortableObject() {
        }

        /// <summary>
        /// Cancels a change in the current sortable and reverts it to the state prior to when the current sort was started. Useful in the stop and receive callback functions.
        /// </summary>
        [InlineCode("{this}.sortable('cancel')")]
        public void Cancel() {
        }


        /// <summary>
        /// Removes the sortable functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.sortable('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the sortable.
        /// </summary>
        [InlineCode("{this}.sortable('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the sortable.
        /// </summary>
        [InlineCode("{this}.sortable('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.sortable('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current sortable options hash.
        /// </summary>
        [InlineCode("{this}.sortable('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the sortable option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.sortable('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the sortable.
        /// </summary>
        [InlineCode("{this}.sortable('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Refresh the sortable items. Triggers the reloading of all sortable items, causing new items to be recognized.
        /// </summary>
        [InlineCode("{this}.sortable('refresh')")]
        public void Refresh() {
        }


        /// <summary>
        /// Refresh the cached positions of the sortable items. Calling this method refreshes the cached item positions of all sortables.
        /// </summary>
        [InlineCode("{this}.sortable('refreshPositions')")]
        public void RefreshPositions() {
        }


        /// <summary>
        /// <para>Serializes the sortable's item <code>id</code>s into a form/ajax submittable string. Calling this method produces a hash that can be appended to any url to easily submit a new item order back to the server.</para><para>It works by default by looking at the <code>id</code> of each item in the format <code>"setname_number"</code>, and it spits out a hash like <code>"setname[]=number&amp;setname[]=number"</code>.</para><para><em>Note: If serialize returns an empty string, make sure the <code>id</code> attributes include an underscore.  They must be in the form: <code>"set_number"</code> For example, a 3 element list with <code>id</code> attributes <code>"foo_1"</code>, <code>"foo_5"</code>, <code>"foo_2"</code> will serialize to <code>"foo[]=1&amp;foo[]=5&amp;foo[]=2"</code>. You can use an underscore, equal sign or hyphen to separate the set and number. For example <code>"foo=1"</code>, <code>"foo-1"</code>, and <code>"foo_1"</code> all serialize to <code>"foo[]=1"</code>.</em></para>
        /// </summary>
        [InlineCode("{this}.sortable('serialize', {options})")]
        public string Serialize(object options) {
                return null;
        }


        /// <summary>
        /// Serializes the sortable's item id's into an array of string.
        /// </summary>
        [InlineCode("{this}.sortable('toArray', {options})")]
        public Array ToArray(object options) {
                return null;
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the sortable.
        /// </summary>
        [InlineCode("{this}.sortable('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Defines where the helper that moves with the mouse is being appended to during the drag (for example, to resolve overlap/zIndex issues).
        /// </summary>
        public TypeOption<Element, jQueryObject, string> AppendTo {
            [InlineCode("{this}.sortable('option', 'appendTo')")]
            get;
            [InlineCode("{this}.sortable('option', 'appendTo', {value})")]
            set;
        }


        /// <summary>
        /// If defined, the items can be dragged only horizontally or vertically. Possible values: <code>"x"</code>, <code>"y"</code>.
        /// </summary>
        public string Axis {
            [InlineCode("{this}.sortable('option', 'axis')")]
            get;
            [InlineCode("{this}.sortable('option', 'axis', {value})")]
            set;
        }


        /// <summary>
        /// Prevents sorting if you start on elements matching the selector.
        /// </summary>
        public string OptionCancel {
            [InlineCode("{this}.sortable('option', 'cancel')")]
            get;
            [InlineCode("{this}.sortable('option', 'cancel', {value})")]
            set;
        }


        /// <summary>
        /// A selector of other sortable elements that the items from this list should be connected to. This is a one-way relationship, if you want the items to be connected in both directions, the <code>connectWith</code> option must be set on both sortable elements.
        /// </summary>
        public string ConnectWith {
            [InlineCode("{this}.sortable('option', 'connectWith')")]
            get;
            [InlineCode("{this}.sortable('option', 'connectWith', {value})")]
            set;
        }


        /// <summary>
        /// <para>Defines a bounding box that the sortable items are contrained to while dragging.</para><para>Note: The element specified for containment must have a calculated width and height (though it need not be explicit). For example, if you have <code>float: left</code> sortable children and specify <code>containment: "parent"</code> be sure to have <code>float: left</code> on the sortable/parent container as well or it will have <code>height: 0</code>, causing undefined behavior.</para>
        /// </summary>
        public TypeOption<Element, string> Containment {
            [InlineCode("{this}.sortable('option', 'containment')")]
            get;
            [InlineCode("{this}.sortable('option', 'containment', {value})")]
            set;
        }


        /// <summary>
        /// Defines the cursor that is being shown while sorting.
        /// </summary>
        public string Cursor {
            [InlineCode("{this}.sortable('option', 'cursor')")]
            get;
            [InlineCode("{this}.sortable('option', 'cursor', {value})")]
            set;
        }


        /// <summary>
        /// Moves the sorting element or helper so the cursor always appears to drag from the same position. Coordinates can be given as a hash using a combination of one or two keys: <code>{ top, left, right, bottom }</code>.
        /// </summary>
        public Box CursorAt {
            [InlineCode("{this}.sortable('option', 'cursorAt')")]
            get;
            [InlineCode("{this}.sortable('option', 'cursorAt', {value})")]
            set;
        }


        /// <summary>
        /// Time in milliseconds to define when the sorting should start. Adding a delay helps preventing unwanted drags when clicking on an element.
        /// </summary>
        public int Delay {
            [InlineCode("{this}.sortable('option', 'delay')")]
            get;
            [InlineCode("{this}.sortable('option', 'delay', {value})")]
            set;
        }


        /// <summary>
        /// Disables the sortable if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.sortable('option', 'disabled')")]
            get;
            [InlineCode("{this}.sortable('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// Tolerance, in pixels, for when sorting should start. If specified, sorting will not start until after mouse is dragged beyond distance. Can be used to allow for clicks on elements within a handle.
        /// </summary>
        public int Distance {
            [InlineCode("{this}.sortable('option', 'distance')")]
            get;
            [InlineCode("{this}.sortable('option', 'distance', {value})")]
            set;
        }


        /// <summary>
        /// If <code>false</code>, items from this sortable can't be dropped on an empty connect sortable (see the <a href="#option-connectWith"><code>connectWith</code></a> option.
        /// </summary>
        public bool DropOnEmpty {
            [InlineCode("{this}.sortable('option', 'dropOnEmpty')")]
            get;
            [InlineCode("{this}.sortable('option', 'dropOnEmpty', {value})")]
            set;
        }


        /// <summary>
        /// If <code>true</code>, forces the helper to have a size.
        /// </summary>
        public bool ForceHelperSize {
            [InlineCode("{this}.sortable('option', 'forceHelperSize')")]
            get;
            [InlineCode("{this}.sortable('option', 'forceHelperSize', {value})")]
            set;
        }


        /// <summary>
        /// If true, forces the placeholder to have a size.
        /// </summary>
        public bool ForcePlaceholderSize {
            [InlineCode("{this}.sortable('option', 'forcePlaceholderSize')")]
            get;
            [InlineCode("{this}.sortable('option', 'forcePlaceholderSize', {value})")]
            set;
        }


        /// <summary>
        /// Snaps the sorting element or helper to a grid, every x and y pixels. Array values: <code>[ x, y ]</code>.
        /// </summary>
        public Array Grid {
            [InlineCode("{this}.sortable('option', 'grid')")]
            get;
            [InlineCode("{this}.sortable('option', 'grid', {value})")]
            set;
        }


        /// <summary>
        /// Restricts sort start click to the specified element.
        /// </summary>
        public TypeOption<Element, string> Handle {
            [InlineCode("{this}.sortable('option', 'handle')")]
            get;
            [InlineCode("{this}.sortable('option', 'handle', {value})")]
            set;
        }


        /// <summary>
        /// Allows for a helper element to be used for dragging display.
        /// </summary>
        public TypeOption<Delegate, string> Helper {
            [InlineCode("{this}.sortable('option', 'helper')")]
            get;
            [InlineCode("{this}.sortable('option', 'helper', {value})")]
            set;
        }


        /// <summary>
        /// Specifies which items inside the element should be sortable.
        /// </summary>
        public string Items {
            [InlineCode("{this}.sortable('option', 'items')")]
            get;
            [InlineCode("{this}.sortable('option', 'items', {value})")]
            set;
        }


        /// <summary>
        /// Defines the opacity of the helper while sorting. From <code>0.01</code> to <code>1</code>.
        /// </summary>
        public int Opacity {
            [InlineCode("{this}.sortable('option', 'opacity')")]
            get;
            [InlineCode("{this}.sortable('option', 'opacity', {value})")]
            set;
        }


        /// <summary>
        /// A class name that gets applied to the otherwise white space.
        /// </summary>
        public string Placeholder {
            [InlineCode("{this}.sortable('option', 'placeholder')")]
            get;
            [InlineCode("{this}.sortable('option', 'placeholder', {value})")]
            set;
        }


        /// <summary>
        /// Whether the sortable items should revert to their new positions using a smooth animation.
        /// </summary>
        public TypeOption<bool, int> Revert {
            [InlineCode("{this}.sortable('option', 'revert')")]
            get;
            [InlineCode("{this}.sortable('option', 'revert', {value})")]
            set;
        }


        /// <summary>
        /// If set to true, the page scrolls when coming to an edge.
        /// </summary>
        public bool Scroll {
            [InlineCode("{this}.sortable('option', 'scroll')")]
            get;
            [InlineCode("{this}.sortable('option', 'scroll', {value})")]
            set;
        }


        /// <summary>
        /// Defines how near the mouse must be to an edge to start scrolling.
        /// </summary>
        public int ScrollSensitivity {
            [InlineCode("{this}.sortable('option', 'scrollSensitivity')")]
            get;
            [InlineCode("{this}.sortable('option', 'scrollSensitivity', {value})")]
            set;
        }


        /// <summary>
        /// The speed at which the window should scroll once the mouse pointer gets within the <a href="#option-scrollSensitivity"><code>scrollSensitivity</code></a> distance.
        /// </summary>
        public int ScrollSpeed {
            [InlineCode("{this}.sortable('option', 'scrollSpeed')")]
            get;
            [InlineCode("{this}.sortable('option', 'scrollSpeed', {value})")]
            set;
        }


        /// <summary>
        /// Specifies which mode to use for testing whether the item being moved is hovering over another item. Possible values:<ul><li><code>"intersect"</code>: The item overlaps the other item by at least 50%.</li><li><code>"pointer"</code>: The mouse pointer overlaps the other item.</li></ul>
        /// </summary>
        public string Tolerance {
            [InlineCode("{this}.sortable('option', 'tolerance')")]
            get;
            [InlineCode("{this}.sortable('option', 'tolerance', {value})")]
            set;
        }


        /// <summary>
        /// Z-index for element/helper while being sorted.
        /// </summary>
        public int ZIndex {
            [InlineCode("{this}.sortable('option', 'zIndex')")]
            get;
            [InlineCode("{this}.sortable('option', 'zIndex', {value})")]
            set;
        }


        /// <summary>
        /// This event is triggered when using connected lists, every connected list on drag start receives it.
        /// </summary>
        public event jQueryUIEventHandler<SortableActivateEvent> OnActivate {
            [InlineCode("{this}.bind('sortactivate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortactivate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered when sorting stops, but when the placeholder/helper is still available.
        /// </summary>
        public event jQueryUIEventHandler<SortableBeforeStopEvent> OnBeforeStop {
            [InlineCode("{this}.bind('sortbeforestop', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortbeforestop', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered during sorting, but only when the DOM position has changed.
        /// </summary>
        public event jQueryUIEventHandler<SortableChangeEvent> OnChange {
            [InlineCode("{this}.bind('sortchange', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortchange', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the sortable is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('sortcreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortcreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered when sorting was stopped, is propagated to all possible connected lists.
        /// </summary>
        public event jQueryUIEventHandler<SortableDeactivateEvent> OnDeactivate {
            [InlineCode("{this}.bind('sortdeactivate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortdeactivate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered when a sortable item is moved away from a connected list.
        /// </summary>
        public event jQueryUIEventHandler<SortableOutEvent> OnOut {
            [InlineCode("{this}.bind('sortout', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortout', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered when a sortable item is moved into a connected list.
        /// </summary>
        public event jQueryUIEventHandler<SortableOverEvent> OnOver {
            [InlineCode("{this}.bind('sortover', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortover', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered when a connected sortable list has received an item from another list.
        /// </summary>
        public event jQueryUIEventHandler<SortableReceiveEvent> OnReceive {
            [InlineCode("{this}.bind('sortreceive', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortreceive', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered when a sortable item has been dragged out from the list and into another.
        /// </summary>
        public event jQueryUIEventHandler<SortableRemoveEvent> OnRemove {
            [InlineCode("{this}.bind('sortremove', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortremove', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered during sorting.
        /// </summary>
        public event jQueryUIEventHandler<SortableSortEvent> OnSort {
            [InlineCode("{this}.bind('sortsort', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortsort', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered when sorting starts.
        /// </summary>
        public event jQueryUIEventHandler<SortableStartEvent> OnStart {
            [InlineCode("{this}.bind('sortstart', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortstart', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered when sorting has stopped.
        /// </summary>
        public event jQueryUIEventHandler<SortableStopEvent> OnStop {
            [InlineCode("{this}.bind('sortstop', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortstop', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered when the user stopped sorting and the DOM position has changed.
        /// </summary>
        public event jQueryUIEventHandler<SortableUpdateEvent> OnUpdate {
            [InlineCode("{this}.bind('sortupdate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('sortupdate', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(SortableObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator SortableObject(jQueryObject o) {
            return null;
        }
    }
}
