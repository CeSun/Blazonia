namespace BlazorBindings.AvaloniaBindings;

public interface IAvaloniaBlazorInitialize
{
    void Initialize(IServiceProvider serviceProvider);
}
public class BlazorBindingsApplication<T> : Application, IAvaloniaBlazorInitialize
    where T : IComponent
{
    public BlazorBindingsApplication()
    {
    }

    public void Initialize(IServiceProvider serviceProvider)
    {
        Configure();

        var renderer = serviceProvider.GetRequiredService<AvaloniaBlazorBindingsRenderer>();

        if (WrapperComponentType != null)
        {
            //var navigation = services.GetService<INavigation>();
            //(navigation as Navigation)?.SetWrapperComponentType(WrapperComponentType);
        }

        var (componentType, parameters) = GetComponentToRender();
        var task = renderer.AddComponent(componentType, this, parameters);
        AwaitVoid(task);

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
