using BlazorBindings.Maui.UriNavigation;
using Microsoft.AspNetCore.Components.Routing;

namespace BlazorBindings.Maui;

// We cannot add Navigation services to common ServiceProvider as it leads to conflicts
// with Blazor navigation for hybrid apps.
// Therefore this wrapper is created to override those services for MBB cases only.
// Any better approach?...
internal class MauiBlazorBindingsServiceProvider : IServiceProvider
{
    private readonly IServiceProvider _serviceProvider;
    private NavigationManager _navigationManager;
    private INavigationInterception _navigationInterception;

    public MauiBlazorBindingsServiceProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public object GetService(Type serviceType)
    {
        if (serviceType == typeof(NavigationManager))
            return _navigationManager ??= new MbbNavigationManager();

        if (serviceType == typeof(INavigationInterception))
            return _navigationInterception ??= new MbbNavigationInterception();

        return _serviceProvider.GetService(serviceType);
    }
}
