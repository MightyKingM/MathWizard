using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
namespace MathWizard
{
    class WorkFaker
    {
        public int question = 1;
        public string[] lines
        {
            get { return toprint.ToArray(); }
        }
        private List<string> toprint;
        public WorkFaker()
        {
            toprint = new List<string>();
        }
        public void NewLine(string line)
        {
            toprint.Add(line);
        }
        public void Print(PrintPageEventArgs e)
        {
            int curremtline = 10;
            e.Graphics.DrawString("Work Shown for Math HW on "+DateTime.Now.Date, new Font(FontFamily.GenericSerif, 10, FontStyle.Bold),Brushes.Black,new Point(0,curremtline));
            curremtline += 12;
            for(int i = 0; i < lines.Length; i++)
            {
                e.Graphics.DrawString(lines[i], new Font(FontFamily.GenericSerif, 5, FontStyle.Regular), Brushes.Black, new Point(0, curremtline));
                curremtline += 6;
                if(curremtline >= 1000)
                {
                    e.HasMorePages = true;
                    toprint.RemoveRange(0,162);
                    return;
                }
            }
            toprint.Clear();
            question = 1;
        }
    }
}
