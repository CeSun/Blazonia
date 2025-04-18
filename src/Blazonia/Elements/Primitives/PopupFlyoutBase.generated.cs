// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACP = Avalonia.Controls.Primitives;
using Blazonia.Components;
using System.ComponentModel;

#pragma warning disable CA2252

namespace Blazonia.Components.Primitives
{
    public abstract partial class PopupFlyoutBase : FlyoutBase
    {
        static PopupFlyoutBase()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public AC.Primitives.PopupPositioning.CustomPopupPlacementCallback CustomPopupPlacementCallback { get; set; }
        [Parameter] public double? HorizontalOffset { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the event that closes the flyout is passed through to the parent window.
        /// </summary>
        [Parameter] public bool? OverlayDismissEventPassThrough { get; set; }
        /// <summary>
        /// Gets or sets an element that should receive pointer input events even when underneath the flyout's overlay.
        /// </summary>
        [Parameter] public global::Avalonia.Input.IInputElement OverlayInputPassThroughElement { get; set; }
        [Parameter] public AC.PlacementMode? Placement { get; set; }
        [Parameter] public AC.Primitives.PopupPositioning.PopupAnchor? PlacementAnchor { get; set; }
        [Parameter] public AC.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment? PlacementConstraintAdjustment { get; set; }
        [Parameter] public AC.Primitives.PopupPositioning.PopupGravity? PlacementGravity { get; set; }
        /// <summary>
        /// Gets or sets the desired ShowMode
        /// </summary>
        [Parameter] public AC.FlyoutShowMode? ShowMode { get; set; }
        [Parameter] public double? VerticalOffset { get; set; }
        [Parameter] public EventCallback<CancelEventArgs> OnClosing { get; set; }
        [Parameter] public EventCallback OnOpening { get; set; }

        public new ACP.PopupFlyoutBase NativeControl => (ACP.PopupFlyoutBase)((AvaloniaObject)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(CustomPopupPlacementCallback):
                    if (!Equals(CustomPopupPlacementCallback, value))
                    {
                        CustomPopupPlacementCallback = (AC.Primitives.PopupPositioning.CustomPopupPlacementCallback)value;
                        NativeControl.CustomPopupPlacementCallback = CustomPopupPlacementCallback;
                    }
                    break;
                case nameof(HorizontalOffset):
                    if (!Equals(HorizontalOffset, value))
                    {
                        HorizontalOffset = (double?)value;
                        NativeControl.HorizontalOffset = HorizontalOffset ?? (double)ACP.PopupFlyoutBase.HorizontalOffsetProperty.GetDefaultValue(ACP.PopupFlyoutBase.HorizontalOffsetProperty.OwnerType);
                    }
                    break;
                case nameof(OverlayDismissEventPassThrough):
                    if (!Equals(OverlayDismissEventPassThrough, value))
                    {
                        OverlayDismissEventPassThrough = (bool?)value;
                        NativeControl.OverlayDismissEventPassThrough = OverlayDismissEventPassThrough ?? (bool)ACP.PopupFlyoutBase.OverlayDismissEventPassThroughProperty.GetDefaultValue(ACP.PopupFlyoutBase.OverlayDismissEventPassThroughProperty.OwnerType);
                    }
                    break;
                case nameof(OverlayInputPassThroughElement):
                    if (!Equals(OverlayInputPassThroughElement, value))
                    {
                        OverlayInputPassThroughElement = (global::Avalonia.Input.IInputElement)value;
                        NativeControl.OverlayInputPassThroughElement = OverlayInputPassThroughElement;
                    }
                    break;
                case nameof(Placement):
                    if (!Equals(Placement, value))
                    {
                        Placement = (AC.PlacementMode?)value;
                        NativeControl.Placement = Placement ?? (AC.PlacementMode)ACP.PopupFlyoutBase.PlacementProperty.GetDefaultValue(ACP.PopupFlyoutBase.PlacementProperty.OwnerType);
                    }
                    break;
                case nameof(PlacementAnchor):
                    if (!Equals(PlacementAnchor, value))
                    {
                        PlacementAnchor = (AC.Primitives.PopupPositioning.PopupAnchor?)value;
                        NativeControl.PlacementAnchor = PlacementAnchor ?? (AC.Primitives.PopupPositioning.PopupAnchor)ACP.PopupFlyoutBase.PlacementAnchorProperty.GetDefaultValue(ACP.PopupFlyoutBase.PlacementAnchorProperty.OwnerType);
                    }
                    break;
                case nameof(PlacementConstraintAdjustment):
                    if (!Equals(PlacementConstraintAdjustment, value))
                    {
                        PlacementConstraintAdjustment = (AC.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment?)value;
                        NativeControl.PlacementConstraintAdjustment = PlacementConstraintAdjustment ?? (AC.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment)ACP.PopupFlyoutBase.PlacementConstraintAdjustmentProperty.GetDefaultValue(ACP.PopupFlyoutBase.PlacementConstraintAdjustmentProperty.OwnerType);
                    }
                    break;
                case nameof(PlacementGravity):
                    if (!Equals(PlacementGravity, value))
                    {
                        PlacementGravity = (AC.Primitives.PopupPositioning.PopupGravity?)value;
                        NativeControl.PlacementGravity = PlacementGravity ?? (AC.Primitives.PopupPositioning.PopupGravity)ACP.PopupFlyoutBase.PlacementGravityProperty.GetDefaultValue(ACP.PopupFlyoutBase.PlacementGravityProperty.OwnerType);
                    }
                    break;
                case nameof(ShowMode):
                    if (!Equals(ShowMode, value))
                    {
                        ShowMode = (AC.FlyoutShowMode?)value;
                        NativeControl.ShowMode = ShowMode ?? (AC.FlyoutShowMode)ACP.PopupFlyoutBase.ShowModeProperty.GetDefaultValue(ACP.PopupFlyoutBase.ShowModeProperty.OwnerType);
                    }
                    break;
                case nameof(VerticalOffset):
                    if (!Equals(VerticalOffset, value))
                    {
                        VerticalOffset = (double?)value;
                        NativeControl.VerticalOffset = VerticalOffset ?? (double)ACP.PopupFlyoutBase.VerticalOffsetProperty.GetDefaultValue(ACP.PopupFlyoutBase.VerticalOffsetProperty.OwnerType);
                    }
                    break;
                case nameof(OnClosing):
                    if (!Equals(OnClosing, value))
                    {
                        void NativeControlClosing(object sender, CancelEventArgs e) => InvokeEventCallback(OnClosing, e);

                        OnClosing = (EventCallback<CancelEventArgs>)value;
                        NativeControl.Closing -= NativeControlClosing;
                        NativeControl.Closing += NativeControlClosing;
                    }
                    break;
                case nameof(OnOpening):
                    if (!Equals(OnOpening, value))
                    {
                        void NativeControlOpening(object sender, EventArgs e) => InvokeEventCallback(OnOpening);

                        OnOpening = (EventCallback)value;
                        NativeControl.Opening -= NativeControlOpening;
                        NativeControl.Opening += NativeControlOpening;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}
