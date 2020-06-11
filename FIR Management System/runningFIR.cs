using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIR_Management_System.myClasses;
using System.Data.SqlClient;

namespace FIR_Management_System
{
    public partial class RunningFIR : Form
    {
        private int firID;
        private int role = users.getRole();
        private String email = users.getEmail();

        public RunningFIR(string control)
        {
            InitializeComponent();
            this.control.Text = control;
        }

        private void runningFIR_Load(object sender, EventArgs e)
        {
            firSindh fir = new firSindh();
            fir.rnFIR = this;

            if(control.Text.Equals("Running FIR's"))
            {
                fir.showFir(1);
            }

            else if (control.Text.Equals("Pending FIR's"))
            {
                fir.showFir(2);
                dgv.Columns[4].HeaderText = "Approve";
            }

            else if (control.Text.Equals("Deleted FIR's"))
            {
                fir.showFir(0);
                dgv.Columns[4].HeaderText = "Delete";
            }

            else if (control.Text.Equals("Completed FIR's"))
            {
                fir.showFir(3);
                dgv.Columns[4].HeaderText = "View Fir";
            }

            else if (control.Text.Equals("Citizen FIR's"))
            {
                fir.showCitFir(email);
                dgv.Columns[4].HeaderText = "View Fir";
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int index = (int) dgv.Rows[e.RowIndex].Cells[0].Value;
                this.firID = index;
                firSindh fir = new firSindh();
                fir.fillFirForm(firID, control.Text);
            }

            RunningFIR rf = new RunningFIR(control.Text);
            rf.runningFIR_Load(sender, e);
        }
       
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchDataRnFir(searchBox.Text);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            myClasses.firSindh fc = new firSindh();
            searchDataRnFir(searchBox.Text);
        }

        public void searchDataRnFir(String searchItem)
        {
            string query = "";

            if (control.Text.Equals("Running FIR's"))
            {
                query = "SELECT fid, date, (name + ' ' + fname) AS NAME, town FROM fir WHERE ((NAME LIKE '%" + searchItem + "%') OR (fid LIKE '%" + searchItem + "%')) AND status = 1";
            }

            else if (control.Text.Equals("Pending FIR's"))
            {
                query = "SELECT fid, date, (name + ' ' + fname) AS NAME, town FROM fir WHERE ((NAME LIKE '%" + searchItem + "%') OR (fid LIKE '%" + searchItem + "%')) AND status = 2";
            }

            else if (control.Text.Equals("Deleted FIR's"))
            {
                query = "SELECT fid, date, (name + ' ' + fname) AS NAME, town FROM fir WHERE ((NAME LIKE '%" + searchItem + "%') OR (fid LIKE '%" + searchItem + "%')) AND status = 0";
            }

            else if (control.Text.Equals("Completed FIR's"))
            {
                query = "SELECT fid, date, (name + ' ' + fname) AS NAME, town FROM fir WHERE ((NAME LIKE '%" + searchItem + "%') OR (fid LIKE '%" + searchItem + "%')) AND status = 3";
            }

            else if (control.Text.Equals("Citizen FIR's"))
            {
                query = "SELECT fid, date, (name + ' ' + fname) AS NAME, town FROM fir WHERE ((NAME LIKE '%" + searchItem + "%') OR (fid LIKE '%" + searchItem + "%')) AND email = " + email;
            }
        
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.Connection = connectionString.getConnection();
            DataTable dtRun = new DataTable();
            sda.Fill(dtRun);
            dgv.DataSource = dtRun;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            if (control.Text.Equals("Citizen FIR's"))
            {
                dashboard dp = new dashboard();
                this.Hide();
                dp.ShowDialog();
                this.Close();
            }

            else
            {
                dashboardPolice dp = new dashboardPolice();
                this.Hide();
                dp.ShowDialog();
                this.Close();
            }
        }

        private void RunningFIR_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
