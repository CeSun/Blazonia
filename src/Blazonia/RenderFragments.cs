﻿namespace Blazonia;

internal static class RenderFragments
{
    public static RenderFragment FromComponentType(Type componentType, Dictionary<string, object> parameters = null)
    {
        return builder =>
        {
            builder.OpenComponent(1, componentType);

            if (parameters != null)
            {
                builder.AddMultipleAttributes(2, parameters);
            }

            builder.CloseComponent();
        };
    }
}
