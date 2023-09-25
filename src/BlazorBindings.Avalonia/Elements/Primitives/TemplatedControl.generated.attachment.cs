using ACP = Avalonia.Controls.Primitives;
using BlazorBindings.AvaloniaBindings.Elements;

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public class TemplatedControl_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the IsTemplateFocusTarget attached property.
        /// </summary>
        [Parameter] public bool IsTemplateFocusTarget { get; set; }

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(IsTemplateFocusTarget):
                    if (!Equals(IsTemplateFocusTarget, value))
                    {
                        IsTemplateFocusTarget = (bool)value;
                        //NativeControl.IsTemplateFocusTargetProperty = IsTemplateFocusTarget;
                    }
                    break;

                }
            }
        
            TryUpdateParent(_parent);
            return base.SetParametersAsync(ParameterView.Empty);
        }

        private void TryUpdateParent(object parentElement)
        {
            if (parentElement is not null)
            {
                if (IsTemplateFocusTarget == Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty);
                }
                else
                {
                    Avalonia.Controls.Primitives.TemplatedControl.SetIsTemplateFocusTarget((Avalonia.Controls.Control)parentElement, IsTemplateFocusTarget);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                IsTemplateFocusTarget = IsTemplateFocusTarget != default ? IsTemplateFocusTarget : Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty.GetDefaultValue(parentType);
            }

            TryUpdateParent(parentElement);
            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            //_children.Clear();

            //Avalonia.Controls.Primitives.TemplatedControl.SetTip(_parent, null);

            _parent = null;
        }

        public void AddChild(object child, int physicalSiblingIndex)
        {
            var childView = child.Cast<AC.Control>();

            //_children.Add(childView);
        }

        public void RemoveChild(object child, int physicalSiblingIndex)
        {
            //_children.Remove((AC.Control)child);
        }

        protected override void RenderAdditionalElementContent(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
        }
    }
}
