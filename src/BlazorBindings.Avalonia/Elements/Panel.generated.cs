// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AC = Avalonia.Controls;
using BlazorBindings.Core;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// Base class for controls that can contain multiple children.
    /// </summary>
    public partial class Panel : Control
    {
        static Panel()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or Sets Panel background brush.
        /// </summary>
        [Parameter] public global::Avalonia.Media.IBrush Background { get; set; }
        /// <summary>
        /// Gets the children of the <see cref="T:Avalonia.Controls.Panel" />.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }

        public new AC.Panel NativeControl => (AC.Panel)((BindableObject)this).NativeControl;

        protected override AC.Panel CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Background):
                    if (!Equals(Background, value))
                    {
                        Background = (global::Avalonia.Media.IBrush)value;
                        NativeControl.Background = Background;
                    }
                    break;
                case nameof(ChildContent):
                    ChildContent = (RenderFragment)value;
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddListContentProperty<AC.Panel, AC.Control>(builder, sequence++, ChildContent, x => x.Children);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
