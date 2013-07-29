using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class SelectableOptions {

        /// <summary>
        /// Which element the selection helper (the lasso) should be appended to.
        /// </summary>
        public string AppendTo {
            get; set;
        }

        /// <summary>
        /// This determines whether to refresh (recalculate) the position and size of each selectee at the beginning of each select operation. If you have many items, you may want to set this to false and call the <a href="#method-refresh"><code>refresh()</code></a> method manually.
        /// </summary>
        public bool AutoRefresh {
            get; set;
        }

        /// <summary>
        /// Prevents selecting if you start on elements matching the selector.
        /// </summary>
        public string Cancel {
            get; set;
        }

        /// <summary>
        /// Time in milliseconds to define when the selecting should start. This helps prevent unwanted selections when clicking on an element.
        /// </summary>
        public int Delay {
            get; set;
        }

        /// <summary>
        /// Disables the selectable if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// Tolerance, in pixels, for when selecting should start. If specified, selecting will not start until the mouse has been dragged beyond the specified distance.
        /// </summary>
        public int Distance {
            get; set;
        }

        /// <summary>
        /// The matching child elements will be made selectees (able to be selected).
        /// </summary>
        public string Filter {
            get; set;
        }

        /// <summary>
        /// Specifies which mode to use for testing whether the lasso should select an item. Possible values:<ul><li><code>"fit"</code>: Lasso overlaps the item entirely.</li><li><code>"touch"</code>: Lasso overlaps the item by any amount.</li></ul>
        /// </summary>
        public string Tolerance {
            get; set;
        }

        /// <summary>
        /// Triggered when the selectable is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// Triggered at the end of the select operation, on each element added to the selection.
        /// </summary>
        [ScriptName("selected")]
        public jQueryUIEventHandler<SelectableSelectedEvent> OnSelected {
             get; set;
        }

        /// <summary>
        /// Triggered during the select operation, on each element added to the selection.
        /// </summary>
        [ScriptName("selecting")]
        public jQueryUIEventHandler<SelectableSelectingEvent> OnSelecting {
             get; set;
        }

        /// <summary>
        /// Triggered at the beginning of the select operation.
        /// </summary>
        [ScriptName("start")]
        public jQueryUIEventHandler<object> OnStart {
             get; set;
        }

        /// <summary>
        /// Triggered at the end of the select operation.
        /// </summary>
        [ScriptName("stop")]
        public jQueryUIEventHandler<object> OnStop {
             get; set;
        }

        /// <summary>
        /// Triggered at the end of the select operation, on each element removed from the selection.
        /// </summary>
        [ScriptName("unselected")]
        public jQueryUIEventHandler<SelectableUnselectedEvent> OnUnselected {
             get; set;
        }

        /// <summary>
        /// Triggered during the select operation, on each element removed from the selection.
        /// </summary>
        [ScriptName("unselecting")]
        public jQueryUIEventHandler<SelectableUnselectingEvent> OnUnselecting {
             get; set;
        }
    }
}
