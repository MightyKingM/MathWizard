using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathWizard
{
    class BinomialQuadratic
    {
        public double a;
        public double b;
        public double c;
        public bool quickfactor = true;
        public double GetMaximumProgress()
        {
            if(!quickfactor)
            {
                return a * b * c;
            }
            else
            {
                List<double> data = new List<double>();
                data.Add(a); data.Add(b);
                return data.Max()/c;
            }
        }
        public BinomialQuadratic(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.c = 1;
        }
        public BinomialQuadratic(double a, double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public BinomialQuadratic(string input)
        {
            string temp = "";
            input +=" ";
            List<double> data = new List<double>();
            for (int i = 0; i < input.Length; i++)
            {
                if (IsNumber(input[i]))
                {
                    temp += input[i];
                }
                else
                {
                    if (i != 0 && IsNumber(input[i - 1]))
                    {
                        data.Add(double.Parse(temp));
                        temp = "";
                    }
                }
            }
            if (data.Count == 4)
            {
                c = data[0];
                a = data[2];
                b = data[3];
            }
            else
            {
                a = data[1];
                b = data[2];
                c = 1;
            }
        }
        public bool IsNumber(char i)
        {
            if (i == '1' || i == '2' || i == '3' || i == '4' || i == '5' || i == '6' || i == '7' || i == '8' || i == '9' || i == '0'||i=='-'||i=='.')
            {
                return true;
            }
            return false;
        }
        public string AsString()
        {
            if(c == 1)
            {
                return "X^2+" + a + "X+" + b;
            }
            return c + "X^2+" + a + "X+" + b;
        }
    }
}
