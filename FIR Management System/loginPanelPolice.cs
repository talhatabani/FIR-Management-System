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
    public partial class loginPanelPolice : Form
    {
        public loginPanelPolice()
        {
            InitializeComponent();
        }

        //login checking criteria.//
        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool status = false;

            if (role.Text.Equals("Constable"))
            {
                constable cs = new constable(username.Text, password.Text, 1);
                status = cs.log(username.Text, password.Text, 1);
            }

            else if (role.Text.Equals("DSP"))
            {
                dsp dn = new dsp(username.Text, password.Text, 2);
                status = dn.log(username.Text, password.Text, 2);
            }

            else
            {
                comissioner cn = new comissioner(username.Text, password.Text, 3);
                status = cn.log(username.Text, password.Text, 3);
            }
            
            dashboardPolice ds = new dashboardPolice();

            if (status == true)
            {
                this.Hide();
                ds.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Login Failed!\nUsername or Password or Role is incoorect.");
                username.Text = null;
                password.Text = null;
                username.Focus();
            }
        }

        //just checking Comissioner login so thatb he can add police officers.//
        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (role.Text.Equals("Comissioner"))
            {
                users us = new users();
                bool status = us.signupEnabled(username.Text, password.Text);
                if (status == true)
                {
                    signupBtn.Enabled = true;
                    signupBtn.BackColor = Color.DarkGreen;
                }

                else
                {
                    signupBtn.Enabled = false;
                    signupBtn.BackColor = Color.Maroon;
                    MessageBox.Show("Your username or password doesn't match.");
                }         
            }

            else
            {
                signupBtn.Enabled = false;
                signupBtn.BackColor = Color.Maroon;
            }
        }

        private void loginPanelPolice_Load(object sender, EventArgs e)
        {
            signupBtn.Enabled = false;
            role.SelectedIndex = 1;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Sign_Up su = new Sign_Up();
            su.setRole(3);
            this.Hide();
            su.ShowDialog();
            this.Close();
        }

        // just a beautify event.//
        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");
            }
        }

        private void loginPanelPolice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
