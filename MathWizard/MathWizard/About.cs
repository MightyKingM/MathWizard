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
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            try
            {
                if (name == "releasenotes")
                {
                    webBrowser.DocumentText = client.DownloadString("https://raw.githubusercontent.com/MightyKingM/MathWizard/master/Notes.txt");
                }
                if (name == "about")
                {
                    webBrowser.DocumentText = client.DownloadString("https://raw.githubusercontent.com/MightyKingM/MathWizard/master/About.txt");
                }
                if (name == "start")
                {
                    webBrowser.DocumentText = client.DownloadString("https://raw.githubusercontent.com/MightyKingM/MathWizard/master/StartupText.txt");
                }
            }
            catch(Exception e)
            {
                webBrowser.DocumentText = "Sorry Pal, <br>"+
                    "We can't fetch any data. Heres the problenm:<br>"+
                    ""+e.Message;
            }
            this.ShowDialog();
        }
    }
}
