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

namespace ProfWorld.Pages
{
    public partial class Prof1_2 : Page
    {
        public Prof1_2()
        {
            InitializeComponent();
        }
        private void check(object sender, RoutedEventArgs e)
        {
            // Проверяем, правильно ли выбраны сочетания
            if (ComboBox1.SelectedIndex == 0 && ComboBox2.SelectedIndex == 1 && ComboBox3.SelectedIndex == 2)
            {
                MessageBox.Show("Поздравляем! Вы правильно угадали последовательность.");
                next1.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("К сожалению, вы сделали ошибку в последовательности. Попробуйте еще раз.");
            }
        }
        private void next(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Prof1_3());
                mainWindow.st3();
            }
        }


        private void pods(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мне кажется что любой дом начинается с его визуализации...");
            DataBank.points -= 10;
            podskazka.IsEnabled = false;
        }
    }
}
