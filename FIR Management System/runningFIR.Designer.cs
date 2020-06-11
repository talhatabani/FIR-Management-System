namespace FIR_Management_System
{
    partial class RunningFIR
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.control = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewFir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(14, 127);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(409, 32);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search by FIR# or Name:";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Firebrick;
            this.searchBtn.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(434, 124);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(130, 41);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search FIR";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.control);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 66);
            this.panel2.TabIndex = 10;
            // 
            // control
            // 
            this.control.AutoSize = true;
            this.control.BackColor = System.Drawing.Color.Transparent;
            this.control.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control.ForeColor = System.Drawing.Color.White;
            this.control.Location = new System.Drawing.Point(219, 15);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(238, 34);
            this.control.TabIndex = 2;
            this.control.Text = "Running FIR\'s";
            this.control.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fid,
            this.date,
            this.name,
            this.town,
            this.viewFir});
            this.dgv.Location = new System.Drawing.Point(12, 196);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(640, 386);
            this.dgv.TabIndex = 11;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // fid
            // 
            this.fid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fid.HeaderText = "FIR#";
            this.fid.Name = "fid";
            this.fid.ReadOnly = true;
            this.fid.Width = 66;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 67;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Full Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // town
            // 
            this.town.HeaderText = "Town";
            this.town.Name = "town";
            this.town.ReadOnly = true;
            // 
            // viewFir
            // 
            this.viewFir.HeaderText = "Edit/Complete";
            this.viewFir.Name = "viewFir";
            this.viewFir.ReadOnly = true;
            this.viewFir.Text = "View FIR";
            this.viewFir.ToolTipText = "View FIR";
            this.viewFir.UseColumnTextForButtonValue = true;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backBtn.Font = new System.Drawing.Font("Verdana", 8.8F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(570, 124);
            this.backBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(82, 41);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // RunningFIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 594);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RunningFIR";
            this.Text = "FIR Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RunningFIR_FormClosing);
            this.Load += new System.EventHandler(this.runningFIR_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn town;
        private System.Windows.Forms.DataGridViewButtonColumn viewFir;
        public System.Windows.Forms.Label control;
        private System.Windows.Forms.Button backBtn;
    }
}