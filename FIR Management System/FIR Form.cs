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

namespace FIR_Management_System
{
    public partial class FIR_Form : Form
    {
        public int status = 10;
        public int fid;
        public int role = users.getRole();
        public string citEmail = users.getEmail();

        firSindh fc = new firSindh();

        public int update = 0;
        public FIR_Form()
        {
            InitializeComponent();
        }

        public FIR_Form(string form)
        {
            InitializeComponent();
            this.controlText.Text = form;
        }

        private void FIR_Form_Load(object sender, EventArgs e)
        {

            roleLab.Text = role.ToString();

            if((role == 1 && controlText.Text.Equals("aaa")) || (role == 0 && controlText.Text.Equals("aaa")))
            {
                firFormTxtEnabled(true);
                deleteBtn.Visible = false;
            }

            else if ((role == 1 && controlText.Text.Equals("Running FIR's")) || (role == 0 && controlText.Text.Equals("Citizen FIR's")))
            {
                firFormTxtEnabled(false);
                deleteBtn.Visible = false;
            }
            
            else if(status == 1)
            {
                completeBtn.Visible = true;
            }

            else if (status == 2)
            {
                deleteBtn.Visible = true;
            }

            else if (status == 3)
            {
                deleteBtn.Visible = true;
            }

            //////////

            if(citEmail != null)
            {
                if (citEmail.Equals(email.Text) && role == 0)
                {
                    email.Enabled = false;
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            if (submitBtn.Text.Equals("UPDATE"))
            {
                fc.updateFIR(
                    fid,
                    name.Text,
                    fname.Text,
                    cnic.Text,
                    email.Text,
                    Convert.ToInt64(cellno.Text),
                    address.Text,
                    town.Text,
                    date.Value.Date,
                    time.Value,
                    location.Text,
                    incidentDet.Text,
                    lostItems.Text,
                    weapon.Text,
                    suspect.Text,
                    suspectName.Text,
                    suspectRelation.Text,
                    suspectAddress.Text,
                    witness.Text,
                    witnessName.Text,
                    witnessRelation.Text,
                    witnessAddress.Text
                );

                dashboardPolice ds = new dashboardPolice();
                this.Hide();
                ds.ShowDialog();
                this.Close();
            }

            else if(submitBtn.Text.Equals("SUBMIT"))
            {
                fc.saveFIR(
                    name.Text,
                    fname.Text,
                    cnic.Text,
                    email.Text,
                    Convert.ToInt64(cellno.Text),
                    address.Text,
                    town.Text,
                    date.Value.Date,
                    time.Value,
                    location.Text,
                    incidentDet.Text,
                    lostItems.Text,
                    weapon.Text,
                    suspect.Text,
                    suspectName.Text,
                    suspectRelation.Text,
                    suspectAddress.Text,
                    witness.Text,
                    witnessName.Text,
                    witnessRelation.Text,
                    witnessAddress.Text
               );

                dashboardPolice ds = new dashboardPolice();
                this.Hide();
                ds.ShowDialog();
                this.Close();
            }

            else if (submitBtn.Text.Equals("SUBMIT FOR APPROVAL"))
            {
                fc.saveFIR(
                    name.Text,
                    fname.Text,
                    cnic.Text,
                    email.Text,
                    Convert.ToInt64(cellno.Text),
                    address.Text,
                    town.Text,
                    date.Value.Date,
                    time.Value,
                    location.Text,
                    incidentDet.Text,
                    lostItems.Text,
                    weapon.Text,
                    suspect.Text,
                    suspectName.Text,
                    suspectRelation.Text,
                    suspectAddress.Text,
                    witness.Text,
                    witnessName.Text,
                    witnessRelation.Text,
                    witnessAddress.Text
               );

                dashboard ds = new dashboard();
                this.Hide();
                ds.ShowDialog();
                this.Close();
            }

            else if (submitBtn.Text.Equals("APPROVE"))
            {
                fc.approveFIR(fid);
                dashboardPolice ds = new dashboardPolice();
                this.Hide();
                ds.ShowDialog();
                this.Close();
            }

            else if (submitBtn.Text.Equals("DELETE"))
            {
                fc.deleteFIR(fid);
                dashboardPolice ds = new dashboardPolice();
                this.Hide();
                ds.ShowDialog();
                this.Close();
            }

            else if (submitBtn.Text.Equals("RE INVESTIGATE"))
            {
                fc.reInvestigateFIR(fid);
                dashboardPolice ds = new dashboardPolice();
                this.Hide();
                ds.ShowDialog();
                this.Close();
            }
        }

        private void suspect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(suspect.SelectedIndex == 1)
            {
                suspectName.Enabled = false;
                suspectRelation.Enabled = false;
                suspectAddress.Enabled = false;
            }

            else
            {
                suspectName.Enabled = true;
                suspectRelation.Enabled = true;
                suspectAddress.Enabled = true;
            }
        }

        private void witness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (witness.SelectedIndex == 1)
            {
                witnessName.Enabled = false;
                witnessRelation.Enabled = false;
                witnessAddress.Enabled = false;
            }

            else
            {
                witnessName.Enabled = true;
                witnessRelation.Enabled = true;
                witnessAddress.Enabled = true;
            }
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            fc.completeFIR(fid);
            dashboardPolice dp = new dashboardPolice();
            this.Hide();
            dp.ShowDialog();
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            fc.deleteFIR(fid);
            dashboardPolice dp = new dashboardPolice();
            this.Hide();
            dp.ShowDialog();
            this.Close();
        }


