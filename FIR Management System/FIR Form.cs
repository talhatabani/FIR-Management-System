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

        firCRUD fc = new firCRUD();

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
            suspect.SelectedIndex = 1;
            witness.SelectedIndex = 1;
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

            else if (citEmail.Equals(email.Text) && role == 0)
            {
                email.Enabled = false;
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

                RunningFIR rnf = new RunningFIR("Running FIR's");
                this.Hide();
                rnf.ShowDialog();
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

                RunningFIR rnf = new RunningFIR(controlText.Text);
                this.Hide();
                rnf.ShowDialog();
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

                RunningFIR rnf = new RunningFIR("Citizen FIR's");
                this.Hide();
                rnf.ShowDialog();
                this.Close();
            }

            else if (submitBtn.Text.Equals("APPROVE"))
            {
                fc.approveFIR(fid);
                RunningFIR rnf = new RunningFIR(controlText.Text);
                this.Close();
            }

            else if (submitBtn.Text.Equals("DELETE"))
            {
                fc.deleteFIR(fid);
                RunningFIR rnf = new RunningFIR(controlText.Text);
                this.Close();
            }

            else if (submitBtn.Text.Equals("RE INVESTIGATE"))
            {
                fc.reInvestigateFIR(fid);
                RunningFIR rnf = new RunningFIR(controlText.Text);
                this.Close();
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if(name.Text == "Someone"){
                name.Text = "";

                name.ForeColor = Color.Black; 
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Someone";

                name.ForeColor = Color.DarkGray;
            }
        }

        private void fname_Enter(object sender, EventArgs e)
        {
            if (fname.Text == "Someone")
            {
                fname.Text = "";

                fname.ForeColor = Color.Black;
            }
        }

        private void fname_Leave(object sender, EventArgs e)
        {
            if (fname.Text == "")
            {
                fname.Text = "Someone";

                fname.ForeColor = Color.DarkGray;
            }
        }

        private void cnic_Enter(object sender, EventArgs e)
        {
            if (cnic.Text == "00000-0000000-0")
            {
                cnic.Text = "";

                cnic.ForeColor = Color.Black;
            }
        }

        private void cnic_Leave(object sender, EventArgs e)
        {
            if (cnic.Text == "")
            {
                cnic.Text = "00000-0000000-0";

                cnic.ForeColor = Color.DarkGray;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "someone@example.com")
            {
                email.Text = "";

                email.ForeColor = Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "someone@example.com";

                email.ForeColor = Color.DarkGray;
            }
        }

        private void cellno_Enter(object sender, EventArgs e)
        {
            if (cellno.Text == "0300-1234567")
            {
                cellno.Text = "";

                cellno.ForeColor = Color.Black;
            }
        }

        private void cellno_Leave(object sender, EventArgs e)
        {
            if (cellno.Text == "")
            {
                cellno.Text = "0300-1234567";

                cellno.ForeColor = Color.DarkGray;
            }
        }

        private void address_Enter(object sender, EventArgs e)
        {
            if (address.Text == "A - 00  block 15 / C , 5th Avenue, F-15 , Islamabad.")
            {
                address.Text = "";

                address.ForeColor = Color.Black;
            }
        }

        private void address_Leave(object sender, EventArgs e)
        {
            if (address.Text == "")
            {
                address.Text = "A - 00  block 15 / C , 5th Avenue, F-15 , Islamabad.";

                address.ForeColor = Color.DarkGray;
            }
        }

        private void lostItems_Enter(object sender, EventArgs e)
        {
            if (lostItems.Text == "Mobile phone along with 20k cash and a hand bag  of pink color branded of gucci.")
            {
                lostItems.Text = "";

                lostItems.ForeColor = Color.Black;
            }
        }

        private void lostItems_Leave(object sender, EventArgs e)
        {
            if (lostItems.Text == "") 
            {
                lostItems.Text = "Mobile phone along with 20k cash and a hand bag  of pink color branded of gucci."; 

                lostItems.ForeColor = Color.DarkGray;
            }
        }

        private void suspectName_Enter(object sender, EventArgs e)
        {
            if (suspectName.Text == "Someone")
            {
                suspectName.Text = "";

                suspectName.ForeColor = Color.Black;
            }
        }

        private void suspectName_Leave(object sender, EventArgs e)
        {
            if (suspectName.Text == "")
            {
                suspectName.Text = "Someone";

                suspectName.ForeColor = Color.DarkGray;
            }
        }

        private void suspectRelation_Enter(object sender, EventArgs e)
        {
            if (suspectRelation.Text == "Neighbour's Son")
            {
                suspectRelation.Text = "";

                suspectRelation.ForeColor = Color.Black;
            }
        }

        private void suspectRelation_Leave(object sender, EventArgs e)
        {
            if (suspectRelation.Text == "")
            {
                suspectRelation.Text = "Neighbour's Son";

                suspectRelation.ForeColor = Color.DarkGray;
            }
        }

        private void suspectAddress_Enter(object sender, EventArgs e)
        {
            if(address.Text == "A - 00  block 15 / C , 5th Avenue, F-15 , Islamabad.")
            {
                address.Text = "";

                address.ForeColor = Color.Black;
            }
        }

        private void suspectAddress_Leave(object sender, EventArgs e)
        {
            if (address.Text == "")
            {
                address.Text = "A - 00  block 15 / C , 5th Avenue, F-15 , Islamabad.";

                address.ForeColor = Color.DarkGray;
            }
        }

        private void witnessName_Enter(object sender, EventArgs e)
        {
            if (witnessName.Text == "Someone")
            {
                witnessName.Text = "";

                witnessName.ForeColor = Color.Black;
            }
        }

        private void witnessName_Leave(object sender, EventArgs e)
        {
            if (witnessName.Text == "")
            {
                witnessName.Text = "Someone";

                witnessName.ForeColor = Color.DarkGray;
            }
        }

        private void witnessRelation_Enter(object sender, EventArgs e)
        {
            if (witnessRelation.Text == "Shop Keeper")
            {
                witnessRelation.Text = "";

                witnessRelation.ForeColor = Color.Black;
            }
        }

        private void witnessRelation_Leave(object sender, EventArgs e)
        {
            if (witnessRelation.Text == "")
            {
                witnessRelation.Text = "Shop Keeper";

                witnessRelation.ForeColor = Color.DarkGray;
            }
        }

        private void witnessAddress_Enter(object sender, EventArgs e)
        {
            if (witnessAddress.Text.Equals("A - 00  block 15 / C , 5th Avenue, F-15 , Islamabad."))
            {
                witnessAddress.Text = "";

                witnessAddress.ForeColor = Color.Black;
            }
        }

        private void witnessAddress_Leave(object sender, EventArgs e)
        {
            if (witnessAddress.Text == "")
            {
                witnessAddress.Text = "A - 00  block 15 / C , 5th Avenue, F-15 , Islamabad.";

                witnessAddress.ForeColor = Color.DarkGray;
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

        private void completeBtn_Click(object sender, EventArgs e)
        {
            fc.completeFIR(fid);
            RunningFIR rf = new RunningFIR("Running FIR's");
            this.Hide();
            rf.ShowDialog();
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            fc.deleteFIR(fid);
            RunningFIR rf = new RunningFIR("Pending FIR's");
            this.Hide();
            rf.ShowDialog();
            this.Close();
        }
    }
}
