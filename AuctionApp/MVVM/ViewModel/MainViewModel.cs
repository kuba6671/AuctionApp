using AuctionApp.Core;
using AuctionApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AuctionApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand SellViewCommand { get; set; }

        public RelayCommand PurchaseViewCommand { get; set; }

        public RelayCommand CloseCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public SellViewModel SellVM { get; set; }
        public PurchaseViewModel PurchaseVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            SellVM = new SellViewModel();
            PurchaseVM = new PurchaseViewModel();

            CurrentView = HomeVM;
            if (Counter.getCounterMainWindow() == 0)
            {
                Counter.incrementMainWindow();
            }
            else
            {
                CurrentView = PurchaseVM;
            }

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            SellViewCommand = new RelayCommand(o =>
            {
                CurrentView = SellVM;
            });

            PurchaseViewCommand = new RelayCommand(o =>
            {
                CurrentView = PurchaseVM;
            });

            CloseCommand = new RelayCommand(o =>
            {
                Application.Current.Shutdown();
            });
        }
    }
}
