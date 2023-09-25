

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public class Canvas_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the Bottom attached property.
        /// </summary>
        [Parameter] public double Bottom { get; set; }

        /// <summary>
        /// Defines the Left attached property.
        /// </summary>
        [Parameter] public double Left { get; set; }

        /// <summary>
        /// Defines the Right attached property.
        /// </summary>
        [Parameter] public double Right { get; set; }

        /// <summary>
        /// Defines the Top attached property.
        /// </summary>
        [Parameter] public double Top { get; set; }

        private Avalonia.AvaloniaObject _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(Bottom):
                    if (!Equals(Bottom, value))
                    {
                        Bottom = (double)value;
                        //NativeControl.BottomProperty = Bottom;
                    }
                    break;

                    case nameof(Left):
                    if (!Equals(Left, value))
                    {
                        Left = (double)value;
                        //NativeControl.LeftProperty = Left;
                    }
                    break;

                    case nameof(Right):
                    if (!Equals(Right, value))
                    {
                        Right = (double)value;
                        //NativeControl.RightProperty = Right;
                    }
                    break;

                    case nameof(Top):
                    if (!Equals(Top, value))
                    {
                        Top = (double)value;
                        //NativeControl.TopProperty = Top;
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
                if (Bottom == Avalonia.Controls.Canvas.BottomProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.Canvas.BottomProperty);
                }
                else
                {
                    Avalonia.Controls.Canvas.SetBottom((Avalonia.AvaloniaObject)parentElement, Bottom);
                }
                
                if (Left == Avalonia.Controls.Canvas.LeftProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.Canvas.LeftProperty);
                }
                else
                {
                    Avalonia.Controls.Canvas.SetLeft((Avalonia.AvaloniaObject)parentElement, Left);
                }
                
                if (Right == Avalonia.Controls.Canvas.RightProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.Canvas.RightProperty);
                }
                else
                {
                    Avalonia.Controls.Canvas.SetRight((Avalonia.AvaloniaObject)parentElement, Right);
                }
                
                if (Top == Avalonia.Controls.Canvas.TopProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.AvaloniaObject)parentElement).ClearValue(Avalonia.Controls.Canvas.TopProperty);
                }
                else
                {
                    Avalonia.Controls.Canvas.SetTop((Avalonia.AvaloniaObject)parentElement, Top);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                Bottom = Bottom != default ? Bottom : Avalonia.Controls.Canvas.BottomProperty.GetDefaultValue(parentType);
                Left = Left != default ? Left : Avalonia.Controls.Canvas.LeftProperty.GetDefaultValue(parentType);
                Right = Right != default ? Right : Avalonia.Controls.Canvas.RightProperty.GetDefaultValue(parentType);
                Top = Top != default ? Top : Avalonia.Controls.Canvas.TopProperty.GetDefaultValue(parentType);
            }

            TryUpdateParent(parentElement);
            _parent = (Avalonia.AvaloniaObject)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            //_children.Clear();

            //Avalonia.Controls.Canvas.SetTip(_parent, null);

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
