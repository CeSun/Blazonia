// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.AvaloniaBindings.Elements;
using BlazorBindings.AvaloniaBindings.Elements.Primitives;

namespace BlazorBindings.AvaloniaBindings.Elements.DataTemplates;

internal class InitializedContentView : ContentControl//Control
{
    [Parameter] public new global::Avalonia.Controls.ContentControl NativeControl { get; set; }
    
    protected override global::Avalonia.Controls.ContentControl CreateNativeElement() => NativeControl;

    protected override void HandleParameter(string name, object value)
    {
        if (name == nameof(NativeControl))
        {
            NativeControl = (global::Avalonia.Controls.ContentControl)value;
        }
        else
        {
            base.HandleParameter(name, value);
        }
    }
}
