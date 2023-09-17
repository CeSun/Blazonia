using Avalonia.Themes.Fluent;
using BlazorBindings.AvaloniaBindings;
using System;

namespace BlazorBindings.Avalonia.HelloWorld;

public class AppBlazor : BlazorBindingsApplication<MainPage>
{
    public AppBlazor()
    {
        Styles.Add(new FluentTheme());
    }
    //public AppBlazor(IServiceProvider services)
    //    : base(services)
    //{
    //}
}
