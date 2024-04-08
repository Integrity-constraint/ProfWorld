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
    /// Логика взаимодействия для Prof3_3.xaml
    /// </summary>
    public partial class Prof3_3 : Page
    {
        
        Robot robot = new BasicRobot();
        public Prof3_3()
        {
            InitializeComponent();

            btnarmor.IsEnabled = false;
             btnergonom.IsEnabled = false;
             btnfly.IsEnabled = false;
             btnnext.IsEnabled = false;
             
        }

        private void robotext()
        {
            tbstats.Text = robot.GetDescription();
        }

        private void next(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Таким образом: Паттерн “Декоратор” в программировании - это способ добавления новых функций к объекту " +
                "без изменения его структуры. " +
                "Это немного похоже на то, как вы тольуо что улучшили робота, не меняя самого робота.");
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Prof3_4());
                mainWindow.st4();
            }
        }

        private void addswim(object sender, RoutedEventArgs e)
        {
            robot = new SwimmingRobot(robot);
            robotext();
            image.Source= new BitmapImage(new Uri("imgprog/robotswim.png", UriKind.Relative));
            btnfly.IsEnabled =true;
            btnswim.IsEnabled =false;
        }

        private void addfly(object sender, RoutedEventArgs e)
        {
            robot = new FlyingRobot(robot);
            robotext();
            image.Source = new BitmapImage(new Uri("imgprog/robotsfly.png", UriKind.Relative));
            btnarmor.IsEnabled = true;
            btnfly.IsEnabled = false;
        }

        private void addarmor(object sender, RoutedEventArgs e)
        {
            robot = new ArmoredRobot(robot);
            robotext();
            image.Source = new BitmapImage(new Uri("imgprog/robotsarmor.png", UriKind.Relative));
            btnarmor.IsEnabled = false;
            btnergonom.IsEnabled=true;
        }

        private void roboergonomic(object sender, RoutedEventArgs e)
        {
            robot = new ErgonomicRobot(robot);
            robotext();
            image.Source = new BitmapImage(new Uri("imgprog/robotsergonomic.png", UriKind.Relative));
            btnergonom.IsEnabled = false;
            btnnext.IsEnabled = true;
        }
    }
}
