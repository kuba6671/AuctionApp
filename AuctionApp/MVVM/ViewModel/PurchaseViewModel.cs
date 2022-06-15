using AuctionApp.Core;
using AuctionApp.MVVM.Model;
using AuctionApp.MVVM.View;
using MySqlConnector;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace AuctionApp.MVVM.ViewModel
{
    class PurchaseViewModel : ObservableObject
    {
        public RelayCommand StateItemCommand { get; set; }

        public RelayCommand SizeItemCommand { get; set; }

        public RelayCommand CategoryItemCommand { get; set; }

        public ObservableCollection<ItemView> itemsList { get; set; }


        public PurchaseViewModel()
        {
            string sql;
            if (Counter.getCounterSearch() == 0)
            {
                sql = "SELECT * from item where userID != @userID";
                loadItems(sql);
                Counter.incrementSearch();
            }

            StateItemCommand = new RelayCommand(o =>
            {
                string trimState = state.ToString().Substring(state.ToString().IndexOf(" ") + 1);
                sql = "SELECT * from item where userID != @userID AND state= @secondParameter";
                loadItems(sql, trimState);
            });

            SizeItemCommand = new RelayCommand(o =>
            {
                string trimSize = size.ToString().Substring(size.ToString().IndexOf(" ") + 1);
                sql = "SELECT * from item where userID != @userID AND size= @secondParameter";
                loadItems(sql, trimSize);

            });

            CategoryItemCommand = new RelayCommand(o =>
            {
                string trimCategory = category.ToString().Substring(category.ToString().IndexOf(" ") + 1);
                sql = "SELECT * from item where userID != @userID AND category= @secondParameter";
                loadItems(sql, trimCategory);
            });
        }

        private string state = "";
        public string getState
        {
            get { return this.state; }
            set
            {
                if (!string.Equals(this.state, value))
                {
                    this.state = value;
                    OnPropertyChanged();
                }
            }
        }

        private string size = "";
        public string getSize
        {
            get { return this.size; }
            set
            {
                if (!string.Equals(this.size, value))
                {
                    this.size = value;
                    OnPropertyChanged();
                }
            }
        }

        private string category = "";
        public string getCategory
        {
            get { return this.category; }
            set
            {
                if (!string.Equals(this.category, value))
                {
                    this.category = value;
                    OnPropertyChanged();
                }
            }
        }

        private void loadItems(string sql)
        {
            Database database = new Database();
            MySqlConnection connection = database.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@userID", User.getUserID());
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<ItemView> items = new List<ItemView>();

            while (rdr.Read())
            {
                ItemToSell itemToSell = new ItemToSell(rdr);
                items.Add(new ItemView(itemToSell));
            }

            itemsList = new ObservableCollection<ItemView> { };
            foreach (ItemView item in items)
            {
                itemsList.Add(item);
            }
        }

        private void loadItems(string sql, string secondParameter)
        {
            Database database = new Database();
            MySqlConnection connection = database.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@userID", User.getUserID());
            cmd.Parameters.AddWithValue("@secondParameter", secondParameter);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<ItemView> items = new List<ItemView>();

            while (rdr.Read())
            {
                ItemToSell itemToSell = new ItemToSell(rdr);
                items.Add(new ItemView(itemToSell));
            }

            itemsList = new ObservableCollection<ItemView> { };
            foreach (ItemView item in items)
            {
                itemsList.Add(item);
            }
        }
    }
}
