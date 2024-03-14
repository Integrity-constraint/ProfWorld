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

namespace ProfWorld.Pages.Prof2
{
    /// <summary>
    /// Логика взаимодействия для Prof2_5.xaml
    /// </summary>
    public partial class Prof2_5 : Page
    {
        public Prof2_5()
        {
            InitializeComponent();
        }

        private void end(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null && parentWindow is MainWindow mainWindow)
            {
                mainWindow.MainFrame.Navigate(new main());
                mainWindow.end();
                mainWindow.finish2();
            }
        }
    }
}
