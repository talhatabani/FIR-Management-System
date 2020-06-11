using System;
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            citizen cs = new citizen(cnicBox.Text, passwordBox.Text);
            bool status = cs.log(cnicBox.Text, passwordBox.Text);
            if(status == true)
            {
                dashboard ds = new dashboard();
                this.Hide();
                ds.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Login Failed!");
                cnicBox.Text = null;
                passwordBox.Text = null;
                cnicBox.Focus();
            }
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            this.Hide();
            signup.ShowDialog();
            this.Close();
        }

        private void cnicBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }

        private void loginPanelCitizen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
