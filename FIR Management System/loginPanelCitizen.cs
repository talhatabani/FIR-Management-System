﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIR_Management_System
{
    public partial class loginPanelCitizen : Form
    {
        public loginPanelCitizen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }
    }
}
