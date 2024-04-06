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

namespace ProfWorld.Pages.Prof2
{
    /// <summary>
    /// Логика взаимодействия для Prof2_1.xaml
    /// </summary>
    public partial class Prof2_1 : Page
    {
        public Prof2_1()
        {
            InitializeComponent();
        }

        private void next(object sender, RoutedEventArgs e)
        {
            {
                // Получаем родительское окно страницы
                Window parentWindow = Window.GetWindow(this);
                if (parentWindow != null && parentWindow is MainWindow mainWindow)
                {
                    // Загружаем следующую страницу в главное окно
                    mainWindow.MainFrame.Navigate(new Prof2_2());
                    mainWindow.st2();
                }
            }
        }
    }
}