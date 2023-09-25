using ACD = Avalonia.Controls.Documents;
using BlazorBindings.AvaloniaBindings.Elements;

namespace BlazorBindings.AvaloniaBindings.Elements
{
    public class TextElement_Attachment : NativeControlComponentBase, INonPhysicalChild, IContainerElementHandler
    {
        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontFamily" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontFamily FontFamily { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontSize" /> property.
        /// </summary>
        [Parameter] public double FontSize { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontStretch" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontStretch FontStretch { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontStyle" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontStyle FontStyle { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.FontWeight" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontWeight FontWeight { get; set; }

        /// <summary>
        /// Defines the <see cref="P:Avalonia.Controls.Documents.TextElement.Foreground" /> property.
        /// </summary>
        [Parameter] public global::Avalonia.Media.IBrush Foreground { get; set; }

        private Avalonia.Controls.Control _parent;

        public object TargetElement => _parent;

        public override Task SetParametersAsync(ParameterView parameters)
        {
            foreach (var parameterValue in parameters)
            {
                var value = parameterValue.Value;
                switch (parameterValue.Name)
                {
                    case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (global::Avalonia.Media.FontFamily)value;
                        //NativeControl.FontFamilyProperty = FontFamily;
                    }
                    break;

                    case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double)value;
                        //NativeControl.FontSizeProperty = FontSize;
                    }
                    break;

                    case nameof(FontStretch):
                    if (!Equals(FontStretch, value))
                    {
                        FontStretch = (global::Avalonia.Media.FontStretch)value;
                        //NativeControl.FontStretchProperty = FontStretch;
                    }
                    break;

                    case nameof(FontStyle):
                    if (!Equals(FontStyle, value))
                    {
                        FontStyle = (global::Avalonia.Media.FontStyle)value;
                        //NativeControl.FontStyleProperty = FontStyle;
                    }
                    break;

                    case nameof(FontWeight):
                    if (!Equals(FontWeight, value))
                    {
                        FontWeight = (global::Avalonia.Media.FontWeight)value;
                        //NativeControl.FontWeightProperty = FontWeight;
                    }
                    break;

                    case nameof(Foreground):
                    if (!Equals(Foreground, value))
                    {
                        Foreground = (global::Avalonia.Media.IBrush)value;
                        //NativeControl.ForegroundProperty = Foreground;
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
                if (FontFamily == Avalonia.Controls.Documents.TextElement.FontFamilyProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontFamilyProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontFamily((Avalonia.Controls.Control)parentElement, FontFamily);
                }
                
                if (FontSize == Avalonia.Controls.Documents.TextElement.FontSizeProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontSizeProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontSize((Avalonia.Controls.Control)parentElement, FontSize);
                }
                
                if (FontStretch == Avalonia.Controls.Documents.TextElement.FontStretchProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontStretchProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontStretch((Avalonia.Controls.Control)parentElement, FontStretch);
                }
                
                if (FontStyle == Avalonia.Controls.Documents.TextElement.FontStyleProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontStyleProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontStyle((Avalonia.Controls.Control)parentElement, FontStyle);
                }
                
                if (FontWeight == Avalonia.Controls.Documents.TextElement.FontWeightProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.FontWeightProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetFontWeight((Avalonia.Controls.Control)parentElement, FontWeight);
                }
                
                if (Foreground == Avalonia.Controls.Documents.TextElement.ForegroundProperty.GetDefaultValue(parentElement.GetType()))
                {
                    ((Avalonia.Controls.Control)parentElement).ClearValue(Avalonia.Controls.Documents.TextElement.ForegroundProperty);
                }
                else
                {
                    Avalonia.Controls.Documents.TextElement.SetForeground((Avalonia.Controls.Control)parentElement, Foreground);
                }
                
            }
        }
    
        void INonPhysicalChild.SetParent(object parentElement)
        {
            var parentType = parentElement?.GetType();
            if (parentType is not null)
            {
                FontFamily = FontFamily != default ? FontFamily : Avalonia.Controls.Documents.TextElement.FontFamilyProperty.GetDefaultValue(parentType);
                FontSize = FontSize != default ? FontSize : Avalonia.Controls.Documents.TextElement.FontSizeProperty.GetDefaultValue(parentType);
                FontStretch = FontStretch != default ? FontStretch : Avalonia.Controls.Documents.TextElement.FontStretchProperty.GetDefaultValue(parentType);
                FontStyle = FontStyle != default ? FontStyle : Avalonia.Controls.Documents.TextElement.FontStyleProperty.GetDefaultValue(parentType);
                FontWeight = FontWeight != default ? FontWeight : Avalonia.Controls.Documents.TextElement.FontWeightProperty.GetDefaultValue(parentType);
                Foreground = Foreground != default ? Foreground : Avalonia.Controls.Documents.TextElement.ForegroundProperty.GetDefaultValue(parentType);
            }

            TryUpdateParent(parentElement);
            _parent = (Avalonia.Controls.Control)parentElement;
        }
        
        
        public void RemoveFromParent(object parentElement)
        {
            //_children.Clear();

            //Avalonia.Controls.Documents.TextElement.SetTip(_parent, null);

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
