using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathWizard
{
    public partial class Form : System.Windows.Forms.Form
    {
        WorkFaker Faker;
        Wizard wizard;
        public Form()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 350;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Text = "Math Wizard";
            Faker = new WorkFaker();
            wizard = new Wizard();
            Display.Text = "Math Wizard \r\n(C) Michael Wang\r\n\r\n" +
                "Version " + Application.ProductVersion + "\r\n" +
                "Major Version " + Application.ProductVersion[0] + "\r\n" +
                "Minor Version " + Application.ProductVersion[2] + "\r\n" +
                "Build Number "+Application.ProductVersion[4]+"\r\n" +
                "Revision "+Application.ProductVersion[6] ;
            Display.ReadOnly = true;
        }

        private void ToBinomialButton_Click(object sender, EventArgs e)
        {
            BinomialQuadratic bgn = new BinomialQuadratic(1, 1, 1);
            Display.Text = "Quadratic-Binomial Solver    (C)Michael Wang";
            try
            {
                bgn = new BinomialQuadratic(InputBox.Text);
                Faker.NewLine(Faker.question+". Convert the quadratic, "+bgn.AsString()+" to a binomial");
                progressBar.Value = 0;
            }
            catch
            {
                Display.Text += "\r\n\r\nOutput:" +
                    "\r\nThis is not a quadratic(binomial format); Invalid format; \r\n" +
                    "should be of ax^2+bx+c";
                return;
            }
            Binomial otp = wizard.ToBinomial(bgn);
            Faker.NewLine("="+otp.AsString());
            Display.Text += "\r\nBegining Value:\r\n" + bgn.AsString();
            Display.Text += "\r\nOutput:\r\n"+otp.AsString();
            
            Faker.question++;progressBar.Value = progressBar.Maximum;
        }

        private void ToBinomialQudraticButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            Display.Text = "Binomial-Quadratic Solver    (C)Michael Wang";
            Binomial bgn = new Binomial(1, 1, 1);
            try
            {
                bgn = new Binomial(InputBox.Text);
                Faker.NewLine(Faker.question+". Convert the Binomial " + bgn.AsString() + " to a quadratic");
            }
            catch
            {
                Display.Text += "\r\nOutput:\r\n" +
                    "This is not a binomial; Invalid Format;\r\n" +
                    "Should be of a(x+b)(X+c)";
                return;
            }
            Display.Text +=
                "\r\nBegining Value\r\n"+bgn.AsString();
            BinomialQuadratic otp = new BinomialQuadratic((bgn.a + bgn.b) * bgn.c, bgn.a * bgn.b * bgn.c, bgn.c);
            Faker.NewLine(bgn.c+"X^2+("+bgn.a+"+" + bgn.b+")*"+bgn.c+"X+"+bgn.a+"*"+bgn.b+"*"+bgn.c);
            Faker.NewLine("=" + otp.AsString());
            Faker.NewLine("");
            Display.Text += "\r\n\r\n" +
                        "Output Value\r\n" + otp.AsString();
            progressBar.Value = progressBar.Maximum;
        }

        private void PrintWork_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Printing Clears all Work","Warning",MessageBoxButtons.YesNo)==DialogResult.Yes&&
                printDialog.ShowDialog()==DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                progressBar.Value = 0;
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            progressBar.Value = 0;
            Faker.Print(e);
            progressBar.Value = progressBar.Maximum;
        }

        private void ToTrinomialButton_Click(object sender, EventArgs e)
        {
            TrinomialQuadratic bgn = new TrinomialQuadratic(1, 1, 1);
            Display.Text = "Quadratic-Trinomial Converter   (C)Michael Wang\r\n";
            progressBar.Value = 0;
            try
            {
                bgn = new TrinomialQuadratic(InputBox.Text);
                Display.Text += "Begining Value:\r\n" + bgn.AsString() + "\r\n";
                MessageBox.Show("This might take a while");
            }
            catch
            {
                Display.Text += "Output:\r\nThis is not a quadratic (trinomial);Invalid Format;\r\n" +
                    "Should be of: aX^3+bX^2+cX+d";
                progressBar.Value = progressBar.Maximum;
                return;
            }
            progressBar.Maximum = bgn.GetMaximumProgrss() * bgn.GetMaximumProgrss() * bgn.GetMaximumProgrss()*8;
            for (int a = -bgn.GetMaximumProgrss(); a <bgn.GetMaximumProgrss(); a++)
            {
                for(int b =-bgn.GetMaximumProgrss(); b < bgn.GetMaximumProgrss(); b++)
                {
                    for(int c=-bgn.GetMaximumProgrss(); c<bgn.GetMaximumProgrss(); c++)
                    {
                        if(bgn.a == bgn.d * c + (a+b) && bgn.b == a*b+c*a+b*a
                            && bgn.c == a *b*c)
                        {
                            progressBar.Value = progressBar.Maximum;
                            Trinomial otp = new Trinomial(a, b, c, bgn.d);
                            Display.Text += "Output:\r\n"+otp.AsString();
                            return;
                        }
                        progressBar.Value++;
                    }
                }
            }
            Display.Text += "Output:\r\nThis quadratic must produce integer";
            progressBar.Value = progressBar.Maximum;
        }

        private void ToTrinomialQuadratic_Click(object sender, EventArgs e)
        {
            Trinomial bgn = new Trinomial(1, 1, 1);
            progressBar.Value = 0;
            Display.Text = "Trinomial-Quadratic Converter   (C)Michael Wang\r\n";
            try
            {
                bgn = new Trinomial(InputBox.Text);
                Display.Text += "Begining Value:\r\n"+bgn.AsString()+"\r\n";
                Faker.NewLine(Faker.question + ". Convert the Trinomial, " + bgn.AsString() + " to a quadratic");
                Faker.question++;
            }
            catch
            {
                Display.Text += "Output:\r\nThis is not a trinomial;Invalid Format;\r\n" +
                    "Should be of: a(X+b)(X+c)(X+d)";
                progressBar.Value = progressBar.Maximum;
                return;
            }
            TrinomialQuadratic otp = new TrinomialQuadratic(bgn.d*bgn.c+bgn.a+bgn.b,bgn.a*bgn.b+bgn.c*bgn.a+bgn.b*bgn.a,
                bgn.c*bgn.a*bgn.b,bgn.d);
            Faker.NewLine("Work as in for a,b,c,d in ax^3+bx^2+cx+d");
            Faker.NewLine("a=" + bgn.d);
            Faker.NewLine("b=" + bgn.d + "*" + bgn.c + "+" + bgn.a + "+" + bgn.b + "=" + ((bgn.d * bgn.c) + bgn.a + bgn.b));
            Faker.NewLine("c=" + bgn.a + "*" + bgn.b + "+" + bgn.c + "*" + bgn.a + "+" + bgn.b + "*" + bgn.a + "=" + (bgn.a * bgn.b + bgn.c * bgn.a + bgn.b * bgn.a));
            Faker.NewLine("d="+bgn.c+"*"+bgn.a+"*"+bgn.c+"="+(bgn.c * bgn.a * bgn.b));
            Faker.NewLine("therfore =" + otp.AsString());
            Faker.NewLine("");
            Display.Text += "Output:\r\n" + otp.AsString();
            progressBar.Value = progressBar.Maximum;
        }

        private void RandomQuadraticButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            Random random = new Random();
            bool bi = false;
            object otp;
            Display.Text = "Generating Random Quadratic...";
            if (random.Next(0, 2) == 1)
            {
                bi = true;
            }
            if (bi)
            {
                int a = random.Next(1, 50);
                int b = random.Next(1, 50);
                int c = random.Next(1, 50);
                otp = new BinomialQuadratic((a + b) * c, a * b * c, c);
            }
            else
            {
                int a = random.Next(1, 50);
                int b = random.Next(1, 50);
                int c = random.Next(1, 50);
                int d = random.Next(1, 50);
                otp = new TrinomialQuadratic(d * c + a + b, a * b + c * a + b * a, c * a * b, d);
            }
            Display.Text = "Random Quadratic Generator  (C)Michael Wang\r\nOutput:\t\n";
            if (bi)
            {
                BinomialQuadratic temp = (BinomialQuadratic)otp;
                Display.Text += temp.AsString();
            }
            else
            {
                TrinomialQuadratic temp = (TrinomialQuadratic)otp;
                Display.Text += temp.AsString();
            }
        }
    }
}
