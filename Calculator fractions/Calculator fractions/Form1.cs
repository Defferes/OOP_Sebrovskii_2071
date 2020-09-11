using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_fractions
{
    public partial class Form1 : Form
    {
        public int numerator1, numerator2, denominator1, denominator2;
        public string action;
        public Form1()
        {
            InitializeComponent();
        }


        private void SumBtn_Click(object sender, EventArgs e)
        {
            numerator1 = Convert.ToInt32(textBox1.Text);
            numerator2 = Convert.ToInt32(textBox4.Text);
            denominator1 = Convert.ToInt32(textBox2.Text);
            denominator2 = Convert.ToInt32(textBox3.Text);
            action = "Sum";
        }

        private void Result_Click(object sender, EventArgs e)
        {

            Rational first = new Rational(numerator1, denominator1);
            Rational second = new Rational(numerator2, denominator2);
            Rational result;
            if ((Int32.TryParse(textBox1.Text, out numerator1) && (Int32.TryParse(textBox4.Text, out numerator2) && (Int32.TryParse(textBox2.Text, out denominator1) && (Int32.TryParse(textBox3.Text, out denominator2))))))
            {
                if ((denominator1 != 0) && (denominator2 != 0))
                {
                    switch (action)
                    {
                        case "Sum":
                            result = first + second;
                            result = result.Reduction(result);
                            textBox6.Text = result.ToString(result);
                            break;
                        case "Sub":
                            result = first - second;
                            result = result.Reduction(result);
                            textBox6.Text = result.ToString(result);
                            break;
                        case "Mul":
                            result = first * second;
                            result = result.Reduction(result);
                            textBox6.Text = result.ToString(result);
                            break;
                        case "Div":
                            result = first / second;
                            result = result.Reduction(result);
                            textBox6.Text = result.ToString(result);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Наличие 0 в знаменателе");
                }
            }
            else
            {
                MessageBox.Show("Неверные значения");
            }

        }
        private void SubtrBtn_Click(object sender, EventArgs e)
        {
            numerator1 = Convert.ToInt32(textBox1.Text);
            numerator2 = Convert.ToInt32(textBox4.Text);
            denominator1 = Convert.ToInt32(textBox2.Text);
            denominator2 = Convert.ToInt32(textBox3.Text);
            action = "Sub";
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            numerator1 = Convert.ToInt32(textBox1.Text);
            numerator2 = Convert.ToInt32(textBox4.Text);
            denominator1 = Convert.ToInt32(textBox2.Text);
            denominator2 = Convert.ToInt32(textBox3.Text);
            action = "Mul";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            numerator1 = Convert.ToInt32(textBox1.Text);
            numerator2 = Convert.ToInt32(textBox4.Text);
            denominator1 = Convert.ToInt32(textBox2.Text);
            denominator2 = Convert.ToInt32(textBox3.Text);
            action = "Div";
        }

    }
}
