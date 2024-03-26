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
    /// <summary>
    /// Логика взаимодействия для Prof1_5.xaml
    /// </summary>
    public partial class Prof1_5 : Page
    {
        private bool isКирпичGuessed = false;
        private bool isЛопатаGuessed = false;
        public Prof1_5()
        {
            InitializeComponent();

            // Добавляем обработчики событий для каждого TextBox
            tbK.TextChanged += (s, e) => CheckLetter(s, 'к');
            tbN.TextChanged += (s, e) => CheckLetter(s, 'и');
            tbР.TextChanged += (s, e) => CheckLetter(s, 'р');
            tbП.TextChanged += (s, e) => CheckLetter(s, 'п'); // Общая буква 'п' для обоих слов
            tbИ.TextChanged += (s, e) => CheckLetter(s, 'и');
            tbЧ.TextChanged += (s, e) => CheckLetter(s, 'ч');
            tbЛ.TextChanged += (s, e) => CheckLetter(s, 'л');
            tbО.TextChanged += (s, e) => CheckLetter(s, 'о');
            tbА.TextChanged += (s, e) => CheckLetter(s, 'а');
            tbТ.TextChanged += (s, e) => CheckLetter(s, 'т');
            tbА1.TextChanged += (s, e) => CheckLetter(s, 'а');
        }

        private void CheckLetter(object sender, char correctLetter)
        {
            var textBox = sender as TextBox;
            if (textBox.Text.ToLower() != correctLetter.ToString())
            {
                MessageBox.Show("Неверная буква! Пожалуйста, попробуйте снова.");
                textBox.Text = string.Empty;
            }
            else
            {
                // Проверяем, угадано ли слово "кирпич"
                if (!isКирпичGuessed && tbK.Text.ToLower() == "к" && tbN.Text.ToLower() == "и" && tbР.Text.ToLower() == "р" &&
                    tbП.Text.ToLower() == "п" && tbИ.Text.ToLower() == "и" && tbЧ.Text.ToLower() == "ч")
                {
                    isКирпичGuessed = true; // Устанавливаем переменную в true

                    // Блокируем TextBox'ы
                    tbK.IsEnabled = false;
                    tbП.IsEnabled = false;
                    tbN.IsEnabled = false;
                    tbР.IsEnabled = false;
                    tbИ.IsEnabled = false;
                    tbЧ.IsEnabled = false;

                    MessageBox.Show("Вы угадали слово 'кирпич'!");
                }

                // Проверяем, угадано ли слово "лопата"
                if (!isЛопатаGuessed && tbЛ.Text.ToLower() == "л" && tbО.Text.ToLower() == "о" && tbП.Text.ToLower() == "п" &&
                    tbА.Text.ToLower() == "а" && tbТ.Text.ToLower() == "т" && tbА1.Text.ToLower() == "а")
                {
                    isЛопатаGuessed = true; // Устанавливаем переменную в true

                    // Блокируем TextBox'ы
                    tbЛ.IsEnabled = false;
                    tbП.IsEnabled = false;
                    tbО.IsEnabled = false;
                    tbА.IsEnabled = false;
                    tbТ.IsEnabled = false;
                    tbА1.IsEnabled = false;

                    MessageBox.Show("Вы угадали слово 'лопата'!");
                }
            
        }
        }

        private void end(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                mainWindow.MainFrame.Navigate(new main());
                mainWindow.end();
                mainWindow.finish1();
            }
        }
    }
}
