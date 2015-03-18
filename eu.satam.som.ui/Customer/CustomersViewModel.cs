using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using eu.satam.som.dao.Model;
using eu.satam.som.ui.Common;

namespace eu.satam.som.ui.Customer
{
    public class CustomersViewModel : ViewModelBase
    {
        public ObservableCollection<Company> Customers { get; set; }
        public ICollectionView CustomersView { get; private set; }
        public ICommand AddCustomer { get; private set; }

        private Timer _updateFilterTimer;

        private string _searchClient = string.Empty;

        public string SearchClient
        {
            get { return _searchClient; }
            set
            {
                if (_searchClient.Equals(value)) { return; }

                _searchClient = value;
                RaisePropertyChanged("SearchClient");
                NeedRefresh = true;
            }
        }

        public bool NeedRefresh { get; set; }

        public CustomersViewModel()
        {
            Dispatcher = Dispatcher.CurrentDispatcher;

            Customers = new ObservableCollection<Company>();
            CustomersView = CollectionViewSource.GetDefaultView(Customers);

            AddCustomer = new Command<object>((o) => { });

            _updateFilterTimer = new Timer(UpdateFilter, null, 0, 500);
        }

        public Dispatcher Dispatcher { get; private set; }

        private void UpdateFilter(object state)
        {
            if (!NeedRefresh) { return; }
            Dispatcher.Invoke(() =>
            {
                CustomersView.Filter = o =>
                {
                    if (o is Company)
                    {
                        var c = (Company)o;
                        if (c.name.StartsWith(_searchClient, StringComparison.InvariantCultureIgnoreCase))
                        {
                            return true;
                        }
                    }
                    return false;
                };
            });
        }
    }

}