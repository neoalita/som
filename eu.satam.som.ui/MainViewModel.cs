using System;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using eu.satam.som.dao.Model;
using eu.satam.som.ui.Common;
using eu.satam.som.ui.Customer;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace eu.satam.som.ui
{
    public class MainViewModel : ViewModelBase
    {
        private bool _isLoading;
        public CustomersViewModel CustomersViewModel { get; set; }

        public bool IsLoading
        {
            get { return _isLoading; }
            set { SetProperty(ref _isLoading, value, () => IsLoading); }
        }

        public MainViewModel(MetroWindow mainWindow)
        {
            Dispatcher = Dispatcher.CurrentDispatcher;
            CustomersViewModel = new CustomersViewModel();

            IsLoading = true;
         
        }

        public Dispatcher Dispatcher { get; private set; }
    }
}