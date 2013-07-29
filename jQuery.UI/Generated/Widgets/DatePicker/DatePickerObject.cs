using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    /// <summary>
    /// Select a date from a popup or inline calendar
    /// </summary>
    /// <remarks>
    /// <para>The jQuery UI Datepicker is a highly configurable plugin that adds datepicker functionality to your pages. You can customize the date format and language, restrict the selectable date ranges and add in buttons and other navigation options easily.</para><para>By default, the datepicker calendar opens in a small overlay when the associated text field gains focus. For an inline calendar, simply attach the datepicker to a div or span.</para><h3>Keyboard interaction</h3><para>While the datepicker is open, the following key commands are available:</para><ul><li>PAGE UP: Move to the previous month.</li><li>PAGE DOWN: Move to the next month.</li><li>CTRL+PAGE UP: Move to the previous year.</li><li>CTRL+PAGE DOWN: Move to the next year.</li><li>CTRL+HOME: Move to the current month. Open the datepicker if closed.</li><li>CTRL+LEFT: Move to the previous day.</li><li>CTRL+RIGHT: Move to the next day.</li><li>CTRL+UP: Move to the previous week.</li><li>CTRL+DOWN: Move the next week.</li><li>ENTER: Select the focused date.</li><li>CTRL+END: Close the datepicker and erase the date.</li><li>ESCAPE: Close the datepicker without selection.</li></ul><h3 id="utility-functions">Utility functions</h3><ul><li>$.datepicker.setDefaults( settings ) - Set settings for all datepicker instances.</li><li>$.datepicker.formatDate( format, date, settings ) - Format a date into a string value with a specified format.</li><li>$.datepicker.parseDate( format, value, settings )  - Extract a date from a string value with a specified format.</li><li>$.datepicker.iso8601Week( date ) - Determine the week of the year for a given date: 1 to 53.</li><li>$.datepicker.noWeekends - Set as beforeShowDay function to prevent selection of weekends.</li></ul><h3>Localization</h3><para>Datepicker provides support for localizing its content to cater for different languages and date formats. Each localization is contained within its own file with the language code appended to the name, e.g., <code>jquery.ui.datepicker-fr.js</code> for French. The desired localization file should be included after the main datepicker code. Each localization file adds its settings to the set of available localizations and automatically applies them as defaults for all instances.</para><para>The <code>$.datepicker.regional</code> attribute holds an array of localizations, indexed by language code, with <code>""</code> referring to the default (English). Each entry is an object with the following attributes: <code>closeText</code>, <code>prevText</code>, <code>nextText</code>, <code>currentText</code>, <code>monthNames</code>, <code>monthNamesShort</code>, <code>dayNames</code>, <code>dayNamesShort</code>, <code>dayNamesMin</code>, <code>weekHeader</code>, <code>dateFormat</code>, <code>firstDay</code>, <code>isRTL</code>, <code>showMonthAfterYear</code>, and <code>yearSuffix</code>.</para><para>You can restore the default localizations with:</para><code>$.datepicker.setDefaults( $.datepicker.regional[ "" ] );</code><para>And can then override an individual datepicker for a specific locale:</para><code>$( selector ).datepicker( $.datepicker.regional[ "fr" ] );</code><h3>Dependencies</h3><ul><li><a href="/category/ui-core/">UI Core</a></li><li><a href="/category/effects-core/">Effects Core</a> (optional; for use with the <a href="#option-showAnim"><code>showAnim</code></a> option)</li></ul>
    /// </remarks>
    [Imported]
    [IgnoreNamespace]
    public sealed class DatePickerObject {

        private DatePickerObject() {
        }

        /// <summary>
        /// Removes the datepicker functionality completely. This will return the element back to its pre-init state.
        /// </summary>
        [InlineCode("{this}.datepicker('destroy')")]
        public void Destroy() {
        }


        /// <summary>
        /// Opens the datepicker in a dialog box.
        /// </summary>
        [InlineCode("{this}.datepicker('dialog', {date}, {onSelect}, {settings}, {pos})")]
        public void Dialog(TypeOption<JsDate, string> date, Delegate onSelect, object settings, TypeOption<int[], jQueryEvent> pos) {
        }


        /// <summary>
        /// Returns the current date for the datepicker or <code>null</code> if no date has been selected.
        /// </summary>
        [InlineCode("{this}.datepicker('getDate')")]
        public JsDate GetDate() {
                return null;
        }


        /// <summary>
        /// Close a previously opened date picker.
        /// </summary>
        [InlineCode("{this}.datepicker('hide')")]
        public void Hide() {
        }


        /// <summary>
        /// Determine whether a date picker has been disabled.
        /// </summary>
        [InlineCode("{this}.datepicker('isDisabled')")]
        public bool IsDisabled() {
                return false;
        }


        /// <summary>
        /// Gets the value currently associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.datepicker('option', {optionName})")]
        public object Option(string optionName) {
                return null;
        }


        /// <summary>
        /// Gets an object containing key/value pairs representing the current datepicker options hash.
        /// </summary>
        [InlineCode("{this}.datepicker('option')")]
        public object Option() {
                return null;
        }


        /// <summary>
        /// Sets the value of the datepicker option associated with the specified <code>optionName</code>.
        /// </summary>
        [InlineCode("{this}.datepicker('option', {optionName}, {value})")]
        public void Option(string optionName, object value) {
        }


        /// <summary>
        /// Sets one or more options for the datepicker.
        /// </summary>
        [InlineCode("{this}.datepicker('option', {options})")]
        public void Option(object options) {
        }


        /// <summary>
        /// Redraw the date picker, after having made some external modifications.
        /// </summary>
        [InlineCode("{this}.datepicker('refresh')")]
        public void Refresh() {
        }


        /// <summary>
        /// Sets the date for the datepicker. The new date may be a <code>Date</code> object or a string in the current <a href="#option-dateFormat">date format</a> (e.g., <code>"01/26/2009"</code>), a number of days from today (e.g., <code>+7</code>) or a string of values and periods (<code>"y"</code> for years, <code>"m"</code> for months, <code>"w"</code> for weeks, <code>"d"</code> for days, e.g., <code>"+1m +7d"</code>), or <code>null</code> to clear the selected date.
        /// </summary>
        [InlineCode("{this}.datepicker('setDate', {date})")]
        public void SetDate(TypeOption<JsDate, string> date) {
        }


        /// <summary>
        /// Open the date picker. If the datepicker is attached to an input, the input must be visible for the datepicker to be shown.
        /// </summary>
        [InlineCode("{this}.datepicker('show')")]
        public void Show() {
        }


        /// <summary>
        /// Returns a <code>jQuery</code> object containing the datepicker.
        /// </summary>
        [InlineCode("{this}.datepicker('widget')")]
        public jQueryObject Widget() {
                return null;
        }


        /// <summary>
        /// An input element that is to be updated with the selected date from the datepicker. Use the <a href="#option-altFormat"><code>altFormat</code></a> option to change the format of the date within this field. Leave as blank for no alternate field.
        /// </summary>
        public TypeOption<Element, jQueryObject, string> AltField {
            [InlineCode("{this}.datepicker('option', 'altField')")]
            get;
            [InlineCode("{this}.datepicker('option', 'altField', {value})")]
            set;
        }


        /// <summary>
        /// The <a href="#option-dateFormat"><code>dateFormat</code></a> to be used for the <a href="#option-altField"><code>altField</code></a> option. This allows one date format to be shown to the user for selection purposes, while a different format is actually sent behind the scenes. For a full list of the possible formats see the [[UI/Datepicker/formatDate|formatDate]] function
        /// </summary>
        public string AltFormat {
            [InlineCode("{this}.datepicker('option', 'altFormat')")]
            get;
            [InlineCode("{this}.datepicker('option', 'altFormat', {value})")]
            set;
        }


        /// <summary>
        /// The text to display after each date field, e.g., to show the required format.
        /// </summary>
        public string AppendText {
            [InlineCode("{this}.datepicker('option', 'appendText')")]
            get;
            [InlineCode("{this}.datepicker('option', 'appendText', {value})")]
            set;
        }


        /// <summary>
        /// Set to <code>true</code> to automatically resize the input field to accommodate dates in the current <a href="#option-dateFormat"><code>dateFormat</code></a>.
        /// </summary>
        public bool AutoSize {
            [InlineCode("{this}.datepicker('option', 'autoSize')")]
            get;
            [InlineCode("{this}.datepicker('option', 'autoSize', {value})")]
            set;
        }


        /// <summary>
        /// A function that takes an input field and current datepicker instance and returns an options object to update the datepicker with. It is called just before the datepicker is displayed.
        /// </summary>
        public Delegate BeforeShow {
            [InlineCode("{this}.datepicker('option', 'beforeShow')")]
            get;
            [InlineCode("{this}.datepicker('option', 'beforeShow', {value})")]
            set;
        }


        /// <summary>
        /// A function takes a date as a parameter and must return an array with <code>[0]</code> equal to <code>true</code>/<code>false</code> indicating whether or not this date is selectable, <code>[1]</code> equal to a CSS class name or <code>""</code> for the default presentation, and <code>[2]</code> an optional popup tooltip for this date. It is called for each day in the datepicker before it is displayed.
        /// </summary>
        public Delegate BeforeShowDay {
            [InlineCode("{this}.datepicker('option', 'beforeShowDay')")]
            get;
            [InlineCode("{this}.datepicker('option', 'beforeShowDay', {value})")]
            set;
        }


        /// <summary>
        /// The URL for the popup button image. If set, the <a href="#option-buttonText"><code>buttonText</code></a> option becomes the <code>alt</code> value and is not directly displayed.
        /// </summary>
        public string ButtonImage {
            [InlineCode("{this}.datepicker('option', 'buttonImage')")]
            get;
            [InlineCode("{this}.datepicker('option', 'buttonImage', {value})")]
            set;
        }


        /// <summary>
        /// Whether the button image should be rendered by itself instead of inside a button element.
        /// </summary>
        public bool ButtonImageOnly {
            [InlineCode("{this}.datepicker('option', 'buttonImageOnly')")]
            get;
            [InlineCode("{this}.datepicker('option', 'buttonImageOnly', {value})")]
            set;
        }


        /// <summary>
        /// The text to display on the trigger button. Use in conjunction with the <a href="#option-showOn"><code>showOn</code></a> option set to <code>"button"</code> or <code>"both"</code>.
        /// </summary>
        public string ButtonText {
            [InlineCode("{this}.datepicker('option', 'buttonText')")]
            get;
            [InlineCode("{this}.datepicker('option', 'buttonText', {value})")]
            set;
        }


        /// <summary>
        /// A function to calculate the week of the year for a given date. The default implementation uses the ISO 8601 definition: weeks start on a Monday; the first week of the year contains the first Thursday of the year.
        /// </summary>
        public Delegate CalculateWeek {
            [InlineCode("{this}.datepicker('option', 'calculateWeek')")]
            get;
            [InlineCode("{this}.datepicker('option', 'calculateWeek', {value})")]
            set;
        }


        /// <summary>
        /// Whether the month should be rendered as a dropdown instead of text.
        /// </summary>
        public bool ChangeMonth {
            [InlineCode("{this}.datepicker('option', 'changeMonth')")]
            get;
            [InlineCode("{this}.datepicker('option', 'changeMonth', {value})")]
            set;
        }


        /// <summary>
        /// Whether the year should be rendered as a dropdown instead of text. Use the <a href="#option-yearRange"><code>yearRange</code></a> option to control which years are made available for selection.
        /// </summary>
        public bool ChangeYear {
            [InlineCode("{this}.datepicker('option', 'changeYear')")]
            get;
            [InlineCode("{this}.datepicker('option', 'changeYear', {value})")]
            set;
        }


        /// <summary>
        /// The text to display for the close link. Use the <a href="#option-showButtonPanel"><code>showButtonPanel</code></a> option to display this button.
        /// </summary>
        public string CloseText {
            [InlineCode("{this}.datepicker('option', 'closeText')")]
            get;
            [InlineCode("{this}.datepicker('option', 'closeText', {value})")]
            set;
        }


        /// <summary>
        /// When <code>true</code>, entry in the input field is constrained to those characters allowed by the current <a href="#option-dateFormat"><code>dateFormat</code></a> option.
        /// </summary>
        public bool ConstrainInput {
            [InlineCode("{this}.datepicker('option', 'constrainInput')")]
            get;
            [InlineCode("{this}.datepicker('option', 'constrainInput', {value})")]
            set;
        }


        /// <summary>
        /// The text to display for the current day link. Use the <a href="#option-showButtonPanel"><code>showButtonPanel</code></a> option to display this button.
        /// </summary>
        public string CurrentText {
            [InlineCode("{this}.datepicker('option', 'currentText')")]
            get;
            [InlineCode("{this}.datepicker('option', 'currentText', {value})")]
            set;
        }


        /// <summary>
        /// The format for parsed and displayed dates. For a full list of the possible formats see the <code>[[UI/Datepicker/formatDate|formatDate]]</code> function.
        /// </summary>
        public string DateFormat {
            [InlineCode("{this}.datepicker('option', 'dateFormat')")]
            get;
            [InlineCode("{this}.datepicker('option', 'dateFormat', {value})")]
            set;
        }


        /// <summary>
        /// The list of long day names, starting from Sunday, for use as requested via the <a href="#option-dateFormat"><code>dateFormat</code></a> option.
        /// </summary>
        public Array DayNames {
            [InlineCode("{this}.datepicker('option', 'dayNames')")]
            get;
            [InlineCode("{this}.datepicker('option', 'dayNames', {value})")]
            set;
        }


        /// <summary>
        /// The list of minimised day names, starting from Sunday, for use as column headers within the datepicker.
        /// </summary>
        public Array DayNamesMin {
            [InlineCode("{this}.datepicker('option', 'dayNamesMin')")]
            get;
            [InlineCode("{this}.datepicker('option', 'dayNamesMin', {value})")]
            set;
        }


        /// <summary>
        /// The list of abbreviated day names, starting from Sunday, for use as requested via the <a href="#option-dateFormat"><code>dateFormat</code></a> option.
        /// </summary>
        public Array DayNamesShort {
            [InlineCode("{this}.datepicker('option', 'dayNamesShort')")]
            get;
            [InlineCode("{this}.datepicker('option', 'dayNamesShort', {value})")]
            set;
        }


        /// <summary>
        /// Set the date to highlight on first opening if the field is blank. Specify either an actual date via a Date object or as a string in the current <code>[[UI/Datepicker#option-dateFormat|dateFormat]]</code>, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
        /// </summary>
        public TypeOption<int, JsDate, string> DefaultDate {
            [InlineCode("{this}.datepicker('option', 'defaultDate')")]
            get;
            [InlineCode("{this}.datepicker('option', 'defaultDate', {value})")]
            set;
        }


        /// <summary>
        /// Control the speed at which the datepicker appears, it may be a time in milliseconds or a string representing one of the three predefined speeds ("slow", "normal", "fast").
        /// </summary>
        public TypeOption<object, string> Duration {
            [InlineCode("{this}.datepicker('option', 'duration')")]
            get;
            [InlineCode("{this}.datepicker('option', 'duration', {value})")]
            set;
        }


        /// <summary>
        /// Set the first day of the week: Sunday is <code>0</code>, Monday is <code>1</code>, etc.
        /// </summary>
        public int FirstDay {
            [InlineCode("{this}.datepicker('option', 'firstDay')")]
            get;
            [InlineCode("{this}.datepicker('option', 'firstDay', {value})")]
            set;
        }


        /// <summary>
        /// When <code>true</code>, the current day link moves to the currently selected date instead of today.
        /// </summary>
        public bool GotoCurrent {
            [InlineCode("{this}.datepicker('option', 'gotoCurrent')")]
            get;
            [InlineCode("{this}.datepicker('option', 'gotoCurrent', {value})")]
            set;
        }


        /// <summary>
        /// Normally the previous and next links are disabled when not applicable (see the <a href="#option-minDate"><code>minDate</code></a> and <a href="#option-maxDate"><code>maxDate</code></a> options). You can hide them altogether by setting this attribute to <code>true</code>.
        /// </summary>
        public bool HideIfNoPrevNext {
            [InlineCode("{this}.datepicker('option', 'hideIfNoPrevNext')")]
            get;
            [InlineCode("{this}.datepicker('option', 'hideIfNoPrevNext', {value})")]
            set;
        }


        /// <summary>
        /// Whether the current language is drawn from right to left.
        /// </summary>
        public bool IsRTL {
            [InlineCode("{this}.datepicker('option', 'isRTL')")]
            get;
            [InlineCode("{this}.datepicker('option', 'isRTL', {value})")]
            set;
        }


        /// <summary>
        /// The maximum selectable date. When set to <code>null</code>, there is no maximum.
        /// </summary>
        public TypeOption<int, JsDate, string> MaxDate {
            [InlineCode("{this}.datepicker('option', 'maxDate')")]
            get;
            [InlineCode("{this}.datepicker('option', 'maxDate', {value})")]
            set;
        }


        /// <summary>
        /// The minimum selectable date. When set to <code>null</code>, there is no minimum.
        /// </summary>
        public TypeOption<int, JsDate, string> MinDate {
            [InlineCode("{this}.datepicker('option', 'minDate')")]
            get;
            [InlineCode("{this}.datepicker('option', 'minDate', {value})")]
            set;
        }


        /// <summary>
        /// The list of full month names, for use as requested via the <a href="#option-dateFormat"><code>dateFormat</code></a> option.
        /// </summary>
        public Array MonthNames {
            [InlineCode("{this}.datepicker('option', 'monthNames')")]
            get;
            [InlineCode("{this}.datepicker('option', 'monthNames', {value})")]
            set;
        }


        /// <summary>
        /// The list of abbreviated month names, as used in the month header on each datepicker and as requested via the <a href="#option-dateFormat"><code>dateFormat</code></a> option.
        /// </summary>
        public Array MonthNamesShort {
            [InlineCode("{this}.datepicker('option', 'monthNamesShort')")]
            get;
            [InlineCode("{this}.datepicker('option', 'monthNamesShort', {value})")]
            set;
        }


        /// <summary>
        /// Whether the <a href="#option-prevText"><code>prevText</code></a> and <a href="#option-nextText"><code>nextText</code></a> options should be parsed as dates by the <code>[[UI/Datepicker/formatDate|formatDate]]</code> function, allowing them to display the target month names for example.
        /// </summary>
        public bool NavigationAsDateFormat {
            [InlineCode("{this}.datepicker('option', 'navigationAsDateFormat')")]
            get;
            [InlineCode("{this}.datepicker('option', 'navigationAsDateFormat', {value})")]
            set;
        }


        /// <summary>
        /// The text to display for the next month link. With the standard ThemeRoller styling, this value is replaced by an icon.
        /// </summary>
        public string NextText {
            [InlineCode("{this}.datepicker('option', 'nextText')")]
            get;
            [InlineCode("{this}.datepicker('option', 'nextText', {value})")]
            set;
        }


        /// <summary>
        /// The number of months to show at once.
        /// </summary>
        public TypeOption<Array, int> NumberOfMonths {
            [InlineCode("{this}.datepicker('option', 'numberOfMonths')")]
            get;
            [InlineCode("{this}.datepicker('option', 'numberOfMonths', {value})")]
            set;
        }


        /// <summary>
        /// Called when the datepicker moves to a new month and/or year. The function receives the selected year, month (1-12), and the datepicker instance as parameters. <code>this</code> refers to the associated input field.
        /// </summary>
        public Delegate OnChangeMonthYear {
            [InlineCode("{this}.datepicker('option', 'onChangeMonthYear')")]
            get;
            [InlineCode("{this}.datepicker('option', 'onChangeMonthYear', {value})")]
            set;
        }


        /// <summary>
        /// Called when the datepicker is closed, whether or not a date is selected. The function receives the selected date as text (<code>""</code> if none) and the datepicker instance as parameters. <code>this</code> refers to the associated input field.
        /// </summary>
        public Delegate OnClose {
            [InlineCode("{this}.datepicker('option', 'onClose')")]
            get;
            [InlineCode("{this}.datepicker('option', 'onClose', {value})")]
            set;
        }


        /// <summary>
        /// Called when the datepicker is selected. The function receives the selected date as text and the datepicker instance as parameters. <code>this</code> refers to the associated input field.
        /// </summary>
        public Delegate OnSelect {
            [InlineCode("{this}.datepicker('option', 'onSelect')")]
            get;
            [InlineCode("{this}.datepicker('option', 'onSelect', {value})")]
            set;
        }


        /// <summary>
        /// The text to display for the previous month link. With the standard ThemeRoller styling, this value is replaced by an icon.
        /// </summary>
        public string PrevText {
            [InlineCode("{this}.datepicker('option', 'prevText')")]
            get;
            [InlineCode("{this}.datepicker('option', 'prevText', {value})")]
            set;
        }


        /// <summary>
        /// Whether days in other months shown before or after the current month are selectable. This only applies if the <a href="#option-showOtherMonths"><code>showOtherMonths</code></a> option is set to <code>true</code>.
        /// </summary>
        public bool SelectOtherMonths {
            [InlineCode("{this}.datepicker('option', 'selectOtherMonths')")]
            get;
            [InlineCode("{this}.datepicker('option', 'selectOtherMonths', {value})")]
            set;
        }


        /// <summary>
        /// The cutoff year for determining the century for a date (used in conjunction with <code>[[UI/Datepicker#option-dateFormat|dateFormat]]</code> 'y'). Any dates entered with a year value less than or equal to the cutoff year are considered to be in the current century, while those greater than it are deemed to be in the previous century.
        /// </summary>
        public TypeOption<int, string> ShortYearCutoff {
            [InlineCode("{this}.datepicker('option', 'shortYearCutoff')")]
            get;
            [InlineCode("{this}.datepicker('option', 'shortYearCutoff', {value})")]
            set;
        }


        /// <summary>
        /// The name of the animation used to show and hide the datepicker. Use <code>"show"</code> (the default), <code>"slideDown"</code>, <code>"fadeIn"</code>, any of the <a href="/category/effects/">jQuery UI effects</a>. Set to an empty string to disable animation.
        /// </summary>
        public string ShowAnim {
            [InlineCode("{this}.datepicker('option', 'showAnim')")]
            get;
            [InlineCode("{this}.datepicker('option', 'showAnim', {value})")]
            set;
        }


        /// <summary>
        /// Whether to show the button panel.
        /// </summary>
        public bool ShowButtonPanel {
            [InlineCode("{this}.datepicker('option', 'showButtonPanel')")]
            get;
            [InlineCode("{this}.datepicker('option', 'showButtonPanel', {value})")]
            set;
        }


        /// <summary>
        /// When displaying multiple months via the <a href="#option-numberOfMonths"><code>numberOfMonths</code></a> option, the <code>showCurrentAtPos</code> option defines which position to display the current month in.
        /// </summary>
        public int ShowCurrentAtPos {
            [InlineCode("{this}.datepicker('option', 'showCurrentAtPos')")]
            get;
            [InlineCode("{this}.datepicker('option', 'showCurrentAtPos', {value})")]
            set;
        }


        /// <summary>
        /// Whether to show the month after the year in the header.
        /// </summary>
        public bool ShowMonthAfterYear {
            [InlineCode("{this}.datepicker('option', 'showMonthAfterYear')")]
            get;
            [InlineCode("{this}.datepicker('option', 'showMonthAfterYear', {value})")]
            set;
        }


        /// <summary>
        /// When the datepicker should appear. The datepicker can appear when the field receives focus (<code>"focus"</code>), when a button is clicked (<code>"button"</code>), or when either event occurs (<code>"both"</code>).
        /// </summary>
        public string ShowOn {
            [InlineCode("{this}.datepicker('option', 'showOn')")]
            get;
            [InlineCode("{this}.datepicker('option', 'showOn', {value})")]
            set;
        }


        /// <summary>
        /// If using one of the jQuery UI effects for the <a href="#option-showAnim"><code>showAnim</code></a> option, you can provide additional settings for that animation via this option.
        /// </summary>
        public object ShowOptions {
            [InlineCode("{this}.datepicker('option', 'showOptions')")]
            get;
            [InlineCode("{this}.datepicker('option', 'showOptions', {value})")]
            set;
        }


        /// <summary>
        /// Whether to display dates in other months (non-selectable) at the start or end of the current month. To make these days selectable use the <a href="#option-selectOtherMonths"><code>selectOtherMonths</code></a> option.
        /// </summary>
        public bool ShowOtherMonths {
            [InlineCode("{this}.datepicker('option', 'showOtherMonths')")]
            get;
            [InlineCode("{this}.datepicker('option', 'showOtherMonths', {value})")]
            set;
        }


        /// <summary>
        /// When <code>true</code>, a column is added to show the week of the year. The <a href="#option-calculateWeek"><code>calculateWeek</code></a> option determines how the week of the year is calculated. You may also want to change the <a href="#option-firstDay"><code>firstDay</code></a> option.
        /// </summary>
        public bool ShowWeek {
            [InlineCode("{this}.datepicker('option', 'showWeek')")]
            get;
            [InlineCode("{this}.datepicker('option', 'showWeek', {value})")]
            set;
        }


        /// <summary>
        /// Set how many months to move when clicking the previous/next links.
        /// </summary>
        public int StepMonths {
            [InlineCode("{this}.datepicker('option', 'stepMonths')")]
            get;
            [InlineCode("{this}.datepicker('option', 'stepMonths', {value})")]
            set;
        }


        /// <summary>
        /// The text to display for the week of the year column heading. Use the <a href="#option-showWeek"><code>showWeek</code></a> option to display this column.
        /// </summary>
        public string WeekHeader {
            [InlineCode("{this}.datepicker('option', 'weekHeader')")]
            get;
            [InlineCode("{this}.datepicker('option', 'weekHeader', {value})")]
            set;
        }


        /// <summary>
        /// The range of years displayed in the year drop-down: either relative to today's year (<code>"-nn:+nn"</code>), relative to the currently selected year (<code>"c-nn:c+nn"</code>), absolute (<code>"nnnn:nnnn"</code>), or combinations of these formats (<code>"nnnn:-nn"</code>). Note that this option only affects what appears in the drop-down, to restrict which dates may be selected use the <a href="#option-minDate"><code>minDate</code></a> and/or <a href="#option-maxDate"><code>maxDate</code></a> options.
        /// </summary>
        public string YearRange {
            [InlineCode("{this}.datepicker('option', 'yearRange')")]
            get;
            [InlineCode("{this}.datepicker('option', 'yearRange', {value})")]
            set;
        }


        /// <summary>
        /// Additional text to display after the year in the month headers.
        /// </summary>
        public string YearSuffix {
            [InlineCode("{this}.datepicker('option', 'yearSuffix')")]
            get;
            [InlineCode("{this}.datepicker('option', 'yearSuffix', {value})")]
            set;
        }


        [ScriptSkip]
        public static explicit operator jQueryObject(DatePickerObject o) {
            return null;
        }

        [ScriptSkip]
        public static explicit operator DatePickerObject(jQueryObject o) {
            return null;
        }
    }
}
