using AuctionApp.Core;
using AuctionApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using MySqlConnector;

namespace AuctionApp.MVVM.ViewModel
{
    class ItemDetailsViewModel : ObservableObject
    {
        public RelayCommand CloseCommand { get; private set; }

        public RelayCommand BuyCommand { get; private set; }

        private string category;
        private string name;
        private string state;
        private string size;
        private string price;
        private ImageSource ItemPhoto;

        public ItemDetailsViewModel() { }

        public ItemDetailsViewModel(ItemToSell itemToSell)
        {
            size = itemToSell.getSize();
            state = itemToSell.getState();
            price = itemToSell.getPrice().ToString();
            category = itemToSell.getCategory();
            name = itemToSell.getName();
            ItemPhoto = new BitmapImage(new Uri(itemToSell.getURL()));

            CloseCommand = new RelayCommand(o =>
            {
                foreach (Window item in Application.Current.Windows)
                {
                    if (item.DataContext == this) item.Close();
                }
            });

            BuyCommand = new RelayCommand(o =>
            {
                Database database = new Database();
                MySqlConnection connection = database.getConnection();
                String sql = "DELETE FROM ITEM WHERE itemID=@itemID";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@itemID", itemToSell.getId());
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr != null)
                {
                    MessageBox.Show("Przedmiot zostal kupiony");
                    foreach (Window item in Application.Current.Windows)
                    {
                        if(item.ToString()== "AuctionApp.MainWindow")
                        {
                            item.Close();
                        }
                        if (item.DataContext == this)
                        {
                            item.Close();
                            MainWindow newWindow = new MainWindow();
                            Application.Current.MainWindow = newWindow;
                            newWindow.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cos poszlo nie tak");
                }
            });
        }

        public ImageSource itemDetailsPhoto
        {
            get { return ItemPhoto; }
            set
            {
                ItemPhoto = value;
                OnPropertyChanged();
            }
        }

        public string CategoryText
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

        public string NameText
        {
            get { return this.name; }
            set
            {
                if (!string.Equals(this.name, value))
                {
                    this.name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string StateText
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

        public string SizeText
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

        public string PriceText
        {
            get { return this.price; }
            set
            {
                if (!string.Equals(this.price, value))
                {
                    this.price = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
