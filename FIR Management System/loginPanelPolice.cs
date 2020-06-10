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
                MessageBox.Show("Login Failed!");
                username.Text = null;
                password.Text = null;
            }
        }
        

        private void role_TextUpdate(object sender, EventArgs e)
        {

        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (role.Text.Equals("Comissioner"))
            {
                users us = new users();
                bool status = us.signupEnabled(username.Text, password.Text);
                if (status == true)
                    signupBtn.Enabled = true;
                else
                    signupBtn.Enabled = false;           
            }

            else
            {
                signupBtn.Enabled = false;
            }
        }

        private void loginPanelPolice_Load(object sender, EventArgs e)
        {
            signupBtn.Enabled = false;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            Sign_Up su = new Sign_Up();
            su.setRole(3);
            this.Hide();
            su.ShowDialog();
            this.Close();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
