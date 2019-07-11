using System;
using System.ComponentModel;
using System.Windows.Forms;
using Calculator.OneArgumentCalculator;
using Calculator.TwoArgumentsCalculator;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            double firstOperand = Convert.ToDouble(textBox1.Text);
            double secondOperand = Convert.ToDouble(textBox2.Text);
            double result = 0;

            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            try
            {
                result = calculator.Calculate(firstOperand, secondOperand);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK);
            }

            label1.Text = result.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double operand = Convert.ToDouble(textBox1.Text);
            double result = 0;

            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            try
            {
                result = calculator.Calculate(operand);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK);
            }
            label1.Text = result.ToString();
        }
    };

}
