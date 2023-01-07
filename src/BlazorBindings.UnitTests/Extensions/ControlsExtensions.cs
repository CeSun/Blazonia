using Microsoft.Maui.Controls;

namespace BlazorBindings.UnitTests.Extensions
{
    public static class ControlsExtensions
    {
        public static T GetTemplateContent<T>(this TemplatedView view)
        {
            return (T)((Layout)view.Children[0]).Children[0];
        }

        public static T GetTemplateContent<T>(this object templateRoot)
        {
            return (T)((Layout)templateRoot).Children[0];
        }
    }
}
