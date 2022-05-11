using AuctionApp.MVVM.Model;
using AuctionApp.MVVM.ViewModel;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuctionApp.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy ItemView.xaml
    /// </summary>
    public partial class ItemView : UserControl
    {
        ItemToSell itemToSell;

        public ItemView(ItemToSell itemToSell)
        {
            InitializeComponent();
            MySqlDataReader rdr = itemToSell.getRdr();
            this.itemToSell = new ItemToSell(rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(),
                Double.Parse(rdr[5].ToString()), rdr[6].ToString());
            itemID.Text = rdr[0].ToString();
            itemName.Text = this.itemToSell.getName();
            SellItemPhoto.Source = new BitmapImage(new Uri(this.itemToSell.getURL()));
        }

        public string getID()
        {
            return itemID.Text;
        }

        public string getName()
        {
            return itemName.Text;
        }

        private void openItemDetails(object sender, RoutedEventArgs e)
        {
            var vm = new ItemDetailsViewModel(itemToSell);
            var detailsWin = new ItemDetailsView();
            detailsWin.DataContext = vm;
            detailsWin.ShowDialog();
        }
    }
}
