using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    /// <summary>
    /// Change the size of an element using the mouse.
    /// </summary>
    /// <remarks>
    /// <para>The jQuery UI Resizable plugin makes selected elements resizable (meaning they have draggable resize handles). You can specify one or more handles as well as min and max width and height.</para><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/mouse/">Mouse Interaction</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class ResizableObject {

        private ResizableObject() {
        }

        /// <summary>
        /// Removes the resizable functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.resizable('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the resizable.
        /// </summary>
        [InlineCode("{this}.resizable('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the resizable.
        /// </summary>
        [InlineCode("{this}.resizable('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.resizable('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current resizable options hash.
        /// </summary>
        [InlineCode("{this}.resizable('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the resizable option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.resizable('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the resizable.
        /// </summary>
        [InlineCode("{this}.resizable('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the resizable.
        /// </summary>
        [InlineCode("{this}.resizable('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// One or more elements to resize synchronously with the resizable element.
        /// </summary>
        public TypeOption<Element, jQueryObject, string> AlsoResize {
            [InlineCode("{this}.resizable('option', 'alsoResize')")]
            get;
            [InlineCode("{this}.resizable('option', 'alsoResize', {value})")]
            set;
        }


        /// <summary>
        /// Animates to the final size after resizing.
        /// </summary>
        public bool Animate {
            [InlineCode("{this}.resizable('option', 'animate')")]
            get;
            [InlineCode("{this}.resizable('option', 'animate', {value})")]
            set;
        }


        /// <summary>
        /// How long to animate when using the <a href="#option-animate"><code>animate</code></a> option.
        /// </summary>
        public TypeOption<int, string> AnimateDuration {
            [InlineCode("{this}.resizable('option', 'animateDuration')")]
            get;
            [InlineCode("{this}.resizable('option', 'animateDuration', {value})")]
            set;
        }


        /// <summary>
        /// Which <a href="/easings/">easing</a> to apply when using the <a href="#option-animate"><code>animate</code></a> option.
        /// </summary>
        public string AnimateEasing {
            [InlineCode("{this}.resizable('option', 'animateEasing')")]
            get;
            [InlineCode("{this}.resizable('option', 'animateEasing', {value})")]
            set;
        }


        /// <summary>
        /// Whether the element should be constrained to a specific aspect ratio.
        /// </summary>
        public TypeOption<bool, int> AspectRatio {
            [InlineCode("{this}.resizable('option', 'aspectRatio')")]
            get;
            [InlineCode("{this}.resizable('option', 'aspectRatio', {value})")]
            set;
        }


        /// <summary>
        /// Whether the handles should hide when the user is not hovering over the element.
        /// </summary>
        public bool AutoHide {
            [InlineCode("{this}.resizable('option', 'autoHide')")]
            get;
            [InlineCode("{this}.resizable('option', 'autoHide', {value})")]
            set;
        }


        /// <summary>
        /// Prevents resizing from starting on specified elements.
        /// </summary>
        public string Cancel {
            [InlineCode("{this}.resizable('option', 'cancel')")]
            get;
            [InlineCode("{this}.resizable('option', 'cancel', {value})")]
            set;
        }


        /// <summary>
        /// Constrains resizing to within the bounds of the specified element or region.
        /// </summary>
        public TypeOption<Element, string> Containment {
            [InlineCode("{this}.resizable('option', 'containment')")]
            get;
            [InlineCode("{this}.resizable('option', 'containment', {value})")]
            set;
        }


        /// <summary>
        /// Tolerance, in milliseconds, for when resizing should start. If specified, resizing will not start until after mouse is moved beyond duration. This can help prevent unintended resizing when clicking on an element.
        /// </summary>
        public int Delay {
            [InlineCode("{this}.resizable('option', 'delay')")]
            get;
            [InlineCode("{this}.resizable('option', 'delay', {value})")]
            set;
        }


        /// <summary>
        /// Disables the resizable if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.resizable('option', 'disabled')")]
            get;
            [InlineCode("{this}.resizable('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// Tolerance, in pixels, for when resizing should start. If specified, resizing will not start until after mouse is moved beyond distance. This can help prevent unintended resizing when clicking on an element.
        /// </summary>
        public int Distance {
            [InlineCode("{this}.resizable('option', 'distance')")]
            get;
            [InlineCode("{this}.resizable('option', 'distance', {value})")]
            set;
        }


        /// <summary>
        /// If set to <code>true</code>, a semi-transparent helper element is shown for resizing.
        /// </summary>
        public bool Ghost {
            [InlineCode("{this}.resizable('option', 'ghost')")]
            get;
            [InlineCode("{this}.resizable('option', 'ghost', {value})")]
            set;
        }


        /// <summary>
        /// Snaps the resizing element to a grid, every x and y pixels. Array values: <code>[ x, y ]</code>.
        /// </summary>
        public Array Grid {
            [InlineCode("{this}.resizable('option', 'grid')")]
            get;
            [InlineCode("{this}.resizable('option', 'grid', {value})")]
            set;
        }


        /// <summary>
        /// Which handles can be used for resizing.
        /// </summary>
        public TypeOption<object, string> Handles {
            [InlineCode("{this}.resizable('option', 'handles')")]
            get;
            [InlineCode("{this}.resizable('option', 'handles', {value})")]
            set;
        }


        /// <summary>
        /// A class name that will be added to a proxy element to outline the resize during the drag of the resize handle. Once the resize is complete, the original element is sized.
        /// </summary>
        public string Helper {
            [InlineCode("{this}.resizable('option', 'helper')")]
            get;
            [InlineCode("{this}.resizable('option', 'helper', {value})")]
            set;
        }


        /// <summary>
        /// The maximum height the resizable should be allowed to resize to.
        /// </summary>
        public int MaxHeight {
            [InlineCode("{this}.resizable('option', 'maxHeight')")]
            get;
            [InlineCode("{this}.resizable('option', 'maxHeight', {value})")]
            set;
        }


        /// <summary>
        /// The maximum width the resizable should be allowed to resize to.
        /// </summary>
        public int MaxWidth {
            [InlineCode("{this}.resizable('option', 'maxWidth')")]
            get;
            [InlineCode("{this}.resizable('option', 'maxWidth', {value})")]
            set;
        }


        /// <summary>
        /// The minimum height the resizable should be allowed to resize to.
        /// </summary>
        public int MinHeight {
            [InlineCode("{this}.resizable('option', 'minHeight')")]
            get;
            [InlineCode("{this}.resizable('option', 'minHeight', {value})")]
            set;
        }


        /// <summary>
        /// The minimum width the resizable should be allowed to resize to.
        /// </summary>
        public int MinWidth {
            [InlineCode("{this}.resizable('option', 'minWidth')")]
            get;
            [InlineCode("{this}.resizable('option', 'minWidth', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when the resizable is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('resizecreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('resizecreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered during the resize, on the drag of the resize handler.
        /// </summary>
        public event jQueryUIEventHandler<ResizableResizeEvent> OnResize {
            [InlineCode("{this}.bind('resizeresize', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('resizeresize', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered at the start of a resize operation.
        /// </summary>
        public event jQueryUIEventHandler<ResizableStartEvent> OnStart {
            [InlineCode("{this}.bind('resizestart', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('resizestart', {value})")]
            remove {
            }
        }


        /// <summary>
        /// This event is triggered at the end of a resize operation.
        /// </summary>
        public event jQueryUIEventHandler<ResizableStopEvent> OnStop {
            [InlineCode("{this}.bind('resizestop', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('resizestop', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(ResizableObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator ResizableObject(jQueryObject o) {
            return null;
        }
    }
}
