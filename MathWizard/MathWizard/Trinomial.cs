using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizard
{
    class Trinomial
    {
        public int a;
        public int b;
        public int c;
        public int d;
        public Trinomial(int a, int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            d = 1;
        }
        public Trinomial(int a, int b, int c,int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public Trinomial(string input)
        {
            string temp = "";
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
                d = data[0];
                a = data[1];
                b = data[2];
                c = data[3];
            }
            else
            {
                a = data[0];
                b = data[1];
                c = data[2];
                d = 1;
            }
        }
        public bool IsNumber(char i)
        {
            if (i == '1' || i == '2' || i == '3' || i == '4' || i == '5' || i == '6' || i == '7' || i == '8' || i == '9' || i == '0')
            {
                return true;
            }
            return false;
        }
        public string AsString()
        {
            return d + "(X+" + a + ")(X+" + b + ")(X+" + c+")";
        }
    }
}
