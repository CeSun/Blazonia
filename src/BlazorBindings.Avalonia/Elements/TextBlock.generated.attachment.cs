

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public class TextBlock_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// DependencyProperty for <see cref="P:Avalonia.Controls.TextBlock.BaselineOffset" /> property.
        /// </summary>
        [Parameter] public double BaselineOffset { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.TextBlock.LetterSpacing" /> property.
        /// </summary>
        [Parameter] public double LetterSpacing { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.TextBlock.LineHeight" /> property.
        /// </summary>
        [Parameter] public double LineHeight { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.TextBlock.MaxLines" /> property.
        /// </summary>
        [Parameter] public int MaxLines { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.TextBlock.TextAlignment" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.TextAlignment TextAlignment { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.TextBlock.TextTrimming" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.TextTrimming TextTrimming { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.TextBlock.TextWrapping" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.TextWrapping TextWrapping { get; set; }

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(BaselineOffset):
                    if (!Equals(BaselineOffset, value))
                    {
                        BaselineOffset = (double)value;
                        //NativeControl.BaselineOffsetProperty = BaselineOffset;
                    }
                    break;

                    case nameof(LetterSpacing):
                    if (!Equals(LetterSpacing, value))
                    {
                        LetterSpacing = (double)value;
                        //NativeControl.LetterSpacingProperty = LetterSpacing;
                    }
                    break;

                    case nameof(LineHeight):
                    if (!Equals(LineHeight, value))
                    {
                        LineHeight = (double)value;
                        //NativeControl.LineHeightProperty = LineHeight;
                    }
                    break;

                    case nameof(MaxLines):
                    if (!Equals(MaxLines, value))
                    {
                        MaxLines = (int)value;
                        //NativeControl.MaxLinesProperty = MaxLines;
                    }
                    break;

                    case nameof(TextAlignment):
                    if (!Equals(TextAlignment, value))
                    {
                        TextAlignment = (global::Avalonia.Media.TextAlignment)value;
                        //NativeControl.TextAlignmentProperty = TextAlignment;
                    }
                    break;

                    case nameof(TextTrimming):
                    if (!Equals(TextTrimming, value))
                    {
                        TextTrimming = (global::Avalonia.Media.TextTrimming)value;
                        //NativeControl.TextTrimmingProperty = TextTrimming;
                    }
                    break;

                    case nameof(TextWrapping):
                    if (!Equals(TextWrapping, value))
                    {
                        TextWrapping = (global::Avalonia.Media.TextWrapping)value;
                        //NativeControl.TextWrappingProperty = TextWrapping;
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
                if (BaselineOffset == Avalonia.Controls.TextBlock.BaselineOffsetProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.TextBlock.BaselineOffsetProperty);
                }
                else
                {
                    Avalonia.Controls.TextBlock.SetBaselineOffset((Avalonia.Controls.Control)parentElement, BaselineOffset);
                }
                
                if (LetterSpacing == Avalonia.Controls.TextBlock.LetterSpacingProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.TextBlock.LetterSpacingProperty);
                }
                else
                {
                    Avalonia.Controls.TextBlock.SetLetterSpacing((Avalonia.Controls.Control)parentElement, LetterSpacing);
                }
                
                if (LineHeight == Avalonia.Controls.TextBlock.LineHeightProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.TextBlock.LineHeightProperty);
                }
                else
                {
                    Avalonia.Controls.TextBlock.SetLineHeight((Avalonia.Controls.Control)parentElement, LineHeight);
                }
                
                if (MaxLines == Avalonia.Controls.TextBlock.MaxLinesProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.TextBlock.MaxLinesProperty);
                }
                else
                {
                    Avalonia.Controls.TextBlock.SetMaxLines((Avalonia.Controls.Control)parentElement, MaxLines);
                }
                
                if (TextAlignment == Avalonia.Controls.TextBlock.TextAlignmentProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.TextBlock.TextAlignmentProperty);
                }
                else
                {
                    Avalonia.Controls.TextBlock.SetTextAlignment((Avalonia.Controls.Control)parentElement, TextAlignment);
                }
                
                if (TextTrimming == Avalonia.Controls.TextBlock.TextTrimmingProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.TextBlock.TextTrimmingProperty);
                }
                else
                {
                    Avalonia.Controls.TextBlock.SetTextTrimming((Avalonia.Controls.Control)parentElement, TextTrimming);
                }
                
                if (TextWrapping == Avalonia.Controls.TextBlock.TextWrappingProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.TextBlock.TextWrappingProperty);
                }
                else
                {
                    Avalonia.Controls.TextBlock.SetTextWrapping((Avalonia.Controls.Control)parentElement, TextWrapping);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                BaselineOffset = BaselineOffset != default ? BaselineOffset : Avalonia.Controls.TextBlock.BaselineOffsetProperty.GetDefaultValue(parentType);
                LetterSpacing = LetterSpacing != default ? LetterSpacing : Avalonia.Controls.TextBlock.LetterSpacingProperty.GetDefaultValue(parentType);
                LineHeight = LineHeight != default ? LineHeight : Avalonia.Controls.TextBlock.LineHeightProperty.GetDefaultValue(parentType);
                MaxLines = MaxLines != default ? MaxLines : Avalonia.Controls.TextBlock.MaxLinesProperty.GetDefaultValue(parentType);
                TextAlignment = TextAlignment != default ? TextAlignment : Avalonia.Controls.TextBlock.TextAlignmentProperty.GetDefaultValue(parentType);
                TextTrimming = TextTrimming != default ? TextTrimming : Avalonia.Controls.TextBlock.TextTrimmingProperty.GetDefaultValue(parentType);
                TextWrapping = TextWrapping != default ? TextWrapping : Avalonia.Controls.TextBlock.TextWrappingProperty.GetDefaultValue(parentType);
            }

            TryUpdateParent(parentElement);
            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            //_children.Clear();

            //Avalonia.Controls.TextBlock.SetTip(_parent, null);

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
