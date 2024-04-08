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
    /// Логика взаимодействия для Prof3_2.xaml
    /// </summary>
    public partial class Prof3_2 : Page
    {
        public Prof3_2()
        {
            InitializeComponent();
            btnnext.IsEnabled = false;

        }
       
        private void next(object sender, RoutedEventArgs e)
        {
           
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Prof3_3());
                mainWindow.st3();
            }
        }

        private void patterns(object sender, RoutedEventArgs e)
        {
            zagolovok.Text = "Паттерны!";
            maintext.Text = "Паттерны проектирования в программировании - это проверенные решения типичных задач, " +
                "которые возникают при проектировании программного обеспечения. Они представляют собой шаблоны, которые можно применять " +
                "в различных ситуациях и контекстах. Вот несколько основных типов паттернов проектирования:\r\n\r\n" +
                "Порождающие паттерны: Эти паттерны отвечают за эффективное создание объектов. Примеры включают в себя Singleton, Factory Method, и Abstract Factory.\r\n" +
                "Структурные паттерны: Эти паттерны помогают обеспечить правильную организацию различных частей программного обеспечения. Примеры включают в себя Adapter, Decorator, и Composite.\r\n" +
                "Поведенческие паттерны: Эти паттерны определяют эффективные способы взаимодействия между объектами. Примеры включают в себя Observer, Strategy, и Command.\r\n" +
                "Использование паттернов проектирования помогает программистам создавать более эффективный, устойчивый и масштабируемый код. " +
                "Они также облегчают процесс общения между программистами, поскольку паттерны предоставляют общий язык для обсуждения решений проектирования. " +
                "Поэтому понимание и использование паттернов проектирования является важной частью работы программиста.";
           
            btnnext.IsEnabled = true;
            btnwhat.Visibility = Visibility.Hidden;
        }
    }
}
