using Microsoft.AspNetCore.Components.Routing;

namespace BlazorBindings.AvaloniaBindings.UriNavigation;

internal class MbbNavigationInterception : INavigationInterception
{
    public Task EnableNavigationInterceptionAsync() => Task.CompletedTask;
}
