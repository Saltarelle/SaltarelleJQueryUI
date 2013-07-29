using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Interactions {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class ResizableOptions {

        /// <summary>
        /// One or more elements to resize synchronously with the resizable element.
        /// </summary>
        public TypeOption<Element, jQueryObject, string> AlsoResize {
            get; set;
        }

        /// <summary>
        /// Animates to the final size after resizing.
        /// </summary>
        public bool Animate {
            get; set;
        }

        /// <summary>
        /// How long to animate when using the <a href="#option-animate"><code>animate</code></a> option.
        /// </summary>
        public TypeOption<int, string> AnimateDuration {
            get; set;
        }

        /// <summary>
        /// Which <a href="/easings/">easing</a> to apply when using the <a href="#option-animate"><code>animate</code></a> option.
        /// </summary>
        public string AnimateEasing {
            get; set;
        }

        /// <summary>
        /// Whether the element should be constrained to a specific aspect ratio.
        /// </summary>
        public TypeOption<bool, int> AspectRatio {
            get; set;
        }

        /// <summary>
        /// Whether the handles should hide when the user is not hovering over the element.
        /// </summary>
        public bool AutoHide {
            get; set;
        }

        /// <summary>
        /// Prevents resizing from starting on specified elements.
        /// </summary>
        public string Cancel {
            get; set;
        }

        /// <summary>
        /// Constrains resizing to within the bounds of the specified element or region.
        /// </summary>
        public TypeOption<Element, string> Containment {
            get; set;
        }

        /// <summary>
        /// Tolerance, in milliseconds, for when resizing should start. If specified, resizing will not start until after mouse is moved beyond duration. This can help prevent unintended resizing when clicking on an element.
        /// </summary>
        public int Delay {
            get; set;
        }

        /// <summary>
        /// Disables the resizable if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// Tolerance, in pixels, for when resizing should start. If specified, resizing will not start until after mouse is moved beyond distance. This can help prevent unintended resizing when clicking on an element.
        /// </summary>
        public int Distance {
            get; set;
        }

        /// <summary>
        /// If set to <code>true</code>, a semi-transparent helper element is shown for resizing.
        /// </summary>
        public bool Ghost {
            get; set;
        }

        /// <summary>
        /// Snaps the resizing element to a grid, every x and y pixels. Array values: <code>[ x, y ]</code>.
        /// </summary>
        public Array Grid {
            get; set;
        }

        /// <summary>
        /// Which handles can be used for resizing.
        /// </summary>
        public TypeOption<object, string> Handles {
            get; set;
        }

        /// <summary>
        /// A class name that will be added to a proxy element to outline the resize during the drag of the resize handle. Once the resize is complete, the original element is sized.
        /// </summary>
        public string Helper {
            get; set;
        }

        /// <summary>
        /// The maximum height the resizable should be allowed to resize to.
        /// </summary>
        public int MaxHeight {
            get; set;
        }

        /// <summary>
        /// The maximum width the resizable should be allowed to resize to.
        /// </summary>
        public int MaxWidth {
            get; set;
        }

        /// <summary>
        /// The minimum height the resizable should be allowed to resize to.
        /// </summary>
        public int MinHeight {
            get; set;
        }

        /// <summary>
        /// The minimum width the resizable should be allowed to resize to.
        /// </summary>
        public int MinWidth {
            get; set;
        }

        /// <summary>
        /// Triggered when the resizable is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// This event is triggered during the resize, on the drag of the resize handler.
        /// </summary>
        [ScriptName("resize")]
        public jQueryUIEventHandler<ResizableResizeEvent> OnResize {
             get; set;
        }

        /// <summary>
        /// This event is triggered at the start of a resize operation.
        /// </summary>
        [ScriptName("start")]
        public jQueryUIEventHandler<ResizableStartEvent> OnStart {
             get; set;
        }

        /// <summary>
        /// This event is triggered at the end of a resize operation.
        /// </summary>
        [ScriptName("stop")]
        public jQueryUIEventHandler<ResizableStopEvent> OnStop {
             get; set;
        }
    }
}
