using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class AutoCompleteOptions {

        /// <summary>
        /// <para>Which element the menu should be appended to. When the value is <code>null</code>, the parents of the input field will be checked for a class of <code>ui-front</code>. If an element with the <code>ui-front</code> class is found, the menu will be appended to that element. Regardless of the value, if no element is found, the menu will be appended to the body.</para><div class="warning"><strong>Note:</strong> The <code>appendTo</code> option should not be changed while the suggestions menu is open.</div>
        /// </summary>
        public string AppendTo {
            get; set;
        }

        /// <summary>
        /// If set to <code>true</code> the first item will automatically be focused when the menu is shown.
        /// </summary>
        public bool AutoFocus {
            get; set;
        }

        /// <summary>
        /// The delay in milliseconds between when a keystroke occurs and when a search is performed. A zero-delay makes sense for local data (more responsive), but can produce a lot of load for remote data, while being less responsive.
        /// </summary>
        public int Delay {
            get; set;
        }

        /// <summary>
        /// Disables the autocomplete if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            get; set;
        }

        /// <summary>
        /// The minimum number of characters a user must type before a search is performed. Zero is useful for local data with just a few items, but a higher value should be used when a single character search could match a few thousand items.
        /// </summary>
        public int MinLength {
            get; set;
        }

        /// <summary>
        /// Identifies the position of the suggestions menu in relation to the associated input element. The <code>of</code> option defaults to the input element, but you can specify another element to position against. You can refer to the <a href="/position">jQuery UI Position</a> utility for more details about the various options.
        /// </summary>
        public object Position {
            get; set;
        }

        /// <summary>
        /// Defines the data to use, must be specified.<para>Independent of the variant you use, the label is always treated as text. If you want the label to be treated as html you can use <a href="https://github.com/scottgonzalez/jquery-ui-extensions/blob/master/autocomplete/jquery.ui.autocomplete.html.js">Scott González' html extension</a>. The demos all focus on different variations of the <code>source</code> option - look for one that matches your use case, and check out the code.</para>
        /// </summary>
        public TypeOption<Array, Delegate, string> Source {
            get; set;
        }

        /// <summary>
        /// Triggered when the field is blurred, if the value has changed.
        /// </summary>
        [ScriptName("change")]
        public jQueryUIEventHandler<AutoCompleteChangeEvent> OnChange {
             get; set;
        }

        /// <summary>
        /// Triggered when the menu is hidden. Not every <code>close</code> event will be accompanied by a <code>change</code> event.
        /// </summary>
        [ScriptName("close")]
        public jQueryUIEventHandler<object> OnClose {
             get; set;
        }

        /// <summary>
        /// Triggered when the autocomplete is created.
        /// </summary>
        [ScriptName("create")]
        public jQueryUIEventHandler<object> OnCreate {
             get; set;
        }

        /// <summary>
        /// Triggered when focus is moved to an item (not selecting). The default action is to replace the text field's value with the value of the focused item, though only if the event was triggered by a keyboard interaction.<para>Canceling this event prevents the value from being updated, but does not prevent the menu item from being focused.</para>
        /// </summary>
        [ScriptName("focus")]
        public jQueryUIEventHandler<AutoCompleteFocusEvent> OnFocus {
             get; set;
        }

        /// <summary>
        /// Triggered when the suggestion menu is opened or updated.
        /// </summary>
        [ScriptName("open")]
        public jQueryUIEventHandler<object> OnOpen {
             get; set;
        }

        /// <summary>
        /// Triggered after a search completes, before the menu is shown. Useful for local manipulation of suggestion data, where a custom <a href="#option-source"><code>source</code></a> option callback is not required. This event is always triggered when a search completes, even if the menu will not be shown because there are no results or the Autocomplete is disabled.
        /// </summary>
        [ScriptName("response")]
        public jQueryUIEventHandler<AutoCompleteResponseEvent> OnResponse {
             get; set;
        }

        /// <summary>
        /// Triggered before a search is performed, after <a href="#option-minLength"><code>minLength</code></a> and <a href="#option-delay"><code>delay</code></a> are met. If canceled, then no request will be started and no items suggested.
        /// </summary>
        [ScriptName("search")]
        public jQueryUIEventHandler<object> OnSearch {
             get; set;
        }

        /// <summary>
        /// Triggered when an item is selected from the menu. The default action is to replace the text field's value with the value of the selected item.<para>Canceling this event prevents the value from being updated, but does not prevent the menu from closing.</para>
        /// </summary>
        [ScriptName("select")]
        public jQueryUIEventHandler<AutoCompleteSelectEvent> OnSelect {
             get; set;
        }
    }
}
