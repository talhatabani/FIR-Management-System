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
    public partial class loginPanel : Form
    {
        public loginPanel()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (role.Text.Equals("Constable"))
            {
                constable cs = new constable(username.Text, password.Text, 1);
                //MessageBox.Show("Constable  " + cs.successful()); 
            }

            else if (role.Text.Equals("DSP"))
            {
                dsp cs = new dsp(username.Text, password.Text, 2);
                //MessageBox.Show("DSP  " + cs.successful());
            }

            else
            {
                comissioner cs = new comissioner(username.Text, password.Text, 3);
                //MessageBox.Show("Comissioner  " +  cs.successful());
            }
        }
    }
}
