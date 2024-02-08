using Avalonia.Controls;

namespace BlazorBindings.AvaloniaBindings.Navigation;

internal class ItemsControlWithItemContainer : ItemsControl
{
    protected override bool NeedsContainerOverride(object item, int index, out object recycleKey)
    {
        recycleKey = DefaultRecycleKey;
        return true;
    }
}