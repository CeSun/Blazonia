using Microsoft.AspNetCore.Components.Routing;

namespace BlazorBindings.Maui.UriNavigation;

internal class MbbNavigationInterception : INavigationInterception
{
    public Task EnableNavigationInterceptionAsync() => Task.CompletedTask;
}
