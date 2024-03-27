using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace ProfWorld
{
    /// <summary>
    /// Логика взаимодействия для EnterWindows.xaml
    /// </summary>
    public partial class EnterWindows : Window
    {

        private RegisterUser _user;
        public EnterWindows(RegisterUser user)
        {
            InitializeComponent();
            _user = user;


        }

        private void авторизация(object sender, RoutedEventArgs e)
        {
            string enteredLogin = tblog.Text;
            string enteredPassword = tbpass.Text;

            if (enteredLogin == _user.Login & enteredPassword == _user.pass)
            {
                MessageBox.Show("Авторизация прошла успешно!");
                // Здесь можно перейти к следующему окну
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }

        }

        private void Регистрация(object sender, RoutedEventArgs e)
        {
            Window reg = new RegisterWindow();
            this.Close();
            reg.Show();
        }
    }
}
