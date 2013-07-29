using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class DialogOptions {

        /// <summary>
        /// <para>Which element the dialog (and overlay, if <a href="#option-modal">modal</a>) should be appended to.</para><div class="warning"><strong>Note:</strong> The <code>appendTo</code> option should not be changed while the dialog is open.</div>
        /// </summary>
        public string AppendTo {
            get; set;
        }

        /// <summary>
        /// If set to <code>true</code>, the dialog will automatically open upon initialization. If <code>false</code>, the dialog will stay hidden until the <a href="#method-open"><code>open()</code></a> method is called.
        /// </summary>
        public bool AutoOpen {
            get; set;
        }

        /// <summary>
        /// Specifies which buttons should be displayed on the dialog. The context of the callback is the dialog element; if you need access to the button, it is available as the target of the event object.
        /// </summary>
        public TypeOption<Array, object> Buttons {
            get; set;
        }

        /// <summary>
        /// Specifies whether the dialog should close when it has focus and the user presses the esacpe (ESC) key.
        /// </summary>
        public bool CloseOnEscape {
            get; set;
        }

        /// <summary>
        /// Specifies the text for the close button. Note that the close text is visibly hidden when using a standard theme.
        /// </summary>
        public string CloseText {
            get; set;
        }

        /// <summary>
        /// The specified class name(s) will be added to the dialog, for additional theming.
        /// </summary>
        public string DialogClass {
            get; set;
        }

        /// <summary>
        /// If set to <code>true</code>, the dialog will be draggable by the title bar. Requires the <a href="/draggable/">jQuery UI Draggable widget</a> to be included.
        /// </summary>
        public bool Draggable {
            get; set;
        }

        /// <summary>
        /// The height of the dialog.
        /// </summary>
        public TypeOption<int, string> Height {
            get; set;
        }

        /// <summary>
        /// If and how to animate the hiding of the dialog.
        /// </summary>
        public TypeOption<int, object, string> Hide {
            get; set;
        }

        /// <summary>
        /// The maximum height to which the dialog can be resized, in pixels.
        /// </summary>
        public int MaxHeight {
            get; set;
        }

        /// <summary>
        /// The maximum width to which the dialog can be resized, in pixels.
        /// </summary>
        public int MaxWidth {
            get; set;
        }

        /// <summary>
        /// The minimum height to which the dialog can be resized, in pixels.
        /// </summary>
        public int MinHeight {
            get; set;
        }

        /// <summary>
        /// The minimum width to which the dialog can be resized, in pixels.
        /// </summary>
        public int MinWidth {
            get; set;
        }

        /// <summary>
        /// If set to <code>true</code>, the dialog will have modal behavior; other items on the page will be disabled, i.e., cannot be interacted with. Modal dialogs create an overlay below the dialog but above other page elements.
        /// </summary>
        public bool Modal {
            get; set;
        }

        /// <summary>
        /// <para>Specifies where the dialog should be displayed. The dialog will handle collisions such that as much of the dialog is visible as possible.</para><para><em>Note: The <code>String</code> and <code>Array</code> forms are deprecated.</em></para>
        /// </summary>
        public TypeOption<Array, object, string> Position {
            get; set;
        }

        /// <summary>
        /// If set to <code>true</code>, the dialog will be resizable. Requires the <a href="/resizable/">jQuery UI Resizable widget</a> to be included.
        /// </summary>
        public bool Resizable {
            get; set;
        }

        /// <summary>
        /// If and how to animate the showing of the dialog.
        /// </summary>
        public TypeOption<int, object, string> Show {
            get; set;
        }

        /// <summary>
        /// Specifies the title of the dialog. If the value is <code>null</code>, the <code>title</code> attribute on the dialog source element will be used.
        /// </summary>
        public string Title {
            get; set;
        }

        /// <summary>
        /// The width of the dialog, in pixels.
        /// </summary>
        public int Width {
            get; set;
        }

        /// <summary>
        /// Triggered when a dialog is about to close. If canceled, the dialog will not close.
        /// </summary>
        [ScriptName("beforeClose")]
        public jQueryUIEventHandler<object> OnBeforeClose {
             get; set;
        }

        /// <summary>
        /// Triggered when the dialog is closed.
        /// </summary>
        [ScriptName("close")]
        public jQueryUIEventHandler<object> OnClose {
             get; set;
        }

        /// <summary>
        /// Triggered when the dialog is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// Triggered while the dialog is being dragged.
        /// </summary>
        [ScriptName("drag")]
        public jQueryUIEventHandler<DialogDragEvent> OnDrag {
             get; set;
        }

        /// <summary>
        /// Triggered when the user starts dragging the dialog.
        /// </summary>
        [ScriptName("dragStart")]
        public jQueryUIEventHandler<DialogDragStartEvent> OnDragStart {
             get; set;
        }

        /// <summary>
        /// Triggered after the dialog has been dragged.
        /// </summary>
        [ScriptName("dragStop")]
        public jQueryUIEventHandler<DialogDragStopEvent> OnDragStop {
             get; set;
        }

        /// <summary>
        /// Triggered when the dialog gains focus.
        /// </summary>
        [ScriptName("focus")]
        public jQueryUIEventHandler<object> OnFocus {
             get; set;
        }

        /// <summary>
        /// Triggered when the dialog is opened.
        /// </summary>
        [ScriptName("open")]
        public jQueryUIEventHandler<object> OnOpen {
             get; set;
        }

        /// <summary>
        /// Triggered while the dialog is being resized.
        /// </summary>
        [ScriptName("resize")]
        public jQueryUIEventHandler<DialogResizeEvent> OnResize {
             get; set;
        }

        /// <summary>
        /// Triggered when the user starts resizing the dialog.
        /// </summary>
        [ScriptName("resizeStart")]
        public jQueryUIEventHandler<DialogResizeStartEvent> OnResizeStart {
             get; set;
        }

        /// <summary>
        /// Triggered after the dialog has been resized.
        /// </summary>
        [ScriptName("resizeStop")]
        public jQueryUIEventHandler<DialogResizeStopEvent> OnResizeStop {
             get; set;
        }
    }
}
