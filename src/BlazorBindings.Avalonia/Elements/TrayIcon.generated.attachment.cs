

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public class TrayIcon_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the <see cref="T:Avalonia.Controls.TrayIcons" /> attached property.
        /// </summary>
        [Parameter] public AC.TrayIcons Icons { get; set; }

        private Avalonia.Application _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(Icons):
                    if (!Equals(Icons, value))
                    {
                        Icons = (AC.TrayIcons)value;
                        //NativeControl.IconsProperty = Icons;
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
                if (Icons == Avalonia.Controls.TrayIcon.IconsProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Application)parentElement).ClearValue(Avalonia.Controls.TrayIcon.IconsProperty);
                }
                else
                {
                    Avalonia.Controls.TrayIcon.SetIcons((Avalonia.Application)parentElement, Icons);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Icons = Icons != default ? Icons : Avalonia.Controls.TrayIcon.IconsProperty.GetDefaultValue(parentType);
            }

            TryUpdateParent(parentElement);
            _parent = (Avalonia.Application)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            //_children.Clear();

            //Avalonia.Controls.TrayIcon.SetTip(_parent, null);

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
