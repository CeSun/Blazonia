// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using MC = Microsoft.Maui.Controls;

namespace BlazorBindings.Maui.Elements
{
    public partial class BaseShellItem : NavigableElement
    {
        static partial void RegisterAdditionalHandlers()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<BaseShellItem>(nameof(ItemTemplate),
                (renderer, _, component) => new DataTemplatePropertyHandler<MC.BaseShellItem, MC.BaseShellItem>(component,
                    (shellItem, dataTemplate) => MC.Shell.SetItemTemplate(shellItem, dataTemplate)));
        }

        [Parameter] public EventCallback OnAppearing { get; set; }
        [Parameter] public EventCallback OnDisappearing { get; set; }
        [Parameter] public RenderFragment<MC.BaseShellItem> ItemTemplate { get; set; }

        partial void RenderAdditionalAttributes(AttributesBuilder builder)
        {
            builder.AddAttribute("onappearing", OnAppearing);
            builder.AddAttribute("ondisappearing", OnDisappearing);
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);

            RenderTreeBuilderHelper.AddDataTemplateProperty(builder, sequence++, typeof(BaseShellItem), ItemTemplate);
        }
    }
}
