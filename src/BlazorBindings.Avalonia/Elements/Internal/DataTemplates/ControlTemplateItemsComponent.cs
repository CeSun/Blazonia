// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Layout;
using Avalonia.Markup.Xaml.Templates;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorBindings.AvaloniaBindings.Elements.DataTemplates;

/// <summary>
/// This ControlTemplate implementation wraps the content in an additional View, therefore it is not suitable in cases when non-View content
/// is expected from template.
/// </summary>
internal class ControlTemplateItemsComponent<TControl, TTemplate> : NativeControlComponentBase, IContainerElementHandler, INonPhysicalChild
    where TControl : TemplatedControl
{
    protected override RenderFragment GetChildContent()
    {
        return builder =>
        {
            foreach (var itemRoot in _dataControlRoots)
            {
                builder.OpenComponent<InitializedContentView>(1);

                builder.AddAttribute(2, nameof(InitializedContentView.NativeControl), itemRoot);
                builder.AddAttribute(3, "ChildContent", (RenderFragment)(builder =>
                {
                    Template.Invoke(builder);
                }));
                builder.AddComponentReferenceCapture(4, reference => { });
                builder.CloseComponent();
            }
        };
    }

    protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
    {
        base.RenderAdditionalElementContent(builder, ref sequence);

        if (SetControlTemplateAction is not null)
        {
            RenderTreeBuilderHelper.AddContentProperty<TControl>(builder, sequence++, Template, (x, value) =>
            {
                if (typeof(ITemplate<AC.Panel>).IsAssignableFrom(typeof(TTemplate)))
                {
                    var controlTemplate = new ItemsPanelTemplate()
                    {
                        Content = (Func<IServiceProvider, object>)((serviceProvider) => new TemplateResult<AC.Control>((AC.Control)value, null))
                    };

                    SetControlTemplateAction(_parent, (TTemplate)(object)controlTemplate);
                }
                else
                {
                    throw new NotSupportedException($"{typeof(TTemplate).Name} is not yet supported");
                }
                
            });
        }
    }

    [Parameter] public Action<TControl, TTemplate> SetControlTemplateAction { get; set; }
    //[Parameter] public Action<T, Avalonia.Controls.Templates.ITemplate<object, Avalonia.Controls.Control>> SetDataTemplateAction { get; set; }
    [Parameter] public Action<TControl, Avalonia.Controls.Templates.IDataTemplate> SetDataTemplateAction { get; set; }
    [Parameter] public RenderFragment Template { get; set; }

    private readonly List<AC.Control> _dataControlRoots = new();
    private TControl _parent;

    private Avalonia.Controls.Control AddDataTemplateRoot()
    {
        var templateRoot = new AvaloniaContentView();
        _dataControlRoots.Add(templateRoot);
        StateHasChanged();

        return templateRoot;
    }

    void INonPhysicalChild.SetParent(object parentElement)
    {
        _parent = parentElement as TControl;

        if (SetDataTemplateAction != null)
        {
            var dataTemplate = new FuncDataTemplate(typeof(TControl), (item, namescope) => AddDataTemplateRoot());
            SetDataTemplateAction(_parent, dataTemplate);
        }
    }


    void INonPhysicalChild.RemoveFromParent(object parentElement) { }
    void IContainerElementHandler.AddChild(object child, int physicalSiblingIndex) { }
    void IContainerElementHandler.RemoveChild(object child, int physicalSiblingIndex) { }
    object IElementHandler.TargetElement => null;
}
