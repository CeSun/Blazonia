// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AM = Avalonia.Media;
using Blazonia.Components;

#pragma warning disable CA2252

namespace Blazonia.Components.Media
{
    /// <summary>
    /// Paints an area with a radial gradient.
    /// </summary>
    public partial class RadialGradientBrush : GradientBrush
    {
        static RadialGradientBrush()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the start point for the gradient.
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.RelativePoint?, string> Center { get; set; }
        /// <summary>
        /// Gets or sets the location of the two-dimensional focal point that defines the beginning of the gradient.
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.RelativePoint?, string> GradientOrigin { get; set; }
        /// <summary>
        /// Gets or sets the horizontal radius of the outermost circle of the radial gradient.
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.RelativeScalar?, string> RadiusX { get; set; }
        /// <summary>
        /// Gets or sets the vertical radius of the outermost circle of the radial gradient.
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.RelativeScalar?, string> RadiusY { get; set; }

        public new AM.RadialGradientBrush NativeControl => (AM.RadialGradientBrush)((AvaloniaObject)this).NativeControl;

        protected override AvaloniaBindableObject CreateNativeElement() => new AM.RadialGradientBrush();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Center):
                    if (!Equals(Center, value))
                    {
                        Center = (OneOf.OneOf<global::Avalonia.RelativePoint?,string>)value;
                        if (Center.IsT0)
                        {
                            NativeControl.Center = (global::Avalonia.RelativePoint)Center.AsT0;
                        }
                        else 
                        {
                            NativeControl.Center = global::Avalonia.RelativePoint.Parse(Center.AsT1);
                        }
                    }
                    break;
                case nameof(GradientOrigin):
                    if (!Equals(GradientOrigin, value))
                    {
                        GradientOrigin = (OneOf.OneOf<global::Avalonia.RelativePoint?,string>)value;
                        if (GradientOrigin.IsT0)
                        {
                            NativeControl.GradientOrigin = (global::Avalonia.RelativePoint)GradientOrigin.AsT0;
                        }
                        else 
                        {
                            NativeControl.GradientOrigin = global::Avalonia.RelativePoint.Parse(GradientOrigin.AsT1);
                        }
                    }
                    break;
                case nameof(RadiusX):
                    if (!Equals(RadiusX, value))
                    {
                        RadiusX = (OneOf.OneOf<global::Avalonia.RelativeScalar?,string>)value;
                        if (RadiusX.IsT0)
                        {
                            NativeControl.RadiusX = (global::Avalonia.RelativeScalar)RadiusX.AsT0;
                        }
                        else 
                        {
                            NativeControl.RadiusX = global::Avalonia.RelativeScalar.Parse(RadiusX.AsT1);
                        }
                    }
                    break;
                case nameof(RadiusY):
                    if (!Equals(RadiusY, value))
                    {
                        RadiusY = (OneOf.OneOf<global::Avalonia.RelativeScalar?,string>)value;
                        if (RadiusY.IsT0)
                        {
                            NativeControl.RadiusY = (global::Avalonia.RelativeScalar)RadiusY.AsT0;
                        }
                        else 
                        {
                            NativeControl.RadiusY = global::Avalonia.RelativeScalar.Parse(RadiusY.AsT1);
                        }
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
