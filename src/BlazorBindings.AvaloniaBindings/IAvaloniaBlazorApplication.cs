using BlazorBindings.AvaloniaBindings.Navigation;

namespace BlazorBindings.AvaloniaBindings;

public interface IAvaloniaBlazorApplication
{
    IServiceProvider ServiceProvider { get; }

    void Initialize(IServiceProvider serviceProvider);

    AvaloniaNavigation Navigation { get; }
}
