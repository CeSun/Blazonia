// <auto-generated>
//     This code was generated by a BlazorBindingsAvalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace Blazonia.Components
{
    /// <summary>
    /// Represents a spinner control that includes two Buttons.
    /// </summary>
    public partial class ButtonSpinner : Spinner
    {
        static ButtonSpinner()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="T:Avalonia.Controls.ButtonSpinner" /> should allow to spin.
        /// </summary>
        [Parameter] public bool? AllowSpin { get; set; }
        /// <summary>
        /// Gets or sets current location of the <see cref="T:Avalonia.Controls.ButtonSpinner" />.
        /// </summary>
        [Parameter] public AC.Location? ButtonSpinnerLocation { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the spin buttons should be shown.
        /// </summary>
        [Parameter] public bool? ShowButtonSpinner { get; set; }

        public new AC.ButtonSpinner NativeControl => (AC.ButtonSpinner)((AvaloniaObject)this).NativeControl;

        protected override AvaloniaBindableObject CreateNativeElement() => new AC.ButtonSpinner();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(AllowSpin):
                    if (!Equals(AllowSpin, value))
                    {
                        AllowSpin = (bool?)value;
                        NativeControl.AllowSpin = AllowSpin ?? (bool)AC.ButtonSpinner.AllowSpinProperty.GetDefaultValue(AC.ButtonSpinner.AllowSpinProperty.OwnerType);
                    }
                    break;
                case nameof(ButtonSpinnerLocation):
                    if (!Equals(ButtonSpinnerLocation, value))
                    {
                        ButtonSpinnerLocation = (AC.Location?)value;
                        NativeControl.ButtonSpinnerLocation = ButtonSpinnerLocation ?? (AC.Location)AC.ButtonSpinner.ButtonSpinnerLocationProperty.GetDefaultValue(AC.ButtonSpinner.ButtonSpinnerLocationProperty.OwnerType);
                    }
                    break;
                case nameof(ShowButtonSpinner):
                    if (!Equals(ShowButtonSpinner, value))
                    {
                        ShowButtonSpinner = (bool?)value;
                        NativeControl.ShowButtonSpinner = ShowButtonSpinner ?? (bool)AC.ButtonSpinner.ShowButtonSpinnerProperty.GetDefaultValue(AC.ButtonSpinner.ShowButtonSpinnerProperty.OwnerType);
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
