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
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sc = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.CommandType = CommandType.StoredProcedure;
            sc.CommandText = "sp_CitizenInsert";
            sc.Connection = connectionString.getConnection();
            sc.Parameters.AddWithValue("@PARAM1", name.Text);
            sc.Parameters.AddWithValue("@PARAM2", fname.Text);
            sc.Parameters.AddWithValue("@PARAM3", Convert.ToInt64(cnic.Text));
            sc.Parameters.AddWithValue("@PARAM4", email.Text);
            sc.Parameters.AddWithValue("@PARAM5", Convert.ToInt64(cellno.Text));
            sc.Parameters.AddWithValue("@PARAM6", password.Text);
            int rows = sc.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Your Account has been created!");
                loginPanelCitizen lpc = new loginPanelCitizen();
                this.Hide();
                lpc.ShowDialog();
                this.Close();
            }
        }
    }
}
