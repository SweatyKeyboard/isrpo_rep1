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

        private const int _clippingSize = 5;

        private Point _firstPoint = new Point(999,999);
        private Point _currentPoint;
        private Point _lastPoint;
        private List<Line> lines = new List<Line>();

        private bool _isDrawing = true;

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
            if (_firstPoint.X == 999 && _firstPoint.Y == 999)
            {
                _firstPoint = e.GetPosition(canvas);
            }
        }

        private void DrawLine(MouseButtonEventArgs e)
        {
            _lastPoint = new Point(_currentPoint.X, _currentPoint.Y);
            _currentPoint = e.GetPosition(canvas);

            Line line = new Line
            {
                Stroke = new SolidColorBrush(Color.FromRgb(0, 0, 0)),
                StrokeThickness = 3
            };
            line.X1 = _lastPoint.X;
            line.X2 = _currentPoint.X;
            line.Y1 = _lastPoint.Y;
            line.Y2 = _currentPoint.Y;

            lines.Add(line);

            canvas.Children.Add(line);

            if (Math.Abs(_currentPoint.X - _firstPoint.X) < _clippingSize && Math.Abs(_currentPoint.Y - _firstPoint.Y) < _clippingSize)
            {
                foreach (Line colorLine in lines)
                {
                    colorLine.Stroke = new SolidColorBrush(Color.FromRgb(50, 50, 150));
                }
                _isDrawing = false;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_isDrawing)
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
}
