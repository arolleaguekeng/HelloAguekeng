namespace HelloAguekeng.WinForm
{
    partial class FrmUserEdit
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbProfile = new System.Windows.Forms.ComboBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.chkStaus = new System.Windows.Forms.CheckBox();
            this.llRemovePicture = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.llShowHidePassword = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(69, 119);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(338, 38);
            this.txtFullName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "FullNmae";
            // 
            // cbbProfile
            // 
            this.cbbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProfile.FormattingEnabled = true;
            this.cbbProfile.Location = new System.Drawing.Point(69, 364);
            this.cbbProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbProfile.Name = "cbbProfile";
            this.cbbProfile.Size = new System.Drawing.Size(338, 39);
            this.cbbProfile.TabIndex = 3;
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPicture.Location = new System.Drawing.Point(490, 119);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(312, 371);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 3;
            this.pbPicture.TabStop = false;
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(69, 198);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(338, 38);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(69, 284);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(338, 38);
            this.txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Profile";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(64, 252);
            this.lbpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(98, 25);
            this.lbpass.TabIndex = 1;
            this.lbpass.Text = "Password";
            // 
            // chkStaus
            // 
            this.chkStaus.AutoSize = true;
            this.chkStaus.Location = new System.Drawing.Point(69, 423);
            this.chkStaus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkStaus.Name = "chkStaus";
            this.chkStaus.Size = new System.Drawing.Size(95, 29);
            this.chkStaus.TabIndex = 4;
            this.chkStaus.Text = "Enable";
            this.chkStaus.UseVisualStyleBackColor = true;
            this.chkStaus.CheckedChanged += new System.EventHandler(this.chkStaus_CheckedChanged);
            // 
            // llRemovePicture
            // 
            this.llRemovePicture.AutoSize = true;
            this.llRemovePicture.Location = new System.Drawing.Point(778, 88);
            this.llRemovePicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llRemovePicture.Name = "llRemovePicture";
            this.llRemovePicture.Size = new System.Drawing.Size(26, 25);
            this.llRemovePicture.TabIndex = 5;
            this.llRemovePicture.TabStop = true;
            this.llRemovePicture.Text = "X";
            this.llRemovePicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemovePicture_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Picture";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Green;
            this.btnSave.Location = new System.Drawing.Point(618, 525);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 48);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // llShowHidePassword
            // 
            this.llShowHidePassword.AutoSize = true;
            this.llShowHidePassword.Location = new System.Drawing.Point(345, 254);
            this.llShowHidePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llShowHidePassword.Name = "llShowHidePassword";
            this.llShowHidePassword.Size = new System.Drawing.Size(62, 25);
            this.llShowHidePassword.TabIndex = 7;
            this.llShowHidePassword.TabStop = true;
            this.llShowHidePassword.Text = "Show";
            this.llShowHidePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowHidePassword_LinkClicked);
            // 
            // FrmUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 592);
            this.Controls.Add(this.llShowHidePassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.llRemovePicture);
            this.Controls.Add(this.chkStaus);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.cbbProfile);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtFullName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUserEdit";
            this.Text = "FrmUserEdit";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbProfile;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.CheckBox chkStaus;
        private System.Windows.Forms.LinkLabel llRemovePicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel llShowHidePassword;
    }
}