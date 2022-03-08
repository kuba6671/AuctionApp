using AuctionApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AuctionApp.MVVM.ViewModel
{
    class LoginViewModel
    {

        public RelayCommand CloseCommand { get; set; }


        public LoginViewModel()
        {
            CloseCommand = new RelayCommand(o =>
            {
                Application.Current.Shutdown();
            });
        }
    }
}
