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
using System.Windows.Shapes;

namespace Farmer
{
    /// <summary>
    /// Interaction logic for DodajMaszyneWindow.xaml
    /// </summary>
    public partial class DodajMaszyneWindow : Window
    {
        public DodajMaszyneWindow()
        {
            InitializeComponent();
        }

        private void anuluj_bt_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void data_przegladu_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            data_przegladu_tb.Text = string.Empty;
        }

        private void nazwa_tb_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            nazwa_tb.Text = string.Empty;
        }

        private void nr_rejestracyjny_tb_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            nr_rejestracyjny_tb.Text = string.Empty;
        }

        private void marka_tb_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            marka_tb.Text = string.Empty;
        }

        private void model_tb_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            model_tb.Text = string.Empty;
        }

        private void data_produkcji_tb_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            data_produkcji_tb.Text = string.Empty;
        }

        private void data_ubezpieczenia_tb_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            data_ubezpieczenia_tb.Text = string.Empty;
        }
    }
}
