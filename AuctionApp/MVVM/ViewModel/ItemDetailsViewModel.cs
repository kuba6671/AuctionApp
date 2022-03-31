using AuctionApp.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AuctionApp.MVVM.ViewModel
{
    class ItemDetailsViewModel
    {
        public RelayCommand CloseCommand { get; private set; }

        public ItemDetailsViewModel()
        {
             CloseCommand = new RelayCommand(o =>
             {
                 foreach (Window item in Application.Current.Windows)
                 {
                     Trace.WriteLine("Dupa");
                     if (item.DataContext == this) item.Close();
                 }
             });

        }
    }
}
