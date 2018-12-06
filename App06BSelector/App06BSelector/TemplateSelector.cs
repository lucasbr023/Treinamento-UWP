using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App06BSelector
{
    public class TemplateSelector : DataTemplateSelector
    {
        public DataTemplate RedTemplate { get; set; }
        public DataTemplate GreenTemplate { get; set; }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            return null;
        }
    }
}
