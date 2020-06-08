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
            this.signOut = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateFIRBtn
            // 
            this.generateFIRBtn.BackColor = System.Drawing.Color.Firebrick;
            this.generateFIRBtn.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Bold);
            this.generateFIRBtn.ForeColor = System.Drawing.Color.White;
            this.generateFIRBtn.Location = new System.Drawing.Point(29, 91);
            this.generateFIRBtn.Margin = new System.Windows.Forms.Padding(2);
            this.generateFIRBtn.Name = "generateFIRBtn";
            this.generateFIRBtn.Size = new System.Drawing.Size(191, 44);
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
            this.pendingFir.Location = new System.Drawing.Point(274, 91);
            this.pendingFir.Name = "pendingFir";
            this.pendingFir.Size = new System.Drawing.Size(191, 44);
            this.pendingFir.TabIndex = 10;
            this.pendingFir.Text = "Pending FIRs";
            this.pendingFir.UseVisualStyleBackColor = false;
            // 
            // deletedFir
            // 
            this.deletedFir.BackColor = System.Drawing.Color.Firebrick;
            this.deletedFir.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Bold);
            this.deletedFir.ForeColor = System.Drawing.Color.White;
            this.deletedFir.Location = new System.Drawing.Point(274, 165);
            this.deletedFir.Name = "deletedFir";
            this.deletedFir.Size = new System.Drawing.Size(191, 44);
            this.deletedFir.TabIndex = 11;
            this.deletedFir.Text = "Deleted FIRs";
            this.deletedFir.UseVisualStyleBackColor = false;
            // 
            // completedFir
            // 
            this.completedFir.BackColor = System.Drawing.Color.Green;
            this.completedFir.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.completedFir.ForeColor = System.Drawing.Color.White;
            this.completedFir.Location = new System.Drawing.Point(124, 239);
            this.completedFir.Name = "completedFir";
            this.completedFir.Size = new System.Drawing.Size(252, 52);
            this.completedFir.TabIndex = 12;
            this.completedFir.Text = "Completed FIRs";
            this.completedFir.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 67);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 26);
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
            this.runningFIRBtn.Location = new System.Drawing.Point(29, 165);
            this.runningFIRBtn.Margin = new System.Windows.Forms.Padding(2);
            this.runningFIRBtn.Name = "runningFIRBtn";
            this.runningFIRBtn.Size = new System.Drawing.Size(191, 44);
            this.runningFIRBtn.TabIndex = 9;
            this.runningFIRBtn.Text = "Running FIRs";
            this.runningFIRBtn.UseVisualStyleBackColor = false;
            this.runningFIRBtn.Click += new System.EventHandler(this.runningFIRBtn_Click);
            // 
            // signOut
            // 
            this.signOut.BackColor = System.Drawing.Color.Green;
            this.signOut.BackgroundImage = global::FIR_Management_System.Properties.Resources.logout1;
            this.signOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signOut.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.signOut.ForeColor = System.Drawing.Color.White;
            this.signOut.Location = new System.Drawing.Point(192, 308);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(110, 110);
            this.signOut.TabIndex = 16;
            this.signOut.UseVisualStyleBackColor = false;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // dashboardPolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.completedFir);
            this.Controls.Add(this.deletedFir);
            this.Controls.Add(this.pendingFir);
            this.Controls.Add(this.runningFIRBtn);
            this.Controls.Add(this.generateFIRBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dashboardPolice";
            this.Text = "dashboardPolice";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
    }
}