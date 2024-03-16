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

namespace ProfWorld
{
    /// <summary>
    /// Логика взаимодействия для EnterWindows.xaml
    /// </summary>
    public partial class EnterWindows : Window
    {
        public EnterWindows()
        {
            InitializeComponent();
        }

        private void авторизация(object sender, RoutedEventArgs e)
        {
            if(tblog.Text == "Логин" & tbpass.Text == "Пароль")
            {
                Window main = new MainWindow();
                this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Ошибка!");
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
