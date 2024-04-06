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

namespace ProfWorld.Pages.Prof3
{
    /// <summary>
    /// Логика взаимодействия для Prof3_1.xaml
    /// </summary>
    public partial class Prof3_1 : Page
    {
        public Prof3_1()
        {
            InitializeComponent();

        }

        private void next(object sender, RoutedEventArgs e)
        {
            if(rbright.IsChecked == true | rbwrong1.IsChecked ==true | rbwrong2.IsChecked == true)
            {
                Window parentWindow = Window.GetWindow(this);
                if (parentWindow != null && parentWindow is MainWindow mainWindow)
                {
                    // Загружаем следующую страницу в главное окно
                    mainWindow.MainFrame.Navigate(new Prof3_2());
                    mainWindow.st2();
                }
            }
            
           
        }
    }
}
