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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuctionApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for PurchaseView.xaml
    /// </summary>
    public partial class PurchaseView : UserControl
    {
        public PurchaseView()
        {
            InitializeComponent();

            StackPanel myStackPanel = new StackPanel();
            myStackPanel.HorizontalAlignment = HorizontalAlignment.Left;
            myStackPanel.VerticalAlignment = VerticalAlignment.Top;

            ItemView item1 = new ItemView("Nazwa1");
            ItemView item2 = new ItemView("Nazwa2");
            ItemView item3 = new ItemView("Nazwa3");
            ItemView item4 = new ItemView("Nazwa4");
            myStackPanel.Children.Add(item1);
            myStackPanel.Children.Add(item2);
            myStackPanel.Children.Add(item3);
            myStackPanel.Children.Add(item4);


            ItemsScrollViewer.Content = myStackPanel;
        }
    }
}
