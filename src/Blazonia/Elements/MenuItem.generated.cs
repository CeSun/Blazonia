// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using System.Windows.Input;

#pragma warning disable CA2252

namespace Blazonia.Components
{
    /// <summary>
    /// A menu item control.
    /// </summary>
    public partial class MenuItem<T> : Blazonia.Components.Primitives.HeaderedSelectingItemsControl<T>
    {
        static MenuItem()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the command associated with the menu item.
        /// </summary>
        [Parameter] public ICommand Command { get; set; }
        /// <summary>
        /// Gets or sets the parameter to pass to the <see cref="P:Avalonia.Controls.MenuItem.Command" /> property of a <see cref="T:Avalonia.Controls.MenuItem" />.
        /// </summary>
        [Parameter] public object CommandParameter { get; set; }
        [Parameter] public string GroupName { get; set; }
        /// <summary>
        /// Gets or sets an <see cref="T:Avalonia.Input.KeyGesture" /> associated with this control
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.Input.KeyGesture, string> HotKey { get; set; }
        /// <summary>
        /// Gets or sets the icon that appears in a <see cref="T:Avalonia.Controls.MenuItem" />.
        /// </summary>
        [Parameter] public object Icon { get; set; }
        /// <summary>
        /// Gets or sets the input gesture that will be displayed in the menu item.
        /// </summary>
        [Parameter] public OneOf.OneOf<global::Avalonia.Input.KeyGesture, string> InputGesture { get; set; }
        [Parameter] public bool? IsChecked { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="T:Avalonia.Controls.MenuItem" /> is currently selected.
        /// </summary>
        [Parameter] public bool? IsSelected { get; set; }
        /// <summary>
        /// Gets or sets a value that indicates whether the submenu of the <see cref="T:Avalonia.Controls.MenuItem" /> is open.
        /// </summary>
        [Parameter] public bool? IsSubMenuOpen { get; set; }
        /// <summary>
        /// Gets or sets a value that indicates the submenu that this <see cref="T:Avalonia.Controls.MenuItem" /> is within should not close when this item is clicked.
        /// </summary>
        [Parameter] public bool? StaysOpenOnClick { get; set; }
        [Parameter] public AC.MenuItemToggleType? ToggleType { get; set; }
        [Parameter] public EventCallback<global::Avalonia.Interactivity.RoutedEventArgs> OnClick { get; set; }
        [Parameter] public EventCallback<global::Avalonia.Interactivity.RoutedEventArgs> OnPointerEnteredItem { get; set; }
        [Parameter] public EventCallback<global::Avalonia.Interactivity.RoutedEventArgs> OnPointerExitedItem { get; set; }
        [Parameter] public EventCallback<global::Avalonia.Interactivity.RoutedEventArgs> OnSubmenuOpened { get; set; }

        public new AC.MenuItem NativeControl => (AC.MenuItem)((AvaloniaObject)this).NativeControl;

        protected override AvaloniaBindableObject CreateNativeElement() => new AC.MenuItem();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Command):
                    if (!Equals(Command, value))
                    {
                        Command = (ICommand)value;
                        NativeControl.Command = Command;
                    }
                    break;
                case nameof(CommandParameter):
                    if (!Equals(CommandParameter, value))
                    {
                        CommandParameter = (object)value;
                        NativeControl.CommandParameter = CommandParameter;
                    }
                    break;
                case nameof(GroupName):
                    if (!Equals(GroupName, value))
                    {
                        GroupName = (string)value;
                        NativeControl.GroupName = GroupName;
                    }
                    break;
                case nameof(HotKey):
                    if (!Equals(HotKey, value))
                    {
                        HotKey = (OneOf.OneOf<global::Avalonia.Input.KeyGesture,string>)value;
                        if (HotKey.IsT0)
                        {
                            NativeControl.HotKey = (global::Avalonia.Input.KeyGesture)HotKey.AsT0;
                        }
                        else 
                        {
                            NativeControl.HotKey = global::Avalonia.Input.KeyGesture.Parse(HotKey.AsT1);
                        }
                    }
                    break;
                case nameof(Icon):
                    if (!Equals(Icon, value))
                    {
                        Icon = (object)value;
                        NativeControl.Icon = Icon;
                    }
                    break;
                case nameof(InputGesture):
                    if (!Equals(InputGesture, value))
                    {
                        InputGesture = (OneOf.OneOf<global::Avalonia.Input.KeyGesture,string>)value;
                        if (InputGesture.IsT0)
                        {
                            NativeControl.InputGesture = (global::Avalonia.Input.KeyGesture)InputGesture.AsT0;
                        }
                        else 
                        {
                            NativeControl.InputGesture = global::Avalonia.Input.KeyGesture.Parse(InputGesture.AsT1);
                        }
                    }
                    break;
                case nameof(IsChecked):
                    if (!Equals(IsChecked, value))
                    {
                        IsChecked = (bool?)value;
                        NativeControl.IsChecked = IsChecked ?? (bool)AC.MenuItem.IsCheckedProperty.GetDefaultValue(AC.MenuItem.IsCheckedProperty.OwnerType);
                    }
                    break;
                case nameof(IsSelected):
                    if (!Equals(IsSelected, value))
                    {
                        IsSelected = (bool?)value;
                        NativeControl.IsSelected = IsSelected ?? default;
                    }
                    break;
                case nameof(IsSubMenuOpen):
                    if (!Equals(IsSubMenuOpen, value))
                    {
                        IsSubMenuOpen = (bool?)value;
                        NativeControl.IsSubMenuOpen = IsSubMenuOpen ?? (bool)AC.MenuItem.IsSubMenuOpenProperty.GetDefaultValue(AC.MenuItem.IsSubMenuOpenProperty.OwnerType);
                    }
                    break;
                case nameof(StaysOpenOnClick):
                    if (!Equals(StaysOpenOnClick, value))
                    {
                        StaysOpenOnClick = (bool?)value;
                        NativeControl.StaysOpenOnClick = StaysOpenOnClick ?? (bool)AC.MenuItem.StaysOpenOnClickProperty.GetDefaultValue(AC.MenuItem.StaysOpenOnClickProperty.OwnerType);
                    }
                    break;
                case nameof(ToggleType):
                    if (!Equals(ToggleType, value))
                    {
                        ToggleType = (AC.MenuItemToggleType?)value;
                        NativeControl.ToggleType = ToggleType ?? (AC.MenuItemToggleType)AC.MenuItem.ToggleTypeProperty.GetDefaultValue(AC.MenuItem.ToggleTypeProperty.OwnerType);
                    }
                    break;
                case nameof(OnClick):
                    if (!Equals(OnClick, value))
                    {
                        void NativeControlClick(object sender, global::Avalonia.Interactivity.RoutedEventArgs e) => InvokeEventCallback(OnClick, e);

                        OnClick = (EventCallback<global::Avalonia.Interactivity.RoutedEventArgs>)value;
                        NativeControl.Click -= NativeControlClick;
                        NativeControl.Click += NativeControlClick;
                    }
                    break;
                case nameof(OnPointerEnteredItem):
                    if (!Equals(OnPointerEnteredItem, value))
                    {
                        void NativeControlPointerEnteredItem(object sender, global::Avalonia.Interactivity.RoutedEventArgs e) => InvokeEventCallback(OnPointerEnteredItem, e);

                        OnPointerEnteredItem = (EventCallback<global::Avalonia.Interactivity.RoutedEventArgs>)value;
                        NativeControl.PointerEnteredItem -= NativeControlPointerEnteredItem;
                        NativeControl.PointerEnteredItem += NativeControlPointerEnteredItem;
                    }
                    break;
                case nameof(OnPointerExitedItem):
                    if (!Equals(OnPointerExitedItem, value))
                    {
                        void NativeControlPointerExitedItem(object sender, global::Avalonia.Interactivity.RoutedEventArgs e) => InvokeEventCallback(OnPointerExitedItem, e);

                        OnPointerExitedItem = (EventCallback<global::Avalonia.Interactivity.RoutedEventArgs>)value;
                        NativeControl.PointerExitedItem -= NativeControlPointerExitedItem;
                        NativeControl.PointerExitedItem += NativeControlPointerExitedItem;
                    }
                    break;
                case nameof(OnSubmenuOpened):
                    if (!Equals(OnSubmenuOpened, value))
                    {
                        void NativeControlSubmenuOpened(object sender, global::Avalonia.Interactivity.RoutedEventArgs e) => InvokeEventCallback(OnSubmenuOpened, e);

                        OnSubmenuOpened = (EventCallback<global::Avalonia.Interactivity.RoutedEventArgs>)value;
                        NativeControl.SubmenuOpened -= NativeControlSubmenuOpened;
                        NativeControl.SubmenuOpened += NativeControlSubmenuOpened;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}
