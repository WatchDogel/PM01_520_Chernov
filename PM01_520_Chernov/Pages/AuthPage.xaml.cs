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

namespace PM01_520_Chernov.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }
        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {
            {
                txtHintLogin.Visibility = Visibility.Visible;
                if (login.Text.Length > 0)
                {
                    txtHintLogin.Visibility = Visibility.Hidden;
                }
            }

        }
        private void PassWr_PasswordChanged(object sender, RoutedEventArgs e)
        {
            {
                PassHint.Visibility = Visibility.Visible;
                if (PassWr.Password.Length > 0)
                {
                    PassHint.Visibility = Visibility.Hidden;
                }
            }

        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(PassWr.Password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
        }
    }
}
