using App07_08_09_ToDo.ViewModels;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App07_08_09_ToDo.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get { return (MainPageViewModel)this.DataContext; } }
        public MainPage()
        {
            this.InitializeComponent();
        }
    }
}
