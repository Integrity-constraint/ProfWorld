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
using HandyControl.Tools;
namespace ProfWorld
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConfigHelper.Instance.SetLang("ru");
            PreviewKeyDown += MainWindow_PreviewKeyDown;
        }

        private void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (DeveloperMenu.Visibility == Visibility.Collapsed)
                {
                    DeveloperMenu.Visibility = Visibility.Visible;
                }
                else
                {
                    DeveloperMenu.Visibility = Visibility.Collapsed;
                }
            }
        }
        private void DeveloperButton_Click(object sender, RoutedEventArgs e)
        {
            if (DeveloperMenu.Visibility == Visibility.Collapsed)
            {
                DeveloperMenu.Visibility = Visibility.Visible;
            }
            else
            {
                DeveloperMenu.Visibility = Visibility.Collapsed;
            }
        }

        private void Prof1(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof1/Prof1_1.xaml", UriKind.Relative));
                QuestName.Content = "Квест 1";
                mainWindow.st1();
            }          
        }
        private void Prof1_1(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof1/Prof1_1.xaml", UriKind.Relative));
            }
        }

        private void Prof1_2(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof1/Prof1_2.xaml", UriKind.Relative));
            }
        }

        private void Prof1_3(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof1/Prof1_3.xaml", UriKind.Relative));
            }
        }

        private void Prof1_4(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof1/Prof1_4.xaml", UriKind.Relative));
            }
        }

        private void Prof1_5(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof1/Prof1_5.xaml", UriKind.Relative));
            }
        }
        private void Prof2(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof2/Prof2_1.xaml", UriKind.Relative));
                QuestName.Content = "Квест 2";
                mainWindow.st1();
            }
        }

        private void Prof2_1(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof2/Prof2_1.xaml", UriKind.Relative));
            }
        }

        private void Prof2_2(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof2/Prof2_2.xaml", UriKind.Relative));
            }
        }

        private void Prof2_3(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof2/Prof2_3.xaml", UriKind.Relative));
            }
        }

        private void Prof2_4(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof2/Prof2_4.xaml", UriKind.Relative));
            }
        }

        private void Prof2_5(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof2/Prof2_5.xaml", UriKind.Relative));
            }
        }

        private void Prof3(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof3/Prof3_1.xaml", UriKind.Relative));
                QuestName.Content = "Квест 3";
                mainWindow.st1();
            }
        }

        private void Prof3_1(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof3/Prof3_1.xaml", UriKind.Relative));
            }
        }
        private void Prof3_2(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof3/Prof3_2.xaml", UriKind.Relative));
            }
        }
        private void Prof3_3(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof3/Prof3_3.xaml", UriKind.Relative));
            }
        }
        private void Prof3_4(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof3/Prof3_4.xaml", UriKind.Relative));
            }
        }
        private void Prof3_5(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Uri("/Pages/Prof3/Prof3_5.xaml", UriKind.Relative));
            }
        }

        public void st1()
        {
            qst1.IsEnabled = true;
        }

        public void st2()
        {
            qst2.IsEnabled = true;
        }

        public void st3()
        {
            qst3.IsEnabled = true;
        }

        public void st4()
        {
            qst4.IsEnabled = true;
        }

        public void st5()
        {
            qst5.IsEnabled = true;
        }

        public void end()
        {
            qst1.IsEnabled = false;
            qst2.IsEnabled = false;
            qst3.IsEnabled = false;
            qst4.IsEnabled = false;
            qst5.IsEnabled = false;
        }

        public void finish1()
        {
            pr1.IsEnabled = false;
        }
        public void finish2()
        {
            pr2.IsEnabled = false;
        }
        public void finish3()
        {
            pr3.IsEnabled = false;
        }
    }
}
