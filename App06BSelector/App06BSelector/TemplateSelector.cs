using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App06BSelector
{
    public class TemplateSelector : DataTemplateSelector
    {
        public DataTemplate ListViewPersonSelectorRed { get; set; }
        public DataTemplate ListViewPersonSelectorGreen { get; set; }
        public int Index = 0;
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var person = item as Person;
            
            return person.Age < 25 ? ListViewPersonSelectorGreen : ListViewPersonSelectorRed;
        }
    }
}
