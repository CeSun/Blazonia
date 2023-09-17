// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Layout;
using BlazorBindings.AvaloniaBindings.ComponentGenerator;
using System.Runtime.CompilerServices;
using Avalonia.Controls.Documents;
using Avalonia.Controls.Shapes;
using Avalonia.Animation;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Controls.Primitives;

[assembly: InternalsVisibleTo("BlazorBindings.UnitTests")]


[assembly: GenerateComponent(typeof(Animatable))]
[assembly: GenerateComponent(typeof(AttachedLayout))]
[assembly: GenerateComponent(typeof(Border))]
[assembly: GenerateComponent(typeof(Brush))]
[assembly: GenerateComponent(typeof(Button))]
[assembly: GenerateComponent(typeof(CheckBox))]
[assembly: GenerateComponent(typeof(ContentControl),
    ContentProperties = new[]
    {
        nameof(ContentControl.Content),
        nameof(ContentControl.ContentTemplate),
        nameof(ContentControl.Template),
    })]
[assembly: GenerateComponent(typeof(Control))]
[assembly: GenerateComponent(typeof(DatePicker))]
[assembly: GenerateComponent(typeof(Decorator))]

[assembly: GenerateComponent(typeof(GradientBrush))]
[assembly: GenerateComponent(typeof(GradientStop))]
[assembly: GenerateComponent(typeof(Grid))]

[assembly: GenerateComponent(typeof(HeaderedSelectingItemsControl))]

[assembly: GenerateComponent(typeof(Inline))]
[assembly: GenerateComponent(typeof(InlineUIContainer))]
[assembly: GenerateComponent(typeof(InputElement))]
[assembly: GenerateComponent(typeof(Interactive))]
[assembly: GenerateComponent(typeof(Image))]
[assembly: GenerateComponent(typeof(ItemsControl),
    ContentProperties = new string[]
    {
        nameof(ItemsControl.ItemTemplate),
        nameof(ItemsControl.ItemsPanel),
    },
    GenericProperties = new string[]
    {
        nameof(ItemsControl.ItemTemplate)
        //nameof(ListBox.SelectedItems),
        //nameof(ListBox.Selection),
        //nameof(ListView.ItemsSource),
        //$"{nameof(ItemsControl.ItemsPanel)}:Avalonia.Controls.Panel",
        //nameof(ListView.GroupDisplayBinding),
        //nameof(ListView.GroupShortNameBinding)
        }
    )]
[assembly: GenerateComponent(typeof(Layoutable))]
[assembly: GenerateComponent(typeof(Label))]
[assembly: GenerateComponent(typeof(LinearGradientBrush))]
[assembly: GenerateComponent(typeof(ListBox),
    Exclude = new string[] 
    { 
        //nameof(ListBox.ItemTemplate) 
    },
    Include = new[]
    {
        nameof(ListBox.ItemsSource),
        nameof(ListBox.SelectionMode),
        nameof(ListBox.SelectedItems),
        nameof(ListBox.Selection)
    },
    ContentProperties =new string[]
    {
        //nameof(ListBox.ItemTemplate),
        //nameof(ListBox.ItemsPanel),
    },
    GenericProperties = new string[]
    {
        //nameof(ListBox.SelectedItems),
        //nameof(ListBox.Selection),
        //nameof(ListView.ItemsSource),
        //$"{nameof(ListBox.ItemsPanel)}:Avalonia.Controls.Panel",
        //nameof(ListView.GroupDisplayBinding),
        //nameof(ListView.GroupShortNameBinding)
    },
    Aliases = new string[] {
        //$"{nameof(ListView.HeaderTemplate)}:Header",
        //$"{nameof(ListView.FooterTemplate)}:Footer" 
    })]
[assembly: GenerateComponent(typeof(MenuItem))]
[assembly: GenerateComponent(typeof(Panel),
    ContentProperties = new string[]
    {
        nameof(Panel.Children)
    }
    )]
[assembly: GenerateComponent(typeof(ProgressBar))]
[assembly: GenerateComponent(typeof(RadialGradientBrush))]
[assembly: GenerateComponent(typeof(RadioButton))]
[assembly: GenerateComponent(typeof(RangeBase))]
[assembly: GenerateComponent(typeof(ScrollViewer))]
[assembly: GenerateComponent(typeof(SelectingItemsControl),
    Include = new string[]
    {
        
    }
)]

[assembly: GenerateComponent(typeof(Slider))]
[assembly: GenerateComponent(typeof(SolidColorBrush))]
[assembly: GenerateComponent(typeof(Span))]
[assembly: GenerateComponent(typeof(StackPanel))]
[assembly: GenerateComponent(typeof(StackLayout))]
[assembly: GenerateComponent(typeof(StyledElement),
    Exclude = new[]
    {
        nameof(StyledElement.Initialized)
    })]

[assembly: GenerateComponent(typeof(TemplatedControl))]
[assembly: GenerateComponent(typeof(TextElement))]
[assembly: GenerateComponent(typeof(TextBlock))]
[assembly: GenerateComponent(typeof(TextBox))]
[assembly: GenerateComponent(typeof(ToggleButton))]
[assembly: GenerateComponent(typeof(ToggleSwitch))]
[assembly: GenerateComponent(typeof(TimePicker))]
[assembly: GenerateComponent(typeof(VirtualizingLayout))]

[assembly: GenerateComponent(typeof(Visual),

    Exclude = new[] {
        nameof(Visual.ActualThemeVariantChanged),
        nameof(Visual.AttachedToLogicalTree),
        nameof(Visual.AttachedToVisualTree),
        //nameof(Visual.DataContextChanged), // ?
        nameof(Visual.DetachedFromLogicalTree),
        nameof(Visual.DetachedFromVisualTree),
        nameof(Visual.ResourcesChanged),

        //nameof(Element.Handler), nameof(Visual.ChildAdded), nameof(Visual.ChildRemoved),
        //nameof(Visual.DescendantAdded), nameof(Visual.DescendantRemoved), nameof(Visual.ParentChanged),
        //nameof(Visual.ParentChanging), nameof(Visual.HandlerChanged), nameof(Visual.HandlerChanging) 
    })]

[assembly: GenerateComponent(typeof(Window))]
[assembly: GenerateComponent(typeof(WindowBase))]
[assembly: GenerateComponent(typeof(TopLevel))]

// Shapes
[assembly: GenerateComponent(typeof(Ellipse))]
[assembly: GenerateComponent(typeof(Line))]
[assembly: GenerateComponent(typeof(Polygon))]
[assembly: GenerateComponent(typeof(Polyline))]
[assembly: GenerateComponent(typeof(Rectangle))]
[assembly: GenerateComponent(typeof(Shape))]
