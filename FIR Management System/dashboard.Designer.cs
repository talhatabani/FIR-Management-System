namespace FIR_Management_System
{
    partial class dashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.generateFIR = new System.Windows.Forms.Button();
            this.checkFIR = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(5, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 82);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome To Sindh Citizen Portal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // generateFIR
            // 
            this.generateFIR.BackColor = System.Drawing.Color.Green;
            this.generateFIR.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.generateFIR.ForeColor = System.Drawing.Color.White;
            this.generateFIR.Location = new System.Drawing.Point(151, 111);
            this.generateFIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateFIR.Name = "generateFIR";
            this.generateFIR.Size = new System.Drawing.Size(340, 71);
            this.generateFIR.TabIndex = 7;
            this.generateFIR.Text = "Generate FIR";
            this.generateFIR.UseVisualStyleBackColor = false;
            this.generateFIR.Click += new System.EventHandler(this.generateFIR_Click);
            // 
            // checkFIR
            // 
            this.checkFIR.BackColor = System.Drawing.Color.Green;
            this.checkFIR.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.checkFIR.ForeColor = System.Drawing.Color.White;
            this.checkFIR.Location = new System.Drawing.Point(151, 217);
            this.checkFIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkFIR.Name = "checkFIR";
            this.checkFIR.Size = new System.Drawing.Size(340, 71);
            this.checkFIR.TabIndex = 8;
            this.checkFIR.Text = "Check FIR Progress";
            this.checkFIR.UseVisualStyleBackColor = false;
            this.checkFIR.Click += new System.EventHandler(this.checkFIR_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Green;
            this.logOutBtn.BackgroundImage = global::FIR_Management_System.Properties.Resources.logout1;
            this.logOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutBtn.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(251, 322);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(139, 135);
            this.logOutBtn.TabIndex = 17;
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 503);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.checkFIR);
            this.Controls.Add(this.generateFIR);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button generateFIR;
        private System.Windows.Forms.Button checkFIR;
        private System.Windows.Forms.Button logOutBtn;
    }
}