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

namespace Farmer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CustomButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Alt Control Delete");
        }

        private void dodaj_maszyna_bt_Click(object sender, RoutedEventArgs e)
        {
            new DodajMaszyneWindow().ShowDialog() ;

        }
    }
}
