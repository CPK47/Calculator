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
        float first;
        float second;
        char op;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Result.Text == "0") { Result.Clear(); }
            Button btn = (Button)sender;
            Result.Text += btn.Content.ToString();
            second = float.Parse(Result.Text);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            first = float.Parse(Result.Text);
            op = '/';
            Result.Clear();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            first = float.Parse(Result.Text);
            op = '*';
            Result.Clear();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            first = float.Parse(Result.Text);
            op = '+';
            Result.Clear();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            first = float.Parse(Result.Text);
            op = '-';
            Result.Clear();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
                second = float.Parse(Result.Text);
                float result = 0f;
                if (op == '+') { result = first + second; }
                else if (op == '-') { result = first - second; }
                else if (op == '*') { result = first * second; }
                else if (op == '/')
                { result = first / second; if (second == 0) { result = 0; } }
                op = ' ';
                Result.Text = result.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Result.Clear();
        }
    }
}
