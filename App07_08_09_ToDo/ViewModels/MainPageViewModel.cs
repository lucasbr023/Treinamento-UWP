using App07_08_09_ToDo.Models;
using Prism.Commands;
using Prism.Windows.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace App07_08_09_ToDo.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        #region Properties
        public ObservableCollection<Person> People { get; set; }
        #endregion

        #region Commands
        public DelegateCommand<string> AddPersonNameCommand { get; private set; }
        #endregion

        public MainPageViewModel()
        {
            People = new ObservableCollection<Person>();
            AddPersonNameCommand = new DelegateCommand<string>(AddPersonName);
        }

        private void AddPersonName(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                People.Add(new Person() { FullName = name });
                name = string.Empty;
            }
        }
    }
}
