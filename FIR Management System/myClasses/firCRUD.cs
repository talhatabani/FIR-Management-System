using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FIR_Management_System.myClasses;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace FIR_Management_System.myClasses
{
    interface firMain
    {
        string FIRCount(int status);

        void saveFIR(
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
          );

        void updateFIR(
                    int fid,
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
        );

        void fillFirForm(int fid, string form);

        void showFir(int status);

    }

    class firCRUD : firMain
    {
        public RunningFIR rnFIR;
        private int role = users.getRole();

        public firCRUD()
        {

        }

        public string FIRCount(int status)
        {
            string query = "SELECT COUNT(*) FROM fir WHERE status = " + status;
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.Connection = connectionString.getConnection();
            return ((sc.ExecuteScalar().ToString()));
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
            //  Deleted = 0, Running = 1, Pending = 2, FIR completed = 3 //

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

        public void updateFIR(
                    int fid,
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
            sc.CommandText = "sp_FirUpdate";

            sc.Parameters.AddWithValue("@updateFID", fid);
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
                MessageBox.Show("FIR Has been Updated Successfully!");
            }
        }

        public void completeFIR(int fid)
        {
            string query = "UPDATE fir SET status = 3 WHERE fid = " + fid;
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.Connection = connectionString.getConnection();
            int rows = sc.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("FIR is Completed!");
            }

        }

        public void reInvestigateFIR(int fid)
        {
            string query = "UPDATE fir SET status = 1 WHERE fid = " + fid;
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.Connection = connectionString.getConnection();
            int rows = sc.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("FIR will Re-Investigate!");
            }

        }

        public void showFir(int status)
        {
            string query = "SELECT fid, date, (name + ' ' + fname) AS NAME, town FROM fir WHERE status = " + status;
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.Connection = connectionString.getConnection();
            DataTable dtRun = new DataTable();
            sda.Fill(dtRun);
            rnFIR.dgv.AutoGenerateColumns = false;
            rnFIR.dgv.Columns[0].DataPropertyName = "fid";
            rnFIR.dgv.Columns[1].DataPropertyName = "date";
            rnFIR.dgv.Columns[2].DataPropertyName = "NAME";
            rnFIR.dgv.Columns[3].DataPropertyName = "town";
            rnFIR.dgv.DataSource = dtRun;
        }

        public void showCitFir(string email)
        {
            string query = "SELECT fid, date, (name + ' ' + fname) AS NAME, town FROM fir WHERE (email = '" + email + "' OR cnic = '" + email + "')";
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.Connection = connectionString.getConnection();
            DataTable dtRun = new DataTable();
            sda.Fill(dtRun);
            rnFIR.dgv.AutoGenerateColumns = false;
            rnFIR.dgv.Columns[0].DataPropertyName = "fid";
            rnFIR.dgv.Columns[1].DataPropertyName = "date";
            rnFIR.dgv.Columns[2].DataPropertyName = "NAME";
            rnFIR.dgv.Columns[3].DataPropertyName = "town";
            rnFIR.dgv.DataSource = dtRun;
        }

        public void fillFirForm(int fid, string form)
        {
            FIR_Form ff = new FIR_Form(form);
            RunningFIR rf = new RunningFIR(form);

            rf.Hide();

            string query = "SELECT * FROM fir WHERE fid = " + fid;
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            sc.Connection = connectionString.getConnection();
            using (SqlDataReader myReader = sc.ExecuteReader())
            {
                while (myReader.Read())
                {
                    ff.fid = Convert.ToInt32(myReader[0]);
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
                    ff.status = Convert.ToInt32(myReader[22]);
                }
            }

            if(rf.control.Text == "Running FIR's")
            {
                ff.submitBtn.Text = "UPDATE";
                ff.submitBtn.BackColor = Color.Purple;
                ff.submitBtn.ForeColor = Color.White;
            }

            else if (rf.control.Text == "Pending FIR's")
            {
                ff.submitBtn.Text = "APPROVE";
                ff.submitBtn.BackColor = Color.Orange;
                ff.submitBtn.ForeColor = Color.White;
            }

            else if (rf.control.Text == "Deleted FIR's")
            {
                ff.submitBtn.Text = "RE INVESTIGATE";
                ff.submitBtn.BackColor = Color.YellowGreen;
                ff.submitBtn.ForeColor = Color.White;
            }

            else if (rf.control.Text == "Completed FIR's")
            {
                ff.submitBtn.Enabled = false;
            }

            else if (rf.control.Text == "Citizen FIR's")
            {
                ff.submitBtn.Text = "SUBMIT FOR APPROVAL";
                ff.submitBtn.Enabled = false;
            }

            ff.ShowDialog();
            ff.Close();
        }

        public void approveFIR(int fid)
        {
            string query = "UPDATE fir SET status = 1 WHERE fid = " + fid;
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.Connection = connectionString.getConnection();
            int rows = sc.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("FIR is Approved!");
            }
        }

        public void deleteFIR(int fid)
        {
            string query = "UPDATE fir SET status = 0 WHERE fid = " + fid;
            SqlCommand sc = new SqlCommand(query, connectionString.getConnection());
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.Connection = connectionString.getConnection();
            int rows = sc.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("FIR is Deleted!");
            }
        }

    }
}
