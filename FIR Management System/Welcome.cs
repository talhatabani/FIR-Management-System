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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void policePortal_Click(object sender, EventArgs e)
        {
            loginPanel lp = new loginPanel();
            this.Hide();
            lp.ShowDialog();
            this.Close();
        }

        private void citizenPortal_Click(object sender, EventArgs e)
        {
            loginPanelCitizen lpc = new loginPanelCitizen();
            this.Hide();
            lpc.ShowDialog();
            this.Close();
        }
    }
}
