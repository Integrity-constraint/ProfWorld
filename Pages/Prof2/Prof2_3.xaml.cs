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
    /// Логика взаимодействия для Prof2_3.xaml
    /// </summary>
    public partial class Prof2_3 : Page
    {
        public Prof2_3()
        {
            InitializeComponent();
        }

        private void CheckAnswers_Click(object sender, RoutedEventArgs e)
        {
            bool[] answers = new bool[4]; // Массив для хранения правильности ответов

            if (Answer1.IsChecked == true)
                answers[0] = true;

            if (Answer5.IsChecked == true)
                answers[1] = true;

            if (Answer8.IsChecked == true)
                answers[2] = true;

            if (Answer11.IsChecked == true)
                answers[3] = true;

            if (answers.Contains(false))
            {
                MessageBox.Show("В тесте есть ошибки. Проверьте свои ответы ещё раз.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Все ответы верны! Поздравляем!", "Проверка завершена", MessageBoxButton.OK, MessageBoxImage.Information);
                next1.IsEnabled = true;
            }
        }

        private bool hintShown = false;

        private void ShowHints_Click(object sender, RoutedEventArgs e)
        {
            if (!hintShown)
            {
                Dispatcher.Invoke(() =>
                {
                    HighlightCorrectAnswers(Answer1, Answer5, Answer8, Answer11);
                });

                hintShown = true;
                ShowHints.IsEnabled = false;
            }
        }

        private void HighlightCorrectAnswers(params RadioButton[] answers)
        {
            Random random = new Random();
            foreach (var answer in answers)
            {
                if ((bool)answer.Tag)
                {
                    answer.Foreground = Brushes.Green;
                }
            }
        }


        private void next(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Prof2_4());
                mainWindow.st4();
            }
        }
    }
}
