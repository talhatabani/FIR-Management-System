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
    public partial class Sign_Up : Form
    {
        private int role = users.getRole();
        public Sign_Up()
        {
            InitializeComponent();
        }

        public void setRole(int role)
        {
            this.role = role;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sc = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.CommandType = CommandType.StoredProcedure;
            sc.Connection = connectionString.getConnection();

            if (role == 3)
            {
                sc.CommandText = "sp_PoliceInsert";
                sc.Parameters.AddWithValue("@PARAM_ROLE", Convert.ToInt32(roleBox.SelectedIndex) + 1);
            }

            else
            {
                sc.CommandText = "sp_CitizenInsert";
            }

            sc.Parameters.AddWithValue("@PARAM1", name.Text);
            sc.Parameters.AddWithValue("@PARAM2", fname.Text);
            sc.Parameters.AddWithValue("@PARAM3", cnic.Text);
            sc.Parameters.AddWithValue("@PARAM4", email.Text);
            sc.Parameters.AddWithValue("@PARAM5", Convert.ToInt64(cellno.Text));
            sc.Parameters.AddWithValue("@PARAM6", password.Text);
            int rows = sc.ExecuteNonQuery();
            if (rows > 0)
            {
                if(role == 3)
                {
                    MessageBox.Show("Police Officer has been added!");
                    loginPanelPolice lpp = new loginPanelPolice();
                    this.Hide();
                    lpp.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Your Account has been created!");
                    loginPanelCitizen lpc = new loginPanelCitizen();
                    this.Hide();
                    lpc.ShowDialog();
                    this.Close();
                }
               
                
            }
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            if (role == 3)
            {
                roleLabel.Visible = true;
                roleBox.Visible = true;
            }
        }
    }
}
