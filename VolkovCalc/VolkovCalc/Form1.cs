using System;
using System.Windows.Forms;
using VolkovCalc.OneArgument;
using VolkovCalc.TwoArguments;

namespace VolkovCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcSwitch(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBox1.Text);
                double second = Convert.ToDouble(textBox2.Text);
                ICalculator calculator = Factory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(first, second);

                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка " + exc.Message);
            }
            
        }

        private void SingleCalcSwitch(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBox1.Text);
                ISingleCalc calculator = SingleFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(first);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка " + exc.Message);
            }

        }
      
    }
}
