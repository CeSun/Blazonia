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
    /// A panel which lays out its children horizontally or vertically.
    /// </summary>
    public partial class StackPanel : Panel
    {
        static StackPanel()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets whether the horizontal snap points for the <see cref="T:Avalonia.Controls.StackPanel" /> are equidistant from each other.
        /// </summary>
        [Parameter] public bool? AreHorizontalSnapPointsRegular { get; set; }
        /// <summary>
        /// Gets or sets whether the vertical snap points for the <see cref="T:Avalonia.Controls.StackPanel" /> are equidistant from each other.
        /// </summary>
        [Parameter] public bool? AreVerticalSnapPointsRegular { get; set; }
        /// <summary>
        /// Gets or sets the orientation in which child controls will be layed out.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.Orientation? Orientation { get; set; }
        /// <summary>
        /// Gets or sets the size of the spacing to place between child controls.
        /// </summary>
        [Parameter] public double? Spacing { get; set; }
        [Parameter] public EventCallback<global::Avalonia.Interactivity.RoutedEventArgs> OnHorizontalSnapPointsChanged { get; set; }
        [Parameter] public EventCallback<global::Avalonia.Interactivity.RoutedEventArgs> OnVerticalSnapPointsChanged { get; set; }

        public new AC.StackPanel NativeControl => (AC.StackPanel)((AvaloniaObject)this).NativeControl;

        protected override AvaloniaBindableObject CreateNativeElement() => new AC.StackPanel();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AreHorizontalSnapPointsRegular):
                    if (!Equals(AreHorizontalSnapPointsRegular, value))
                    {
                        AreHorizontalSnapPointsRegular = (bool?)value;
                        NativeControl.AreHorizontalSnapPointsRegular = AreHorizontalSnapPointsRegular ?? (bool)AC.StackPanel.AreHorizontalSnapPointsRegularProperty.GetDefaultValue(AC.StackPanel.AreHorizontalSnapPointsRegularProperty.OwnerType);
                    }
                    break;
                case nameof(AreVerticalSnapPointsRegular):
                    if (!Equals(AreVerticalSnapPointsRegular, value))
                    {
                        AreVerticalSnapPointsRegular = (bool?)value;
                        NativeControl.AreVerticalSnapPointsRegular = AreVerticalSnapPointsRegular ?? (bool)AC.StackPanel.AreVerticalSnapPointsRegularProperty.GetDefaultValue(AC.StackPanel.AreVerticalSnapPointsRegularProperty.OwnerType);
                    }
                    break;
                case nameof(Orientation):
                    if (!Equals(Orientation, value))
                    {
                        Orientation = (global::Avalonia.Layout.Orientation?)value;
                        NativeControl.Orientation = Orientation ?? (global::Avalonia.Layout.Orientation)AC.StackPanel.OrientationProperty.GetDefaultValue(AC.StackPanel.OrientationProperty.OwnerType);
                    }
                    break;
                case nameof(Spacing):
                    if (!Equals(Spacing, value))
                    {
                        Spacing = (double?)value;
                        NativeControl.Spacing = Spacing ?? (double)AC.StackPanel.SpacingProperty.GetDefaultValue(AC.StackPanel.SpacingProperty.OwnerType);
                    }
                    break;
                case nameof(OnHorizontalSnapPointsChanged):
                    if (!Equals(OnHorizontalSnapPointsChanged, value))
                    {
                        void NativeControlHorizontalSnapPointsChanged(object sender, global::Avalonia.Interactivity.RoutedEventArgs e) => InvokeEventCallback(OnHorizontalSnapPointsChanged, e);

                        OnHorizontalSnapPointsChanged = (EventCallback<global::Avalonia.Interactivity.RoutedEventArgs>)value;
                        NativeControl.HorizontalSnapPointsChanged -= NativeControlHorizontalSnapPointsChanged;
                        NativeControl.HorizontalSnapPointsChanged += NativeControlHorizontalSnapPointsChanged;
                    }
                    break;
                case nameof(OnVerticalSnapPointsChanged):
                    if (!Equals(OnVerticalSnapPointsChanged, value))
                    {
                        void NativeControlVerticalSnapPointsChanged(object sender, global::Avalonia.Interactivity.RoutedEventArgs e) => InvokeEventCallback(OnVerticalSnapPointsChanged, e);

                        OnVerticalSnapPointsChanged = (EventCallback<global::Avalonia.Interactivity.RoutedEventArgs>)value;
                        NativeControl.VerticalSnapPointsChanged -= NativeControlVerticalSnapPointsChanged;
                        NativeControl.VerticalSnapPointsChanged += NativeControlVerticalSnapPointsChanged;
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
