namespace FIR_Management_System
{
    partial class dashboardPolice
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
            this.generateFIRBtn = new System.Windows.Forms.Button();
            this.pendingFir = new System.Windows.Forms.Button();
            this.deletedFir = new System.Windows.Forms.Button();
            this.completedFir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.runningFIRBtn = new System.Windows.Forms.Button();
            this.pendingFIRCount = new System.Windows.Forms.Label();
            this.runningFIRCount = new System.Windows.Forms.Label();
            this.deletedFIRCount = new System.Windows.Forms.Label();
            this.completedFIRCount = new System.Windows.Forms.Label();
            this.signOut = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateFIRBtn
            // 
            this.generateFIRBtn.BackColor = System.Drawing.Color.Firebrick;
            this.generateFIRBtn.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Bold);
            this.generateFIRBtn.ForeColor = System.Drawing.Color.White;
            this.generateFIRBtn.Location = new System.Drawing.Point(39, 112);
            this.generateFIRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateFIRBtn.Name = "generateFIRBtn";
            this.generateFIRBtn.Size = new System.Drawing.Size(255, 54);
            this.generateFIRBtn.TabIndex = 8;
            this.generateFIRBtn.Text = "Generate FIR";
            this.generateFIRBtn.UseVisualStyleBackColor = false;
            this.generateFIRBtn.Click += new System.EventHandler(this.generateFIRBtn_Click);
            // 
            // pendingFir
            // 
            this.pendingFir.BackColor = System.Drawing.Color.Firebrick;
            this.pendingFir.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Bold);
            this.pendingFir.ForeColor = System.Drawing.Color.White;
            this.pendingFir.Location = new System.Drawing.Point(365, 112);
            this.pendingFir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pendingFir.Name = "pendingFir";
            this.pendingFir.Size = new System.Drawing.Size(255, 54);
            this.pendingFir.TabIndex = 10;
            this.pendingFir.Text = "Pending FIRs";
            this.pendingFir.UseVisualStyleBackColor = false;
            this.pendingFir.Click += new System.EventHandler(this.pendingFir_Click);
            // 
            // deletedFir
            // 
            this.deletedFir.BackColor = System.Drawing.Color.Firebrick;
            this.deletedFir.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Bold);
            this.deletedFir.ForeColor = System.Drawing.Color.White;
            this.deletedFir.Location = new System.Drawing.Point(365, 203);
            this.deletedFir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletedFir.Name = "deletedFir";
            this.deletedFir.Size = new System.Drawing.Size(255, 54);
            this.deletedFir.TabIndex = 11;
            this.deletedFir.Text = "Deleted FIRs";
            this.deletedFir.UseVisualStyleBackColor = false;
            this.deletedFir.Click += new System.EventHandler(this.deletedFir_Click);
            // 
            // completedFir
            // 
            this.completedFir.BackColor = System.Drawing.Color.Green;
            this.completedFir.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.completedFir.ForeColor = System.Drawing.Color.White;
            this.completedFir.Location = new System.Drawing.Point(165, 294);
            this.completedFir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.completedFir.Name = "completedFir";
            this.completedFir.Size = new System.Drawing.Size(336, 64);
            this.completedFir.TabIndex = 12;
            this.completedFir.Text = "Completed FIRs";
            this.completedFir.UseVisualStyleBackColor = false;
            this.completedFir.Click += new System.EventHandler(this.completedFir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 82);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome To Sindh Police Portal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // runningFIRBtn
            // 
            this.runningFIRBtn.BackColor = System.Drawing.Color.Firebrick;
            this.runningFIRBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.runningFIRBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.runningFIRBtn.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Bold);
            this.runningFIRBtn.ForeColor = System.Drawing.Color.White;
            this.runningFIRBtn.Location = new System.Drawing.Point(39, 203);
            this.runningFIRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runningFIRBtn.Name = "runningFIRBtn";
            this.runningFIRBtn.Size = new System.Drawing.Size(255, 54);
            this.runningFIRBtn.TabIndex = 9;
            this.runningFIRBtn.Text = "Running FIRs";
            this.runningFIRBtn.UseVisualStyleBackColor = false;
            this.runningFIRBtn.Click += new System.EventHandler(this.runningFIRBtn_Click);
            // 
            // pendingFIRCount
            // 
            this.pendingFIRCount.AutoSize = true;
            this.pendingFIRCount.BackColor = System.Drawing.Color.Green;
            this.pendingFIRCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pendingFIRCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingFIRCount.ForeColor = System.Drawing.Color.White;
            this.pendingFIRCount.Location = new System.Drawing.Point(581, 101);
            this.pendingFIRCount.Name = "pendingFIRCount";
            this.pendingFIRCount.Size = new System.Drawing.Size(29, 31);
            this.pendingFIRCount.TabIndex = 17;
            this.pendingFIRCount.Text = "0";
            // 
            // runningFIRCount
            // 
            this.runningFIRCount.AutoSize = true;
            this.runningFIRCount.BackColor = System.Drawing.Color.Green;
            this.runningFIRCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.runningFIRCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningFIRCount.ForeColor = System.Drawing.Color.White;
            this.runningFIRCount.Location = new System.Drawing.Point(256, 191);
            this.runningFIRCount.Name = "runningFIRCount";
            this.runningFIRCount.Size = new System.Drawing.Size(29, 31);
            this.runningFIRCount.TabIndex = 18;
            this.runningFIRCount.Text = "0";
            // 
            // deletedFIRCount
            // 
            this.deletedFIRCount.AutoSize = true;
            this.deletedFIRCount.BackColor = System.Drawing.Color.Green;
            this.deletedFIRCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deletedFIRCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletedFIRCount.ForeColor = System.Drawing.Color.White;
            this.deletedFIRCount.Location = new System.Drawing.Point(581, 191);
            this.deletedFIRCount.Name = "deletedFIRCount";
            this.deletedFIRCount.Size = new System.Drawing.Size(29, 31);
            this.deletedFIRCount.TabIndex = 19;
            this.deletedFIRCount.Text = "0";
            // 
            // completedFIRCount
            // 
            this.completedFIRCount.AutoSize = true;
            this.completedFIRCount.BackColor = System.Drawing.Color.Firebrick;
            this.completedFIRCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.completedFIRCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedFIRCount.ForeColor = System.Drawing.Color.White;
            this.completedFIRCount.Location = new System.Drawing.Point(461, 282);
            this.completedFIRCount.Name = "completedFIRCount";
            this.completedFIRCount.Size = new System.Drawing.Size(29, 31);
            this.completedFIRCount.TabIndex = 20;
            this.completedFIRCount.Text = "0";
            // 
            // signOut
            // 
            this.signOut.BackColor = System.Drawing.Color.Green;
            this.signOut.BackgroundImage = global::FIR_Management_System.Properties.Resources.logout1;
            this.signOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signOut.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.signOut.ForeColor = System.Drawing.Color.White;
            this.signOut.Location = new System.Drawing.Point(261, 379);
            this.signOut.Margin = new System.Windows.Forms.Padding(4);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(134, 135);
            this.signOut.TabIndex = 16;
            this.signOut.UseVisualStyleBackColor = false;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // dashboardPolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 554);
            this.Controls.Add(this.completedFIRCount);
            this.Controls.Add(this.deletedFIRCount);
            this.Controls.Add(this.runningFIRCount);
            this.Controls.Add(this.pendingFIRCount);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.completedFir);
            this.Controls.Add(this.deletedFir);
            this.Controls.Add(this.pendingFir);
            this.Controls.Add(this.runningFIRBtn);
            this.Controls.Add(this.generateFIRBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dashboardPolice";
            this.Text = "dashboardPolice";
            this.Load += new System.EventHandler(this.dashboardPolice_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateFIRBtn;
        private System.Windows.Forms.Button runningFIRBtn;
        private System.Windows.Forms.Button pendingFir;
        private System.Windows.Forms.Button completedFir;
        private System.Windows.Forms.Button deletedFir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Label pendingFIRCount;
        private System.Windows.Forms.Label runningFIRCount;
        private System.Windows.Forms.Label deletedFIRCount;
        private System.Windows.Forms.Label completedFIRCount;
    }
}