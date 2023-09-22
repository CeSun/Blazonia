//using AC = Avalonia.Controls;

//namespace BlazorBindings.AvaloniaBindings;

//internal class NavigationHandler : IContainerElementHandler
//{
//    private readonly NavigationTarget _target;
//    private readonly AC.INavigation _navigation;
//    private readonly bool _animated;
//    private readonly TaskCompletionSource _taskCompletionSource = new();
//    private AC.Page _currentPage;
//    private bool _firstAdd = true;

//    public NavigationHandler(AC.INavigation navigation, NavigationTarget target, bool animated)
//    {
//        _target = target;
//        _navigation = navigation;
//        _animated = animated;
//    }

//    public Task WaitForNavigation() => _taskCompletionSource.Task;
//    public event Action PageClosed;

//    public async Task AddChildAsync(AC.Page child)
//    {
//        _currentPage = child;

//        if (_target == NavigationTarget.Modal)
//        {
//            await _navigation.PushModalAsync(child, _firstAdd && _animated);
//        }
//        else
//        {
//            await _navigation.PushAsync(child, _firstAdd && _animated);
//        }

//        _taskCompletionSource.TrySetResult();
//        _firstAdd = false;

//        child.ParentChanged += ParentChanged;
//    }

//    public async Task RemoveChildAsync(AC.Page child)
//    {
//        child.ParentChanged -= ParentChanged;
//        if (_target == NavigationTarget.Modal)
//        {
//            if (_navigation.ModalStack.LastOrDefault() == child)
//            {
//                await _navigation.PopModalAsync(animated: false);
//            }
//        }
//        else
//        {
//            if (_navigation.NavigationStack.Contains(child))
//                _navigation.RemovePage(child);
//        }
//    }

//    private void ParentChanged(object sender, EventArgs e)
//    {
//        var page = sender as AC.Page;

//        if (page == _currentPage && page.Parent == null)
//        {
//            // Notify that the page is closed so that rootComponent could be removed from Blazor tree.
//            PageClosed?.Invoke();
//        }

//        page.ParentChanged -= ParentChanged;
//    }

//    public async void RemoveChild(object child, int physicalSiblingIndex)
//    {
//        await RemoveChildAsync((AC.Page)child);
//    }

//    public async void AddChild(object child, int physicalSiblingIndex)
//    {
//        await AddChildAsync((AC.Page)child);
//    }

//    public object TargetElement => null;
//}
