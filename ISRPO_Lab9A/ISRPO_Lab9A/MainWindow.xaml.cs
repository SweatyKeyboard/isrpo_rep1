using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            MessageBox.Show(VisualTreeHelper.GetParent((DependencyObject)sender).ToString());

            rb3.IsChecked = true;
            MessageBox.Show(Application.Current.MainWindow.ToString());
        }
    }
}