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
        if (_application.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime classic)
        {
            if (child is global::Avalonia.Controls.Window w)
            {
                classic.MainWindow = w;
            }
            else
            {
                classic.MainWindow = new global::Avalonia.Controls.Window()
                {
                    Content = child.Cast<global::Avalonia.Controls.Control>()
                };
            }
        }
        else if (_application.ApplicationLifetime is ISingleViewApplicationLifetime single)
        {
            single.MainView = child.Cast<global::Avalonia.Controls.Control>();
        }
    }

    public void RemoveChild(object child, int physicalSiblingIndex)
    {
        // It is not allowed to have no MainPage.
    }

    public object TargetElement => _application;
}
