using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathWizard
{
    class Binomial
    {
        public double a;
        public double b;
        public double c;
        public Binomial(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.c = 1;
        }
        public Binomial(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Binomial(string input)
        {
            string temp = "";
            List<double> data = new List<double>();
            for(int i = 0; i<input.Length;i++)
            {
                if(IsNumber(input[i]))
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
            if(IsNumber(input[0]))
            {
                c = data[0];
                a = data[1];
                b = data[2];
            }
            else
            {
                a = data[0];
                b = data[1];
                c = 1;
            }
        }
        public string AsString()
        {
            if(c==1)
            {
                return "(X+" + a + ")(X+" + b + ")";
            }
            return c + "(X+" + a + ")(X+" + b + ")";
        }
        public bool IsNumber(char i)
        {
            if(i=='1'||i=='2'||i=='3'||i=='4'||i=='5' || i =='6' || i =='7' || i == '8'||i=='9'||i=='0'||i=='-'||i=='.')
            {
                return true;
            }
            return false;
        }
    }
}
