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

            // Привязываем обработчик события изменения размеров окна
            SizeChanged += MainWindow_SizeChanged;

            // Инициализируем начальные размеры квадрата
            UpdateSquareSize();
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // При изменении размеров окна обновляем размеры квадрата
            UpdateSquareSize();
        }

        private void UpdateSquareSize()
        {
            // Вычисляем минимальную сторону окна
            double minSide = Math.Min(ActualWidth, ActualHeight);

            // Устанавливаем размеры квадрата
            square.Width = minSide;
            square.Height = minSide;

            // Перемещаем квадрат в центр окна
            Canvas.SetLeft(square, (ActualWidth - minSide) / 2);
            Canvas.SetTop(square, (ActualHeight - minSide) / 2);
        }

      
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Установить минимальное значение размера для StackPanel
            double minSize = Math.Min(ActualWidth, ActualHeight);

        }
        private void Image_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image draggedImage = sender as Image;
            DataObject dragData = new DataObject(typeof(ImageSource), draggedImage.Source);
            DragDrop.DoDragDrop(draggedImage, dragData, DragDropEffects.Copy);
        }

        private void GridDropTarget_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ImageSource)))
            {
                // Получение данных перетаскивания (изображения)
                Image droppedImage = new Image();
                droppedImage.Source = e.Data.GetData(typeof(ImageSource)) as ImageSource;

                // Добавление изображения в целевую ячейку
                Border target = sender as Border;
                target.Child = droppedImage;
                target.Tag = droppedImage.Source;
            }
        }

        private void CheckMatchButton_Click(object sender, RoutedEventArgs e)
        {
            string text1 = "pack://application:,,,/ProfWorld;component/pages/prof2/img/";
            // Переменная для отслеживания правильности расположения всех картинок
            bool allMatchesCorrect = true;

            // Проверяем соответствие каждой картинки и её ячейке
            if (b1.Child == null || b1.Tag == null || b1.Tag.ToString() != text1 + "1.png")
            {
                allMatchesCorrect = false;
            }
            if (b2.Child == null || b2.Tag == null || b2.Tag.ToString() != text1 + "2.png")
            {
                allMatchesCorrect = false;
            }
            if (b3.Child == null || b3.Tag == null || b3.Tag.ToString() != text1 + "3.png")
            {
                allMatchesCorrect = false;
            }
            if (b4.Child == null || b4.Tag == null || b4.Tag.ToString() != text1 + "4.png")
            {
                allMatchesCorrect = false;
            }
            if (b5.Child == null || b5.Tag == null || b5.Tag.ToString() != text1 + "5.png")
            {
                allMatchesCorrect = false;
            }
            if (b6.Child == null || b6.Tag == null || b6.Tag.ToString() != text1 + "6.png")
            {
                allMatchesCorrect = false;
            }
            if (b7.Child == null || b7.Tag == null || b7.Tag.ToString() != text1 + "7.png")
            {
                allMatchesCorrect = false;
            }
            if (b8.Child == null || b8.Tag == null || b8.Tag.ToString() != text1 + "8.png")
            {
                allMatchesCorrect = false;
            }
            if (b9.Child == null || b9.Tag == null || b9.Tag.ToString() != text1 + "9.png")
            {
                allMatchesCorrect = false;
            }

            // Показываем сообщение о правильности или неправильности расположения всех картинок
            if (allMatchesCorrect)
            {
                MessageBox.Show("Все картинки находятся в правильных ячейках.");
                next1.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Некоторые картинки находятся в неправильных ячейках или ячейки пустые.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Начните собирать крышу");
            check.IsEnabled = false;
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