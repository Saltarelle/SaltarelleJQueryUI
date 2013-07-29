using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI {

    /// <summary>
    /// The base interaction layer.
    /// </summary>
    /// <remarks>
    /// <para>Similar to <a href="/jQuery.Widget#jQuery-Widget2"><code>jQuery.Widget</code></a>, the mouse interaction is not intended to be used directly. It is purely a base layer for other widgets to inherit from. This page only documents what is added to <code>jQuery.Widget</code>, but it does include internal methods that are not intended to be overwritten. The intended public API is <a href="#method-_mouseStart"><code>_mouseStart()</code></a>, <a href="#method-_mouseDrag"><code>_mouseDrag()</code></a>, <a href="#method-_mouseStop"><code>_mouseStop()</code></a>, and <a href="#method-_mouseCapture"><code>_mouseCapture()</code></a>.</para><h3>Dependencies</h3><ul><li><a href="/jQuery.widget/">Widget Factory</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class MouseObject {

        private MouseObject() {
        }

        /// <summary>
        /// Determines whether an interaction should start based on event target of the interaction. The default implementation always returns <code>true</code>.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseCapture')")]
        public bool MouseCapture() {
                return false;
        }


        /// <summary>
        /// Determines whether the <a href="#option-delay"><code>delay</code></a> option has been met for the current interaction.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseDelayMet')")]
        public bool MouseDelayMet() {
                return false;
        }


        /// <summary>
        /// Destroys the interaction event handlers. This must be called from the extending widget's <code>_destroy()</code> method.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseDestroy')")]
        public void MouseDestroy() {
        }


        /// <summary>
        /// Determines whether the <a href="#option-distance"><code>distance</code></a> option has been met for the current interaction.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseDistanceMet')")]
        public bool MouseDistanceMet() {
                return false;
        }


        /// <summary>
        /// Handles the beginning of an interaction. Verifies that the event is associated with the primary mouse button and ensures that the <a href="#option-delay"><code>delay</code></a> and <a href="#option-distance"><code>distance</code></a> options are met prior to starting the interaction. When the interaction is ready to start, invokes the <a href="#method-_mouseStart"><code>_mouseStart()</code></a> method for the extending widget to handle.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseDown')")]
        public void MouseDown() {
        }


        /// <summary>
        /// The extending widget should implement a <code>_mouseDrag()</code> method to handle each movement of an interaction. This method will receive the mouse event associated with the movement.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseDrag')")]
        public void MouseDrag() {
        }


        /// <summary>
        /// Initializes the interaction event handlers. This must be called from the extending widget's <code>_create()</code> method.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseInit')")]
        public void MouseInit() {
        }


        /// <summary>
        /// Handles each movement of the interaction. Invokes the <a href="#method-_mouseDrag"><code>mouseDrag()</code></a> method for the extending widget to handle.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseMove')")]
        public void MouseMove() {
        }


        /// <summary>
        /// The extending widget should implement a <code>_mouseStart()</code> method to handle the beginning of an interaction. This method will receive the mouse event associated with the start of the interaction.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseStart')")]
        public void MouseStart() {
        }


        /// <summary>
        /// The extending widget should implement a <code>_mouseStop()</code> method to handle the end of an interaction. This method will receive the mouse event associated with the end of the interaction.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseStop')")]
        public void MouseStop() {
        }


        /// <summary>
        /// Handles the end of the interaction. Invokes the <a href="#method-_mouseStop"><code>mouseStop()</code></a> method for the extending widget to handle.
        /// </summary>
        [InlineCode("{this}.mouse('_mouseUp')")]
        public void MouseUp() {
        }


        /// <summary>
        /// Prevents interactions from starting on specified elements.
        /// </summary>
        public string Cancel {
            [InlineCode("{this}.mouse('option', 'cancel')")]
            get;
            [InlineCode("{this}.mouse('option', 'cancel', {value})")]
            set;
        }


        /// <summary>
        /// Time in milliseconds after mousedown until the interaction should start. This option can be used to prevent unwanted interactions when clicking on an element.
        /// </summary>
        public int Delay {
            [InlineCode("{this}.mouse('option', 'delay')")]
            get;
            [InlineCode("{this}.mouse('option', 'delay', {value})")]
            set;
        }


        /// <summary>
        /// Distance in pixels after mousedown the mouse must move before the interaction should start. This option can be used to prevent unwanted interactions when clicking on an element.
        /// </summary>
        public int Distance {
            [InlineCode("{this}.mouse('option', 'distance')")]
            get;
            [InlineCode("{this}.mouse('option', 'distance', {value})")]
            set;
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(MouseObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator MouseObject(jQueryObject o) {
            return null;
        }
    }
}
