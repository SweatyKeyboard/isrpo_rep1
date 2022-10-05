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

namespace ISRPO_Lab7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    class DataItem
    {
        public string KeyCode { get; set; }
        public string KeyValue {get;set;}
        public string KeyState {get;set;}
        public string KeyChar {get;set;}
        public string SystemKey {get;set;}
        public string KeyDown {get;set;}
        public string KeyUp {get;set;}
        public DataItem(string keyCode, string keyValue, string keyState, string keyChar, string systemKey, string keyDown, string keyUp)
        {
            KeyCode = keyCode;
            KeyValue = keyValue;
            KeyState = keyState;
            KeyChar = keyChar;
            SystemKey = systemKey;
            KeyDown = keyDown;
            KeyUp = keyUp;
        }
    }


    public partial class MainWindow : Window
    {
        List<DataItem> items = new List<DataItem>();
        public MainWindow()
        {            
            InitializeComponent();
            dataGrid.ItemsSource = items;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            items.Add(new DataItem(
                ((int)e.Key).ToString(),
                e.Key.ToString(),
                e.KeyStates.ToString(),
                ((char)e.Key).ToString(),
                e.SystemKey.ToString(),
                "True",
                "False"));
            CollectionViewSource.GetDefaultView(dataGrid.ItemsSource).Refresh();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            items.Add(new DataItem(
                ((int)e.Key).ToString(),
                e.Key.ToString(),
                e.KeyStates.ToString(),
                ((char)e.Key).ToString(),
                e.SystemKey.ToString(),
                "False",
                "True"));
            CollectionViewSource.GetDefaultView(dataGrid.ItemsSource).Refresh();
        }
    }
}