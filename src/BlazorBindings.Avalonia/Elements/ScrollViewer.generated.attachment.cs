

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public class ScrollViewer_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.AllowAutoHide" /> property.
        /// </summary>
        [Parameter] public bool AllowAutoHide { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChange" /> property.
        /// </summary>
        [Parameter] public bool BringIntoViewOnFocusChange { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibility" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignment" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.SnapPointsAlignment HorizontalSnapPointsAlignment { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.HorizontalSnapPointsType" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.SnapPointsType HorizontalSnapPointsType { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.IsScrollChainingEnabled" /> property.
        /// </summary>
        [Parameter] public bool IsScrollChainingEnabled { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabled" /> property.
        /// </summary>
        [Parameter] public bool IsScrollInertiaEnabled { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibility" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.ScrollBarVisibility VerticalScrollBarVisibility { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignment" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.SnapPointsAlignment VerticalSnapPointsAlignment { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.ScrollViewer.VerticalSnapPointsType" /> property.
        /// </summary>
        [Parameter] public AC.Primitives.SnapPointsType VerticalSnapPointsType { get; set; }

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(AllowAutoHide):
                    if (!Equals(AllowAutoHide, value))
                    {
                        AllowAutoHide = (bool)value;
                        //NativeControl.AllowAutoHideProperty = AllowAutoHide;
                    }
                    break;

                    case nameof(BringIntoViewOnFocusChange):
                    if (!Equals(BringIntoViewOnFocusChange, value))
                    {
                        BringIntoViewOnFocusChange = (bool)value;
                        //NativeControl.BringIntoViewOnFocusChangeProperty = BringIntoViewOnFocusChange;
                    }
                    break;

                    case nameof(HorizontalScrollBarVisibility):
                    if (!Equals(HorizontalScrollBarVisibility, value))
                    {
                        HorizontalScrollBarVisibility = (AC.Primitives.ScrollBarVisibility)value;
                        //NativeControl.HorizontalScrollBarVisibilityProperty = HorizontalScrollBarVisibility;
                    }
                    break;

                    case nameof(HorizontalSnapPointsAlignment):
                    if (!Equals(HorizontalSnapPointsAlignment, value))
                    {
                        HorizontalSnapPointsAlignment = (AC.Primitives.SnapPointsAlignment)value;
                        //NativeControl.HorizontalSnapPointsAlignmentProperty = HorizontalSnapPointsAlignment;
                    }
                    break;

                    case nameof(HorizontalSnapPointsType):
                    if (!Equals(HorizontalSnapPointsType, value))
                    {
                        HorizontalSnapPointsType = (AC.Primitives.SnapPointsType)value;
                        //NativeControl.HorizontalSnapPointsTypeProperty = HorizontalSnapPointsType;
                    }
                    break;

                    case nameof(IsScrollChainingEnabled):
                    if (!Equals(IsScrollChainingEnabled, value))
                    {
                        IsScrollChainingEnabled = (bool)value;
                        //NativeControl.IsScrollChainingEnabledProperty = IsScrollChainingEnabled;
                    }
                    break;

                    case nameof(IsScrollInertiaEnabled):
                    if (!Equals(IsScrollInertiaEnabled, value))
                    {
                        IsScrollInertiaEnabled = (bool)value;
                        //NativeControl.IsScrollInertiaEnabledProperty = IsScrollInertiaEnabled;
                    }
                    break;

                    case nameof(VerticalScrollBarVisibility):
                    if (!Equals(VerticalScrollBarVisibility, value))
                    {
                        VerticalScrollBarVisibility = (AC.Primitives.ScrollBarVisibility)value;
                        //NativeControl.VerticalScrollBarVisibilityProperty = VerticalScrollBarVisibility;
                    }
                    break;

                    case nameof(VerticalSnapPointsAlignment):
                    if (!Equals(VerticalSnapPointsAlignment, value))
                    {
                        VerticalSnapPointsAlignment = (AC.Primitives.SnapPointsAlignment)value;
                        //NativeControl.VerticalSnapPointsAlignmentProperty = VerticalSnapPointsAlignment;
                    }
                    break;

                    case nameof(VerticalSnapPointsType):
                    if (!Equals(VerticalSnapPointsType, value))
                    {
                        VerticalSnapPointsType = (AC.Primitives.SnapPointsType)value;
                        //NativeControl.VerticalSnapPointsTypeProperty = VerticalSnapPointsType;
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
                if (AllowAutoHide == Avalonia.Controls.ScrollViewer.AllowAutoHideProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetAllowAutoHide((Avalonia.Controls.Control)parentElement, AllowAutoHide);
                }
                
                if (BringIntoViewOnFocusChange == Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetBringIntoViewOnFocusChange((Avalonia.Controls.Control)parentElement, BringIntoViewOnFocusChange);
                }
                
                if (HorizontalScrollBarVisibility == Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetHorizontalScrollBarVisibility((Avalonia.Controls.Control)parentElement, HorizontalScrollBarVisibility);
                }
                
                if (HorizontalSnapPointsAlignment == Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetHorizontalSnapPointsAlignment((Avalonia.Controls.Control)parentElement, HorizontalSnapPointsAlignment);
                }
                
                if (HorizontalSnapPointsType == Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetHorizontalSnapPointsType((Avalonia.Controls.Control)parentElement, HorizontalSnapPointsType);
                }
                
                if (IsScrollChainingEnabled == Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetIsScrollChainingEnabled((Avalonia.Controls.Control)parentElement, IsScrollChainingEnabled);
                }
                
                if (IsScrollInertiaEnabled == Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetIsScrollInertiaEnabled((Avalonia.Controls.Control)parentElement, IsScrollInertiaEnabled);
                }
                
                if (VerticalScrollBarVisibility == Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetVerticalScrollBarVisibility((Avalonia.Controls.Control)parentElement, VerticalScrollBarVisibility);
                }
                
                if (VerticalSnapPointsAlignment == Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetVerticalSnapPointsAlignment((Avalonia.Controls.Control)parentElement, VerticalSnapPointsAlignment);
                }
                
                if (VerticalSnapPointsType == Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty);
                }
                else
                {
                    Avalonia.Controls.ScrollViewer.SetVerticalSnapPointsType((Avalonia.Controls.Control)parentElement, VerticalSnapPointsType);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                AllowAutoHide = AllowAutoHide != default ? AllowAutoHide : Avalonia.Controls.ScrollViewer.AllowAutoHideProperty.GetDefaultValue(parentType);
                BringIntoViewOnFocusChange = BringIntoViewOnFocusChange != default ? BringIntoViewOnFocusChange : Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty.GetDefaultValue(parentType);
                HorizontalScrollBarVisibility = HorizontalScrollBarVisibility != default ? HorizontalScrollBarVisibility : Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty.GetDefaultValue(parentType);
                HorizontalSnapPointsAlignment = HorizontalSnapPointsAlignment != default ? HorizontalSnapPointsAlignment : Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty.GetDefaultValue(parentType);
                HorizontalSnapPointsType = HorizontalSnapPointsType != default ? HorizontalSnapPointsType : Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty.GetDefaultValue(parentType);
                IsScrollChainingEnabled = IsScrollChainingEnabled != default ? IsScrollChainingEnabled : Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty.GetDefaultValue(parentType);
                IsScrollInertiaEnabled = IsScrollInertiaEnabled != default ? IsScrollInertiaEnabled : Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty.GetDefaultValue(parentType);
                VerticalScrollBarVisibility = VerticalScrollBarVisibility != default ? VerticalScrollBarVisibility : Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty.GetDefaultValue(parentType);
                VerticalSnapPointsAlignment = VerticalSnapPointsAlignment != default ? VerticalSnapPointsAlignment : Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty.GetDefaultValue(parentType);
                VerticalSnapPointsType = VerticalSnapPointsType != default ? VerticalSnapPointsType : Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty.GetDefaultValue(parentType);
            }

            TryUpdateParent(parentElement);
            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            //_children.Clear();

            //Avalonia.Controls.ScrollViewer.SetTip(_parent, null);

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
