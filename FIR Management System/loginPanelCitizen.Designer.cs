namespace FIR_Management_System
{
    partial class loginPanelCitizen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPanelCitizen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cnicBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signupBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-16, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 156);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIR Management \r\nSystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-16, 178);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 66);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Citizen Login Panel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Teal;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderSize = 10;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(131, 434);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(208, 48);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(23, 377);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(409, 34);
            this.passwordBox.TabIndex = 9;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(20, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password:";
            // 
            // cnicBox
            // 
            this.cnicBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicBox.Location = new System.Drawing.Point(23, 304);
            this.cnicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cnicBox.Multiline = true;
            this.cnicBox.Name = "cnicBox";
            this.cnicBox.Size = new System.Drawing.Size(409, 32);
            this.cnicBox.TabIndex = 7;
            this.cnicBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnicBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cnicBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(19, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "CNIC# OR Email:";
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.OldLace;
            this.signupBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signupBtn.FlatAppearance.BorderSize = 10;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.Brown;
            this.signupBtn.Location = new System.Drawing.Point(131, 542);
            this.signupBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(208, 48);
            this.signupBtn.TabIndex = 15;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(201, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 35);
            this.label6.TabIndex = 14;
            this.label6.Text = "Or";
            // 
            // loginPanelCitizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 602);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cnicBox);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginPanelCitizen";
            this.Text = "loginPanelCitizen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginPanelCitizen_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cnicBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label label6;
    }
}