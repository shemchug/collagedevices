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

namespace CollageDevices
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void usrtLogin(string Login, string Password)
        {
            var userLogin = CollageDevicesEntities.GetContext().Users.Where(p => p.Login == Login && p.Password == Password).FirstOrDefault();
            if (userLogin != null)
            {
                MessageBox.Show($"Здравствуйте, {userLogin.FullName}!");
            }
            else
            {
                MessageBox.Show("Введён неверный логин или пароль!");
            }
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            usrtLogin(tbLogin.Text, pbPassword.Password);
        }
    }
}
