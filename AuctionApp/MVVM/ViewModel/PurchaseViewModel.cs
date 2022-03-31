using AuctionApp.Core;
using AuctionApp.MVVM.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AuctionApp.MVVM.ViewModel
{
    class PurchaseViewModel : ObservableObject
    {
        public RelayCommand openItemDetails { get; set; }

        public PurchaseViewModel()
        {
            openItemDetails = new RelayCommand(o =>
            {
                var vm = new ItemDetailsViewModel();
                var detailsWin = new ItemDetailsView("1", "2", "3", "4", "5");
                detailsWin.DataContext = vm;
             
                detailsWin.ShowDialog();
            });
        }
    }
}