        public void firFormTxtEnabled(bool status)
        {
            name.Enabled = status;
            fname.Enabled = status;
            cnic.Enabled = status;
            email.Enabled = status;
            cellno.Enabled = status;
            address.Enabled = status;
            town.Enabled = status;
            date.Enabled = status;
            time.Enabled = status;
            location.Enabled = status;
            incidentDet.Enabled = status;
            lostItems.Enabled = status;
            weapon.Enabled = status;
            suspect.Enabled = status;
            suspectName.Enabled = status;
            suspectRelation.Enabled = status;
            suspectAddress.Enabled = status;
            witness.Enabled = status;
            witnessName.Enabled = status;
            witnessRelation.Enabled = status;
            witnessAddress.Enabled = status;
            submitBtn.Enabled = status;
        }
        public void firFormTxtColorBlack()
        {
            name.ForeColor = Color.Black;
            fname.ForeColor = Color.Black;
            cnic.ForeColor = Color.Black;
            email.ForeColor = Color.Black;
            cellno.ForeColor = Color.Black;
            address.ForeColor = Color.Black;
            town.ForeColor = Color.Black;
            date.ForeColor = Color.Black;
            time.ForeColor = Color.Black;
            location.ForeColor = Color.Black;
            incidentDet.ForeColor = Color.Black;
            lostItems.ForeColor = Color.Black;
            weapon.ForeColor = Color.Black;
            suspect.ForeColor = Color.Black;
            suspectName.ForeColor = Color.Black;
            suspectRelation.ForeColor = Color.Black;
            suspectAddress.ForeColor = Color.Black;
            witness.ForeColor = Color.Black;
            witnessName.ForeColor = Color.Black;
            witnessRelation.ForeColor = Color.Black;
            witnessAddress.ForeColor = Color.Black;
            submitBtn.ForeColor = Color.Black;
        }

        private void name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text))
            {
                e.Cancel = true;
                name.Focus();
                errorProvider.SetError(name, "Name should not be left blank!");
            }

            else
            {
                e.Cancel = false;
                errorProvider.SetError(name, "");
            }
        }

        private void fname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                e.Cancel = true;
                fname.Focus();
                errorProvider.SetError(fname, "Father / Husband Name should not be left blank!");
            }

            else
            {
                e.Cancel = false;
                errorProvider.SetError(fname, "");
            }
        }

        private void cnic_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cnic.Text))
            {
                e.Cancel = true;
                cnic.Focus();
                errorProvider.SetError(cnic, "Cnic should not be left blank!");
            }

            else
            {
                e.Cancel = false;
                errorProvider.SetError(cnic, "");
            }
        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email.Text))
            {
                e.Cancel = true;
                email.Focus();
                errorProvider.SetError(email, "Email should not be left blank!");
            }

            else
            {
                e.Cancel = false;
                errorProvider.SetError(email, "");
            }
        }

        private void cellno_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cellno.Text))
            {
                e.Cancel = true;
                cellno.Focus();
                errorProvider.SetError(cellno, "Cell No# should not be left blank!");
            }

            else
            {
                e.Cancel = false;
                errorProvider.SetError(cellno, "");
            }
        }

        private void address_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(address.Text))
            {
                e.Cancel = true;
                address.Focus();
                errorProvider.SetError(address, "Address should not be left blank!");
            }

            else
            {
                e.Cancel = false;
                errorProvider.SetError(address, "");
            }
        }

        private void location_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(location.Text))
            {
                e.Cancel = true;
                location.Focus();
                errorProvider.SetError(location, "Name should not be left blank!");
            }

            else
            {
                e.Cancel = false;
                errorProvider.SetError(location, "");
            }
        }

        private void incidentDet_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(incidentDet.Text))
            {
                e.Cancel = true;
                incidentDet.Focus();
                errorProvider.SetError(incidentDet, "Incident Detail should not be left blank!");
            }

            else
            {
                e.Cancel = false;
                errorProvider.SetError(incidentDet, "");
            }
        }

        private void FIR_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (controlText.Text.Equals("Citizen FIR's"))
            {
                dashboard dp = new dashboard();
                this.Hide();
                dp.ShowDialog();
                this.Close();
            }

            else if(controlText.Text.Equals("Running FIR's"))
            {
                dashboardPolice dp = new dashboardPolice();
                this.Hide();
                dp.ShowDialog();
                this.Close();
            }

            else if (controlText.Text.Equals("Pending FIR's"))
            {
                dashboardPolice dp = new dashboardPolice();
                this.Hide();
                dp.ShowDialog();
                this.Close();
            }

            else if (controlText.Text.Equals("Completed FIR's"))
            {
                dashboardPolice dp = new dashboardPolice();
                this.Hide();
                dp.ShowDialog();
                this.Close();
            }

            else if (controlText.Text.Equals("Deleted FIR's"))
            {
                dashboardPolice dp = new dashboardPolice();
                this.Hide();
                dp.ShowDialog();
                this.Close();
            }

            else
            {
                dashboard dp = new dashboard();
                this.Hide();
                dp.ShowDialog();
                this.Close();
            }
        }
    }
}
