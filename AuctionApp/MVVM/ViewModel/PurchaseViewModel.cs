using AuctionApp.Core;
using AuctionApp.MVVM.Model;
using AuctionApp.MVVM.View;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AuctionApp.MVVM.ViewModel
{
    class PurchaseViewModel : ObservableObject
    {
        public RelayCommand openItemDetails { get; set; }

        public ObservableCollection<ItemView> itemsList { get; set; }

        public PurchaseViewModel()
        {
            Database database = new Database();
            MySqlConnection connection = database.getConnection();

            string sql = "SELECT name, imageSource from item where userID=@userID";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@userID", User.getUserID());
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<ItemView> items = new List<ItemView>();

            while (rdr.Read())
            {
                items.Add(new ItemView(rdr[0].ToString()));
            }

            itemsList = new ObservableCollection<ItemView>{};
            foreach (ItemView item in items)
            {
                itemsList.Add(item);
            }
            
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
