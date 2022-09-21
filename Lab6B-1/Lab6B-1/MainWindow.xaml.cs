using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab6B_1
{

    public partial class MainWindow : Window
    {

        private Deck _deck = new Deck();
        public MainWindow()
        {
            InitializeComponent();
            RedrawCards();
        }

        private void RedrawCards()
        {
            grid.Children.Clear();

            for (int i = 0; i < 52; i++)
            {
                Label labelSample = new Label();
                labelSample.FontSize = 24;
                labelSample.Content = _deck.GetCard(i).ToString();
                if (_deck.GetCard(i).Suit <= 1)
                {
                    labelSample.Foreground = new SolidColorBrush(Color.FromRgb(222, 88, 66));
                }
                grid.Children.Add(labelSample);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _deck.Shuffle();
            RedrawCards();
        }
    }
}
