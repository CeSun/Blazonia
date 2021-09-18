// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using System.Threading.Tasks;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public abstract partial class Layout : View
    {
        static Layout()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public bool? IgnoreSafeArea { get; set; }
        [Parameter] public Thickness? Padding { get; set; }

        public new MC.Layout NativeControl => ((LayoutHandler)ElementHandler).LayoutControl;

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            if (IgnoreSafeArea != null)
            {
                builder.AddAttribute(nameof(IgnoreSafeArea), IgnoreSafeArea.Value);
            }
            if (Padding != null)
            {
                builder.AddAttribute(nameof(Padding), AttributeHelper.ThicknessToString(Padding.Value));
            }

            RenderAdditionalAttributes(builder);
        }

        partial void RenderAdditionalAttributes(AttributesBuilder builder);

        static partial void RegisterAdditionalHandlers();
    }
}
