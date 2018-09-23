using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace MathWizard
{
    class Wizard
    {
        public Wizard()
        {

        }
        public bool IsQuadratic(string Input)
        {
            if(Input.Contains("^")&&Input.Contains("X")&&!Input.Contains("(")&&!Input.Contains(")"))
            {
                return true;
            }
            return false;
        }
        public Binomial ToBinomial(BinomialQuadratic quadratic)
        {
            double bgna = quadratic.c;
            double bgnb = quadratic.a;
            double bgnc = quadratic.b;

            double item = Math.Sqrt((bgnb * bgnb) - (4 * bgna * bgnc));
            double b = (-bgnb + item)/ (2 * bgna);
            double c = (-bgnb - item)/(2*bgna);
            

            return new Binomial(-b,-c,bgna);
        }
    }
}
