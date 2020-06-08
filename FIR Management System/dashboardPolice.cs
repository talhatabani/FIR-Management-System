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
    public partial class dashboardPolice : Form
    {
        private int role = users.getRole();

        public dashboardPolice()
        {
            InitializeComponent();
        }

        private void generateFIRBtn_Click(object sender, EventArgs e)
        {
            FIR_Form fir = new FIR_Form();
            this.Hide();
            fir.ShowDialog();
            this.Close();
            
        }

        private void runningFIRBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
