using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Windows.Mvvm;

namespace App10AsyncTask.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        #region Commands
        public DelegateCommand StartCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }
        #endregion

        #region Properties

        private int _progressBarOneValue;

        public int ProgressBarOneValue
        {
            get { return _progressBarOneValue; }
            set
            {
                SetProperty(ref _progressBarOneValue, value);
            }
        }

        private int _progressBarTwoValue;

        public int ProgressBarTwoValue
        {
            get { return _progressBarTwoValue; }
            set { SetProperty(ref _progressBarTwoValue, value); }
        }

        private int _progressBarThreeValue;

        public int ProgressBarThreeValue
        {
            get { return _progressBarThreeValue; }
            set { SetProperty(ref _progressBarThreeValue, value); }
        }

        public string ProgressBarOneText { get; set; }
        public string ProgressBarTwoText { get; set; }
        public string ProgressBarThreeText { get; set; }

        public CancellationTokenSource CancellationTokenSource { get; set; }
        #endregion

        public bool RunTask;

        public MainPageViewModel()
        {
            StartCommand = new DelegateCommand(Start, () => !RunTask);
            CancelCommand = new DelegateCommand(Cancel, () => RunTask);
        }

        private void Cancel()
        {
            if (CancellationTokenSource != null)
            {
                CancellationTokenSource.Cancel();
            }

            RunTask = false;

            StartCommand.RaiseCanExecuteChanged();
            CancelCommand.RaiseCanExecuteChanged();

        }

        private async void Start()
        {
            try
            {
                CancellationTokenSource = new CancellationTokenSource();

                RunTask = true;
                StartCommand.RaiseCanExecuteChanged();
                CancelCommand.RaiseCanExecuteChanged();

                var tasks = new List<Task>();

                tasks.AddRange(new List<Task>()
                {
                    InitializeProgressBar(ProgressBarOneText, new Progress<int>(p => ProgressBarOneValue = p), CancellationTokenSource.Token),
                    InitializeProgressBar(ProgressBarTwoText, new Progress<int>(p => ProgressBarTwoValue = p), CancellationTokenSource.Token),
                    InitializeProgressBar(ProgressBarThreeText, new Progress<int>(p => ProgressBarThreeValue = p), CancellationTokenSource.Token),
                });

                await Task.WhenAll(tasks);
            }
            catch (OperationCanceledException)
            {

            }
            finally
            {
                RunTask = false;
                StartCommand.RaiseCanExecuteChanged();
                CancelCommand.RaiseCanExecuteChanged();
            }
        }

        private async Task InitializeProgressBar(string valueText, IProgress<int> progress, CancellationToken token)
        {
            if (int.TryParse(valueText, out var time))
            {
                await Task.Run(async () =>
                {
                    progress.Report(0);
                    for (int i = 0; i <= time; i++)
                    {
                        await Task.Delay(300, token);
                        progress.Report(i);
                        token.ThrowIfCancellationRequested();
                    }
                }, token);
            }
        }
    }
}
