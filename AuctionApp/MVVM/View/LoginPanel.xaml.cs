using AuctionApp.MVVM.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Interaction logic for LoginPanel.xaml
    /// </summary>
    public partial class LoginPanel : Window
    {
        int i = 0;
        public SecureString SecurePassword { private get; set; }

        public LoginPanel()
        {
            InitializeComponent();
        }


        private void SignIn(object sender, RoutedEventArgs e)
        {
            Database database = new Database();
            MySqlConnection connection = database.getConnection();

            string sql = "SELECT userID,username, password from user where username=@username AND password=@userPassword";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@username", UsernameTextbox.Text);
            cmd.Parameters.AddWithValue("@userPassword", PasswordTextbox.Password);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                User.SetUsername(UsernameTextbox.Text);
                string stringUserID = rdr[0].ToString();
                int userID = int.Parse(stringUserID);
                User.SetUserID(userID);
                MainWindow mainWin = new MainWindow();
                this.Visibility = Visibility.Hidden;
                mainWin.Show();
            }
            else
            {
                MessageBox.Show("Podane dane sa bledne");
            }
            rdr.Close();

        }

        private void SignUp(object sender, RoutedEventArgs e)
        {
            RegistrationView signUpWindow = new RegistrationView();
            this.Visibility = Visibility.Hidden;
            signUpWindow.Show();
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
    }
}
