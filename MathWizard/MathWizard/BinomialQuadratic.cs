using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizard
{
    class BinomialQuadratic
    {
        public int a;
        public int b;
        public int c;
        public bool quickfactor = true;
        public int GetMaximumProgress()
        {
            if(!quickfactor)
            {
                return a * b * c;
            }
            else
            {
                List<int> data = new List<int>();
                data.Add(a); data.Add(b);
                return data.Max();
            }
        }
        public BinomialQuadratic(int a, int b)
        {
            this.a = a;
            this.b = b;
            this.c = 1;
        }
        public BinomialQuadratic(int a, int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public BinomialQuadratic(string input)
        {
            string temp = "";
            input +=" ";
            List<int> data = new List<int>();
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
                        data.Add(int.Parse(temp));
                        temp = "";
                    }
                }
            }
            if (IsNumber(input[0]))
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
            if (i == '1' || i == '2' || i == '3' || i == '4' || i == '5' || i == '6' || i == '7' || i == '8' || i == '9' || i == '0'||i=='-')
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
