using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Autocomplete enables users to quickly find and select from a pre-populated list of values as they type, leveraging searching and filtering.
    /// </summary>
    /// <remarks>
    /// <para>By giving an Autocomplete field focus or entering something into it, the plugin starts searching for entries that match and displays a list of values to choose from. By entering more characters, the user can filter down the list to better matches.</para><para>This can be used to choose previously selected values, such as entering tags for articles or entering email addresses from an address book. Autocomplete can also be used to populate associated information, such as entering a city name and getting the zip code.</para><para>You can pull data in from a local or remote source: Local is good for small data sets, e.g., an address book with 50 entries; remote is necessary for big data sets, such as a database with hundreds or millions of entries to select from. To find out more about customizing the data soure, see the documentation for the <a href="#option-source"><code>source</code></a> option.</para><h3>Keyboard interaction</h3><para>When the menu is open, the following key commands are available:</para><ul><li>UP - Move focus to the previous item. If on first item, move focus to the input. If on the input, move focus to last item.</li><li>DOWN - Move focus to the next item. If on last item, move focus to the input. If on the input, move focus to the first item.</li><li>ESCAPE - Close the menu.</li><li>ENTER - Select the currently focused item and close the menu.</li><li>TAB - Select the currently focused item, close the menu, and move focus to the next focusable element.</li><li>PAGE UP/DOWN - Scroll through a page of items (based on height of menu). <em>It's generally a bad idea to display so many items that users need to page.</em>.</li></ul><para>When the menu is closed, the following key commands are available:</para><ul><li>UP/DOWN - Open the menu, if the <a href="#option-minLength"><code>minLength</code></a> has been met.</li></ul><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/jQuery.widget/">Widget Factory</a></li><li><a href="/position/">Position</a></li><li><a href="/menu/">Menu</a></li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class AutoCompleteObject {

        private AutoCompleteObject() {
        }

        /// <summary>
        /// Closes the Autocomplete menu. Useful in combination with the <a href="#method-search"><code>search</code></a> method, to close the open menu.
        /// </summary>
        [InlineCode("{this}.autocomplete('close')")]
        public void Close() {
        }


        /// <summary>
        /// Removes the autocomplete functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.autocomplete('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Disables the autocomplete.
        /// </summary>
        [InlineCode("{this}.autocomplete('disable')")]
        public void Disable() {
        }


        /// <summary>
        /// Enables the autocomplete.
        /// </summary>
        [InlineCode("{this}.autocomplete('enable')")]
        public void Enable() {
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.autocomplete('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current autocomplete options hash.
        /// </summary>
        [InlineCode("{this}.autocomplete('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the autocomplete option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.autocomplete('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the autocomplete.
        /// </summary>
        [InlineCode("{this}.autocomplete('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Triggers a <a href="#event-search"><code>search</code></a> event and invokes the data source if the event is not canceled. Can be used by a selectbox-like button to open the suggestions when clicked. When invoked with no parameters, the current input's value is used. Can be called with an empty string and <code>minLength: 0</code> to display all items.
        /// </summary>
        [InlineCode("{this}.autocomplete('search', {value})")]
        public void Search(string value) {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the menu element. Although the menu items are constantly created and destroyed, the menu element itself is created during initialization and is constantly reused.
        /// </summary>
        [InlineCode("{this}.autocomplete('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// Which element the menu should be appended to. When the value is <code>null</code>, the parents of the input field will be checked for a class of <code>ui-front</code>. If an element with the <code>ui-front</code> class is found, the menu will be appended to that element. Regardless of the value, if no element is found, the menu will be appended to the body.
        /// </summary>
        public string AppendTo {
            [InlineCode("{this}.autocomplete('option', 'appendTo')")]
            get;
            [InlineCode("{this}.autocomplete('option', 'appendTo', {value})")]
            set;
        }


        /// <summary>
        /// If set to <code>true</code> the first item will automatically be focused when the menu is shown.
        /// </summary>
        public bool AutoFocus {
            [InlineCode("{this}.autocomplete('option', 'autoFocus')")]
            get;
            [InlineCode("{this}.autocomplete('option', 'autoFocus', {value})")]
            set;
        }


        /// <summary>
        /// The delay in milliseconds between when a keystroke occurs and when a search is performed. A zero-delay makes sense for local data (more responsive), but can produce a lot of load for remote data, while being less responsive.
        /// </summary>
        public int Delay {
            [InlineCode("{this}.autocomplete('option', 'delay')")]
            get;
            [InlineCode("{this}.autocomplete('option', 'delay', {value})")]
            set;
        }


        /// <summary>
        /// Disables the autocomplete if set to <code>true</code>.
        /// </summary>
        public bool Disabled {
            [InlineCode("{this}.autocomplete('option', 'disabled')")]
            get;
            [InlineCode("{this}.autocomplete('option', 'disabled', {value})")]
            set;
        }


        /// <summary>
        /// The minimum number of characters a user must type before a search is performed. Zero is useful for local data with just a few items, but a higher value should be used when a single character search could match a few thousand items.
        /// </summary>
        public int MinLength {
            [InlineCode("{this}.autocomplete('option', 'minLength')")]
            get;
            [InlineCode("{this}.autocomplete('option', 'minLength', {value})")]
            set;
        }


        /// <summary>
        /// Identifies the position of the suggestions menu in relation to the associated input element. The <code>of</code> option defaults to the input element, but you can specify another element to position against. You can refer to the <a href="/position">jQuery UI Position</a> utility for more details about the various options.
        /// </summary>
        public object Position {
            [InlineCode("{this}.autocomplete('option', 'position')")]
            get;
            [InlineCode("{this}.autocomplete('option', 'position', {value})")]
            set;
        }


        /// <summary>
        /// Defines the data to use, must be specified.<para>Independent of the variant you use, the label is always treated as text. If you want the label to be treated as html you can use <a href="https://github.com/scottgonzalez/jquery-ui-extensions/blob/master/autocomplete/jquery.ui.autocomplete.html.js">Scott González' html extension</a>. The demos all focus on different variations of the <code>source</code> option - look for one that matches your use case, and check out the code.</para>
        /// </summary>
        public TypeOption<Array, Delegate, string> Source {
            [InlineCode("{this}.autocomplete('option', 'source')")]
            get;
            [InlineCode("{this}.autocomplete('option', 'source', {value})")]
            set;
        }


        /// <summary>
        /// Triggered when the field is blurred, if the value has changed.
        /// </summary>
        public event jQueryUIEventHandler<AutoCompleteChangeEvent> OnChange {
            [InlineCode("{this}.bind('autocompletechange', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('autocompletechange', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the menu is hidden. Not every <code>close</code> event will be accompanied by a <code>change</code> event.
        /// </summary>
        public event jQueryUIEventHandler<object> OnClose {
            [InlineCode("{this}.bind('autocompleteclose', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('autocompleteclose', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the autocomplete is created.
        /// </summary>
        public event jQueryUIEventHandler<object> OnCreate {
            [InlineCode("{this}.bind('autocompletecreate', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('autocompletecreate', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when focus is moved to an item (not selecting). The default action is to replace the text field's value with the value of the focused item, though only if the event was triggered by a keyboard interaction.<para>Canceling this event prevents the value from being updated, but does not prevent the menu item from being focused.</para>
        /// </summary>
        public event jQueryUIEventHandler<AutoCompleteFocusEvent> OnFocus {
            [InlineCode("{this}.bind('autocompletefocus', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('autocompletefocus', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when the suggestion menu is opened or updated.
        /// </summary>
        public event jQueryUIEventHandler<object> OnOpen {
            [InlineCode("{this}.bind('autocompleteopen', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('autocompleteopen', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered after a search completes, before the menu is shown. Useful for local manipulation of suggestion data, where a custom <a href="#option-source"><code>source</code></a> option callback is not required. This event is always triggered when a search completes, even if the menu will not be shown because there are no results or the Autocomplete is disabled.
        /// </summary>
        public event jQueryUIEventHandler<AutoCompleteResponseEvent> OnResponse {
            [InlineCode("{this}.bind('autocompleteresponse', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('autocompleteresponse', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered before a search is performed, after <a href="#option-minLength"><code>minLength</code></a> and <a href="#option-delay"><code>delay</code></a> are met. If canceled, then no request will be started and no items suggested.
        /// </summary>
        public event jQueryUIEventHandler<object> OnSearch {
            [InlineCode("{this}.bind('autocompletesearch', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('autocompletesearch', {value})")]
            remove {
            }
        }


        /// <summary>
        /// Triggered when an item is selected from the menu. The default action is to replace the text field's value with the value of the selected item.<para>Canceling this event prevents the value from being updated, but does not prevent the menu from closing.</para>
        /// </summary>
        public event jQueryUIEventHandler<AutoCompleteSelectEvent> OnSelect {
            [InlineCode("{this}.bind('autocompleteselect', {value})")]
            add {
            }
            [InlineCode("{this}.unbind('autocompleteselect', {value})")]
            remove {
            }
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(AutoCompleteObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator AutoCompleteObject(jQueryObject o) {
            return null;
        }
    }
}
