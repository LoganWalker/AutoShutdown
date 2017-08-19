namespace MultifunctionApp
{
    partial class UserFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFeedback));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gbBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PersonalFeedback = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFields = new System.Windows.Forms.Label();
            this.txtAgeBox = new System.Windows.Forms.TextBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.gbBasicInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // gbBasicInfo
            // 
            this.gbBasicInfo.Controls.Add(this.lblActivity);
            this.gbBasicInfo.Controls.Add(this.txtAgeBox);
            this.gbBasicInfo.Controls.Add(this.txtEmail);
            this.gbBasicInfo.Controls.Add(this.email);
            this.gbBasicInfo.Controls.Add(this.chkAgree);
            this.gbBasicInfo.Controls.Add(this.txtLocation);
            this.gbBasicInfo.Controls.Add(this.txtName);
            this.gbBasicInfo.Controls.Add(this.label1);
            this.gbBasicInfo.Controls.Add(this.lblLocation);
            this.gbBasicInfo.Controls.Add(this.lblAge);
            this.gbBasicInfo.Controls.Add(this.lblName);
            resources.ApplyResources(this.gbBasicInfo, "gbBasicInfo");
            this.gbBasicInfo.Name = "gbBasicInfo";
            this.gbBasicInfo.TabStop = false;
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.Name = "email";
            // 
            // chkAgree
            // 
            resources.ApplyResources(this.chkAgree, "chkAgree");
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            resources.ApplyResources(this.txtLocation, "txtLocation");
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Leave += new System.EventHandler(this.txtLocation_Leave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.lblLocation.Name = "lblLocation";
            // 
            // lblAge
            // 
            resources.ApplyResources(this.lblAge, "lblAge");
            this.lblAge.Name = "lblAge";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // rdoFemale
            // 
            resources.ApplyResources(this.rdoFemale, "rdoFemale");
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            resources.ApplyResources(this.rdoMale, "rdoMale");
            this.rdoMale.Checked = true;
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.TabStop = true;
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // PersonalFeedback
            // 
            resources.ApplyResources(this.PersonalFeedback, "PersonalFeedback");
            this.PersonalFeedback.Name = "PersonalFeedback";
            this.PersonalFeedback.Leave += new System.EventHandler(this.PersonalFeedback_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PersonalFeedback);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.rdoFemale);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.Name = "lblGender";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblFields
            // 
            resources.ApplyResources(this.lblFields, "lblFields");
            this.lblFields.Name = "lblFields";
            // 
            // txtAgeBox
            // 
            resources.ApplyResources(this.txtAgeBox, "txtAgeBox");
            this.txtAgeBox.Name = "txtAgeBox";
            this.txtAgeBox.TextChanged += new System.EventHandler(this.txtAgeBox_TextChanged);
            this.txtAgeBox.Leave += new System.EventHandler(this.txtAgeBox_Leave);
            // 
            // lblActivity
            // 
            resources.ApplyResources(this.lblActivity, "lblActivity");
            this.lblActivity.Name = "lblActivity";
            // 
            // UserFeedback
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFields);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbBasicInfo);
            this.Controls.Add(this.lblWelcome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserFeedback";
            this.gbBasicInfo.ResumeLayout(false);
            this.gbBasicInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox gbBasicInfo;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox PersonalFeedback;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtAgeBox;
        private System.Windows.Forms.Label lblActivity;
    }
}