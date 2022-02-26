using System;
using System.Collections.Generic;
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
            string username = UsernameTextbox.Text;
            string userUsername = "user";
            string chars = "pass";
            SecureString secureUserPassword = new SecureString();

            foreach (char ch in chars)
                secureUserPassword.AppendChar(ch);

            if (SecureStringEqual(SecurePassword, secureUserPassword) && (username.Equals(userUsername)))
            {
                MainWindow mainWin = new MainWindow();
                this.Visibility = Visibility.Hidden;
                mainWin.Show();
            }
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

        Boolean SecureStringEqual(SecureString secureString1, SecureString secureString2)
        {
            if (secureString1 == null)
            {
                //throw new ArgumentNullException("s1");
                return false;
            }
            if (secureString2 == null)
            {
                return false;
                //throw new ArgumentNullException("s2");
            }

            if (secureString1.Length != secureString2.Length)
            {
                return false;
            }

            IntPtr ss_bstr1_ptr = IntPtr.Zero;
            IntPtr ss_bstr2_ptr = IntPtr.Zero;

            try
            {
                ss_bstr1_ptr = Marshal.SecureStringToBSTR(secureString1);
                ss_bstr2_ptr = Marshal.SecureStringToBSTR(secureString2);

                String str1 = Marshal.PtrToStringBSTR(ss_bstr1_ptr);
                String str2 = Marshal.PtrToStringBSTR(ss_bstr2_ptr);

                return str1.Equals(str2);
            }
            finally
            {
                if (ss_bstr1_ptr != IntPtr.Zero)
                {
                    Marshal.ZeroFreeBSTR(ss_bstr1_ptr);
                }

                if (ss_bstr2_ptr != IntPtr.Zero)
                {
                    Marshal.ZeroFreeBSTR(ss_bstr2_ptr);
                }
            }
        }
    }
}
