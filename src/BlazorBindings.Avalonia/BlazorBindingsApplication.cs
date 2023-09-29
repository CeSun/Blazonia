﻿using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using BlazorBindings.AvaloniaBindings.Navigation;

namespace BlazorBindings.AvaloniaBindings;
public class BlazorBindingsApplication<T> : Application, IAvaloniaBlazorApplication
    where T : IComponent
{
    private IServiceProvider _serviceProvider = null;
    private AvaloniaNavigation _avaloniaNavigation = null;
    
    public BlazorBindingsApplication()
    {
    }

    public IServiceProvider ServiceProvider => _serviceProvider;

    public AvaloniaNavigation Navigation => _avaloniaNavigation;

    public void Initialize(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;

        Configure();

        var renderer = serviceProvider.GetRequiredService<AvaloniaBlazorBindingsRenderer>();

        if (WrapperComponentType != null)
        {
            var navigation = _serviceProvider.GetService<INavigation>();
            (navigation as BlazorNavigation)?.SetWrapperComponentType(WrapperComponentType);
        }

        var (componentType, parameters) = GetComponentToRender();
        var task = renderer.AddComponent(componentType, this, parameters);
        AwaitVoid(task);

        var navigationView = new NavigationView();
        _avaloniaNavigation = new AvaloniaNavigation(navigationView);
        var pushTask = _avaloniaNavigation.PushAsync((Control)((IClassicDesktopStyleApplicationLifetime)Avalonia.Application.Current.ApplicationLifetime).MainWindow.Content, false);

        ((IClassicDesktopStyleApplicationLifetime)Avalonia.Application.Current.ApplicationLifetime).MainWindow.Content = navigationView;

        AwaitVoid(pushTask);

        static async void AwaitVoid(Task task) => await task;
    }

    public virtual Type WrapperComponentType { get; }

    /// <summary>
    /// This method is executed before the rendering. It can be used to set resources, for example.
    /// </summary>
    protected virtual void Configure() { }

    private (Type ComponentType, Dictionary<string, object> Parameters) GetComponentToRender()
    {
        if (WrapperComponentType is null)
        {
            return (typeof(T), null);
        }
        else
        {
            var parameters = new Dictionary<string, object>
            {
                ["ChildContent"] = RenderFragments.FromComponentType(typeof(T))
            };
            return (WrapperComponentType, parameters);
        }
    }
}
