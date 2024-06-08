using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string _lastOperation;
        private string _firstOperand;
        private bool _secondOperand;
        public Form1()
        {
            _secondOperand = false;
            InitializeComponent();
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (_secondOperand)
            {
                _secondOperand = false;
                textBox1.Text = "0";
            }
            Button clickButton = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = clickButton.Text;
            }
            else
            {
                textBox1.Text += clickButton.Text;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button clickButton = (Button)sender;
            _lastOperation = clickButton.Text;
            _firstOperand = textBox1.Text;
            _secondOperand = true;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            double dnumber1 = Convert.ToDouble(_firstOperand);
            double dnumber2 = Convert.ToDouble(textBox1.Text);
            double result = 0;

            switch (_lastOperation)
            {
                case "+":
                    result = dnumber1 + dnumber2;
                    break;
                case "-":
                    result = dnumber1 - dnumber2;
                    break;
                case "/":
                    result = dnumber1 / dnumber2;
                    break;
                case "x":
                    result = dnumber1 * dnumber2;
                    break;
                case "%":
                    result = dnumber1 * dnumber2 / 100;
                    break;
                default:
                    result = 0;
                    break;
            };

            _lastOperation = "=";
            _secondOperand = true;
            textBox1.Text = result.ToString();
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(number);
            textBox1.Text = result.ToString();
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            double number, result;

            number = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(number, 2);
            textBox1.Text = result.ToString();
        }

        private void DivisionOneByNumber_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToDouble(textBox1.Text);
            result = 1 / number;
            textBox1.Text = result.ToString();
        }

        private void NegateButton_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToDouble(textBox1.Text);
            result = -number;
            textBox1.Text = result.ToString();
        }

        private void DecimalPointButton_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void DeleteLastDigitButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1) 
            { 
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }
    }
}
