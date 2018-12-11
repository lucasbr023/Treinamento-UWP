using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Windows.Mvvm;

namespace ChallengeCustomControlCounter.ViewModels
{
    public class CounterControlViewModel : ViewModelBase
    {
        #region Commands
        public DelegateCommand AddPointCommand { get; set; }
        public DelegateCommand RemovePointCommnad { get; set; }
        #endregion

        #region Properties

        private int _pointValue;

        public int PointValue
        {
            get { return _pointValue; }
            set { SetProperty(ref _pointValue, value); }
        }


        #endregion

        //public CounterControlViewModel()
        //{
        //    AddPointCommand = new DelegateCommand(AddPoint);
        //    RemovePointCommnad = new DelegateCommand(RemovePoint);
        //    PointValue = 0;
        //}

     
    }
}
