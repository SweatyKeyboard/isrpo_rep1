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

namespace ISRPO_Lab7C
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point _currentPoint;
        private Point _lastPoint;
        private List<Line> lines = new List<Line>();

        /*private Ellipse circle = new Ellipse
        {
            Width = 10,
            Height = 10
        };*/

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawpPoint(MouseButtonEventArgs e)
        {
            _currentPoint = e.GetPosition(canvas);            
        }

        private void DrawLine(MouseButtonEventArgs e)
        {
            _lastPoint = new Point(_currentPoint.X, _currentPoint.Y);
            _currentPoint = e.GetPosition(canvas);

            Line line = new Line
            {
                Stroke = new SolidColorBrush(Color.FromRgb(0, 0, 0))
        };
            line.X1 = _lastPoint.X;
            line.X2 = _currentPoint.X;
            line.Y1 = _lastPoint.Y;
            line.Y2 = _currentPoint.Y;

            lines.Add(line);

            canvas.Children.Add(line);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_currentPoint.X != 0 && _currentPoint.Y != 0)
            {
                DrawLine(e);
            }
            else
            {
                DrawpPoint(e);
            }
        }
    }
}
