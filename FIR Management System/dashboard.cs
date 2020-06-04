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

        private int role;
        public dashboard()
        {
            InitializeComponent();
        }

        public void setRole(int role)
        {
            this.role = role;
        }

        public int getRole()
        {
            return role;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            rolebox.Text = "Role = " + role;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(role != 1)
            {
                MessageBox.Show("You are authentic person!");
            }

            else
            {
                MessageBox.Show("You have no rights to enter here!!");
            }
        }
    }
}
