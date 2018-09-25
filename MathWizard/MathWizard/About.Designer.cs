namespace MathWizard
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1282, 667);
            this.webBrowser.TabIndex = 3;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 690);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "Math Wizard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

