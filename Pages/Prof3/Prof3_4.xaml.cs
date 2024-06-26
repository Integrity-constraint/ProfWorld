﻿using System;
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
    /// Логика взаимодействия для Prof3_4.xaml
    /// </summary>
    public partial class Prof3_4 : Page
    {
        public Prof3_4()
        {
            InitializeComponent();
        }

        private void next(object sender, RoutedEventArgs e)
        {
            if (rbright.IsChecked == true | rbwrong.IsChecked == true | rbwrong2.IsChecked == true)
            {
                if(rbright.IsChecked == true)
                {
                    DataBank.points += 10;
                }
                Window parentWindow = Window.GetWindow(this);
                if (parentWindow != null && parentWindow is MainWindow mainWindow)
                {
                    // Загружаем следующую страницу в главное окно
                    mainWindow.MainFrame.Navigate(new Prof3_5());
                    mainWindow.st5();
                }
            }
            else
            {
                MessageBox.Show("Ответьте на вопрос");
            }
               
             
        }

        private void hint(object sender, RoutedEventArgs e)
        {
            DataBank.points -= 5;
            hintb.IsEnabled = false;
            MessageBox.Show("Вспомните робота! Он один, а улучшений много и все они относятся к нему");
        }
    }
}
