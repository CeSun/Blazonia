using BlazorBindings.Maui;

namespace ValidationsSample;

public class App : BlazorBindingsApplication<LoginPage>
{
    public App(IServiceProvider services) : base(services)
    {
    }
}
