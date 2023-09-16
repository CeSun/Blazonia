using Microsoft.AspNetCore.Components.Routing;

namespace BlazorBindings.AvaloniaBindings.UriNavigation;

internal class MbbScrollToLocationHash : IScrollToLocationHash
{
    public Task RefreshScrollPositionForHash(string locationAbsolute) => Task.CompletedTask;
}
