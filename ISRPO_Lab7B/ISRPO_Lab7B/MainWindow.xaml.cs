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

namespace ISRPO_Lab7B
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Rect_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                ScaleTransform sc = new ScaleTransform(1.5, 1.5);
                ((Rectangle)sender).RenderTransform = sc;
            }
            else
                if (e.RightButton == MouseButtonState.Pressed)
            {
                ScaleTransform sc = new ScaleTransform(0.5, 0.5);
                ((Rectangle)sender).RenderTransform = sc;
            }
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                RotateTransform rc = new RotateTransform(120, 0, 0);
                ((Ellipse)sender).RenderTransform = rc;
            }
            else
                if (e.RightButton == MouseButtonState.Pressed)
            {
                RotateTransform rc = new RotateTransform(-22, 0.5, 0.5);
                ((Ellipse)sender).RenderTransform = rc;
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                TranslateTransform rc = new TranslateTransform(12,22);
                ((Image)sender).RenderTransform = rc;
            }
            else
                if (e.RightButton == MouseButtonState.Pressed)
            {
                TranslateTransform rc = new TranslateTransform(75, -10);
                ((Image)sender).RenderTransform = rc;
            }
        }
    }
}
