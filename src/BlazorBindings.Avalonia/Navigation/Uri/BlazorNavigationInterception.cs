using Microsoft.AspNetCore.Components.Routing;

namespace BlazorBindings.AvaloniaBindings.UriNavigation;

internal class BlazorNavigationInterception : INavigationInterception
{
    public Task EnableNavigationInterceptionAsync() => Task.CompletedTask;
}
