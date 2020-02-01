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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string a ="", b ="";
        char operation = '0';
        double result;
        public MainWindow()
        {
            InitializeComponent();
        }

        #region ЦИФРЫ
        private void number1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a += '1';
                Tablo.Text = a.ToString();
            }

            else
            {
               b += '1';
               Tablo.Text = b.ToString();
            }
        }
        private void number2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a += '2';
                Tablo.Text = a.ToString();
            }

            else
            {
                b += '2';
                Tablo.Text = b.ToString();
            }
        }
        private void number3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a += '3';
                Tablo.Text = a.ToString();
            }

            else
            {
                b += '3';
                Tablo.Text = b.ToString();
            }
        }
        private void number4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a += '4';
                Tablo.Text = a.ToString();
            }

            else
            {
                b += '4';
                Tablo.Text = b.ToString();
            }
        }
        private void number5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a += '5';
                Tablo.Text = a.ToString();
            }

            else
            {
                b += '5';
                Tablo.Text = b.ToString();
            }
        }
        private void number6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a += '6';
                Tablo.Text = a.ToString();
            }

            else
            {
                b += '6';
                Tablo.Text = b.ToString();
            }
        }
        private void number7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a += '7';
                Tablo.Text = a.ToString();
            }

            else
            {
                b += '7';
                Tablo.Text = b.ToString();
            }
        }
        private void number8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a += '8';
                Tablo.Text = a.ToString();
            }

            else
            {
                b += '8';
                Tablo.Text = b.ToString();
            }
        }
        private void number9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a += '9';
                Tablo.Text = a.ToString();
            }

            else
            {
                b += '9';
                Tablo.Text = b.ToString();
            }
        }
        private void number0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a += '0';
                Tablo.Text = a.ToString();
            }

            else
            {
                b += '0';
                Tablo.Text = b.ToString();
            }
        }
        #endregion
        #region ОПЕРАЦИИ
        private void Divide(object sender, RoutedEventArgs e)
        {
            operation = '/';
        }
        private void Multiply(object sender, RoutedEventArgs e)
        {
            operation = '*';
        }
        private void Substract(object sender, RoutedEventArgs e)
        {
            operation = '-';
        }
        private void Sum(object sender, RoutedEventArgs e)
        {
            operation = '+';
        }
        private void Percent(object sender, RoutedEventArgs e)
        {
            operation = '%';
        }
        private void Pow(object sender, RoutedEventArgs e)
        {
            operation = 'P';
        }
        private void Sqrt(object sender, RoutedEventArgs e)
        {
            result = Math.Sqrt(Convert.ToDouble(a));
            Tablo.Text = result.ToString();
            a = result == 0 ? "" : result.ToString();
            b = "";
            operation = '0';
        }
        private void Decimal(object sender, RoutedEventArgs e)
        {
            result = 1 / Convert.ToDouble(a);
            Tablo.Text = result.ToString();
            a = result == 0 ? "" : result.ToString();
            b = "";
            operation = '0';
        }
        private void Equal(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case ('+'):
                    result = Convert.ToDouble(a) + Convert.ToDouble(b);
                    break;
                case ('-'):
                    result = Convert.ToDouble(a) - Convert.ToDouble(b);
                    break;
                case ('/'):
                    result = Convert.ToDouble(a) / Convert.ToDouble(b);
                    break;
                case ('*'):
                    result = Convert.ToDouble(a) * Convert.ToDouble(b);
                    break;
                case ('%'):
                    result = Convert.ToDouble(a) /100 * Convert.ToDouble(b);
                    break;
                case ('P'):
                    result = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b));
                    break;
            }
            Tablo.Text = result.ToString();
            a = result == 0 ? "" : result.ToString();
            b = "";
            operation = '0';
        }
        #endregion
        #region ЗНАК И ТОЧКА
        private void Sign(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                a = PlusMinus(a);
                Tablo.Text = a.ToString();
            }

            else
            {
                b = PlusMinus(b);
                Tablo.Text = b.ToString();
            }
        }
        private string PlusMinus(string number)
        {
            string result = number;
            double _number = Convert.ToDouble(number);
            if (_number > 0)
            {
                result = number.Insert(0, "-");
            }
            else if (_number < 0)
            {
                result = number.TrimStart('-');
            }
            return result;
        }
        private void Dot(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                if (a == "") a = "0,";
                else
                {
                   a = a.Contains(',')? a: a + ',';
                }
                    Tablo.Text = a;
            }

            else
            {
                b += ',';
                Tablo.Text = b;
            }
        }
        #endregion

        #region УДАЛИТЕЛИ
        private void Remove(object sender, RoutedEventArgs e)
        {
            if (operation == '0')
            {
                if (Tablo.Text.Length>1)
                {

                    int a1 = a.Length - 1;
                    a = a.Remove(a1);
                    Tablo.Text = a.ToString();
                }
                else
                {
                    a = "";
                    Tablo.Text = "0";
                }
            }

            else
            {
                if (Tablo.Text.Length > 1)
                {

                    int b1 = b.Length - 1;
                    b = b.Remove(b1);
                    Tablo.Text = b.ToString();
                }
                else
                {
                    b = "";
                    Tablo.Text = "0";
                }
            }
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            a = "";
            b = "";
            operation = '0';
            Tablo.Text = "0";

        }
        #endregion

    }
}
