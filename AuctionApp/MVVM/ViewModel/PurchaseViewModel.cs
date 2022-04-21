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
        //private string itemID;
        //private string itemName;

        public RelayCommand openItemDetails { get; set; }

        public ObservableCollection<ItemView> itemsList { get; set; }

        public PurchaseViewModel()
        {
            Database database = new Database();
            MySqlConnection connection = database.getConnection();

            string sql = "SELECT * from item where userID=@userID";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@userID", User.getUserID());
            MySqlDataReader rdr = cmd.ExecuteReader();


            List<ItemView> items = new List<ItemView>();

            while (rdr.Read())
            {
                ItemToSell itemToSell = new ItemToSell(rdr);
                items.Add(new ItemView(itemToSell));
            }

            itemsList = new ObservableCollection<ItemView>{};
            foreach (ItemView item in items)
            {
                itemsList.Add(item);
            }

        }
    }
}
