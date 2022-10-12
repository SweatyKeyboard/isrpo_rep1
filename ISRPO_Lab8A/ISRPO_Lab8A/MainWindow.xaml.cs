using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ISRPO_Lab8A
{
    public partial class MainWindow : Window
    {

        private double _size;
        private bool _isBold;
        private bool _isItalic;
        private FontFamily _family;

        public MainWindow()
        {
            InitializeComponent();
            cbFont.ItemsSource = Fonts.SystemFontFamilies;
            slidSize.Minimum = 1;
        }

        private void ButBold_Click(object sender, RoutedEventArgs e)
        {
            _isBold = !_isBold;
            rtb.FontWeight = (_isBold) ? FontWeights.Bold : FontWeights.Normal;
        }

        private void ButItalic_Click(object sender, RoutedEventArgs e)
        {
            _isItalic = !_isItalic;
            rtb.FontStyle = (_isItalic) ? FontStyles.Italic : FontStyles.Normal;                
        }

        private void SlidSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _size = ((Slider)sender).Value;
            rtb.FontSize = _size;
        }

        private void CbFont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _family = new FontFamily(((ComboBox)sender).SelectedItem.ToString());
            rtb.FontFamily = _family;
        }
    }
}
