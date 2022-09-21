using System.Windows;

namespace Lab6A_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lab1.Content = (new Circle()).Show();
        }
    }
}
