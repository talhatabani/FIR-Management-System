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
            this.runningFIRBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generateFIRBtn
            // 
            this.generateFIRBtn.BackColor = System.Drawing.Color.Firebrick;
            this.generateFIRBtn.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Bold);
            this.generateFIRBtn.ForeColor = System.Drawing.Color.White;
            this.generateFIRBtn.Location = new System.Drawing.Point(35, 91);
            this.generateFIRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateFIRBtn.Name = "generateFIRBtn";
            this.generateFIRBtn.Size = new System.Drawing.Size(237, 41);
            this.generateFIRBtn.TabIndex = 8;
            this.generateFIRBtn.Text = "Generate FIR";
            this.generateFIRBtn.UseVisualStyleBackColor = false;
            this.generateFIRBtn.Click += new System.EventHandler(this.generateFIRBtn_Click);
            // 
            // runningFIRBtn
            // 
            this.runningFIRBtn.BackColor = System.Drawing.Color.Firebrick;
            this.runningFIRBtn.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Bold);
            this.runningFIRBtn.ForeColor = System.Drawing.Color.White;
            this.runningFIRBtn.Location = new System.Drawing.Point(399, 91);
            this.runningFIRBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runningFIRBtn.Name = "runningFIRBtn";
            this.runningFIRBtn.Size = new System.Drawing.Size(237, 41);
            this.runningFIRBtn.TabIndex = 9;
            this.runningFIRBtn.Text = "Running FIR\'s";
            this.runningFIRBtn.UseVisualStyleBackColor = false;
            this.runningFIRBtn.Click += new System.EventHandler(this.runningFIRBtn_Click);
            // 
            // dashboardPolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 403);
            this.Controls.Add(this.runningFIRBtn);
            this.Controls.Add(this.generateFIRBtn);
            this.Name = "dashboardPolice";
            this.Text = "dashboardPolice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateFIRBtn;
        private System.Windows.Forms.Button runningFIRBtn;
    }
}