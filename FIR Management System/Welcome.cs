using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIR_Management_System.myClasses;

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
            loginPanelPolice lp = new loginPanelPolice();
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

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
