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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();

        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            string mail = tbmail.Text;
            string login = tblogin.Text;
            RegisterUser reg = new RegisterUser();
            reg.Register(mail, login);
           
            Window enter = new EnterWindows(reg);
            this.Close();
            enter.Show();
            
        }

        private void Questionmark(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Если вы не видите письма с паролем на вашей почте, обязательно загляните в пункт СПАМ");
        }
    }
}
