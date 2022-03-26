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
                ItemDetailsView detailsWin = new ItemDetailsView();
                foreach (Window item in Application.Current.Windows)
                {
                    if(item != detailsWin)
                        item.Close();
                }
                detailsWin.ShowDialog();
            });
        }
    }
}
