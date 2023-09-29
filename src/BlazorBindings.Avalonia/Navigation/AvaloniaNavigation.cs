using Avalonia.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlazorBindings.AvaloniaBindings.Navigation;

public class AvaloniaNavigation : INotifyPropertyChanged
{
    private Control _currentPage;
    private readonly NavigationView navigationView;

    public Stack<Control> ModalStack { get; internal set; } = new Stack<Control>();
    public Stack<Control> NavigationStack { get; internal set; } = new Stack<Control>();

    public event PropertyChangedEventHandler PropertyChanged;

    public AvaloniaNavigation(NavigationView navigationView)
    {
        this.navigationView = navigationView;
        this.navigationView.DataContext = this;
    }

    public Control CurrentPage { get => _currentPage; private set => Raise(ref _currentPage, value); }

    private void Raise<T>(ref T target, T value, [CallerMemberName] string propertyName = null)
    {
        if (target?.Equals(value) != true)
        {
            target = value;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public async Task PopAsync(bool animated)
    {
        NavigationStack.Pop();

        UpdateCurrentPage();
    }

    private void UpdateCurrentPage()
    {
        NavigationStack.TryPeek(out var current);

        CurrentPage = current;
    }

    public async Task PopModalAsync(bool animated)
    {
        ModalStack.TryPop(out _);
    }

    public async Task PopToRootAsync(bool animated)
    {
        while (NavigationStack.Count > 1)
        {
            NavigationStack.Pop();
        }
    }

    public async Task PushAsync(AvaloniaPage child, bool animated)
    {
        NavigationStack.Push(child);

        UpdateCurrentPage();
    }

    public async Task PushModalAsync(AvaloniaPage child, bool animated)
    {
        ModalStack.Push(child);
    }

    public void RemovePage(AvaloniaPage child)
    {
        if (NavigationStack.Contains(child))
        {
            var list = new List<Control>();
            while (NavigationStack.TryPop(out var page))
            {
                if (page == child)
                {
                    break;
                }
                else
                {
                    list.Add(page);
                }
            }

            for (var i = list.Count - 1; i >= 0; i++)
            {
                NavigationStack.Push(list[i]);
            }
        }
        else if (ModalStack.Contains(child))
        {
            var list = new List<Control>();
            while (ModalStack.TryPop(out var page))
            {
                if (page == child)
                {
                    break;
                }
                else
                {
                    list.Add(page);
                }
            }

            for (var i = list.Count - 1; i >= 0; i++)
            {
                ModalStack.Push(list[i]);
            }
        }
    }
}