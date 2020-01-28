// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.MobileBlazorBindings.Core;
using System;
using XF = Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Elements.Handlers
{
    public partial class InputViewHandler : ViewHandler
    {
        public InputViewHandler(NativeComponentRenderer renderer, XF.InputView inputViewControl) : base(renderer, inputViewControl)
        {
            InputViewControl = inputViewControl ?? throw new ArgumentNullException(nameof(inputViewControl));

            Initialize(renderer);
        }

        partial void Initialize(NativeComponentRenderer renderer);

        public XF.InputView InputViewControl { get; }

        public override void ApplyAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch (attributeName)
            {
                case nameof(XF.InputView.IsReadOnly):
                    InputViewControl.IsReadOnly = AttributeHelper.GetBool(attributeValue);
                    break;
                case nameof(XF.InputView.IsSpellCheckEnabled):
                    InputViewControl.IsSpellCheckEnabled = AttributeHelper.GetBool(attributeValue, true);
                    break;
                case nameof(XF.InputView.MaxLength):
                    InputViewControl.MaxLength = AttributeHelper.GetInt(attributeValue, int.MaxValue);
                    break;
                default:
                    base.ApplyAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;
            }
        }
    }
}
