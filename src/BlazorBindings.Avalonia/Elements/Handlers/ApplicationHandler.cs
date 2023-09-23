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
            if (child is AC.Window w)
            {
                classic.MainWindow = w;
            }
            else
            {
                classic.MainWindow = new AC.Window()
                {
                    Content = child.Cast<AC.Control>()
                };
            }
        }
        else if (_application.ApplicationLifetime is ISingleViewApplicationLifetime single)
        {
            single.MainView = child.Cast<AC.Control>();
        }
    }

    public void RemoveChild(object child, int physicalSiblingIndex)
    {
        // It is not allowed to have no MainPage.
    }

    public object TargetElement => _application;
}
