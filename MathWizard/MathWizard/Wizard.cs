using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
