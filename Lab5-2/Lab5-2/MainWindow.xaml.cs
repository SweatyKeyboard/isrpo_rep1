using System;
using System.Windows;
using System.Windows.Threading;

namespace Lab5_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Building building;
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            building = new Building(Convert.ToInt32(floorsTB.Text));
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += (o, e) =>
            {
                building.Elevator.MoveToFloor(Convert.ToInt32(toFloor.Text));
                building.Elevator.OnMovingEnd += () => timer.Stop();
                UpdateText();
            };
        }

        private void UpdateText()
        {
            description.Content =
                "Лифт " +
                ((building.Elevator.Moving == Moving.Stay) ? "стоит " : (building.Elevator.Moving == Moving.Up) ? "едет вверх" : "едет вниз") +
                " на " + building.Elevator.Floor + " этаже с " +
                ((building.Elevator.Doors == Doors.Closed) ? "закрытыми" : "открытыми") + " дверьми";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            building.Elevator.OpenDoors();
            UpdateText();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            building = new Building(Convert.ToInt32(floorsTB.Text));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            building.Elevator.CloseDoors();
            UpdateText();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (building.Elevator.Doors == Doors.Closed)
            {
                timer.Start();
            }
        }
    }
}
