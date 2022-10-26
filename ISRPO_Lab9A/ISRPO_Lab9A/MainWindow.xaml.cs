using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ISRPO_Lab9A
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            rb1.IsChecked = true;
            MessageBox.Show(sender.ToString());

            rb2.IsChecked = true;
            MessageBox.Show(e.Source.ToString());

            rb3.IsChecked = true;
            MessageBox.Show(e.OriginalSource.ToString());
        }
    }
}