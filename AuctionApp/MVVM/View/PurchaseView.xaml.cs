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
            /* TextBlock myTextBlock = new TextBlock();
             myTextBlock.TextWrapping = TextWrapping.Wrap;
             myTextBlock.Margin = new Thickness(0, 0, 0, 20);
             myTextBlock.Text = "Scrolling is enabled when it is necessary. Resize the Window, making it larger and smaller.";

             Rectangle myRectangle = new Rectangle();
             myRectangle.Fill = Brushes.Red;
             myRectangle.Width = 500;
             myRectangle.Height = 500;
             // Add child elements to the parent StackPanel
             myStackPanel.Children.Add(myTextBlock);
             myStackPanel.Children.Add(myRectangle);*/
            ItemView item1 = new ItemView();
            ItemView item2 = new ItemView();
            ItemView item3 = new ItemView();
            ItemView item4 = new ItemView();
            myStackPanel.Children.Add(item1);
            myStackPanel.Children.Add(item2);
            myStackPanel.Children.Add(item3);
            myStackPanel.Children.Add(item4);


            ItemsScrollViewer.Content = myStackPanel;
        }
    }
}
