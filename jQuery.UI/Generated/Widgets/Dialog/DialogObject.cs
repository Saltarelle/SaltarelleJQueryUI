using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Open content in an interactive overlay.
    /// </summary>
    /// <remarks>
    /// <para>A dialog is a floating window that contains a title bar and a content area. The dialog window can be moved, resized and closed with the 'x' icon by default.</para><para>If the content length exceeds the maximum height, a scrollbar will automatically appear.</para><para>A bottom button bar and semi-transparent modal overlay layer are common options that can be added.</para><h3>Focus</h3><para>Upon opening a dialog, focus is automatically moved to the first item that matches the following:</para><ol><li>The first element within the dialog with the <code>autofocus</code> attribute</li><li>The first <a href="/tabbable-selector/"><code>:tabbable</code></a> element within the dialog's content</li><li>The first <a href="/tabbable-selector/"><code>:tabbable</code></a> element within the dialog's buttonpane</li><li>The dialog's close button</li><li>The dialog itself</li></ol><para>While open, the dialog widget ensures that tabbing cycles focus between elements within the dialog itself, not elements outside of it. Modal dialogs additionally prevent mouse users from clicking on elements outside of the dialog.</para><para>Upon closing a dialog, focus is automatically returned to the element that had focus when the dialog was opened.</para><h3>Hiding the close button</h3><para>In some cases, you may want to hide the close button, for instance, if you have a close button in the button pane. The best way to accomplish this is via CSS. As an example, you can define a simple rule, such as:</para><c><code>.no-close .ui-dialog-titlebar-close {display: none;}</code></c><para>Then, you can simply add the <code>no-close</code> class to any dialog in order to hide its close button:</para><c><code>$( "#dialog" ).dialog({dialogClass: "no-close",buttons: [{text: "OK",click: function() {$( this ).dialog( "close" );}}]});</code></c><div><h3 id="theming">Theming</h3><para>The dialog widget uses the <a href="/theming/css-framework">jQuery UI CSS framework</a> to style its look and feel. If dialog specific styling is needed, the following CSS class names can be used:</para></div><ul><li><code>ui-dialog</code>: The outer container of the dialog.<ul><li><code>ui-dialog-titlebar</code>: The title bar containing the dialog's title and close button.<ul><li><code>ui-dialog-title</code>: The container around the textual title of the dialog.</li><li><code>ui-dialog-titlebar-close</code>: The dialog's close button.</li></ul></li><li><code>ui-dialog-content</code>: The container around the dialog's content. This is also the element the widget was instantiated with.</li><li><code>ui-dialog-buttonpane</code>: The pane that contains the dialog's buttons. This will only be present if the <a href="#option-buttons"><code>buttons</code></a> option is set.<ul><li><code>ui-dialog-buttonset</code>: The container around the buttons themselves.</li></ul></li></ul></li></ul><para>Additionally, when the <a href="#option-modal"><code>modal</code></a> option is set, an element with a <code>ui-widget-overlay</code> class name is appended to the <code>&lt;body&gt;</code>.</para><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/position/">Position</a></li><li><a href="/button/">Button</a></li><li><a href="/draggable/">Draggable</a> (optional; for use with the <a href="#option-draggable"><code>draggable</code></a> option)</li><li><a href="/resizable/">Resizable</a> (optional; for use with the <a href="#option-resizable"><code>resizable</code></a> option)</li><li><a href="/category/effects-core/">Effects Core</a> (optional; for use with the <a href="#option-show"><code>show</code></a> and <a href="#option-hide"><code>hide</code></a> options)</li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class DialogObject {

        private DialogObject() {
        }

        /// <summary>
        /// Closes the dialog.
        /// </summary>
        [InlineCode("{this}.dialog('close')")]
        public void Close() {
        }


        /// <summary>
        /// Removes the dialog functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.dialog('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Whether the dialog is currently open.
        /// </summary>
        [InlineCode("{this}.dialog('isOpen')")]
        public bool IsOpen() {
                return false;
        }


        /// <summary>
        /// Moves the dialog to the top of the dialog stack.
        /// </summary>
        [InlineCode("{this}.dialog('moveToTop')")]
        public void MoveToTop() {
        }


        /// <summary>
        /// Opens the dialog.
        /// </summary>
        [InlineCode("{this}.dialog('open')")]
        public void Open() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.dialog('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current dialog options hash.
        /// </summary>
        [InlineCode("{this}.dialog('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the dialog option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.dialog('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the dialog.
        /// </summary>
        [InlineCode("{this}.dialog('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the dialog.
        /// </summary>
        [InlineCode("{this}.dialog('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// <para>Which element the dialog (and overlay, if <a href="#option-modal">modal</a>) should be appended to.</para><div class="warning"><strong>Note:</strong> The <code>appendTo</code> option should not be changed while the dialog is open.</div>
        /// </summary>
        public string AppendTo {
            [InlineCode("{this}.dialog('option', 'appendTo')")]
            get;
            [InlineCode("{this}.dialog('option', 'appendTo', {value})")]
            set;
        }


        /// <summary>
        /// If set to <code>true</code>, the dialog will automatically open upon initialization. If <code>false</code>, the dialog will stay hidden until the <a href="#method-open"><code>open()</code></a> method is called.
        /// </summary>
        public bool AutoOpen {
            [InlineCode("{this}.dialog('option', 'autoOpen')")]
            get;
            [InlineCode("{this}.dialog('option', 'autoOpen', {value})")]
            set;
        }


        /// <summary>
        /// Specifies which buttons should be displayed on the dialog. The context of the callback is the dialog element; if you need access to the button, it is available as the target of the event object.
        /// </summary>
        public TypeOption<Array, object> Buttons {
            [InlineCode("{this}.dialog('option', 'buttons')")]
            get;
            [InlineCode("{this}.dialog('option', 'buttons', {value})")]
            set;
        }


        /// <summary>
        /// Specifies whether the dialog should close when it has focus and the user presses the esacpe (ESC) key.
        /// </summary>
        public bool CloseOnEscape {
            [InlineCode("{this}.dialog('option', 'closeOnEscape')")]
            get;
            [InlineCode("{this}.dialog('option', 'closeOnEscape', {value})")]
            set;
        }


        /// <summary>
        /// Specifies the text for the close button. Note that the close text is visibly hidden when using a standard theme.
        /// </summary>
        public string CloseText {
            [InlineCode("{this}.dialog('option', 'closeText')")]
            get;
            [InlineCode("{this}.dialog('option', 'closeText', {value})")]
            set;
        }


        /// <summary>
        /// The specified class name(s) will be added to the dialog, for additional theming.
        /// </summary>
        public string DialogClass {
            [InlineCode("{this}.dialog('option', 'dialogClass')")]
            get;
            [InlineCode("{this}.dialog('option', 'dialogClass', {value})")]
            set;
        }


        /// <summary>
        /// If set to <code>true</code>, the dialog will be draggable by the title bar. Requires the <a href="/draggable/">jQuery UI Draggable widget</a> to be included.
        /// </summary>
        public bool Draggable {
            [InlineCode("{this}.dialog('option', 'draggable')")]
            get;
            [InlineCode("{this}.dialog('option', 'draggable', {value})")]
            set;
        }


        /// <summary>
        /// The height of the dialog.
        /// </summary>
        public TypeOption<int, string> Height {
            [InlineCode("{this}.dialog('option', 'height')")]
            get;
            [InlineCode("{this}.dialog('option', 'height', {value})")]
            set;
        }


        /// <summary>
        /// If and how to animate the hiding of the dialog.
        /// </summary>
        public TypeOption<int, object, string> Hide {
            [InlineCode("{this}.dialog('option', 'hide')")]
            get;
            [InlineCode("{this}.dialog('option', 'hide', {value})")]
            set;
        }


        /// <summary>
        /// The maximum height to which the dialog can be resized, in pixels.
        /// </summary>
        public int MaxHeight {
            [InlineCode("{this}.dialog('option', 'maxHeight')")]
            get;
            [InlineCode("{this}.dialog('option', 'maxHeight', {value})")]
            set;
        }


        /// <summary>
        /// The maximum width to which the dialog can be resized, in pixels.
        /// </summary>
        public int MaxWidth {
            [InlineCode("{this}.dialog('option', 'maxWidth')")]
            get;
            [InlineCode("{this}.dialog('option', 'maxWidth', {value})")]
            set;
        }


        /// <summary>
        /// The minimum height to which the dialog can be resized, in pixels.
        /// </summary>
        public int MinHeight {
            [InlineCode("{this}.dialog('option', 'minHeight')")]
            get;
            [InlineCode("{this}.dialog('option', 'minHeight', {value})")]
            set;
        }


        /// <summary>
        /// The minimum width to which the dialog can be resized, in pixels.
        /// </summary>
        public int MinWidth {
            [InlineCode("{this}.dialog('option', 'minWidth')")]
            get;
            [InlineCode("{this}.dialog('option', 'minWidth', {value})")]
            set;
        }


        /// <summary>
        /// If set to <code>true</code>, the dialog will have modal behavior; other items on the page will be disabled, i.e., cannot be interacted with. Modal dialogs create an overlay below the dialog but above other page elements.
        /// </summary>
        public bool Modal {
            [InlineCode("{this}.dialog('option', 'modal')")]
            get;
            [InlineCode("{this}.dialog('option', 'modal', {value})")]
            set;
        }


        /// <summary>
        /// <para>Specifies where the dialog should be displayed. The dialog will handle collisions such that as much of the dialog is visible as possible.</para><para><em>Note: The <code>String</code> and <code>Array</code> forms are deprecated.</em></para>
        /// </summary>
        public TypeOption<Array, object, string> Position {
            [InlineCode("{this}.dialog('option', 'position')")]
            get;
            [InlineCode("{this}.dialog('option', 'position', {value})")]
            set;
        }


        /// <summary>
        /// If set to <code>true</code>, the dialog will be resizable. Requires the <a href="/resizable/">jQuery UI Resizable widget</a> to be included.
        /// </summary>
        public bool Resizable {
            [InlineCode("{this}.dialog('option', 'resizable')")]
            get;
            [InlineCode("{this}.dialog('option', 'resizable', {value})")]
            set;
        }


        /// <summary>
        /// If and how to animate the showing of the dialog.
        /// </summary>
        public TypeOption<int, object, string> Show {
            [InlineCode("{this}.dialog('option', 'show')")]
            get;
            [InlineCode("{this}.dialog('option', 'show', {value})")]
            set;
        }


        /// <summary>
        /// Specifies the title of the dialog. If the value is <code>null</code>, the <code>title</code> attribute on the dialog source element will be used.
        /// </summary>
        public string Title {
            [InlineCode("{this}.dialog('option', 'title')")]
            get;
            [InlineCode("{this}.dialog('option', 'title', {value})")]
            set;
        }


        /// <summary>
        /// The width of the dialog, in pixels.
        /// </summary>
        public int Width {
            [InlineCode("{this}.dialog('option', 'width')")]
            get;
            [InlineCode("{this}.dialog('option', 'width', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when a dialog is about to close. If canceled, the dialog will not close.
        /// </summary>
        public event jQueryUIEventHandler<object> OnBeforeClose {
            [InlineCode("{this}.bind('dialogbeforeclose', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogbeforeclose', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the dialog is closed.
        /// </summary>
        public event jQueryUIEventHandler<object> OnClose {
            [InlineCode("{this}.bind('dialogclose', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogclose', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the dialog is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('dialogcreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogcreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered while the dialog is being dragged.
        /// </summary>
        public event jQueryUIEventHandler<DialogDragEvent> OnDrag {
            [InlineCode("{this}.bind('dialogdrag', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogdrag', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the user starts dragging the dialog.
        /// </summary>
        public event jQueryUIEventHandler<DialogDragStartEvent> OnDragStart {
            [InlineCode("{this}.bind('dialogdragstart', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogdragstart', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered after the dialog has been dragged.
        /// </summary>
        public event jQueryUIEventHandler<DialogDragStopEvent> OnDragStop {
            [InlineCode("{this}.bind('dialogdragstop', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogdragstop', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the dialog gains focus.
        /// </summary>
        public event jQueryUIEventHandler<object> OnFocus {
            [InlineCode("{this}.bind('dialogfocus', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogfocus', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the dialog is opened.
        /// </summary>
        public event jQueryUIEventHandler<object> OnOpen {
            [InlineCode("{this}.bind('dialogopen', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogopen', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered while the dialog is being resized.
        /// </summary>
        public event jQueryUIEventHandler<DialogResizeEvent> OnResize {
            [InlineCode("{this}.bind('dialogresize', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogresize', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the user starts resizing the dialog.
        /// </summary>
        public event jQueryUIEventHandler<DialogResizeStartEvent> OnResizeStart {
            [InlineCode("{this}.bind('dialogresizestart', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogresizestart', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered after the dialog has been resized.
        /// </summary>
        public event jQueryUIEventHandler<DialogResizeStopEvent> OnResizeStop {
            [InlineCode("{this}.bind('dialogresizestop', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('dialogresizestop', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(DialogObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator DialogObject(jQueryObject o) {
            return null;
        }
    }
}
