using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathWizard
{
    class TrinomialQuadratic
    {
        public int a;
        public int b;
        public int c;
        public int d;
        public bool quickfactor = true;
        public int GetMaximumProgrss()
        {
            if(!quickfactor)
            {
                return (a + 1) * (b + 1) * (c + 1) * d;
            }
            List<int> dataset = new List<int>();
            dataset.Add(a); dataset.Add(c);
            dataset.Add(b);
            return dataset.Max()/d;
        }
        public TrinomialQuadratic(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = 1;
        }
        public TrinomialQuadratic(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public TrinomialQuadratic(string input)
        {
            string temp = "";
            input += "e";
            List<int> data = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (IsNumber(input[i]))
                {
                    temp += input[i];
                }
                else
                {
                    if (i != 0)
                    {
                        if (IsNumber(input[i - 1]))
                        {
                            data.Add(int.Parse(temp));
                            temp = "";
                        }
                    }
                }
            }
            if (data.Count == 6)
            {
                d = data[0];
                a = data[2];
                b = data[4];
                c = data[5];
            }
            else
            {
                d = 1;
                a = data[1];
                a = data[3];
                c = data[4];
            }
        }

        public string AsString()
        {
            if(d == 1)
            {
                return "X^3+"+a+"X^2+"+b+"X"+c;
            }
            return d+"X^3+"+a+"X^2+"+b+"X+"+c;
        }
        public bool IsNumber(char i)
        {
            if (i == '1' || i == '2' || i == '3' || i == '4' || i == '5' || i == '6' || i == '7' || i == '8' || i == '9' || i == '0'||i=='-')
            {
                return true;
            }
            return false;
        }
    }
}
