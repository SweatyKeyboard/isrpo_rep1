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

namespace Lab5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private float _inputedPrice;
        private float _finalPrice;
        private a_HotDrink _selectedDrink;

        public MainWindow()
        {
            InitializeComponent();
            _selectedDrink = new Americano();
            _finalPrice = 30;
        }

        private void UpdateFinalPrice()
        {
            _finalPrice = _selectedDrink.Price;
            if (_selectedDrink.IsWithMilk)
            {
                _finalPrice += 10;
            }
            if (_selectedDrink.IsWithSugar)
            {
                _finalPrice += 5;
            }

            priceLabel.Content = $"Цена напитка: {_finalPrice}";
        }

        private void SugarCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            sugarImage.Visibility = Visibility.Visible;
            _selectedDrink.IsWithSugar = true;
            UpdateFinalPrice();
        }

        private void SugarCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            sugarImage.Visibility = Visibility.Hidden;
            _selectedDrink.IsWithSugar = false;
            UpdateFinalPrice();
        }

        private void MilkCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            milkImage.Visibility = Visibility.Visible;
            _selectedDrink.IsWithMilk = true;
            UpdateFinalPrice();
        }

        private void MilkCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            milkImage.Visibility = Visibility.Hidden;
            _selectedDrink.IsWithMilk = false;
            UpdateFinalPrice();
        }

        private void AmericanoRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            _selectedDrink = new Americano();
            if (sugarCheckBox != null)
            {
                _selectedDrink.IsWithSugar = (bool)sugarCheckBox.IsChecked;
                _selectedDrink.IsWithMilk = (bool)milkCheckBox.IsChecked;
                coffeImage.Source = new BitmapImage(new Uri(@"/Lab5;component/Images/Cup2.png", UriKind.Relative));
                UpdateFinalPrice();
            }
        }

        private void CapuccinoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _selectedDrink = new Capuccino();
            _selectedDrink.IsWithSugar = (bool)sugarCheckBox.IsChecked;
            _selectedDrink.IsWithMilk = (bool)milkCheckBox.IsChecked;

            coffeImage.Source = new BitmapImage(new Uri(@"/Lab5;component/Images/Cup4.png", UriKind.Relative));
            UpdateFinalPrice();
        }

        private void EspressoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _selectedDrink = new Espresso();
            _selectedDrink.IsWithSugar = (bool)sugarCheckBox.IsChecked;
            _selectedDrink.IsWithMilk = (bool)milkCheckBox.IsChecked;

            coffeImage.Source = new BitmapImage(new Uri(@"/Lab5;component/Images/Cup3.png", UriKind.Relative));
            UpdateFinalPrice();
        }

        private void CacaoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            _selectedDrink = new Cacao();
            _selectedDrink.IsWithSugar = (bool)sugarCheckBox.IsChecked;
            _selectedDrink.IsWithMilk = (bool)milkCheckBox.IsChecked;

            coffeImage.Source = new BitmapImage(new Uri(@"/Lab5;component/Images/Cup1.png", UriKind.Relative));
            UpdateFinalPrice();
        }

        private void MoneyInputButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _inputedPrice += Convert.ToInt32(moneyInputTextBox.Text);
                moneyInputedLabel.Content = $"Внесенная сумма: {_inputedPrice}";
            }
            catch
            {
                moneyInputTextBox.Text = "";
            }
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (_inputedPrice < _finalPrice)
            {
                resultLabel.Content = "Недостаточно денег";
            }
            else
            {
                resultLabel.Content = "Вот ваш напиток и сдача";
                changeLabel.Content = $"Сдача: {_inputedPrice - _finalPrice}";
                _inputedPrice -= 0;
                moneyInputedLabel.Content = $"Внесенная сумма: {_inputedPrice}";
            }
        }
    }
}
