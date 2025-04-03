// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace BlazorBindingsAvalonia.Elements
{
    /// <summary>
    /// Represents a control that can be used to display or edit unformatted text.
    /// </summary>
    public partial class TextBox : BlazorBindingsAvalonia.Elements.Primitives.TemplatedControl
    {
        static TextBox()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value that determines whether the TextBox allows and displays newline or return characters
        /// </summary>
        [Parameter] public bool? AcceptsReturn { get; set; }
        /// <summary>
        /// Gets or sets a value that determins whether the TextBox allows and displays tabs
        /// </summary>
        [Parameter] public bool? AcceptsTab { get; set; }
        [Parameter] public TimeSpan? CaretBlinkInterval { get; set; }
        /// <summary>
        /// Gets or sets a brush that is used for the text caret
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.Media.IBrush, global::Avalonia.Media.Color, string> CaretBrush { get; set; }
        /// <summary>
        /// Gets or sets the index of the text caret
        /// </summary>
        [Parameter] public int? CaretIndex { get; set; }
        /// <summary>
        /// Gets or sets a value that determines whether the TextBox clears its selection after it loses focus.
        /// </summary>
        [Parameter] public bool? ClearSelectionOnLostFocus { get; set; }
        /// <summary>
        /// Gets or sets the horizontal alignment of the content within the control.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.HorizontalAlignment? HorizontalContentAlignment { get; set; }
        /// <summary>
        /// Gets or sets custom content that is positioned on the left side of the text layout box
        /// </summary>
        [Parameter] public object InnerLeftContent { get; set; }
        /// <summary>
        /// Gets or sets custom content that is positioned on the right side of the text layout box
        /// </summary>
        [Parameter] public object InnerRightContent { get; set; }
        /// <summary>
        /// Gets or sets a value that determines whether the TextBox shows a selection highlight when it is not focused.
        /// </summary>
        [Parameter] public bool? IsInactiveSelectionHighlightEnabled { get; set; }
        /// <summary>
        /// Gets or sets a value whether this TextBox is read-only
        /// </summary>
        [Parameter] public bool? IsReadOnly { get; set; }
        /// <summary>
        /// Property for determining whether undo/redo is enabled
        /// </summary>
        [Parameter] public bool? IsUndoEnabled { get; set; }
        /// <summary>
        /// Gets or sets the spacing between characters
        /// </summary>
        [Parameter] public double? LetterSpacing { get; set; }
        /// <summary>
        /// Gets or sets the line height.
        /// </summary>
        [Parameter] public double? LineHeight { get; set; }
        /// <summary>
        /// Gets or sets the maximum number of characters that the <see cref="T:Avalonia.Controls.TextBox" /> can accept. This constraint only applies for manually entered (user-inputted) text.
        /// </summary>
        [Parameter] public int? MaxLength { get; set; }
        /// <summary>
        /// Gets or sets the maximum number of visible lines to size to.
        /// </summary>
        [Parameter] public int? MaxLines { get; set; }
        /// <summary>
        /// Gets or sets the minimum number of visible lines to size to.
        /// </summary>
        [Parameter] public int? MinLines { get; set; }
        /// <summary>
        /// Gets or sets which characters are inserted when Enter is pressed. Default: <see cref="P:System.Environment.NewLine" />
        /// </summary>
        [Parameter] public string NewLine { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:System.Char" /> that should be used for password masking
        /// </summary>
        [Parameter] public char? PasswordChar { get; set; }
        /// <summary>
        /// Gets or sets whether text masked by <see cref="P:Avalonia.Controls.TextBox.PasswordChar" /> should be revealed
        /// </summary>
        [Parameter] public bool? RevealPassword { get; set; }
        /// <summary>
        /// Gets or sets the text selected in the TextBox
        /// </summary>
        [Parameter] public string SelectedText { get; set; }
        /// <summary>
        /// Gets or sets a brush that is used to highlight selected text
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.Media.IBrush, global::Avalonia.Media.Color, string> SelectionBrush { get; set; }
        /// <summary>
        /// Gets or sets the end position of the text selected in the TextBox
        /// </summary>
        [Parameter] public int? SelectionEnd { get; set; }
        /// <summary>
        /// Gets or sets a brush that is used for the foreground of selected text
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.Media.IBrush, global::Avalonia.Media.Color, string> SelectionForegroundBrush { get; set; }
        /// <summary>
        /// Gets or sets the starting position of the text selected in the TextBox
        /// </summary>
        [Parameter] public int? SelectionStart { get; set; }
        /// <summary>
        /// Gets or sets the Text content of the TextBox
        /// </summary>
        [Parameter] public string Text { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Avalonia.Media.TextAlignment" /> of the TextBox
        /// </summary>
        [Parameter] public global::Avalonia.Media.TextAlignment? TextAlignment { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Avalonia.Media.TextWrapping" /> of the TextBox
        /// </summary>
        [Parameter] public global::Avalonia.Media.TextWrapping? TextWrapping { get; set; }
        /// <summary>
        /// Gets or sets the maximum number of items that can reside in the Undo stack
        /// </summary>
        [Parameter] public int? UndoLimit { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="P:Avalonia.Controls.TextBox.Watermark" /> will still be shown above the <see cref="P:Avalonia.Controls.TextBox.Text" /> even after a text value is set.
        /// </summary>
        [Parameter] public bool? UseFloatingWatermark { get; set; }
        /// <summary>
        /// Gets or sets the vertical alignment of the content within the control.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.VerticalAlignment? VerticalContentAlignment { get; set; }
        /// <summary>
        /// Gets or sets the placeholder or descriptive text that is displayed even if the <see cref="P:Avalonia.Controls.TextBox.Text" /> property is not yet set.
        /// </summary>
        [Parameter] public string Watermark { get; set; }
        [Parameter] public EventCallback<global::Avalonia.Interactivity.RoutedEventArgs> OnCopyingToClipboard { get; set; }
        [Parameter] public EventCallback<global::Avalonia.Interactivity.RoutedEventArgs> OnCuttingToClipboard { get; set; }
        [Parameter] public EventCallback<global::Avalonia.Interactivity.RoutedEventArgs> OnPastingFromClipboard { get; set; }
        [Parameter] public EventCallback<string> TextChanged { get; set; }
        [Parameter] public EventCallback<AC.TextChangingEventArgs> OnTextChanging { get; set; }

        public new AC.TextBox NativeControl => (AC.TextBox)((AvaloniaObject)this).NativeControl;

        protected override AC.TextBox CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AcceptsReturn):
                    if (!Equals(AcceptsReturn, value))
                    {
                        AcceptsReturn = (bool?)value;
                        NativeControl.AcceptsReturn = AcceptsReturn ?? (bool)AC.TextBox.AcceptsReturnProperty.GetDefaultValue(AC.TextBox.AcceptsReturnProperty.OwnerType);
                    }
                    break;
                case nameof(AcceptsTab):
                    if (!Equals(AcceptsTab, value))
                    {
                        AcceptsTab = (bool?)value;
                        NativeControl.AcceptsTab = AcceptsTab ?? (bool)AC.TextBox.AcceptsTabProperty.GetDefaultValue(AC.TextBox.AcceptsTabProperty.OwnerType);
                    }
                    break;
                case nameof(CaretBlinkInterval):
                    if (!Equals(CaretBlinkInterval, value))
                    {
                        CaretBlinkInterval = (TimeSpan?)value;
                        NativeControl.CaretBlinkInterval = CaretBlinkInterval ?? (TimeSpan)AC.TextBox.CaretBlinkIntervalProperty.GetDefaultValue(AC.TextBox.CaretBlinkIntervalProperty.OwnerType);
                    }
                    break;
                case nameof(CaretBrush):
                    if (!Equals(CaretBrush, value))
                    {
                        CaretBrush = (OneOf.OneOf<global::Avalonia.Media.IBrush, Avalonia.Media.Color, string>)value;
                        if (CaretBrush.IsT0)
                        {
                            NativeControl.CaretBrush = (global::Avalonia.Media.IBrush)CaretBrush.AsT0;
                        }
                        else if (CaretBrush.IsT1)
                        {
                            NativeControl.CaretBrush = new global::Avalonia.Media.Immutable.ImmutableSolidColorBrush(CaretBrush.AsT1);
                        }
                        else 
                        {
                            NativeControl.CaretBrush = Avalonia.Media.Brush.Parse(CaretBrush.AsT2);
                        }
                    }
                    break;
                case nameof(CaretIndex):
                    if (!Equals(CaretIndex, value))
                    {
                        CaretIndex = (int?)value;
                        NativeControl.CaretIndex = CaretIndex ?? (int)AC.TextBox.CaretIndexProperty.GetDefaultValue(AC.TextBox.CaretIndexProperty.OwnerType);
                    }
                    break;
                case nameof(ClearSelectionOnLostFocus):
                    if (!Equals(ClearSelectionOnLostFocus, value))
                    {
                        ClearSelectionOnLostFocus = (bool?)value;
                        NativeControl.ClearSelectionOnLostFocus = ClearSelectionOnLostFocus ?? (bool)AC.TextBox.ClearSelectionOnLostFocusProperty.GetDefaultValue(AC.TextBox.ClearSelectionOnLostFocusProperty.OwnerType);
                    }
                    break;
                case nameof(HorizontalContentAlignment):
                    if (!Equals(HorizontalContentAlignment, value))
                    {
                        HorizontalContentAlignment = (global::Avalonia.Layout.HorizontalAlignment?)value;
                        NativeControl.HorizontalContentAlignment = HorizontalContentAlignment ?? (global::Avalonia.Layout.HorizontalAlignment)AC.TextBox.HorizontalContentAlignmentProperty.GetDefaultValue(AC.TextBox.HorizontalContentAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(InnerLeftContent):
                    if (!Equals(InnerLeftContent, value))
                    {
                        InnerLeftContent = (object)value;
                        NativeControl.InnerLeftContent = InnerLeftContent;
                    }
                    break;
                case nameof(InnerRightContent):
                    if (!Equals(InnerRightContent, value))
                    {
                        InnerRightContent = (object)value;
                        NativeControl.InnerRightContent = InnerRightContent;
                    }
                    break;
                case nameof(IsInactiveSelectionHighlightEnabled):
                    if (!Equals(IsInactiveSelectionHighlightEnabled, value))
                    {
                        IsInactiveSelectionHighlightEnabled = (bool?)value;
                        NativeControl.IsInactiveSelectionHighlightEnabled = IsInactiveSelectionHighlightEnabled ?? (bool)AC.TextBox.IsInactiveSelectionHighlightEnabledProperty.GetDefaultValue(AC.TextBox.IsInactiveSelectionHighlightEnabledProperty.OwnerType);
                    }
                    break;
                case nameof(IsReadOnly):
                    if (!Equals(IsReadOnly, value))
                    {
                        IsReadOnly = (bool?)value;
                        NativeControl.IsReadOnly = IsReadOnly ?? (bool)AC.TextBox.IsReadOnlyProperty.GetDefaultValue(AC.TextBox.IsReadOnlyProperty.OwnerType);
                    }
                    break;
                case nameof(IsUndoEnabled):
                    if (!Equals(IsUndoEnabled, value))
                    {
                        IsUndoEnabled = (bool?)value;
                        NativeControl.IsUndoEnabled = IsUndoEnabled ?? (bool)AC.TextBox.IsUndoEnabledProperty.GetDefaultValue(AC.TextBox.IsUndoEnabledProperty.OwnerType);
                    }
                    break;
                case nameof(LetterSpacing):
                    if (!Equals(LetterSpacing, value))
                    {
                        LetterSpacing = (double?)value;
                        NativeControl.LetterSpacing = LetterSpacing ?? (double)AC.TextBox.LetterSpacingProperty.GetDefaultValue(AC.TextBox.LetterSpacingProperty.OwnerType);
                    }
                    break;
                case nameof(LineHeight):
                    if (!Equals(LineHeight, value))
                    {
                        LineHeight = (double?)value;
                        NativeControl.LineHeight = LineHeight ?? (double)AC.TextBox.LineHeightProperty.GetDefaultValue(AC.TextBox.LineHeightProperty.OwnerType);
                    }
                    break;
                case nameof(MaxLength):
                    if (!Equals(MaxLength, value))
                    {
                        MaxLength = (int?)value;
                        NativeControl.MaxLength = MaxLength ?? (int)AC.TextBox.MaxLengthProperty.GetDefaultValue(AC.TextBox.MaxLengthProperty.OwnerType);
                    }
                    break;
                case nameof(MaxLines):
                    if (!Equals(MaxLines, value))
                    {
                        MaxLines = (int?)value;
                        NativeControl.MaxLines = MaxLines ?? (int)AC.TextBox.MaxLinesProperty.GetDefaultValue(AC.TextBox.MaxLinesProperty.OwnerType);
                    }
                    break;
                case nameof(MinLines):
                    if (!Equals(MinLines, value))
                    {
                        MinLines = (int?)value;
                        NativeControl.MinLines = MinLines ?? (int)AC.TextBox.MinLinesProperty.GetDefaultValue(AC.TextBox.MinLinesProperty.OwnerType);
                    }
                    break;
                case nameof(NewLine):
                    if (!Equals(NewLine, value))
                    {
                        NewLine = (string)value;
                        NativeControl.NewLine = NewLine;
                    }
                    break;
                case nameof(PasswordChar):
                    if (!Equals(PasswordChar, value))
                    {
                        PasswordChar = (char?)value;
                        NativeControl.PasswordChar = PasswordChar ?? (char)AC.TextBox.PasswordCharProperty.GetDefaultValue(AC.TextBox.PasswordCharProperty.OwnerType);
                    }
                    break;
                case nameof(RevealPassword):
                    if (!Equals(RevealPassword, value))
                    {
                        RevealPassword = (bool?)value;
                        NativeControl.RevealPassword = RevealPassword ?? (bool)AC.TextBox.RevealPasswordProperty.GetDefaultValue(AC.TextBox.RevealPasswordProperty.OwnerType);
                    }
                    break;
                case nameof(SelectedText):
                    if (!Equals(SelectedText, value))
                    {
                        SelectedText = (string)value;
                        NativeControl.SelectedText = SelectedText;
                    }
                    break;
                case nameof(SelectionBrush):
                    if (!Equals(SelectionBrush, value))
                    {
                        SelectionBrush = (OneOf.OneOf<global::Avalonia.Media.IBrush, Avalonia.Media.Color, string>)value;
                        if (SelectionBrush.IsT0)
                        {
                            NativeControl.SelectionBrush = (global::Avalonia.Media.IBrush)SelectionBrush.AsT0;
                        }
                        else if (SelectionBrush.IsT1)
                        {
                            NativeControl.SelectionBrush = new global::Avalonia.Media.Immutable.ImmutableSolidColorBrush(SelectionBrush.AsT1);
                        }
                        else 
                        {
                            NativeControl.SelectionBrush = Avalonia.Media.Brush.Parse(SelectionBrush.AsT2);
                        }
                    }
                    break;
                case nameof(SelectionEnd):
                    if (!Equals(SelectionEnd, value))
                    {
                        SelectionEnd = (int?)value;
                        NativeControl.SelectionEnd = SelectionEnd ?? (int)AC.TextBox.SelectionEndProperty.GetDefaultValue(AC.TextBox.SelectionEndProperty.OwnerType);
                    }
                    break;
                case nameof(SelectionForegroundBrush):
                    if (!Equals(SelectionForegroundBrush, value))
                    {
                        SelectionForegroundBrush = (OneOf.OneOf<global::Avalonia.Media.IBrush, Avalonia.Media.Color, string>)value;
                        if (SelectionForegroundBrush.IsT0)
                        {
                            NativeControl.SelectionForegroundBrush = (global::Avalonia.Media.IBrush)SelectionForegroundBrush.AsT0;
                        }
                        else if (SelectionForegroundBrush.IsT1)
                        {
                            NativeControl.SelectionForegroundBrush = new global::Avalonia.Media.Immutable.ImmutableSolidColorBrush(SelectionForegroundBrush.AsT1);
                        }
                        else 
                        {
                            NativeControl.SelectionForegroundBrush = Avalonia.Media.Brush.Parse(SelectionForegroundBrush.AsT2);
                        }
                    }
                    break;
                case nameof(SelectionStart):
                    if (!Equals(SelectionStart, value))
                    {
                        SelectionStart = (int?)value;
                        NativeControl.SelectionStart = SelectionStart ?? (int)AC.TextBox.SelectionStartProperty.GetDefaultValue(AC.TextBox.SelectionStartProperty.OwnerType);
                    }
                    break;
                case nameof(Text):
                    if (!Equals(Text, value))
                    {
                        Text = (string)value;
                        NativeControl.Text = Text;
                    }
                    break;
                case nameof(TextAlignment):
                    if (!Equals(TextAlignment, value))
                    {
                        TextAlignment = (global::Avalonia.Media.TextAlignment?)value;
                        NativeControl.TextAlignment = TextAlignment ?? (global::Avalonia.Media.TextAlignment)AC.TextBox.TextAlignmentProperty.GetDefaultValue(AC.TextBox.TextAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(TextWrapping):
                    if (!Equals(TextWrapping, value))
                    {
                        TextWrapping = (global::Avalonia.Media.TextWrapping?)value;
                        NativeControl.TextWrapping = TextWrapping ?? (global::Avalonia.Media.TextWrapping)AC.TextBox.TextWrappingProperty.GetDefaultValue(AC.TextBox.TextWrappingProperty.OwnerType);
                    }
                    break;
                case nameof(UndoLimit):
                    if (!Equals(UndoLimit, value))
                    {
                        UndoLimit = (int?)value;
                        NativeControl.UndoLimit = UndoLimit ?? (int)AC.TextBox.UndoLimitProperty.GetDefaultValue(AC.TextBox.UndoLimitProperty.OwnerType);
                    }
                    break;
                case nameof(UseFloatingWatermark):
                    if (!Equals(UseFloatingWatermark, value))
                    {
                        UseFloatingWatermark = (bool?)value;
                        NativeControl.UseFloatingWatermark = UseFloatingWatermark ?? (bool)AC.TextBox.UseFloatingWatermarkProperty.GetDefaultValue(AC.TextBox.UseFloatingWatermarkProperty.OwnerType);
                    }
                    break;
                case nameof(VerticalContentAlignment):
                    if (!Equals(VerticalContentAlignment, value))
                    {
                        VerticalContentAlignment = (global::Avalonia.Layout.VerticalAlignment?)value;
                        NativeControl.VerticalContentAlignment = VerticalContentAlignment ?? (global::Avalonia.Layout.VerticalAlignment)AC.TextBox.VerticalContentAlignmentProperty.GetDefaultValue(AC.TextBox.VerticalContentAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(Watermark):
                    if (!Equals(Watermark, value))
                    {
                        Watermark = (string)value;
                        NativeControl.Watermark = Watermark;
                    }
                    break;
                case nameof(OnCopyingToClipboard):
                    if (!Equals(OnCopyingToClipboard, value))
                    {
                        void NativeControlCopyingToClipboard(object sender, global::Avalonia.Interactivity.RoutedEventArgs e) => InvokeEventCallback(OnCopyingToClipboard, e);

                        OnCopyingToClipboard = (EventCallback<global::Avalonia.Interactivity.RoutedEventArgs>)value;
                        NativeControl.CopyingToClipboard -= NativeControlCopyingToClipboard;
                        NativeControl.CopyingToClipboard += NativeControlCopyingToClipboard;
                    }
                    break;
                case nameof(OnCuttingToClipboard):
                    if (!Equals(OnCuttingToClipboard, value))
                    {
                        void NativeControlCuttingToClipboard(object sender, global::Avalonia.Interactivity.RoutedEventArgs e) => InvokeEventCallback(OnCuttingToClipboard, e);

                        OnCuttingToClipboard = (EventCallback<global::Avalonia.Interactivity.RoutedEventArgs>)value;
                        NativeControl.CuttingToClipboard -= NativeControlCuttingToClipboard;
                        NativeControl.CuttingToClipboard += NativeControlCuttingToClipboard;
                    }
                    break;
                case nameof(OnPastingFromClipboard):
                    if (!Equals(OnPastingFromClipboard, value))
                    {
                        void NativeControlPastingFromClipboard(object sender, global::Avalonia.Interactivity.RoutedEventArgs e) => InvokeEventCallback(OnPastingFromClipboard, e);

                        OnPastingFromClipboard = (EventCallback<global::Avalonia.Interactivity.RoutedEventArgs>)value;
                        NativeControl.PastingFromClipboard -= NativeControlPastingFromClipboard;
                        NativeControl.PastingFromClipboard += NativeControlPastingFromClipboard;
                    }
                    break;
                case nameof(TextChanged):
                    if (!Equals(TextChanged, value))
                    {
                        void NativeControlTextChanged(object sender, AC.TextChangedEventArgs e)
                        {
                            var value = NativeControl.Text;
                            Text = value;
                            InvokeEventCallback(TextChanged, value);
                        }

                        TextChanged = (EventCallback<string>)value;
                        NativeControl.TextChanged -= NativeControlTextChanged;
                        NativeControl.TextChanged += NativeControlTextChanged;
                    }
                    break;
                case nameof(OnTextChanging):
                    if (!Equals(OnTextChanging, value))
                    {
                        void NativeControlTextChanging(object sender, AC.TextChangingEventArgs e) => InvokeEventCallback(OnTextChanging, e);

                        OnTextChanging = (EventCallback<AC.TextChangingEventArgs>)value;
                        NativeControl.TextChanging -= NativeControlTextChanging;
                        NativeControl.TextChanging += NativeControlTextChanging;
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
