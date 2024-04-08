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
    /// Логика взаимодействия для Prof3_5.xaml
    /// </summary>
    public partial class Prof3_5 : Page
    {
        private bool isПрограммист= false;
        private bool isПаттерн = false;
        private bool isмассив = false;
        private bool isтабуляция = false;
        private bool isитерация = false;
        public Prof3_5()
        {
            InitializeComponent();
            tbП.TextChanged += (s, e) => CheckLetter(s, 'п');
            tbр.TextChanged += (s, e) => CheckLetter(s, 'р');
            tbо.TextChanged += (s, e) => CheckLetter(s, 'о');
            tbг.TextChanged += (s, e) => CheckLetter(s, 'г'); 
            tbр2.TextChanged += (s, e) => CheckLetter(s, 'р');
            tbа.TextChanged += (s, e) => CheckLetter(s, 'а');
            tbм.TextChanged += (s, e) => CheckLetter(s, 'м');
            tbм2.TextChanged += (s, e) => CheckLetter(s, 'м');
            tbи.TextChanged += (s, e) => CheckLetter(s, 'и');
            tbс.TextChanged += (s, e) => CheckLetter(s, 'с');
            tbт.TextChanged += (s, e) => CheckLetter(s, 'т');
            //паттерн
            tbа2.TextChanged += (s, e) => CheckLetter(s, 'а');
            tbт2.TextChanged += (s, e) => CheckLetter(s, 'т');
            tbт3.TextChanged += (s, e) => CheckLetter(s, 'т');
            tbе.TextChanged += (s, e) => CheckLetter(s, 'е');
            tbр3.TextChanged += (s, e) => CheckLetter(s, 'р');
            tbн.TextChanged += (s, e) => CheckLetter(s, 'н');
            //массив
            tbа3.TextChanged += (s, e) => CheckLetter(s, 'а');
            tbс2.TextChanged += (s, e) => CheckLetter(s, 'с');
            tbс3.TextChanged += (s, e) => CheckLetter(s, 'с');
            tbи2.TextChanged += (s, e) => CheckLetter(s, 'и');
             tbв.TextChanged += (s, e) => CheckLetter(s, 'в');


            tbа4.TextChanged += (s, e) => CheckLetter(s, 'а');
            tbб.TextChanged += (s, e) => CheckLetter(s, 'б');
            tbу.TextChanged += (s, e) => CheckLetter(s, 'у');
            tbл.TextChanged += (s, e) => CheckLetter(s, 'л');
            tbя.TextChanged += (s, e) => CheckLetter(s, 'я');
            tbц.TextChanged += (s, e) => CheckLetter(s, 'ц');
            tbи3.TextChanged += (s, e) => CheckLetter(s, 'и');
            tbя2.TextChanged += (s, e) => CheckLetter(s, 'я');

            tbт4.TextChanged += (s, e) => CheckLetter(s, 'т');
            tbе2.TextChanged += (s, e) => CheckLetter(s, 'е');
             tbР.TextChanged += (s, e) => CheckLetter(s, 'р');
             tbА.TextChanged += (s, e) => CheckLetter(s, 'а');
             tbЦ.TextChanged += (s, e) => CheckLetter(s, 'ц');
             tbИ.TextChanged += (s, e) => CheckLetter(s, 'и');
             tbЯ.TextChanged += (s, e) => CheckLetter(s, 'я');

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
                if (!isПрограммист && tbП.Text.ToLower() == "п" && tbр.Text.ToLower() == "р" && tbо.Text.ToLower() == "о" &&
                    tbг.Text.ToLower() == "г" && tbр2.Text.ToLower() == "р" && tbа.Text.ToLower() == "а" && tbм.Text.ToLower() == "м" && tbм2.Text.ToLower() == "м"
                    && tbи.Text.ToLower() == "и" && tbс.Text.ToLower() == "с" && tbт.Text.ToLower() == "т"
                    )
                {
                    isПрограммист = true; // Устанавливаем переменную в true

                    // Блокируем TextBox'ы
                    tbП.IsEnabled = false;
                    tbр.IsEnabled = false;
                    tbо.IsEnabled = false;
                    tbг.IsEnabled = false;
                   tbр2.IsEnabled = false;
                    tbа.IsEnabled = false;
                    tbм.IsEnabled = false;
                   tbм2.IsEnabled = false;
                    tbи.IsEnabled = false;
                    tbс.IsEnabled = false;
                    tbт.IsEnabled = false;

                    MessageBox.Show("Вы угадали слово 'Программист'!");
                }

                // Проверяем, угадано ли слово "лопата"
               if (!isПаттерн && tbП.Text.ToLower() == "п" && tbа2.Text.ToLower() == "а" && tbт2.Text.ToLower() == "т" &&
                    tbт3.Text.ToLower() == "т" && tbе.Text.ToLower() == "е" && tbр3.Text.ToLower() == "р" && tbн.Text.ToLower() == "н")
               {
                    isПаттерн = true; // Устанавливаем переменную в true

                    // Блокируем TextBox'ы


                    tbП.IsEnabled = false;
                    tbа2.IsEnabled = false;
                   tbт2.IsEnabled = false;
                   tbт3.IsEnabled = false;
                    tbе.IsEnabled = false;
                   tbр3.IsEnabled = false;
                    tbн.IsEnabled = false;



                    MessageBox.Show("Вы угадали слово 'Паттерн'!");
               }

                if (!isмассив && tbа3.Text.ToLower() == "а" && tbс2.Text.ToLower() == "с" && tbс3.Text.ToLower() == "с" &&
                    tbи2.Text.ToLower() == "и" && tbв.Text.ToLower() == "в")
                {
                    isмассив = true; // Устанавливаем переменную в true

                    // Блокируем TextBox'ы


                    tbа3.IsEnabled = false;
                    tbс2.IsEnabled = false;
                    tbс3.IsEnabled = false;
                    tbи2.IsEnabled = false;
                    tbв.IsEnabled = false;
                   



                    MessageBox.Show("Вы угадали слово 'Массив'!");
                }

                if (!isтабуляция && tbа4.Text.ToLower() == "а" && tbб.Text.ToLower() == "б" && tbу.Text.ToLower() == "у" &&
                  tbл.Text.ToLower() == "л" && tbя.Text.ToLower() == "я" && tbц.Text.ToLower() == "ц" && tbи3.Text.ToLower() == "и" && tbя2.Text.ToLower() == "я")
                {
                    isтабуляция = true; // Устанавливаем переменную в true

                    // Блокируем TextBox'ы


                    tbт.IsEnabled = false;
                    tbа4.IsEnabled = false;
                    tbб.IsEnabled = false;
                    tbу.IsEnabled = false;
                    tbл.IsEnabled = false;
                    tbя.IsEnabled = false;
                    tbц.IsEnabled = false;
                    tbи3.IsEnabled = false;
                    tbя2.IsEnabled = false;



                    MessageBox.Show("Вы угадали слово 'Табуляция'!");
                }

                if (!isитерация && tbт4.Text.ToLower() == "т" && tbе2.Text.ToLower() == "е" && tbР.Text.ToLower() == "р" &&
                tbА.Text.ToLower() == "а" && tbЦ.Text.ToLower() == "ц" && tbИ.Text.ToLower() == "и" && tbЯ.Text.ToLower() == "я")
                {
                    isитерация = true; // Устанавливаем переменную в true

                    // Блокируем TextBox'ы
                    tbи.IsEnabled = false;
                    tbт4.IsEnabled = false;
                    tbе2.IsEnabled = false;
                    tbР.IsEnabled = false;
                    tbА.IsEnabled = false;
                    tbЦ.IsEnabled = false;
                    tbИ.IsEnabled = false;
                    tbЯ.IsEnabled = false;




                    MessageBox.Show("Вы угадали слово 'Итерация'!");
                }

            }
        }
        private void end(object sender, RoutedEventArgs e)
        {
            if(!isитерация == true | !isмассив == true | !isПаттерн == true | !isПрограммист == true | !isтабуляция == true)
            {
                MessageBoxResult result = MessageBox.Show("Вы сдаётесь?", "Подтверждение", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Window parentWindow = Window.GetWindow(this);
                    if (parentWindow != null && parentWindow is MainWindow mainWindow)
                    {
                        mainWindow.MainFrame.Navigate(new main());
                        mainWindow.end();
                        mainWindow.finish3();
                        MessageBox.Show($"Поздравляем вас с прохождением квеста профессий! Вы набрали {DataBank.points} ");
                    }
                    
                }
                else if (result == MessageBoxResult.No)
                {
                   
                }
            }
            else
            {
                Window parentWindow = Window.GetWindow(this);
                if (parentWindow != null && parentWindow is MainWindow mainWindow)
                {
                    mainWindow.MainFrame.Navigate(new main());
                    mainWindow.end();
                    mainWindow.finish3();
                }
            }
          
        }

        private void Pathint(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("это часто встречающееся решение определённой проблемы при проектировании архитектуры программ");
        }

        private void iterhint(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("повторение одной и той же последовательности действий с целью достижения результата.");
        }

        private void tabul(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Это позволяло создавать ровные колонки таблиц и не считать отступы вручную");
        }

        private void mashint(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("структура данных, хранящая набор значений (элементов массива), идентифицируемых по индексу или набору индексов");
        }

        private void progh(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Человек, занимающийся разработкой ПО и его сопровождением");
        }
    }
}
