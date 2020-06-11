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
    public partial class dashboard : Form
    {
        private int role = 0;
        private string email = users.getEmail();

        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (role != 1)
            {
                MessageBox.Show("You are authentic person!");
            }

            else
            {
                MessageBox.Show("You have no rights to enter here!!");
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Welcome wel = new Welcome();
            this.Close();
            wel.ShowDialog();
        }

        private void generateFIR_Click(object sender, EventArgs e)
        {
            FIR_Form fir = new FIR_Form();
            fir.email.Text = email;
            fir.submitBtn.Text = "SUBMIT FOR APPROVAL";
            this.Hide();
            MessageBox.Show("Things you should NOT do:\n"
                            + "\n1-Never file a false complaint or give wrong information to the   police.You can be prosecuted under law for giving wrong information or for misleading the police (Section 182 of the Pakistan Penal Code, 1860).\n"
                            + "\n2-Never exaggerate or distort facts.\n"
                            + "\n3-Never make vague or unclear statements.\n"
                            + "\n4-One who refuses to sign his statement of FIR can be prosecuted under section 180 of Pakistan Penal Code, 1860.\n"
                            + "\n5-One who lodges a false charge of offence made with intent to injure a person can be prosecuted under section 211 of Pakistan Penal Code, 1860.", "Policy Box");
            fir.ShowDialog();
            this.Close();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.ShowDialog();
            this.Close();
        }

        private void checkFIR_Click(object sender, EventArgs e)
        {
            RunningFIR rn = new RunningFIR("Citizen FIR's");
            this.Hide();
            rn.ShowDialog();
            this.Close();
        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
