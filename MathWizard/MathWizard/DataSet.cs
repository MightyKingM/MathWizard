using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathWizard
{
    class DataSet
    {
        public int[] data
        {
            get { return currentdat.ToArray(); }
        }
        public string AsString()
        {
            string ret = "";
            for(int i = 0; i < data.Length; i++)
            {
                ret += data[i] + ",";
            }
            return ret;
        }
        private List<int> currentdat;
        public DataSet(string input)
        {
            input += " ";
            currentdat = new List<int>();
            string temp = "";
            for(int i = 0;i<input.Length;i++)
            {
                if(input[i] == '-' ||input[i] == ',' || input[i] == ' ')
                {
                    currentdat.Add(int.Parse(temp));
                    temp = "";
                }
                else
                {
                    temp += input[i];
                }
            }
        }
        public float mean()
        {
            int total = 0;
            for(int i = 0; i<data.Length;i++)
            {
                total = total + data[i];
            }
            return (float)total / data.Length;
        }
    }
}
