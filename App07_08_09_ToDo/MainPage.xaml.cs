using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App07_08_09_ToDo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string Name = String.Empty;
           
        public ObservableCollection<Person> People { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            People = new ObservableCollection<Person>();
        }

        private void AddPersonToCollection(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(Name))
            {
                People.Add(new Person() { FullName = Name });
                Name = string.Empty;
            }
        }
    }
}
