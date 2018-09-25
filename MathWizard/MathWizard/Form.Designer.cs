namespace MathWizard
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ToBinomialButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ToBinomialQudraticButton = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.PrintWork = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.BinomialsTab = new System.Windows.Forms.TabPage();
            this.TrinomialTab = new System.Windows.Forms.TabPage();
            this.ToTrinomialQuadratic = new System.Windows.Forms.Button();
            this.ToTrinomialButton = new System.Windows.Forms.Button();
            this.GeneralToolsTab = new System.Windows.Forms.TabPage();
            this.RandomQuadraticButton = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.ReleaseNotesButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.BinomialsTab.SuspendLayout();
            this.TrinomialTab.SuspendLayout();
            this.GeneralToolsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(0, 0);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(1270, 38);
            this.InputBox.TabIndex = 0;
            this.InputBox.WordWrap = false;
            // 
            // ToBinomialButton
            // 
            this.ToBinomialButton.Location = new System.Drawing.Point(6, 6);
            this.ToBinomialButton.Name = "ToBinomialButton";
            this.ToBinomialButton.Size = new System.Drawing.Size(210, 50);
            this.ToBinomialButton.TabIndex = 1;
            this.ToBinomialButton.Text = "ToBinomial";
            this.ToBinomialButton.UseVisualStyleBackColor = true;
            this.ToBinomialButton.Click += new System.EventHandler(this.ToBinomialButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 65);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1270, 23);
            this.progressBar.TabIndex = 2;
            // 
            // ToBinomialQudraticButton
            // 
            this.ToBinomialQudraticButton.Location = new System.Drawing.Point(222, 6);
            this.ToBinomialQudraticButton.Name = "ToBinomialQudraticButton";
            this.ToBinomialQudraticButton.Size = new System.Drawing.Size(200, 50);
            this.ToBinomialQudraticButton.TabIndex = 3;
            this.ToBinomialQudraticButton.Text = "ToQuadratic";
            this.ToBinomialQudraticButton.UseVisualStyleBackColor = true;
            this.ToBinomialQudraticButton.Click += new System.EventHandler(this.ToBinomialQudraticButton_Click);
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(0, 244);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(1270, 486);
            this.Display.TabIndex = 4;
            // 
            // PrintWork
            // 
            this.PrintWork.Location = new System.Drawing.Point(1016, 110);
            this.PrintWork.Name = "PrintWork";
            this.PrintWork.Size = new System.Drawing.Size(210, 120);
            this.PrintWork.TabIndex = 7;
            this.PrintWork.Text = "PrintMyWork";
            this.PrintWork.UseVisualStyleBackColor = true;
            this.PrintWork.Click += new System.EventHandler(this.PrintWork_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.BinomialsTab);
            this.Tabs.Controls.Add(this.TrinomialTab);
            this.Tabs.Controls.Add(this.GeneralToolsTab);
            this.Tabs.Location = new System.Drawing.Point(0, 110);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(978, 120);
            this.Tabs.TabIndex = 8;
            // 
            // BinomialsTab
            // 
            this.BinomialsTab.Controls.Add(this.ToBinomialButton);
            this.BinomialsTab.Controls.Add(this.ToBinomialQudraticButton);
            this.BinomialsTab.Location = new System.Drawing.Point(10, 48);
            this.BinomialsTab.Name = "BinomialsTab";
            this.BinomialsTab.Padding = new System.Windows.Forms.Padding(3);
            this.BinomialsTab.Size = new System.Drawing.Size(958, 62);
            this.BinomialsTab.TabIndex = 0;
            this.BinomialsTab.Text = "Binomial Tools";
            this.BinomialsTab.UseVisualStyleBackColor = true;
            // 
            // TrinomialTab
            // 
            this.TrinomialTab.Controls.Add(this.ToTrinomialQuadratic);
            this.TrinomialTab.Controls.Add(this.ToTrinomialButton);
            this.TrinomialTab.Location = new System.Drawing.Point(10, 48);
            this.TrinomialTab.Name = "TrinomialTab";
            this.TrinomialTab.Padding = new System.Windows.Forms.Padding(3);
            this.TrinomialTab.Size = new System.Drawing.Size(958, 62);
            this.TrinomialTab.TabIndex = 1;
            this.TrinomialTab.Text = "Trinomial Tools";
            this.TrinomialTab.UseVisualStyleBackColor = true;
            // 
            // ToTrinomialQuadratic
            // 
            this.ToTrinomialQuadratic.Location = new System.Drawing.Point(222, 6);
            this.ToTrinomialQuadratic.Name = "ToTrinomialQuadratic";
            this.ToTrinomialQuadratic.Size = new System.Drawing.Size(200, 50);
            this.ToTrinomialQuadratic.TabIndex = 4;
            this.ToTrinomialQuadratic.Text = "ToQuadratic";
            this.ToTrinomialQuadratic.UseVisualStyleBackColor = true;
            this.ToTrinomialQuadratic.Click += new System.EventHandler(this.ToTrinomialQuadratic_Click);
            // 
            // ToTrinomialButton
            // 
            this.ToTrinomialButton.Location = new System.Drawing.Point(6, 6);
            this.ToTrinomialButton.Name = "ToTrinomialButton";
            this.ToTrinomialButton.Size = new System.Drawing.Size(210, 50);
            this.ToTrinomialButton.TabIndex = 2;
            this.ToTrinomialButton.Text = "ToTrinomial";
            this.ToTrinomialButton.UseVisualStyleBackColor = true;
            this.ToTrinomialButton.Click += new System.EventHandler(this.ToTrinomialButton_Click);
            // 
            // GeneralToolsTab
            // 
            this.GeneralToolsTab.Controls.Add(this.AboutButton);
            this.GeneralToolsTab.Controls.Add(this.ReleaseNotesButton);
            this.GeneralToolsTab.Controls.Add(this.RandomQuadraticButton);
            this.GeneralToolsTab.Location = new System.Drawing.Point(10, 48);
            this.GeneralToolsTab.Name = "GeneralToolsTab";
            this.GeneralToolsTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralToolsTab.Size = new System.Drawing.Size(958, 62);
            this.GeneralToolsTab.TabIndex = 2;
            this.GeneralToolsTab.Text = "GeneralTools";
            this.GeneralToolsTab.UseVisualStyleBackColor = true;
            // 
            // RandomQuadraticButton
            // 
            this.RandomQuadraticButton.Location = new System.Drawing.Point(6, 9);
            this.RandomQuadraticButton.Name = "RandomQuadraticButton";
            this.RandomQuadraticButton.Size = new System.Drawing.Size(270, 50);
            this.RandomQuadraticButton.TabIndex = 5;
            this.RandomQuadraticButton.Text = "RandomQuadratic";
            this.RandomQuadraticButton.UseVisualStyleBackColor = true;
            this.RandomQuadraticButton.Click += new System.EventHandler(this.RandomQuadraticButton_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // ReleaseNotesButton
            // 
            this.ReleaseNotesButton.Location = new System.Drawing.Point(294, 9);
            this.ReleaseNotesButton.Name = "ReleaseNotesButton";
            this.ReleaseNotesButton.Size = new System.Drawing.Size(250, 50);
            this.ReleaseNotesButton.TabIndex = 6;
            this.ReleaseNotesButton.Text = "ReleaseNotes";
            this.ReleaseNotesButton.UseVisualStyleBackColor = true;
            this.ReleaseNotesButton.Click += new System.EventHandler(this.ReleaseNotesButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(559, 9);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(250, 50);
            this.AboutButton.TabIndex = 7;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 758);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.PrintWork);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.InputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Math Wizard";
            this.Tabs.ResumeLayout(false);
            this.BinomialsTab.ResumeLayout(false);
            this.TrinomialTab.ResumeLayout(false);
            this.GeneralToolsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button ToBinomialButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button ToBinomialQudraticButton;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button PrintWork;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage BinomialsTab;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TabPage TrinomialTab;
        private System.Windows.Forms.Button ToTrinomialButton;
        private System.Windows.Forms.Button ToTrinomialQuadratic;
        private System.Windows.Forms.TabPage GeneralToolsTab;
        private System.Windows.Forms.Button RandomQuadraticButton;
        private System.Windows.Forms.Button ReleaseNotesButton;
        private System.Windows.Forms.Button AboutButton;
    }
}

