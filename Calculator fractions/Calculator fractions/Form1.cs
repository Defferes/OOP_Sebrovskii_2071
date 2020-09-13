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
    enum Action
    {
        Sum,
        Sub,
        Mul,
        Div,
        None
    }
    
    public partial class Form1 : Form
    {   

        public int numerator1, numerator2, denominator1, denominator2;
        Action action = Action.None;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void SumBtn_Click(object sender, EventArgs e)
        {

            action = Action.Sum;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if ((Int32.TryParse(textBox1.Text, out numerator1) && (Int32.TryParse(textBox4.Text, out numerator2) && (Int32.TryParse(textBox2.Text, out denominator1) && (Int32.TryParse(textBox3.Text, out denominator2))))))
            {
                Rational first = new Rational(numerator1, denominator1);
                Rational second = new Rational(numerator2, denominator2);
                Rational result;
                if ((denominator1 != 0) && (denominator2 != 0))
                {
                    switch (action)
                    {
                        case Action.Sum:
                            result = first + second;
                            result = result.Reduction(result);
                            textBox6.Text = result.ToString(result);
                            break;
                        case Action.Sub:
                            result = first - second;
                            result = result.Reduction(result);
                            textBox6.Text = result.ToString(result);
                            break;
                        case Action.Mul:
                            result = first * second;
                            result = result.Reduction(result);
                            textBox6.Text = result.ToString(result);
                            break;
                        case Action.Div:
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
            action = Action.Sub;
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            action = Action.Mul;
        }

        private void Division_Click(object sender, EventArgs e)
        {
            action = Action.Div;
        }

    }
}
