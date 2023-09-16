//// Copyright (c) Microsoft Corporation.
//// Licensed under the MIT license.

//namespace BlazorBindings.AvaloniaBindings.Elements;

//public partial class AttributeHelper
//{
//    private static readonly FlexBasisTypeConverter _flexBasisConverter = new();

//    public static FlexBasis StringToFlexBasis(object value)
//    {
//        return value switch
//        {
//            FlexBasis flexBasis => flexBasis,
//            float f => (FlexBasis)f,
//            string str => (FlexBasis)_flexBasisConverter.ConvertFromInvariantString(str),
//            _ => throw new ArgumentException("Cannot convert value to FlexBasis.", nameof(value))
//        };
//    }
//}
