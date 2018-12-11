using Windows.UI;
using Windows.UI.Xaml;
using ChallengeCustomControlCounter.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ChallengeCustomControlCounter.Controls
{
    public sealed partial class CounterControl : UserControl
    {
        public CounterControlViewModel ViewModel { get; set; }
        public CounterControl()
        {
            this.InitializeComponent();
            PointValue = 0;
            TextBlockPointValue.Text = PointValue.ToString();
        }

        private int pointValue;

        public int PointValue
        {
            get { return pointValue; }
            set
            {
                pointValue = value;
                DefineColorPointText();
            }
        }


        private void AddPoint(object sender, RoutedEventArgs e)
        {
            PointValue = PointValue + 1;
            TextBlockPointValue.Text = PointValue.ToString();
        }

        private void RemovePoint(object sender, RoutedEventArgs e)
        {
            PointValue = PointValue - 1;
            TextBlockPointValue.Text = PointValue.ToString();
        }

        private void DefineColorPointText()
        {
            if (PointValue < 0) 
            {
                TextBlockPointValue.Foreground = new SolidColorBrush(Colors.Red);
            }else if (PointValue > 0)
            {
                TextBlockPointValue.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                TextBlockPointValue.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

    }
}
