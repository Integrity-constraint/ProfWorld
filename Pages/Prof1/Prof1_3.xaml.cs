using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ProfWorld.Pages
{
    public partial class Prof1_3 : Page
    {
        public Prof1_3()
        {
            InitializeComponent();
        }

        private void CheckAnswers_Click(object sender, RoutedEventArgs e)
        {
            // Проверка ответов
            bool[] answers = new bool[8]; // Массив для хранения правильности ответов

            // Проверка ответа на первый вопрос
            if (Answer1B.IsChecked == true)
                answers[0] = true; // Правильный ответ

            // Проверка ответа на второй вопрос
            if (Answer2B.IsChecked == true)
                answers[1] = true; // Правильный ответ

            // Проверка ответа на третий вопрос
            if (Answer3B.IsChecked == true)
                answers[2] = true;

            // Проверка ответа на четвёртый вопрос
            if (Answer4A.IsChecked == true)
                answers[3] = true;

            // Проверка ответа на пятый вопрос
            if (Answer5C.IsChecked == true)
                answers[4] = true;

            // Проверка ответа на шестой вопрос
            if (Answer6B.IsChecked == true)
                answers[5] = true;

            // Проверка ответа на седьмой вопрос
            if (Answer7C.IsChecked == true)
                answers[6] = true;

            // Проверка ответа на восьмой вопрос
            if (Answer8C.IsChecked == true)
                answers[7] = true;

            // Проверка, есть ли хотя бы один неправильный ответ
            if (answers.Contains(false))
            {
                // Если есть хотя бы один неправильный ответ, выводим сообщение об ошибке
                MessageBox.Show("В тесте есть ошибки.", "Проверка завершена", MessageBoxButton.OK, MessageBoxImage.Error);
                next1.IsEnabled = true;
            }
            else
            {
                // Если все ответы верны, сообщаем об этом пользователю
                MessageBox.Show("Все ответы верны! Поздравляем!", "Проверка завершена", MessageBoxButton.OK, MessageBoxImage.Information);
                next1.IsEnabled = true;
            }
        }


        private bool hintShown = false; // Флаг, показывающий, была ли уже отображена подсказка

        private void ShowHints_Click(object sender, RoutedEventArgs e)
        {
            if (!hintShown)
            {
                // Вызываем метод HighlightCorrectAnswers через Dispatcher для обеспечения доступа к элементам управления из основного потока UI
                Dispatcher.Invoke(() =>
                {
                    // Подсветить три случайных правильных ответа для каждого вопроса
                    HighlightCorrectAnswers(Answer1A, Answer1B, Answer1C);
                    HighlightCorrectAnswers(Answer2A, Answer2B, Answer2C);
                    HighlightCorrectAnswers(Answer3A, Answer3B, Answer3C);
                    HighlightCorrectAnswers(Answer4A, Answer4B, Answer4C);
                    HighlightCorrectAnswers(Answer5A, Answer5B, Answer5C);
                    HighlightCorrectAnswers(Answer6A, Answer6B, Answer6C);
                    HighlightCorrectAnswers(Answer7A, Answer7B, Answer7C);
                    HighlightCorrectAnswers(Answer8A, Answer8B, Answer8C);
                });

                hintShown = true; // Устанавливаем флаг в true, чтобы показать, что подсказка была отображена
                DataBank.points -= 5;
                // Делаем кнопку "Подсказка" неактивной
                Dispatcher.Invoke(() => ShowHints.IsEnabled = false);
            }
        }

        // Метод для подсветки трех случайных правильных ответов
        private void HighlightCorrectAnswers(params RadioButton[] answers)
        {
            Random random = new Random();
            List<RadioButton> correctAnswers = answers.Where(answer => answer.Tag is bool && (bool)answer.Tag).ToList();

            for (int i = 0; i < 3 && i < correctAnswers.Count; i++)
            {
                correctAnswers[i].Foreground = Brushes.Green;
            }
        }

        private void next(object sender, RoutedEventArgs e)
        {
            // Получаем родительское окно страницы
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                // Загружаем следующую страницу в главное окно
                mainWindow.MainFrame.Navigate(new Prof1_4());
                mainWindow.st4();
            }
        }
    }
}
