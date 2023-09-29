using Microsoft.AspNetCore.Components.Routing;

namespace BlazorBindings.AvaloniaBindings.UriNavigation;

internal class BlazorScrollToLocationHash : IScrollToLocationHash
{
    public Task RefreshScrollPositionForHash(string locationAbsolute) => Task.CompletedTask;
}
