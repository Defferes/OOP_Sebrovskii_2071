using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_fractions
{
    class Rational
    {
        public int numerator, denominator;
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public Rational Sum(Rational second)
        {
            Rational result = new Rational(0, 0);
            if(this.denominator == second.denominator)
            {
                result.denominator = this.denominator;
                result.numerator = this.numerator + second.numerator;
            }
            else
            {
                result.numerator = this.numerator * second.denominator + second.numerator * this.denominator;
                result.denominator = this.denominator * second.denominator;
            }
            return result;
        }
        public Rational Subtraction(Rational second)
        {
            Rational result = new Rational(0, 0);
            if (this.denominator == second.denominator)
            {
                result.denominator = this.denominator;
                result.numerator = this.numerator - second.numerator;
            }
            else
            {
                result.numerator = this.numerator * second.denominator - second.numerator * this.denominator;
                result.denominator = this.denominator * second.denominator;
            }
            return result;
        }
        public Rational Multiplication(Rational second)
        {
            Rational result = new Rational(0, 0);
            result.numerator = this.numerator * second.numerator;
            result.denominator = this.denominator * second.denominator;
            return result;
        }
        public Rational Division(Rational second)
        {
            Rational result = new Rational(0, 0);
            result.numerator = this.numerator * second.denominator;
            result.denominator = this.denominator * second.numerator;
            return result;
        }
        public Rational Reduction(Rational first)
        {
            int a = first.numerator;
            int b = first.denominator;
            while(a !=b)
            {
                if(a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }

            }
            Rational result = new Rational(first.numerator / a, first.denominator / a);
            return result;
        }
        public string ToString(Rational first)
        {
            if(first.denominator== 1)
            {
                return Convert.ToString(first.numerator);
            }
            else
            return Convert.ToString(first.numerator) + "/" + Convert.ToString(first.denominator);
        }
        public static Rational operator +(Rational first, Rational second)
        {
            return first.Sum(second);
        }
        public static Rational operator -(Rational first, Rational second)
        {
            return first.Subtraction(second);
        }
        public static Rational operator *(Rational first, Rational second)
        {
            return first.Multiplication(second);
        }
        public static Rational operator /(Rational first, Rational second)
        {
            return first.Division(second);
        }
    }
}
