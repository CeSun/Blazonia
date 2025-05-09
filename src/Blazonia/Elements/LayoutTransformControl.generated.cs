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
    /// Control that implements support for transformations as if applied by LayoutTransform.
    /// </summary>
    public partial class LayoutTransformControl : Decorator
    {
        static LayoutTransformControl()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a graphics transformation that should apply to this element when layout is performed.
        /// </summary>
        [Parameter] public global::Avalonia.Media.ITransform LayoutTransform { get; set; }
        /// <summary>
        /// Utilize the <see cref="F:Avalonia.Visual.RenderTransformProperty" /> for layout transforms.
        /// </summary>
        [Parameter] public bool? UseRenderTransform { get; set; }

        public new AC.LayoutTransformControl NativeControl => (AC.LayoutTransformControl)((AvaloniaObject)this).NativeControl;

        protected override AvaloniaBindableObject CreateNativeElement() => new AC.LayoutTransformControl();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(LayoutTransform):
                    if (!Equals(LayoutTransform, value))
                    {
                        LayoutTransform = (global::Avalonia.Media.ITransform)value;
                        NativeControl.LayoutTransform = LayoutTransform;
                    }
                    break;
                case nameof(UseRenderTransform):
                    if (!Equals(UseRenderTransform, value))
                    {
                        UseRenderTransform = (bool?)value;
                        NativeControl.UseRenderTransform = UseRenderTransform ?? (bool)AC.LayoutTransformControl.UseRenderTransformProperty.GetDefaultValue(AC.LayoutTransformControl.UseRenderTransformProperty.OwnerType);
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
