namespace MultifunctionApp
{
    partial class Option
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
            this.rdoSafeY = new System.Windows.Forms.RadioButton();
            this.rdoSafeN = new System.Windows.Forms.RadioButton();
            this.gbPrePressSafe = new System.Windows.Forms.GroupBox();
            this.lblMessagePreCheck = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPrePressSafe.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoSafeY
            // 
            this.rdoSafeY.AutoSize = true;
            this.rdoSafeY.Checked = true;
            this.rdoSafeY.Location = new System.Drawing.Point(6, 19);
            this.rdoSafeY.Name = "rdoSafeY";
            this.rdoSafeY.Size = new System.Drawing.Size(43, 17);
            this.rdoSafeY.TabIndex = 1;
            this.rdoSafeY.TabStop = true;
            this.rdoSafeY.Text = "Yes";
            this.rdoSafeY.UseVisualStyleBackColor = true;
            this.rdoSafeY.CheckedChanged += new System.EventHandler(this.rdoSafeY_CheckedChanged);
            // 
            // rdoSafeN
            // 
            this.rdoSafeN.AutoSize = true;
            this.rdoSafeN.Location = new System.Drawing.Point(55, 19);
            this.rdoSafeN.Name = "rdoSafeN";
            this.rdoSafeN.Size = new System.Drawing.Size(39, 17);
            this.rdoSafeN.TabIndex = 2;
            this.rdoSafeN.Text = "No";
            this.rdoSafeN.UseVisualStyleBackColor = true;
            // 
            // gbPrePressSafe
            // 
            this.gbPrePressSafe.Controls.Add(this.rdoSafeN);
            this.gbPrePressSafe.Controls.Add(this.rdoSafeY);
            this.gbPrePressSafe.Location = new System.Drawing.Point(15, 63);
            this.gbPrePressSafe.Name = "gbPrePressSafe";
            this.gbPrePressSafe.Size = new System.Drawing.Size(109, 42);
            this.gbPrePressSafe.TabIndex = 3;
            this.gbPrePressSafe.TabStop = false;
            this.gbPrePressSafe.Text = "Start Safe Mode";
            // 
            // lblMessagePreCheck
            // 
            this.lblMessagePreCheck.AutoSize = true;
            this.lblMessagePreCheck.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblMessagePreCheck.Location = new System.Drawing.Point(12, 24);
            this.lblMessagePreCheck.Name = "lblMessagePreCheck";
            this.lblMessagePreCheck.Size = new System.Drawing.Size(257, 26);
            this.lblMessagePreCheck.TabIndex = 4;
            this.lblMessagePreCheck.Text = "Do you want to see a message box before \r\nyou start your option to confim you giv" +
    "en information?";
            this.lblMessagePreCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 119);
            this.Controls.Add(this.lblMessagePreCheck);
            this.Controls.Add(this.gbPrePressSafe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Option";
            this.Text = "Option";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Option_FormClosing);
            this.gbPrePressSafe.ResumeLayout(false);
            this.gbPrePressSafe.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessagePreCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.RadioButton rdoSafeY;
        public System.Windows.Forms.RadioButton rdoSafeN;
        public System.Windows.Forms.GroupBox gbPrePressSafe;
    }
}