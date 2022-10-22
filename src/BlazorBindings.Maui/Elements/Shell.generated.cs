// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class Shell : Page
    {
        static Shell()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<Shell>(nameof(FlyoutBackdrop),
                (renderer, parent, component) => new ContentPropertyHandler<MC.Shell>((x, value) => x.FlyoutBackdrop = (MC.Brush)value));
            ElementHandlerRegistry.RegisterPropertyContentHandler<Shell>(nameof(FlyoutBackground),
                (renderer, parent, component) => new ContentPropertyHandler<MC.Shell>((x, value) => x.FlyoutBackground = (MC.Brush)value));
            ElementHandlerRegistry.RegisterPropertyContentHandler<Shell>(nameof(FlyoutContent),
                (renderer, parent, component) => new DataTemplatePropertyHandler<MC.Shell>(component,
                    (x, dataTemplate) => x.FlyoutContentTemplate = dataTemplate));
            ElementHandlerRegistry.RegisterPropertyContentHandler<Shell>(nameof(FlyoutFooter),
                (renderer, parent, component) => new DataTemplatePropertyHandler<MC.Shell>(component,
                    (x, dataTemplate) => x.FlyoutFooterTemplate = dataTemplate));
            ElementHandlerRegistry.RegisterPropertyContentHandler<Shell>(nameof(FlyoutHeader),
                (renderer, parent, component) => new DataTemplatePropertyHandler<MC.Shell>(component,
                    (x, dataTemplate) => x.FlyoutHeaderTemplate = dataTemplate));
            ElementHandlerRegistry.RegisterPropertyContentHandler<Shell>(nameof(ItemTemplate),
                (renderer, parent, component) => new DataTemplatePropertyHandler<MC.Shell, MC.BaseShellItem>(component,
                    (x, dataTemplate) => x.ItemTemplate = dataTemplate));
            ElementHandlerRegistry.RegisterPropertyContentHandler<Shell>(nameof(MenuItemTemplate),
                (renderer, parent, component) => new DataTemplatePropertyHandler<MC.Shell, MC.BaseShellItem>(component,
                    (x, dataTemplate) => x.MenuItemTemplate = dataTemplate));
            RegisterAdditionalHandlers();
        }

        [Parameter] public Color FlyoutBackdropColor { get; set; }
        [Parameter] public Color FlyoutBackgroundColor { get; set; }
        [Parameter] public MC.ImageSource FlyoutBackgroundImage { get; set; }
        [Parameter] public Aspect? FlyoutBackgroundImageAspect { get; set; }
        [Parameter] public FlyoutBehavior? FlyoutBehavior { get; set; }
        [Parameter] public MC.FlyoutHeaderBehavior? FlyoutHeaderBehavior { get; set; }
        [Parameter] public double? FlyoutHeight { get; set; }
        [Parameter] public MC.ImageSource FlyoutIcon { get; set; }
        [Parameter] public bool? FlyoutIsPresented { get; set; }
        [Parameter] public MC.ScrollMode? FlyoutVerticalScrollMode { get; set; }
        [Parameter] public double? FlyoutWidth { get; set; }
        [Parameter] public RenderFragment FlyoutBackdrop { get; set; }
        [Parameter] public RenderFragment FlyoutBackground { get; set; }
        [Parameter] public RenderFragment FlyoutContent { get; set; }
        [Parameter] public RenderFragment FlyoutFooter { get; set; }
        [Parameter] public RenderFragment FlyoutHeader { get; set; }
        [Parameter] public RenderFragment<MC.BaseShellItem> ItemTemplate { get; set; }
        [Parameter] public RenderFragment<MC.BaseShellItem> MenuItemTemplate { get; set; }
        [Parameter] public EventCallback<MC.ShellNavigatedEventArgs> OnNavigated { get; set; }
        [Parameter] public EventCallback<MC.ShellNavigatingEventArgs> OnNavigating { get; set; }

        public new MC.Shell NativeControl => (MC.Shell)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.Shell();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(FlyoutBackdropColor):
                    if (!Equals(FlyoutBackdropColor, value))
                    {
                        FlyoutBackdropColor = (Color)value;
                        NativeControl.FlyoutBackdrop = FlyoutBackdropColor;
                    }
                    break;
                case nameof(FlyoutBackgroundColor):
                    if (!Equals(FlyoutBackgroundColor, value))
                    {
                        FlyoutBackgroundColor = (Color)value;
                        NativeControl.FlyoutBackgroundColor = FlyoutBackgroundColor;
                    }
                    break;
                case nameof(FlyoutBackgroundImage):
                    if (!Equals(FlyoutBackgroundImage, value))
                    {
                        FlyoutBackgroundImage = (MC.ImageSource)value;
                        NativeControl.FlyoutBackgroundImage = FlyoutBackgroundImage;
                    }
                    break;
                case nameof(FlyoutBackgroundImageAspect):
                    if (!Equals(FlyoutBackgroundImageAspect, value))
                    {
                        FlyoutBackgroundImageAspect = (Aspect?)value;
                        NativeControl.FlyoutBackgroundImageAspect = FlyoutBackgroundImageAspect ?? (Aspect)MC.Shell.FlyoutBackgroundImageAspectProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutBehavior):
                    if (!Equals(FlyoutBehavior, value))
                    {
                        FlyoutBehavior = (FlyoutBehavior?)value;
                        NativeControl.FlyoutBehavior = FlyoutBehavior ?? (FlyoutBehavior)MC.Shell.FlyoutBehaviorProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutHeaderBehavior):
                    if (!Equals(FlyoutHeaderBehavior, value))
                    {
                        FlyoutHeaderBehavior = (MC.FlyoutHeaderBehavior?)value;
                        NativeControl.FlyoutHeaderBehavior = FlyoutHeaderBehavior ?? (MC.FlyoutHeaderBehavior)MC.Shell.FlyoutHeaderBehaviorProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutHeight):
                    if (!Equals(FlyoutHeight, value))
                    {
                        FlyoutHeight = (double?)value;
                        NativeControl.FlyoutHeight = FlyoutHeight ?? (double)MC.Shell.FlyoutHeightProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutIcon):
                    if (!Equals(FlyoutIcon, value))
                    {
                        FlyoutIcon = (MC.ImageSource)value;
                        NativeControl.FlyoutIcon = FlyoutIcon;
                    }
                    break;
                case nameof(FlyoutIsPresented):
                    if (!Equals(FlyoutIsPresented, value))
                    {
                        FlyoutIsPresented = (bool?)value;
                        NativeControl.FlyoutIsPresented = FlyoutIsPresented ?? (bool)MC.Shell.FlyoutIsPresentedProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutVerticalScrollMode):
                    if (!Equals(FlyoutVerticalScrollMode, value))
                    {
                        FlyoutVerticalScrollMode = (MC.ScrollMode?)value;
                        NativeControl.FlyoutVerticalScrollMode = FlyoutVerticalScrollMode ?? (MC.ScrollMode)MC.Shell.FlyoutVerticalScrollModeProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutWidth):
                    if (!Equals(FlyoutWidth, value))
                    {
                        FlyoutWidth = (double?)value;
                        NativeControl.FlyoutWidth = FlyoutWidth ?? (double)MC.Shell.FlyoutWidthProperty.DefaultValue;
                    }
                    break;
                case nameof(FlyoutBackdrop):
                    FlyoutBackdrop = (RenderFragment)value;
                    break;
                case nameof(FlyoutBackground):
                    FlyoutBackground = (RenderFragment)value;
                    break;
                case nameof(FlyoutContent):
                    FlyoutContent = (RenderFragment)value;
                    break;
                case nameof(FlyoutFooter):
                    FlyoutFooter = (RenderFragment)value;
                    break;
                case nameof(FlyoutHeader):
                    FlyoutHeader = (RenderFragment)value;
                    break;
                case nameof(ItemTemplate):
                    ItemTemplate = (RenderFragment<MC.BaseShellItem>)value;
                    break;
                case nameof(MenuItemTemplate):
                    MenuItemTemplate = (RenderFragment<MC.BaseShellItem>)value;
                    break;
                case nameof(OnNavigated):
                    if (!Equals(OnNavigated, value))
                    {
                        void NativeControlNavigated(object sender, MC.ShellNavigatedEventArgs e) => InvokeAsync(() => OnNavigated.InvokeAsync(e));

                        OnNavigated = (EventCallback<MC.ShellNavigatedEventArgs>)value;
                        NativeControl.Navigated -= NativeControlNavigated;
                        NativeControl.Navigated += NativeControlNavigated;
                    }
                    break;
                case nameof(OnNavigating):
                    if (!Equals(OnNavigating, value))
                    {
                        void NativeControlNavigating(object sender, MC.ShellNavigatingEventArgs e) => InvokeAsync(() => OnNavigating.InvokeAsync(e));

                        OnNavigating = (EventCallback<MC.ShellNavigatingEventArgs>)value;
                        NativeControl.Navigating -= NativeControlNavigating;
                        NativeControl.Navigating += NativeControlNavigating;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(Shell), FlyoutBackdrop);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(Shell), FlyoutBackground);
            RenderTreeBuilderHelper.AddDataTemplateProperty(builder, sequence++, typeof(Shell), FlyoutContent);
            RenderTreeBuilderHelper.AddDataTemplateProperty(builder, sequence++, typeof(Shell), FlyoutFooter);
            RenderTreeBuilderHelper.AddDataTemplateProperty(builder, sequence++, typeof(Shell), FlyoutHeader);
            RenderTreeBuilderHelper.AddDataTemplateProperty(builder, sequence++, typeof(Shell), ItemTemplate);
            RenderTreeBuilderHelper.AddDataTemplateProperty(builder, sequence++, typeof(Shell), MenuItemTemplate);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
