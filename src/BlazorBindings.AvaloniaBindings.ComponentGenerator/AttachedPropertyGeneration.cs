using System;

namespace BlazorBindings.AvaloniaBindings.ComponentGenerator;

[Flags]
public enum AttachedPropertyGeneration
{
    ExtensionMethods = 1,
    Elements = 2
}
