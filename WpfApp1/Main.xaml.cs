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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainS1 s1 = new MainS1();
            s1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainS2 s2 = new MainS2();
            s2.Show();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Main3 s2 = new Main3();
            s2.Show();
        }
    }
}
