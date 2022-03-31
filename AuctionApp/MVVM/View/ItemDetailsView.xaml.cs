using AuctionApp.MVVM.ViewModel;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace AuctionApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for ItemDetailsView.xaml
    /// </summary>
    public partial class ItemDetailsView : Window
    {
        public ItemDetailsView(string category, string size, string state, string price, string name)
        {
            InitializeComponent();
            categoryText.Text = category;
            sizeText.Text = size;
            stateText.Text = state;
            priceText.Text = price;
            nameText.Text = name;
        }
    }
}
