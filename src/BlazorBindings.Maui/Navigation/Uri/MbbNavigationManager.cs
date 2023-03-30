namespace BlazorBindings.Maui.UriNavigation;

internal class MbbNavigationManager : NavigationManager
{
    protected override void EnsureInitialized()
    {
        Initialize("app:///", "app:///");
    }

    protected override void NavigateToCore(string uri, NavigationOptions options)
    {
        Uri = ToAbsoluteUri(uri).AbsoluteUri;
        NotifyLocationChanged(false);
    }
}
