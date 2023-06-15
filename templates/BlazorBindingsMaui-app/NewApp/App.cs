using BlazorBindings.Maui;

namespace NewApp;

public class App : BlazorBindingsApplication<AppShell>
{
    public App(IServiceProvider services) : base(services)
    {
    }
}
