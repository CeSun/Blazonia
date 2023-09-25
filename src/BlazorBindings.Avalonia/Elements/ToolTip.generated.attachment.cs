

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public class ToolTip_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the ToolTip.HorizontalOffset property.
        /// </summary>
        [Parameter] public double HorizontalOffset { get; set; }

        /// <summary>
        /// Defines the ToolTip.IsOpen attached property.
        /// </summary>
        [Parameter] public bool IsOpen { get; set; }

        /// <summary>
        /// Defines the ToolTip.Placement property.
        /// </summary>
        [Parameter] public AC.PlacementMode Placement { get; set; }

        /// <summary>
        /// Defines the ToolTip.ShowDelay property.
        /// </summary>
        [Parameter] public int ShowDelay { get; set; }

        /// <summary>
        /// Defines the ToolTip.Tip attached property.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// Defines the ToolTip.VerticalOffset property.
        /// </summary>
        [Parameter] public double VerticalOffset { get; set; }


        protected override RenderFragment GetChildContent() => ChildContent;

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(HorizontalOffset):
                    if (!Equals(HorizontalOffset, value))
                    {
                        HorizontalOffset = (double)value;
                        //NativeControl.HorizontalOffsetProperty = HorizontalOffset;
                    }
                    break;

                    case nameof(IsOpen):
                    if (!Equals(IsOpen, value))
                    {
                        IsOpen = (bool)value;
                        //NativeControl.IsOpenProperty = IsOpen;
                    }
                    break;

                    case nameof(Placement):
                    if (!Equals(Placement, value))
                    {
                        Placement = (AC.PlacementMode)value;
                        //NativeControl.PlacementProperty = Placement;
                    }
                    break;

                    case nameof(ShowDelay):
                    if (!Equals(ShowDelay, value))
                    {
                        ShowDelay = (int)value;
                        //NativeControl.ShowDelayProperty = ShowDelay;
                    }
                    break;

                    case nameof(ChildContent):
                    if (!Equals(ChildContent, value))
                    {
                        ChildContent = (RenderFragment)value;
                        //NativeControl.TipProperty = ChildContent;
                    }
                    break;

                    case nameof(VerticalOffset):
                    if (!Equals(VerticalOffset, value))
                    {
                        VerticalOffset = (double)value;
                        //NativeControl.VerticalOffsetProperty = VerticalOffset;
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
                if (HorizontalOffset == Avalonia.Controls.ToolTip.HorizontalOffsetProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ToolTip.HorizontalOffsetProperty);
                }
                else
                {
                    Avalonia.Controls.ToolTip.SetHorizontalOffset((Avalonia.Controls.Control)parentElement, HorizontalOffset);
                }
                
                if (IsOpen == Avalonia.Controls.ToolTip.IsOpenProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ToolTip.IsOpenProperty);
                }
                else
                {
                    Avalonia.Controls.ToolTip.SetIsOpen((Avalonia.Controls.Control)parentElement, IsOpen);
                }
                
                if (Placement == Avalonia.Controls.ToolTip.PlacementProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ToolTip.PlacementProperty);
                }
                else
                {
                    Avalonia.Controls.ToolTip.SetPlacement((Avalonia.Controls.Control)parentElement, Placement);
                }
                
                if (ShowDelay == Avalonia.Controls.ToolTip.ShowDelayProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ToolTip.ShowDelayProperty);
                }
                else
                {
                    Avalonia.Controls.ToolTip.SetShowDelay((Avalonia.Controls.Control)parentElement, ShowDelay);
                }
                
                if (VerticalOffset == Avalonia.Controls.ToolTip.VerticalOffsetProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ToolTip.VerticalOffsetProperty);
                }
                else
                {
                    Avalonia.Controls.ToolTip.SetVerticalOffset((Avalonia.Controls.Control)parentElement, VerticalOffset);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                HorizontalOffset = HorizontalOffset != default ? HorizontalOffset : Avalonia.Controls.ToolTip.HorizontalOffsetProperty.GetDefaultValue(parentType);
                IsOpen = IsOpen != default ? IsOpen : Avalonia.Controls.ToolTip.IsOpenProperty.GetDefaultValue(parentType);
                Placement = Placement != default ? Placement : Avalonia.Controls.ToolTip.PlacementProperty.GetDefaultValue(parentType);
                ShowDelay = ShowDelay != default ? ShowDelay : Avalonia.Controls.ToolTip.ShowDelayProperty.GetDefaultValue(parentType);
                VerticalOffset = VerticalOffset != default ? VerticalOffset : Avalonia.Controls.ToolTip.VerticalOffsetProperty.GetDefaultValue(parentType);
            }

            TryUpdateParent(parentElement);
            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            //_children.Clear();

            //Avalonia.Controls.ToolTip.SetTip(_parent, null);

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
            RenderTreeBuilderHelper.AddContentProperty<Avalonia.Controls.Control>(builder, sequence++, ChildContent,
                (nativeControl, value) => Avalonia.Controls.ToolTip.SetTip(_parent, value));
        }
    }
}
