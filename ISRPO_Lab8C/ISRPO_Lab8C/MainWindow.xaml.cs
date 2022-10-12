using System;
using System.Windows;
using System.Windows.Controls;

namespace ISRPO_Lab8C
{

    enum Operation
    {
        Sum,
        Difference,
        Product,
        Quotient
    };

    enum State
    {
        FirstNumberAwaiting,
        SecondNumberAwating,
        ClearAwating
    }
    public partial class MainWindow : Window
    {
        private Button[] _digits = new Button[11];

        private double _firstNumber;
        private double _secondNumber;

        private bool _isFirstNumberHasDot = false;
        private bool _isSecondNumberHasDot = false;
        private Operation _operation;
        private State _state = State.FirstNumberAwaiting;

        public MainWindow()
        {
            InitializeComponent();
            for (int c = 1; c <= 10; c++)
            {
                int d = c;
                _digits[c] = new Button();
                _digits[c].Content = c % 10;
                _digits[c].Click += (o, e) => NumberEntering(o, e, d % 10);
                ug.Children.Add(_digits[c]);
            }
            _digits[10] = new Button();
            _digits[10].Content = ",";
            _digits[10].Click += (o, e) =>
            {
                if (_state == State.FirstNumberAwaiting)
                {
                    _isFirstNumberHasDot = true;
                }
                else if (_state == State.SecondNumberAwating)
                {
                    _isSecondNumberHasDot = true;
                }
            };
            ug.Children.Add(_digits[10]);
        }

        private void NumberEntering(object sender, RoutedEventArgs e, int value)
        {
            if (_state == State.FirstNumberAwaiting)
            {
                if (!_isFirstNumberHasDot)
                {
                    _firstNumber *= 10;
                    _firstNumber += value;
                }
                else
                {
                    _firstNumber += value / Math.Pow(10, -(_firstNumber.ToString().Substring(_firstNumber.ToString().IndexOf(','))).Length);
                }
                tbAns.Text = _firstNumber.ToString();
            }
            else if (_state == State.SecondNumberAwating)
            {
                if (!_isSecondNumberHasDot)
                {
                    _secondNumber *= 10;
                    _secondNumber += value;
                }
                else
                {
                    _secondNumber += value / Math.Pow(10, -_secondNumber.ToString().Substring(_secondNumber.ToString().IndexOf('.')).Length);
                }
                tbAns.Text = _firstNumber + " " + GetOperationSign(_operation) + " " + _secondNumber;
            }
        }        

        private char GetOperationSign(Operation operation)
        {
            switch (operation)
            {
                case Operation.Sum:
                    return '+';

                case Operation.Difference:
                    return '-';

                case Operation.Product:
                    return '*';

                case Operation.Quotient:
                    return '/';

                default:
                    return '?';
            }
        }

        private double Result()
        {
            switch (_operation)
            {
                case Operation.Sum:
                    return _firstNumber + _secondNumber;

                case Operation.Difference:
                    return _firstNumber - _secondNumber;

                case Operation.Product:
                    return _firstNumber * _secondNumber;

                case Operation.Quotient:
                    return _firstNumber / _secondNumber;

                default:
                    return 0;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_state == State.FirstNumberAwaiting)
            {
                _operation = Operation.Sum;
                _state = State.SecondNumberAwating;
            }
            tbAns.Text = _firstNumber.ToString() + " " + GetOperationSign(_operation);
        }

        private void ButMinus_Click(object sender, RoutedEventArgs e)
        {
            if (_state == State.FirstNumberAwaiting)
            {
                _operation = Operation.Difference;
                _state = State.SecondNumberAwating;
            }
            tbAns.Text = _firstNumber.ToString() + " " + GetOperationSign(_operation);
        }

        private void ButMult_Click(object sender, RoutedEventArgs e)
        {
            if (_state == State.FirstNumberAwaiting)
            {
                _operation = Operation.Product;
                _state = State.SecondNumberAwating;
            }
            tbAns.Text = _firstNumber.ToString() + " " + GetOperationSign(_operation);
        }

        private void ButDiv_Click(object sender, RoutedEventArgs e)
        {
            if (_state == State.FirstNumberAwaiting)
            {
                _operation = Operation.Quotient;
                _state = State.SecondNumberAwating;
            }
            tbAns.Text = _firstNumber.ToString() + " " + GetOperationSign(_operation);
        }

        private void ButAns_Click(object sender, RoutedEventArgs e)
        {
            if (_state == State.SecondNumberAwating)
            {
                tbAns.Text = _firstNumber + " " + GetOperationSign(_operation) + _secondNumber + " = " + Result();
                _state = State.ClearAwating;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _firstNumber = 0;
            _secondNumber = 0;
            _state = State.FirstNumberAwaiting;
            tbAns.Text = "";
            _isFirstNumberHasDot = false;
            _isSecondNumberHasDot = false;
        }
    }
}
