using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ISRPO_Lab9B
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int _counter;
        private int _maxNumber = 10000;
        BackgroundWorker _backgroundWorker = new BackgroundWorker();
        private bool _isGoingForward = true;

        public MainWindow()
        {
            InitializeComponent();

            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += (a, b) =>
            {
                if (_isGoingForward)
                {
                    while (_counter < _maxNumber && !_backgroundWorker.CancellationPending)
                    {
                        _counter++;
                        Thread.Sleep(1);
                        _backgroundWorker.ReportProgress((int)((double)_counter / _maxNumber * 100));
                    }
                    if (_counter == _maxNumber)
                    {
                        _isGoingForward = false;
                    }
                }
                else
                {
                    while (_counter > 0 && !_backgroundWorker.CancellationPending)
                    {
                        _counter--;
                        Thread.Sleep(1);
                        _backgroundWorker.ReportProgress((int)((double)_counter / _maxNumber * 100));
                    }
                    if (_counter == 0)
                    {
                        _isGoingForward = true;
                    }
                }
                
            };

            _backgroundWorker.ProgressChanged += (a, b) =>
            {
                UpdateProgress(b.ProgressPercentage);
            };
        }

        private void UpdateProgress(int progress)
        {
            lab.Content = _counter.ToString();
            pb.Value = progress;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _backgroundWorker.RunWorkerAsync();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _backgroundWorker.CancelAsync();
        }
    }
}
