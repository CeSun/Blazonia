using A = Avalonia;

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public class Visual_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Visual.FlowDirection" /> property.
        /// </summary>
        [Parameter] public A.Media.FlowDirection FlowDirection { get; set; }

        private Avalonia.Visual _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(FlowDirection):
                    if (!Equals(FlowDirection, value))
                    {
                        FlowDirection = (A.Media.FlowDirection)value;
                        //NativeControl.FlowDirectionProperty = FlowDirection;
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
                if (FlowDirection == Avalonia.Visual.FlowDirectionProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Visual)parentElement).ClearValue(Avalonia.Visual.FlowDirectionProperty);
                }
                else
                {
                    Avalonia.Visual.SetFlowDirection((Avalonia.Visual)parentElement, FlowDirection);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                FlowDirection = FlowDirection != default ? FlowDirection : Avalonia.Visual.FlowDirectionProperty.GetDefaultValue(parentType);
            }

            TryUpdateParent(parentElement);
            _parent = (Avalonia.Visual)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            //_children.Clear();

            //Avalonia.Visual.SetTip(_parent, null);

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
