using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Widgets {

    [Imported]
    [IgnoreNamespace]
    [Serializable]
    public sealed class DatePickerOptions {

        /// <summary>
        /// An input element that is to be updated with the selected date from the datepicker. Use the <a href="#option-altFormat"><code>altFormat</code></a> option to change the format of the date within this field. Leave as blank for no alternate field.
        /// </summary>
        public TypeOption<Element, jQueryObject, string> AltField {
            get; set;
        }

        /// <summary>
        /// The <a href="#option-dateFormat"><code>dateFormat</code></a> to be used for the <a href="#option-altField"><code>altField</code></a> option. This allows one date format to be shown to the user for selection purposes, while a different format is actually sent behind the scenes. For a full list of the possible formats see the [[UI/Datepicker/formatDate|formatDate]] function
        /// </summary>
        public string AltFormat {
            get; set;
        }

        /// <summary>
        /// The text to display after each date field, e.g., to show the required format.
        /// </summary>
        public string AppendText {
            get; set;
        }

        /// <summary>
        /// Set to <code>true</code> to automatically resize the input field to accommodate dates in the current <a href="#option-dateFormat"><code>dateFormat</code></a>.
        /// </summary>
        public bool AutoSize {
            get; set;
        }

        /// <summary>
        /// A function that takes an input field and current datepicker instance and returns an options object to update the datepicker with. It is called just before the datepicker is displayed.
        /// </summary>
        public Delegate BeforeShow {
            get; set;
        }

        /// <summary>
        /// A function takes a date as a parameter and must return an array with <code>[0]</code> equal to <code>true</code>/<code>false</code> indicating whether or not this date is selectable, <code>[1]</code> equal to a CSS class name or <code>""</code> for the default presentation, and <code>[2]</code> an optional popup tooltip for this date. It is called for each day in the datepicker before it is displayed.
        /// </summary>
        public Delegate BeforeShowDay {
            get; set;
        }

        /// <summary>
        /// The URL for the popup button image. If set, the <a href="#option-buttonText"><code>buttonText</code></a> option becomes the <code>alt</code> value and is not directly displayed.
        /// </summary>
        public string ButtonImage {
            get; set;
        }

        /// <summary>
        /// Whether the button image should be rendered by itself instead of inside a button element.
        /// </summary>
        public bool ButtonImageOnly {
            get; set;
        }

        /// <summary>
        /// The text to display on the trigger button. Use in conjunction with the <a href="#option-showOn"><code>showOn</code></a> option set to <code>"button"</code> or <code>"both"</code>.
        /// </summary>
        public string ButtonText {
            get; set;
        }

        /// <summary>
        /// A function to calculate the week of the year for a given date. The default implementation uses the ISO 8601 definition: weeks start on a Monday; the first week of the year contains the first Thursday of the year.
        /// </summary>
        public Delegate CalculateWeek {
            get; set;
        }

        /// <summary>
        /// Whether the month should be rendered as a dropdown instead of text.
        /// </summary>
        public bool ChangeMonth {
            get; set;
        }

        /// <summary>
        /// Whether the year should be rendered as a dropdown instead of text. Use the <a href="#option-yearRange"><code>yearRange</code></a> option to control which years are made available for selection.
        /// </summary>
        public bool ChangeYear {
            get; set;
        }

        /// <summary>
        /// The text to display for the close link. Use the <a href="#option-showButtonPanel"><code>showButtonPanel</code></a> option to display this button.
        /// </summary>
        public string CloseText {
            get; set;
        }

        /// <summary>
        /// When <code>true</code>, entry in the input field is constrained to those characters allowed by the current <a href="#option-dateFormat"><code>dateFormat</code></a> option.
        /// </summary>
        public bool ConstrainInput {
            get; set;
        }

        /// <summary>
        /// The text to display for the current day link. Use the <a href="#option-showButtonPanel"><code>showButtonPanel</code></a> option to display this button.
        /// </summary>
        public string CurrentText {
            get; set;
        }

        /// <summary>
        /// The format for parsed and displayed dates. For a full list of the possible formats see the <code>[[UI/Datepicker/formatDate|formatDate]]</code> function.
        /// </summary>
        public string DateFormat {
            get; set;
        }

        /// <summary>
        /// The list of long day names, starting from Sunday, for use as requested via the <a href="#option-dateFormat"><code>dateFormat</code></a> option.
        /// </summary>
        public Array DayNames {
            get; set;
        }

        /// <summary>
        /// The list of minimised day names, starting from Sunday, for use as column headers within the datepicker.
        /// </summary>
        public Array DayNamesMin {
            get; set;
        }

        /// <summary>
        /// The list of abbreviated day names, starting from Sunday, for use as requested via the <a href="#option-dateFormat"><code>dateFormat</code></a> option.
        /// </summary>
        public Array DayNamesShort {
            get; set;
        }

        /// <summary>
        /// Set the date to highlight on first opening if the field is blank. Specify either an actual date via a Date object or as a string in the current <code>[[UI/Datepicker#option-dateFormat|dateFormat]]</code>, or a number of days from today (e.g. +7) or a string of values and periods ('y' for years, 'm' for months, 'w' for weeks, 'd' for days, e.g. '+1m +7d'), or null for today.
        /// </summary>
        public TypeOption<int, JsDate, string> DefaultDate {
            get; set;
        }

        /// <summary>
        /// Control the speed at which the datepicker appears, it may be a time in milliseconds or a string representing one of the three predefined speeds ("slow", "normal", "fast").
        /// </summary>
        public TypeOption<object, string> Duration {
            get; set;
        }

        /// <summary>
        /// Set the first day of the week: Sunday is <code>0</code>, Monday is <code>1</code>, etc.
        /// </summary>
        public int FirstDay {
            get; set;
        }

        /// <summary>
        /// When <code>true</code>, the current day link moves to the currently selected date instead of today.
        /// </summary>
        public bool GotoCurrent {
            get; set;
        }

        /// <summary>
        /// Normally the previous and next links are disabled when not applicable (see the <a href="#option-minDate"><code>minDate</code></a> and <a href="#option-maxDate"><code>maxDate</code></a> options). You can hide them altogether by setting this attribute to <code>true</code>.
        /// </summary>
        public bool HideIfNoPrevNext {
            get; set;
        }

        /// <summary>
        /// Whether the current language is drawn from right to left.
        /// </summary>
        public bool IsRTL {
            get; set;
        }

        /// <summary>
        /// The maximum selectable date. When set to <code>null</code>, there is no maximum.
        /// </summary>
        public TypeOption<int, JsDate, string> MaxDate {
            get; set;
        }

        /// <summary>
        /// The minimum selectable date. When set to <code>null</code>, there is no minimum.
        /// </summary>
        public TypeOption<int, JsDate, string> MinDate {
            get; set;
        }

        /// <summary>
        /// The list of full month names, for use as requested via the <a href="#option-dateFormat"><code>dateFormat</code></a> option.
        /// </summary>
        public Array MonthNames {
            get; set;
        }

        /// <summary>
        /// The list of abbreviated month names, as used in the month header on each datepicker and as requested via the <a href="#option-dateFormat"><code>dateFormat</code></a> option.
        /// </summary>
        public Array MonthNamesShort {
            get; set;
        }

        /// <summary>
        /// Whether the <a href="#option-prevText"><code>prevText</code></a> and <a href="#option-nextText"><code>nextText</code></a> options should be parsed as dates by the <code>[[UI/Datepicker/formatDate|formatDate]]</code> function, allowing them to display the target month names for example.
        /// </summary>
        public bool NavigationAsDateFormat {
            get; set;
        }

        /// <summary>
        /// The text to display for the next month link. With the standard ThemeRoller styling, this value is replaced by an icon.
        /// </summary>
        public string NextText {
            get; set;
        }

        /// <summary>
        /// The number of months to show at once.
        /// </summary>
        public TypeOption<Array, int> NumberOfMonths {
            get; set;
        }

        /// <summary>
        /// Called when the datepicker moves to a new month and/or year. The function receives the selected year, month (1-12), and the datepicker instance as parameters. <code>this</code> refers to the associated input field.
        /// </summary>
        public Delegate OnChangeMonthYear {
            get; set;
        }

        /// <summary>
        /// Called when the datepicker is closed, whether or not a date is selected. The function receives the selected date as text (<code>""</code> if none) and the datepicker instance as parameters. <code>this</code> refers to the associated input field.
        /// </summary>
        public Delegate OnClose {
            get; set;
        }

        /// <summary>
        /// Called when the datepicker is selected. The function receives the selected date as text and the datepicker instance as parameters. <code>this</code> refers to the associated input field.
        /// </summary>
        public Delegate OnSelect {
            get; set;
        }

        /// <summary>
        /// The text to display for the previous month link. With the standard ThemeRoller styling, this value is replaced by an icon.
        /// </summary>
        public string PrevText {
            get; set;
        }

        /// <summary>
        /// Whether days in other months shown before or after the current month are selectable. This only applies if the <a href="#option-showOtherMonths"><code>showOtherMonths</code></a> option is set to <code>true</code>.
        /// </summary>
        public bool SelectOtherMonths {
            get; set;
        }

        /// <summary>
        /// The cutoff year for determining the century for a date (used in conjunction with <code>[[UI/Datepicker#option-dateFormat|dateFormat]]</code> 'y'). Any dates entered with a year value less than or equal to the cutoff year are considered to be in the current century, while those greater than it are deemed to be in the previous century.
        /// </summary>
        public TypeOption<int, string> ShortYearCutoff {
            get; set;
        }

        /// <summary>
        /// The name of the animation used to show and hide the datepicker. Use <code>"show"</code> (the default), <code>"slideDown"</code>, <code>"fadeIn"</code>, any of the <a href="/category/effects/">jQuery UI effects</a>. Set to an empty string to disable animation.
        /// </summary>
        public string ShowAnim {
            get; set;
        }

        /// <summary>
        /// Whether to show the button panel.
        /// </summary>
        public bool ShowButtonPanel {
            get; set;
        }

        /// <summary>
        /// When displaying multiple months via the <a href="#option-numberOfMonths"><code>numberOfMonths</code></a> option, the <code>showCurrentAtPos</code> option defines which position to display the current month in.
        /// </summary>
        public int ShowCurrentAtPos {
            get; set;
        }

        /// <summary>
        /// Whether to show the month after the year in the header.
        /// </summary>
        public bool ShowMonthAfterYear {
            get; set;
        }

        /// <summary>
        /// When the datepicker should appear. The datepicker can appear when the field receives focus (<code>"focus"</code>), when a button is clicked (<code>"button"</code>), or when either event occurs (<code>"both"</code>).
        /// </summary>
        public string ShowOn {
            get; set;
        }

        /// <summary>
        /// If using one of the jQuery UI effects for the <a href="#option-showAnim"><code>showAnim</code></a> option, you can provide additional settings for that animation via this option.
        /// </summary>
        public object ShowOptions {
            get; set;
        }

        /// <summary>
        /// Whether to display dates in other months (non-selectable) at the start or end of the current month. To make these days selectable use the <a href="#option-selectOtherMonths"><code>selectOtherMonths</code></a> option.
        /// </summary>
        public bool ShowOtherMonths {
            get; set;
        }

        /// <summary>
        /// When <code>true</code>, a column is added to show the week of the year. The <a href="#option-calculateWeek"><code>calculateWeek</code></a> option determines how the week of the year is calculated. You may also want to change the <a href="#option-firstDay"><code>firstDay</code></a> option.
        /// </summary>
        public bool ShowWeek {
            get; set;
        }

        /// <summary>
        /// Set how many months to move when clicking the previous/next links.
        /// </summary>
        public int StepMonths {
            get; set;
        }

        /// <summary>
        /// The text to display for the week of the year column heading. Use the <a href="#option-showWeek"><code>showWeek</code></a> option to display this column.
        /// </summary>
        public string WeekHeader {
            get; set;
        }

        /// <summary>
        /// The range of years displayed in the year drop-down: either relative to today's year (<code>"-nn:+nn"</code>), relative to the currently selected year (<code>"c-nn:c+nn"</code>), absolute (<code>"nnnn:nnnn"</code>), or combinations of these formats (<code>"nnnn:-nn"</code>). Note that this option only affects what appears in the drop-down, to restrict which dates may be selected use the <a href="#option-minDate"><code>minDate</code></a> and/or <a href="#option-maxDate"><code>maxDate</code></a> options.
        /// </summary>
        public string YearRange {
            get; set;
        }

        /// <summary>
        /// Additional text to display after the year in the month headers.
        /// </summary>
        public string YearSuffix {
            get; set;
        }
    }
}
