using ChallengeCustomControlCounter.Constants;
using Prism.Unity.Windows;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace ChallengeCustomControlCounter
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : PrismUnityApplication
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            return base.OnInitializeAsync(args);
        }

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate(PageTokens.MainPage, null);
            return Task.FromResult(true);
        }


        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }
    }
}
