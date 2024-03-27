using System;
using System.Collections.Generic;
using System.IO.Packaging;
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

        public string LOg;
        public string PAs;
        public EnterWindows()
        {
            InitializeComponent();
           


        }

        private void авторизация(object sender, RoutedEventArgs e)
        {
            if (tblog.Text == DataBank.login & tbpass.Text == DataBank.password)
            {
                MessageBox.Show("Вход успешен!");
                Window win = new MainWindow();
                win.Show();
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
