using Microsoft.AspNetCore.Components.Routing;

namespace BlazorBindings.Maui.UriNavigation;

internal class NavigationInterception : INavigationInterception
{
    public Task EnableNavigationInterceptionAsync() => Task.CompletedTask;
}
