using System;
using System.Collections.Generic;
using System.IO;
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

namespace StampaArray
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtstringa.Focus();
            btnstampa.IsEnabled = false;
            btnpubblica.IsEnabled = false;
        }
        private const string file_name = "txtfile";
        string[] array = new string[5];
        int c = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                array[c] = txtstringa.Text;
                c = c + 1;
            }
            if (c >= 5)
            {
                btninserisci.IsEnabled = false;
                btnstampa.IsEnabled = true;
            }
            txtstringa.Clear();
            txtstringa.Focus();
        }
                string array2;
        private void btnstampa_Click(object sender, RoutedEventArgs e)
        {
            
            for(c=0;c<array.Length;c++)
            {
                array2 += $"Cella N°{c} : {array[c]} \n";
            }
            lblresult.Content = array2;
            btnpubblica.IsEnabled = true;
            btnstampa.IsEnabled = false;
        }

        private void btnpubblica_Click(object sender, RoutedEventArgs e)
        {
            btnstampa.IsEnabled = false;
            btnpubblica.IsEnabled = false;
            btninserisci.IsEnabled = true;
            using (StreamWriter t = new StreamWriter("file_name.txt", true))
            {
                for (c = 0; c < array.Length; c++)
                {
                    t.WriteLine($"Cella N°{c} : {array[c]} \n");
                }


               
            }
        }
    }
}
