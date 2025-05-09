// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using System.Collections.Generic;

#pragma warning disable CA2252

namespace Blazonia.Components
{
    /// <summary>
    /// Base class for top-level widgets.
    /// </summary>
    public abstract partial class TopLevel : ContentControl
    {
        static TopLevel()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public global::Avalonia.Styling.ThemeVariant RequestedThemeVariant { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Avalonia.Media.IBrush" /> that transparency will blend with when transparency is not supported. By default this is a solid white brush.
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.Media.IBrush, global::Avalonia.Media.Color, string> TransparencyBackgroundFallback { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Avalonia.Controls.WindowTransparencyLevel" /> that the TopLevel should use when possible. Accepts multiple values which are applied in a fallback order. For instance, with "Mica, Blur" Mica will be applied only on platforms where it is possible, and Blur will be used on the rest of them. Default value is an empty array or "None".
        /// </summary>
        [Parameter] public IReadOnlyList<AC.WindowTransparencyLevel> TransparencyLevelHint { get; set; }
        [Parameter] public EventCallback OnOpened { get; set; }
        [Parameter] public EventCallback OnClosed { get; set; }
        [Parameter] public EventCallback OnScalingChanged { get; set; }
        [Parameter] public EventCallback<global::Avalonia.Interactivity.RoutedEventArgs> OnBackRequested { get; set; }

        public new AC.TopLevel NativeControl => (AC.TopLevel)((AvaloniaObject)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(RequestedThemeVariant):
                    if (!Equals(RequestedThemeVariant, value))
                    {
                        RequestedThemeVariant = (global::Avalonia.Styling.ThemeVariant)value;
                        NativeControl.RequestedThemeVariant = RequestedThemeVariant;
                    }
                    break;
                case nameof(TransparencyBackgroundFallback):
                    if (!Equals(TransparencyBackgroundFallback, value))
                    {
                        TransparencyBackgroundFallback = (OneOf.OneOf<global::Avalonia.Media.IBrush, Avalonia.Media.Color, string>)value;
                        if (TransparencyBackgroundFallback.IsT0)
                        {
                            NativeControl.TransparencyBackgroundFallback = (global::Avalonia.Media.IBrush)TransparencyBackgroundFallback.AsT0;
                        }
                        else if (TransparencyBackgroundFallback.IsT1)
                        {
                            NativeControl.TransparencyBackgroundFallback = new global::Avalonia.Media.Immutable.ImmutableSolidColorBrush(TransparencyBackgroundFallback.AsT1);
                        }
                        else 
                        {
                            NativeControl.TransparencyBackgroundFallback = Avalonia.Media.Brush.Parse(TransparencyBackgroundFallback.AsT2);
                        }
                    }
                    break;
                case nameof(TransparencyLevelHint):
                    if (!Equals(TransparencyLevelHint, value))
                    {
                        TransparencyLevelHint = (IReadOnlyList<AC.WindowTransparencyLevel>)value;
                        NativeControl.TransparencyLevelHint = TransparencyLevelHint;
                    }
                    break;
                case nameof(OnOpened):
                    if (!Equals(OnOpened, value))
                    {
                        void NativeControlOpened(object sender, EventArgs e) => InvokeEventCallback(OnOpened);

                        OnOpened = (EventCallback)value;
                        NativeControl.Opened -= NativeControlOpened;
                        NativeControl.Opened += NativeControlOpened;
                    }
                    break;
                case nameof(OnClosed):
                    if (!Equals(OnClosed, value))
                    {
                        void NativeControlClosed(object sender, EventArgs e) => InvokeEventCallback(OnClosed);

                        OnClosed = (EventCallback)value;
                        NativeControl.Closed -= NativeControlClosed;
                        NativeControl.Closed += NativeControlClosed;
                    }
                    break;
                case nameof(OnScalingChanged):
                    if (!Equals(OnScalingChanged, value))
                    {
                        void NativeControlScalingChanged(object sender, EventArgs e) => InvokeEventCallback(OnScalingChanged);

                        OnScalingChanged = (EventCallback)value;
                        NativeControl.ScalingChanged -= NativeControlScalingChanged;
                        NativeControl.ScalingChanged += NativeControlScalingChanged;
                    }
                    break;
                case nameof(OnBackRequested):
                    if (!Equals(OnBackRequested, value))
                    {
                        void NativeControlBackRequested(object sender, global::Avalonia.Interactivity.RoutedEventArgs e) => InvokeEventCallback(OnBackRequested, e);

                        OnBackRequested = (EventCallback<global::Avalonia.Interactivity.RoutedEventArgs>)value;
                        NativeControl.BackRequested -= NativeControlBackRequested;
                        NativeControl.BackRequested += NativeControlBackRequested;
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
