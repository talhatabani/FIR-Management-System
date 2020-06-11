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
        myClasses.firSindh fc = new myClasses.firSindh();
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
            RunningFIR rf = new RunningFIR("Running FIR's");
            this.Hide();
            rf.ShowDialog();
            this.Close();
         }

        private void pendingFir_Click(object sender, EventArgs e)
        {
            if(role == 1)
            {
                MessageBox.Show("you're not given authority to access these things! ");
            }

            else
            {
                RunningFIR rf = new RunningFIR("Pending FIR's");
                this.Hide();
                rf.ShowDialog();
                this.Close();
            }
            
        }

        private void deletedFir_Click(object sender, EventArgs e)
        {
            if (role == 1)
            {
                MessageBox.Show("you're not given authority to access these things! ");
            }

            else
            {
                RunningFIR rf = new RunningFIR("Deleted FIR's");
                this.Hide();
                rf.ShowDialog();
                this.Close();
            }
        }

        private void completedFir_Click(object sender, EventArgs e)
        {
            if (role == 1)
            {
                MessageBox.Show("you're not given authority to access these things! ");
            }

            else
            {
                RunningFIR rf = new RunningFIR("Completed FIR's");
                this.Hide();
                rf.ShowDialog();
                this.Close();
            }
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            Welcome wel = new Welcome();
            this.Hide();
            MessageBox.Show("Logout Successfully");
            wel.ShowDialog();
            this.Close();
        }

        private void dashboardPolice_Load(object sender, EventArgs e)
        {
            deletedFIRCount.Text = fc.FIRCount(0);
            runningFIRCount.Text = fc.FIRCount(1);
            pendingFIRCount.Text = fc.FIRCount(2);
            completedFIRCount.Text = fc.FIRCount(3);
        }

        private void dashboardPolice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
