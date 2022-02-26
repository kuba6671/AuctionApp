using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
    /// Interaction logic for RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : Window
    {
        int i = 0;

        public SecureString SecurePassword { private get; set; }

        public RegistrationView()
        {
            InitializeComponent();
        }

        private void UsernameTextbox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (this.i == 0)
            {
                UsernameTextbox.Text = "";
                i++;
            }
        }

        private void PasswordTextbox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            SecurePassword = PasswordTextbox.SecurePassword;
        }
        private void SignUp(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextbox.Text;

            LoginPanel loginWin = new LoginPanel();
            this.Visibility = Visibility.Hidden;
            loginWin.Show();
        }
    }
}
