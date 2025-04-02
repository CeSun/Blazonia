// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACS = Avalonia.Controls.Shapes;
using BlazorBindingsAvalonia.Elements;

#pragma warning disable CA2252

namespace BlazorBindingsAvalonia.Elements.Shapes
{
    /// <summary>
    /// Provides a base class for shape elements, such as <see cref="T:Avalonia.Controls.Shapes.Ellipse" />, <see cref="T:Avalonia.Controls.Shapes.Polygon" /> and <see cref="T:Avalonia.Controls.Shapes.Rectangle" />.
    /// </summary>
    public abstract partial class Shape : BlazorBindingsAvalonia.Elements.Control
    {
        static Shape()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the <see cref="T:Avalonia.Media.IBrush" /> that specifies how the shape's interior is painted.
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.Media.IBrush, string> Fill { get; set; }
        /// <summary>
        /// Gets or sets a <see cref="P:Avalonia.Controls.Shapes.Shape.Stretch" /> enumeration value that describes how the shape fills its allocated space.
        /// </summary>
        [Parameter] public global::Avalonia.Media.Stretch? Stretch { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Avalonia.Media.IBrush" /> that specifies how the shape's outline is painted.
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.Media.IBrush, string> Stroke { get; set; }
        /// <summary>
        /// Gets or sets a collection of <see cref="T:System.Double" /> values that indicate the pattern of dashes and gaps that is used to outline shapes.
        /// </summary>
        [Parameter] public global::Avalonia.Collections.AvaloniaList<double> StrokeDashArray { get; set; }
        /// <summary>
        /// Gets or sets a value that specifies the distance within the dash pattern where a dash begins.
        /// </summary>
        [Parameter] public double? StrokeDashOffset { get; set; }
        /// <summary>
        /// Gets or sets a <see cref="T:Avalonia.Media.PenLineJoin" /> enumeration value that specifies the type of join that is used at the vertices of a Shape.
        /// </summary>
        [Parameter] public global::Avalonia.Media.PenLineJoin? StrokeJoin { get; set; }
        /// <summary>
        /// Gets or sets a <see cref="T:Avalonia.Media.PenLineCap" /> enumeration value that describes the shape at the ends of a line.
        /// </summary>
        [Parameter] public global::Avalonia.Media.PenLineCap? StrokeLineCap { get; set; }
        /// <summary>
        /// Gets or sets the width of the shape outline.
        /// </summary>
        [Parameter] public double? StrokeThickness { get; set; }

        public new ACS.Shape NativeControl => (ACS.Shape)((AvaloniaObject)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Fill):
                    if (!Equals(Fill, value))
                    {
                        Fill = (OneOf.OneOf<global::Avalonia.Media.IBrush,string>)value;
                        if (Fill.IsT0)
                        {
                            NativeControl.Fill = (global::Avalonia.Media.IBrush)Fill.AsT0;
                        }
                        else 
                        {
                            NativeControl.Fill = Avalonia.Media.Brush.Parse(Fill.AsT1);
                        }
                    }
                    break;
                case nameof(Stretch):
                    if (!Equals(Stretch, value))
                    {
                        Stretch = (global::Avalonia.Media.Stretch?)value;
                        NativeControl.Stretch = Stretch ?? (global::Avalonia.Media.Stretch)ACS.Shape.StretchProperty.GetDefaultValue(ACS.Shape.StretchProperty.OwnerType);
                    }
                    break;
                case nameof(Stroke):
                    if (!Equals(Stroke, value))
                    {
                        Stroke = (OneOf.OneOf<global::Avalonia.Media.IBrush,string>)value;
                        if (Stroke.IsT0)
                        {
                            NativeControl.Stroke = (global::Avalonia.Media.IBrush)Stroke.AsT0;
                        }
                        else 
                        {
                            NativeControl.Stroke = Avalonia.Media.Brush.Parse(Stroke.AsT1);
                        }
                    }
                    break;
                case nameof(StrokeDashArray):
                    if (!Equals(StrokeDashArray, value))
                    {
                        StrokeDashArray = (global::Avalonia.Collections.AvaloniaList<double>)value;
                        NativeControl.StrokeDashArray = StrokeDashArray;
                    }
                    break;
                case nameof(StrokeDashOffset):
                    if (!Equals(StrokeDashOffset, value))
                    {
                        StrokeDashOffset = (double?)value;
                        NativeControl.StrokeDashOffset = StrokeDashOffset ?? (double)ACS.Shape.StrokeDashOffsetProperty.GetDefaultValue(ACS.Shape.StrokeDashOffsetProperty.OwnerType);
                    }
                    break;
                case nameof(StrokeJoin):
                    if (!Equals(StrokeJoin, value))
                    {
                        StrokeJoin = (global::Avalonia.Media.PenLineJoin?)value;
                        NativeControl.StrokeJoin = StrokeJoin ?? (global::Avalonia.Media.PenLineJoin)ACS.Shape.StrokeJoinProperty.GetDefaultValue(ACS.Shape.StrokeJoinProperty.OwnerType);
                    }
                    break;
                case nameof(StrokeLineCap):
                    if (!Equals(StrokeLineCap, value))
                    {
                        StrokeLineCap = (global::Avalonia.Media.PenLineCap?)value;
                        NativeControl.StrokeLineCap = StrokeLineCap ?? (global::Avalonia.Media.PenLineCap)ACS.Shape.StrokeLineCapProperty.GetDefaultValue(ACS.Shape.StrokeLineCapProperty.OwnerType);
                    }
                    break;
                case nameof(StrokeThickness):
                    if (!Equals(StrokeThickness, value))
                    {
                        StrokeThickness = (double?)value;
                        NativeControl.StrokeThickness = StrokeThickness ?? (double)ACS.Shape.StrokeThicknessProperty.GetDefaultValue(ACS.Shape.StrokeThicknessProperty.OwnerType);
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
