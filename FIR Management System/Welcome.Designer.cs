namespace FIR_Management_System
{
    partial class Welcome
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
            this.policePortal = new System.Windows.Forms.Button();
            this.citizenPortal = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 83);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome To Sindh Police Portal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // policePortal
            // 
            this.policePortal.BackColor = System.Drawing.Color.Firebrick;
            this.policePortal.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policePortal.ForeColor = System.Drawing.Color.White;
            this.policePortal.Location = new System.Drawing.Point(181, 115);
            this.policePortal.Name = "policePortal";
            this.policePortal.Size = new System.Drawing.Size(304, 87);
            this.policePortal.TabIndex = 6;
            this.policePortal.Text = "Police Portal ";
            this.policePortal.UseVisualStyleBackColor = false;
            this.policePortal.Click += new System.EventHandler(this.policePortal_Click);
            // 
            // citizenPortal
            // 
            this.citizenPortal.BackColor = System.Drawing.Color.Firebrick;
            this.citizenPortal.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenPortal.ForeColor = System.Drawing.Color.White;
            this.citizenPortal.Location = new System.Drawing.Point(181, 222);
            this.citizenPortal.Name = "citizenPortal";
            this.citizenPortal.Size = new System.Drawing.Size(304, 87);
            this.citizenPortal.TabIndex = 7;
            this.citizenPortal.Text = "Citizen Portal ";
            this.citizenPortal.UseVisualStyleBackColor = false;
            this.citizenPortal.Click += new System.EventHandler(this.citizenPortal_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 338);
            this.Controls.Add(this.citizenPortal);
            this.Controls.Add(this.policePortal);
            this.Controls.Add(this.panel2);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button policePortal;
        private System.Windows.Forms.Button citizenPortal;
    }
}