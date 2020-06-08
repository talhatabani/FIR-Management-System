using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FIR_Management_System.myClasses;
using System.Data;
using System.Windows.Forms;

namespace FIR_Management_System.myClasses
{
    class firCRUD
    {
        public RunningFIR rnFIR;
        private int role = users.getRole();
        public firCRUD()
        {

        }

        public void saveFIR(
                    string name,
                    string fname,
                    string cnic,
                    string email, 
                    long cellno,
                    string address,
                    string town, 
                    DateTime date,
                    DateTime time,
                    string location,
                    string incidentDet,
                    string lostItems,
                    string weapon,
                    string suspect,
                    string suspectName,
                    string suspectRelation,
                    string suspectAddress,
                    string witness,
                    string witnessName,
                    string witnessRelation,
                    string witnessAddress
                           )
        {
            SqlCommand sc = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.CommandType = CommandType.StoredProcedure;
            sc.Connection = connectionString.getConnection();
            sc.CommandText = "sp_FirInsert";

            // Status Details //
            //  Deleted = 0, Approved = 1, Not Approved = 2, FIR completed = 3 //

            if (role == 2 || role == 3)
            {
                sc.Parameters.AddWithValue("@STATUS", 1);
            }

            else
            {
                sc.Parameters.AddWithValue("@STATUS", 2);
            }

            sc.Parameters.AddWithValue("@PARAM1", name);
            sc.Parameters.AddWithValue("@PARAM2", fname);
            sc.Parameters.AddWithValue("@PARAM3", cnic);
            sc.Parameters.AddWithValue("@PARAM4", email);
            sc.Parameters.AddWithValue("@PARAM5", cellno);
            sc.Parameters.AddWithValue("@PARAM6", address);
            sc.Parameters.AddWithValue("@PARAM7", town);
            sc.Parameters.AddWithValue("@PARAM8", date);
            sc.Parameters.AddWithValue("@PARAM9", time);
            sc.Parameters.AddWithValue("@PARAM10", location);
            sc.Parameters.AddWithValue("@PARAM11", incidentDet);
            sc.Parameters.AddWithValue("@PARAM12", lostItems);
            sc.Parameters.AddWithValue("@PARAM13", weapon);
            sc.Parameters.AddWithValue("@PARAM14", suspect);
            sc.Parameters.AddWithValue("@PARAM15", suspectName);
            sc.Parameters.AddWithValue("@PARAM16", suspectRelation);
            sc.Parameters.AddWithValue("@PARAM17", suspectAddress);
            sc.Parameters.AddWithValue("@PARAM18", witness);
            sc.Parameters.AddWithValue("@PARAM19", witnessName);
            sc.Parameters.AddWithValue("@PARAM20", witnessRelation);
            sc.Parameters.AddWithValue("@PARAM21", witnessAddress);

            int rows = sc.ExecuteNonQuery();
            if (rows > 0)
            {
                if (role == 2 || role == 3)
                {
                    MessageBox.Show("FIR Has been Registered Successfully!");
                }

                else
                {
                    MessageBox.Show("FIR is Pending for Approval!");
                }
            }
        }

        public void showRunningFir()
        {
            string query = "SELECT fid, date, (name + ' ' + fname) AS NAME, town FROM fir WHERE status = 1";
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.Connection = connectionString.getConnection();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rnFIR.dgv.AutoGenerateColumns = false;
            rnFIR.dgv.Columns[0].DataPropertyName = "fid";
            rnFIR.dgv.Columns[1].DataPropertyName = "date";
            rnFIR.dgv.Columns[2].DataPropertyName = "NAME";
            rnFIR.dgv.Columns[3].DataPropertyName = "town";
            rnFIR.dgv.DataSource = dt;
        }

        public void fillFirForm(int fid)
        {
            RunningFIR rf = new RunningFIR();
            FIR_Form ff = new FIR_Form();
            rf.Hide();

            string query = "SELECT * FROM fir WHERE fid = " + fid;
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            sc.Connection = connectionString.getConnection();
            using (SqlDataReader myReader = sc.ExecuteReader())
            {
                while (myReader.Read())
                {
                    ff.name.Text = myReader[1].ToString();
                    ff.fname.Text = myReader[2].ToString();
                    ff.cnic.Text = myReader[3].ToString();
                    ff.email.Text = myReader[4].ToString();
                    ff.cellno.Text = myReader[5].ToString();
                    ff.address.Text = myReader[6].ToString();
                    ff.town.Text = myReader[7].ToString();
                    ff.date.Text = myReader[8].ToString();
                    ff.time.Text = myReader[9].ToString();
                    ff.location.Text = myReader[10].ToString();
                    ff.incidentDet.Text = myReader[11].ToString();
                    ff.lostItems.Text = myReader[12].ToString();
                    ff.weapon.Text = myReader[13].ToString();
                    ff.suspect.Text = myReader[14].ToString();
                    ff.suspectName.Text = myReader[15].ToString();
                    ff.suspectRelation.Text = myReader[16].ToString();
                    ff.suspectAddress.Text = myReader[17].ToString();
                    ff.witness.Text = myReader[18].ToString();
                    ff.witnessName.Text = myReader[19].ToString();
                    ff.witnessRelation.Text = myReader[20].ToString();
                    ff.witnessAddress.Text = myReader[21].ToString();
                }
            }

            if(role != 3 || role != 2)
            {
                ff.name.Enabled = false;
                ff.fname.Enabled = false;
                ff.cnic.Enabled = false;
                ff.email.Enabled = false;
                ff.cellno.Enabled = false;
                ff.address.Enabled = false;
                ff.town.Enabled = false;
                ff.date.Enabled = false;
                ff.time.Enabled = false;
                ff.location.Enabled = false;
                ff.incidentDet.Enabled = false;
                ff.lostItems.Enabled = false;
                ff.weapon.Enabled = false;
                ff.suspect.Enabled = false;
                ff.suspectName.Enabled = false;
                ff.suspectRelation.Enabled = false;
                ff.suspectAddress.Enabled = false;
                ff.witness.Enabled = false;
                ff.witnessName.Enabled = false;
                ff.witnessRelation.Enabled = false;
                ff.witnessAddress.Enabled = false;
                ff.submitBtn.Enabled = false;
            }

            else
            {
                ff.name.Enabled = true;
                ff.fname.Enabled = true;
                ff.cnic.Enabled = true;
                ff.email.Enabled = true;
                ff.cellno.Enabled = true;
                ff.address.Enabled = true;
                ff.town.Enabled = true;
                ff.date.Enabled = true;
                ff.time.Enabled = true;
                ff.location.Enabled = true;
                ff.incidentDet.Enabled = true;
                ff.lostItems.Enabled = true;
                ff.weapon.Enabled = true;
                ff.suspect.Enabled = true;
                ff.suspectName.Enabled = true;
                ff.suspectRelation.Enabled = true;
                ff.suspectAddress.Enabled = true;
                ff.witness.Enabled = true;
                ff.witnessName.Enabled = true;
                ff.witnessRelation.Enabled = true;
                ff.witnessAddress.Enabled = true;
                ff.submitBtn.Enabled = true;
            }

            ff.submitBtn.Text = "Update Fir";
            ff.ShowDialog();
            rf.Close();

        }
    }
}
