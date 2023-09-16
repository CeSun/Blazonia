using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using BlazorBindings.AvaloniaBindings.Extensions;

namespace BlazorBindings.AvaloniaBindings.Elements.Handlers;

internal class ApplicationHandler : IContainerElementHandler
{
    private readonly Application _application;

    public ApplicationHandler(Application application)
    {
        _application = application;
    }

    public void AddChild(object child, int physicalSiblingIndex)
    {
        var lifetime = ((IClassicDesktopStyleApplicationLifetime)_application.ApplicationLifetime);

        lifetime.MainWindow = child.Cast<Window>();
    }

    public void RemoveChild(object child, int physicalSiblingIndex)
    {
        // It is not allowed to have no MainPage.
    }

    public object TargetElement => _application;
}
