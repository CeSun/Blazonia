// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Avalonia.Controls.Templates;

namespace BlazorBindings.AvaloniaBindings.Elements.DataTemplates;

/// <summary>
/// This ControlTemplate implementation wraps the content in an additional View, therefore it is not suitable in cases when non-View content
/// is expected from template.
/// </summary>
internal class ControlTemplateItemsComponent<T> : NativeControlComponentBase, IContainerElementHandler, INonPhysicalChild
    where T : AvaloniaBindableObject
{
    protected override RenderFragment GetChildContent()
    {
        return builder =>
        {
            foreach (var itemRoot in _itemRoots)
            {
                builder.OpenComponent<InitializedContentView>(1);

                builder.AddAttribute(2, nameof(InitializedContentView.NativeControl), itemRoot);
                builder.AddAttribute(3, "ChildContent", (RenderFragment)(builder =>
                {
                    Template.Invoke(builder);
                }));

                builder.CloseComponent();
            }
        };
    }

    [Parameter] public Action<T, IControlTemplate> SetControlTemplateAction { get; set; }
    //[Parameter] public Action<T, Avalonia.Controls.Templates.ITemplate<object, Avalonia.Controls.Control>> SetDataTemplateAction { get; set; }
    [Parameter] public Action<T, Avalonia.Controls.Templates.IDataTemplate> SetDataTemplateAction { get; set; }
    [Parameter] public RenderFragment Template { get; set; }

    private readonly List<AvaloniaContentView> _itemRoots = new();

    private Avalonia.Controls.Control AddTemplateRoot()
    {
        var templateRoot = new AvaloniaContentView();
        _itemRoots.Add(templateRoot);
        StateHasChanged();

        return templateRoot;
    }

    void INonPhysicalChild.SetParent(object parentElement)
    {
        var parent = parentElement as T;

        if (SetControlTemplateAction != null)
        {
            //var controlTemplate = new AvaloniaControlTemplate();
            var controlTemplate = new global::Avalonia.Controls.Templates.FuncControlTemplate((tc, namescope) => AddTemplateRoot());
            SetControlTemplateAction(parent, controlTemplate);
        }

        if (SetDataTemplateAction != null)
        {

            //var dataTemplate = new AvaloniaDataTemplate();
            var dataTemplate = new FuncDataTemplate(typeof(T), (item, namescope) => AddTemplateRoot());
            //dataTemplate.Content = AddTemplateRoot();
            SetDataTemplateAction(parent, dataTemplate);
        }
    }

    void INonPhysicalChild.RemoveFromParent(object parentElement) { }
    void IContainerElementHandler.AddChild(object child, int physicalSiblingIndex) { }
    void IContainerElementHandler.RemoveChild(object child, int physicalSiblingIndex) { }
    object IElementHandler.TargetElement => null;
}
