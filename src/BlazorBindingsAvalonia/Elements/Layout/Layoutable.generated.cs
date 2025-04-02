// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AL = Avalonia.Layout;
using BlazorBindingsAvalonia.Elements;

#pragma warning disable CA2252

namespace BlazorBindingsAvalonia.Elements.Layout
{
    /// <summary>
    /// Implements layout-related functionality for a control.
    /// </summary>
    public partial class Layoutable : BlazorBindingsAvalonia.Elements.Visual
    {
        static Layoutable()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the height of the element.
        /// </summary>
        [Parameter] public double? Height { get; set; }
        /// <summary>
        /// Gets or sets the element's preferred horizontal alignment in its parent.
        /// </summary>
        [Parameter] public AL.HorizontalAlignment? HorizontalAlignment { get; set; }
        /// <summary>
        /// Gets or sets the margin around the element.
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.Thickness?, string> Margin { get; set; }
        /// <summary>
        /// Gets or sets the maximum height of the element.
        /// </summary>
        [Parameter] public double? MaxHeight { get; set; }
        /// <summary>
        /// Gets or sets the maximum width of the element.
        /// </summary>
        [Parameter] public double? MaxWidth { get; set; }
        /// <summary>
        /// Gets or sets the minimum height of the element.
        /// </summary>
        [Parameter] public double? MinHeight { get; set; }
        /// <summary>
        /// Gets or sets the minimum width of the element.
        /// </summary>
        [Parameter] public double? MinWidth { get; set; }
        /// <summary>
        /// Gets or sets a value that determines whether the element should be snapped to pixel boundaries at layout time.
        /// </summary>
        [Parameter] public bool? UseLayoutRounding { get; set; }
        /// <summary>
        /// Gets or sets the element's preferred vertical alignment in its parent.
        /// </summary>
        [Parameter] public AL.VerticalAlignment? VerticalAlignment { get; set; }
        /// <summary>
        /// Gets or sets the width of the element.
        /// </summary>
        [Parameter] public double? Width { get; set; }
        [Parameter] public EventCallback<AL.EffectiveViewportChangedEventArgs> OnEffectiveViewportChanged { get; set; }
        [Parameter] public EventCallback OnLayoutUpdated { get; set; }

        public new AL.Layoutable NativeControl => (AL.Layoutable)((AvaloniaObject)this).NativeControl;

        protected override AL.Layoutable CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Height):
                    if (!Equals(Height, value))
                    {
                        Height = (double?)value;
                        NativeControl.Height = Height ?? (double)AL.Layoutable.HeightProperty.GetDefaultValue(AL.Layoutable.HeightProperty.OwnerType);
                    }
                    break;
                case nameof(HorizontalAlignment):
                    if (!Equals(HorizontalAlignment, value))
                    {
                        HorizontalAlignment = (AL.HorizontalAlignment?)value;
                        NativeControl.HorizontalAlignment = HorizontalAlignment ?? (AL.HorizontalAlignment)AL.Layoutable.HorizontalAlignmentProperty.GetDefaultValue(AL.Layoutable.HorizontalAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(Margin):
                    if (!Equals(Margin, value))
                    {
                        Margin = (OneOf.OneOf<global::Avalonia.Thickness?,string>)value;
                        if (Margin.IsT0)
                        {
                            NativeControl.Margin = (global::Avalonia.Thickness)Margin.AsT0;
                        }
                        else 
                        {
                            NativeControl.Margin = global::Avalonia.Thickness.Parse(Margin.AsT1);
                        }
                    }
                    break;
                case nameof(MaxHeight):
                    if (!Equals(MaxHeight, value))
                    {
                        MaxHeight = (double?)value;
                        NativeControl.MaxHeight = MaxHeight ?? (double)AL.Layoutable.MaxHeightProperty.GetDefaultValue(AL.Layoutable.MaxHeightProperty.OwnerType);
                    }
                    break;
                case nameof(MaxWidth):
                    if (!Equals(MaxWidth, value))
                    {
                        MaxWidth = (double?)value;
                        NativeControl.MaxWidth = MaxWidth ?? (double)AL.Layoutable.MaxWidthProperty.GetDefaultValue(AL.Layoutable.MaxWidthProperty.OwnerType);
                    }
                    break;
                case nameof(MinHeight):
                    if (!Equals(MinHeight, value))
                    {
                        MinHeight = (double?)value;
                        NativeControl.MinHeight = MinHeight ?? (double)AL.Layoutable.MinHeightProperty.GetDefaultValue(AL.Layoutable.MinHeightProperty.OwnerType);
                    }
                    break;
                case nameof(MinWidth):
                    if (!Equals(MinWidth, value))
                    {
                        MinWidth = (double?)value;
                        NativeControl.MinWidth = MinWidth ?? (double)AL.Layoutable.MinWidthProperty.GetDefaultValue(AL.Layoutable.MinWidthProperty.OwnerType);
                    }
                    break;
                case nameof(UseLayoutRounding):
                    if (!Equals(UseLayoutRounding, value))
                    {
                        UseLayoutRounding = (bool?)value;
                        NativeControl.UseLayoutRounding = UseLayoutRounding ?? (bool)AL.Layoutable.UseLayoutRoundingProperty.GetDefaultValue(AL.Layoutable.UseLayoutRoundingProperty.OwnerType);
                    }
                    break;
                case nameof(VerticalAlignment):
                    if (!Equals(VerticalAlignment, value))
                    {
                        VerticalAlignment = (AL.VerticalAlignment?)value;
                        NativeControl.VerticalAlignment = VerticalAlignment ?? (AL.VerticalAlignment)AL.Layoutable.VerticalAlignmentProperty.GetDefaultValue(AL.Layoutable.VerticalAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(Width):
                    if (!Equals(Width, value))
                    {
                        Width = (double?)value;
                        NativeControl.Width = Width ?? (double)AL.Layoutable.WidthProperty.GetDefaultValue(AL.Layoutable.WidthProperty.OwnerType);
                    }
                    break;
                case nameof(OnEffectiveViewportChanged):
                    if (!Equals(OnEffectiveViewportChanged, value))
                    {
                        void NativeControlEffectiveViewportChanged(object sender, AL.EffectiveViewportChangedEventArgs e) => InvokeEventCallback(OnEffectiveViewportChanged, e);

                        OnEffectiveViewportChanged = (EventCallback<AL.EffectiveViewportChangedEventArgs>)value;
                        NativeControl.EffectiveViewportChanged -= NativeControlEffectiveViewportChanged;
                        NativeControl.EffectiveViewportChanged += NativeControlEffectiveViewportChanged;
                    }
                    break;
                case nameof(OnLayoutUpdated):
                    if (!Equals(OnLayoutUpdated, value))
                    {
                        void NativeControlLayoutUpdated(object sender, EventArgs e) => InvokeEventCallback(OnLayoutUpdated);

                        OnLayoutUpdated = (EventCallback)value;
                        NativeControl.LayoutUpdated -= NativeControlLayoutUpdated;
                        NativeControl.LayoutUpdated += NativeControlLayoutUpdated;
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
