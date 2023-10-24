

namespace BlazorBindings.AvaloniaBindings.Elements
{
    
    internal static class TopLevelInitializer
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        internal static void RegisterAdditionalHandlers()
        {
            AttachedPropertyRegistry.RegisterAttachedPropertyHandler("TopLevel.SystemBarColor",
                (element, value) => 
                {
                    if (value?.Equals(AvaloniaProperty.UnsetValue) == true)
                    {
                        element.ClearValue(AC.TopLevel.SystemBarColorProperty);
                    }
                    else
                    {
                        Avalonia.Controls.TopLevel.SetSystemBarColor((Avalonia.Controls.Control)element, (global::Avalonia.Media.SolidColorBrush)value);
                    }
                });
        }
    }

    public static class TopLevelExtensions
    {
        /// <summary>
        /// Defines the SystemBarColor attached property.
        /// </summary>
        public static Control TopLevelSystemBarColor(this Control element, global::Avalonia.Media.SolidColorBrush value)
        {
            element.AttachedProperties["TopLevel.SystemBarColor"] = value;
        
            return element;
        }
    }

    public class TopLevel_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the SystemBarColor attached property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.SolidColorBrush SystemBarColor { get; set; }

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(SystemBarColor):
                    if (!Equals(SystemBarColor, value))
                    {
                        SystemBarColor = (global::Avalonia.Media.SolidColorBrush)value;
                        //NativeControl.SystemBarColorProperty = SystemBarColor;
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
                if (SystemBarColor == Avalonia.Controls.TopLevel.SystemBarColorProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.TopLevel.SystemBarColorProperty);
                }
                else
                {
                    Avalonia.Controls.TopLevel.SetSystemBarColor((Avalonia.Controls.Control)parentElement, SystemBarColor);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                SystemBarColor = SystemBarColor != default ? SystemBarColor : Avalonia.Controls.TopLevel.SystemBarColorProperty.GetDefaultValue(parentType);
            }

            TryUpdateParent(parentElement);
            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            //_children.Clear();

            //Avalonia.Controls.TopLevel.SetTip(_parent, null);

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
