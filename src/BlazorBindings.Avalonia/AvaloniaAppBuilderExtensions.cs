// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.Extensions.Logging;
using AvaloniaAppBuilder = global::Avalonia.AppBuilder;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorBindings.AvaloniaBindings;

public static class AvaloniaAppBuilderExtensions
{
    public static AvaloniaAppBuilder UseAvaloniaBlazorBindings(this AvaloniaAppBuilder builder, Action<IServiceCollection> configureServices)
    {   
        ArgumentNullException.ThrowIfNull(builder);

        // Use factories for performance.
        builder.AfterSetup(b =>
        {
            var services = new ServiceCollection();

            configureServices?.Invoke(services);
            //.TryAddSingleton<Navigation>(svcs => new Navigation(svcs.GetRequiredService<AvaloniaBlazorBindingsServiceProvider>()))
            //.TryAddSingleton<INavigation>(services => services.GetRequiredService<Navigation>())
            services.TryAddSingleton(svcs => new AvaloniaBlazorBindingsRenderer(svcs.GetRequiredService<AvaloniaBlazorBindingsServiceProvider>(), svcs.GetRequiredService<ILoggerFactory>()));
            services.TryAddSingleton(svcs => new AvaloniaBlazorBindingsServiceProvider(svcs));
            services.AddLogging();

            var serviceProvider = services.BuildServiceProvider();

            b.With(serviceProvider);


            ((IAvaloniaBlazorInitialize)b.Instance).Initialize(serviceProvider);
        });

        return builder;
    }
}
