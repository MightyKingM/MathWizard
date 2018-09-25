using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MathWizard
{
    public partial class About : System.Windows.Forms.Form
    {
       
        public About(string name)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            WebClient client = new WebClient();
            if (name == "releasenotes")
            {
                webBrowser.DocumentText = client.DownloadString("https://raw.githubusercontent.com/MightyKingM/MathWizard/master/Notes.txt");
            }
            if(name == "about")
            {
                webBrowser.DocumentText = client.DownloadString("https://raw.githubusercontent.com/MightyKingM/MathWizard/master/About.txt");
            }
            this.ShowDialog();
        }
    }
}
