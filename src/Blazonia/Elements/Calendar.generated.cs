// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace Blazonia.Components
{
    /// <summary>
    /// Represents a control that enables a user to select a date by using a visual calendar display.
    /// </summary>
    public partial class Calendar : Blazonia.Components.Primitives.TemplatedControl
    {
        static Calendar()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the date to display.
        /// </summary>
        /// <value>
        /// The date to display.
        /// </value>
        [Parameter] public DateTime? DisplayDate { get; set; }
        /// <summary>
        /// Gets or sets the last date to be displayed.
        /// </summary>
        /// <value>
        /// The last date to display.
        /// </value>
        [Parameter] public Nullable<DateTime> DisplayDateEnd { get; set; }
        /// <summary>
        /// Gets or sets the first date to be displayed.
        /// </summary>
        /// <value>
        /// The first date to display.
        /// </value>
        [Parameter] public Nullable<DateTime> DisplayDateStart { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the calendar is displayed in months, years, or decades.
        /// </summary>
        /// <value>
        /// A value indicating what length of time the <see cref="T:System.Windows.Controls.Calendar" /> should display.
        /// </value>
        [Parameter] public AC.CalendarMode? DisplayMode { get; set; }
        /// <summary>
        /// Gets or sets the day that is considered the beginning of the week.
        /// </summary>
        /// <value>
        /// A <see cref="T:System.DayOfWeek" /> representing the beginning of the week. The default is <see cref="F:System.DayOfWeek.Sunday" />.
        /// </value>
        [Parameter] public DayOfWeek? FirstDayOfWeek { get; set; }
        [Parameter] public OneOf.OneOf<global::Avalonia.Media.IBrush, global::Avalonia.Media.Color, string> HeaderBackground { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the current date is highlighted.
        /// </summary>
        /// <value>
        /// True if the current date is highlighted; otherwise, false. The default is true.
        /// </value>
        [Parameter] public bool? IsTodayHighlighted { get; set; }
        /// <summary>
        /// Gets or sets the currently selected date.
        /// </summary>
        /// <value>
        /// The date currently selected. The default is null.
        /// </value>
        [Parameter] public Nullable<DateTime> SelectedDate { get; set; }
        /// <summary>
        /// Gets or sets a value that indicates what kind of selections are allowed.
        /// </summary>
        /// <value>
        /// A value that indicates the current selection mode. The default is <see cref="F:System.Windows.Controls.CalendarSelectionMode.SingleDate" />.
        /// </value>
        [Parameter] public AC.CalendarSelectionMode? SelectionMode { get; set; }
        [Parameter] public EventCallback<AC.SelectionChangedEventArgs> OnSelectedDatesChanged { get; set; }
        [Parameter] public EventCallback<DateTime?> DisplayDateChanged { get; set; }
        [Parameter] public EventCallback<AC.CalendarMode?> DisplayModeChanged { get; set; }

        public new AC.Calendar NativeControl => (AC.Calendar)((AvaloniaObject)this).NativeControl;

        protected override AvaloniaBindableObject CreateNativeElement() => new AC.Calendar();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(DisplayDate):
                    if (!Equals(DisplayDate, value))
                    {
                        DisplayDate = (DateTime?)value;
                        NativeControl.DisplayDate = DisplayDate ?? (DateTime)AC.Calendar.DisplayDateProperty.GetDefaultValue(AC.Calendar.DisplayDateProperty.OwnerType);
                    }
                    break;
                case nameof(DisplayDateEnd):
                    if (!Equals(DisplayDateEnd, value))
                    {
                        DisplayDateEnd = (Nullable<DateTime>)value;
                        NativeControl.DisplayDateEnd = DisplayDateEnd;
                    }
                    break;
                case nameof(DisplayDateStart):
                    if (!Equals(DisplayDateStart, value))
                    {
                        DisplayDateStart = (Nullable<DateTime>)value;
                        NativeControl.DisplayDateStart = DisplayDateStart;
                    }
                    break;
                case nameof(DisplayMode):
                    if (!Equals(DisplayMode, value))
                    {
                        DisplayMode = (AC.CalendarMode?)value;
                        NativeControl.DisplayMode = DisplayMode ?? (AC.CalendarMode)AC.Calendar.DisplayModeProperty.GetDefaultValue(AC.Calendar.DisplayModeProperty.OwnerType);
                    }
                    break;
                case nameof(FirstDayOfWeek):
                    if (!Equals(FirstDayOfWeek, value))
                    {
                        FirstDayOfWeek = (DayOfWeek?)value;
                        NativeControl.FirstDayOfWeek = FirstDayOfWeek ?? (DayOfWeek)AC.Calendar.FirstDayOfWeekProperty.GetDefaultValue(AC.Calendar.FirstDayOfWeekProperty.OwnerType);
                    }
                    break;
                case nameof(HeaderBackground):
                    if (!Equals(HeaderBackground, value))
                    {
                        HeaderBackground = (OneOf.OneOf<global::Avalonia.Media.IBrush, Avalonia.Media.Color, string>)value;
                        if (HeaderBackground.IsT0)
                        {
                            NativeControl.HeaderBackground = (global::Avalonia.Media.IBrush)HeaderBackground.AsT0;
                        }
                        else if (HeaderBackground.IsT1)
                        {
                            NativeControl.HeaderBackground = new global::Avalonia.Media.Immutable.ImmutableSolidColorBrush(HeaderBackground.AsT1);
                        }
                        else 
                        {
                            NativeControl.HeaderBackground = Avalonia.Media.Brush.Parse(HeaderBackground.AsT2);
                        }
                    }
                    break;
                case nameof(IsTodayHighlighted):
                    if (!Equals(IsTodayHighlighted, value))
                    {
                        IsTodayHighlighted = (bool?)value;
                        NativeControl.IsTodayHighlighted = IsTodayHighlighted ?? (bool)AC.Calendar.IsTodayHighlightedProperty.GetDefaultValue(AC.Calendar.IsTodayHighlightedProperty.OwnerType);
                    }
                    break;
                case nameof(SelectedDate):
                    if (!Equals(SelectedDate, value))
                    {
                        SelectedDate = (Nullable<DateTime>)value;
                        NativeControl.SelectedDate = SelectedDate;
                    }
                    break;
                case nameof(SelectionMode):
                    if (!Equals(SelectionMode, value))
                    {
                        SelectionMode = (AC.CalendarSelectionMode?)value;
                        NativeControl.SelectionMode = SelectionMode ?? (AC.CalendarSelectionMode)AC.Calendar.SelectionModeProperty.GetDefaultValue(AC.Calendar.SelectionModeProperty.OwnerType);
                    }
                    break;
                case nameof(OnSelectedDatesChanged):
                    if (!Equals(OnSelectedDatesChanged, value))
                    {
                        void NativeControlSelectedDatesChanged(object sender, AC.SelectionChangedEventArgs e) => InvokeEventCallback(OnSelectedDatesChanged, e);

                        OnSelectedDatesChanged = (EventCallback<AC.SelectionChangedEventArgs>)value;
                        NativeControl.SelectedDatesChanged -= NativeControlSelectedDatesChanged;
                        NativeControl.SelectedDatesChanged += NativeControlSelectedDatesChanged;
                    }
                    break;
                case nameof(DisplayDateChanged):
                    if (!Equals(DisplayDateChanged, value))
                    {
                        void NativeControlDisplayDateChanged(object sender, AC.CalendarDateChangedEventArgs e)
                        {
                            var value = NativeControl.DisplayDate is DateTime item ? item : default(DateTime?);
                            DisplayDate = value;
                            InvokeEventCallback(DisplayDateChanged, value);
                        }

                        DisplayDateChanged = (EventCallback<DateTime?>)value;
                        NativeControl.DisplayDateChanged -= NativeControlDisplayDateChanged;
                        NativeControl.DisplayDateChanged += NativeControlDisplayDateChanged;
                    }
                    break;
                case nameof(DisplayModeChanged):
                    if (!Equals(DisplayModeChanged, value))
                    {
                        void NativeControlDisplayModeChanged(object sender, AC.CalendarModeChangedEventArgs e)
                        {
                            var value = NativeControl.DisplayMode is AC.CalendarMode item ? item : default(AC.CalendarMode?);
                            DisplayMode = value;
                            InvokeEventCallback(DisplayModeChanged, value);
                        }

                        DisplayModeChanged = (EventCallback<AC.CalendarMode?>)value;
                        NativeControl.DisplayModeChanged -= NativeControlDisplayModeChanged;
                        NativeControl.DisplayModeChanged += NativeControlDisplayModeChanged;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}
