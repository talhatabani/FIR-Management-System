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
        public int role = users.getRole();

        public int update = 0;
        public FIR_Form()
        {
            InitializeComponent();
        }

        private void FIR_Form_Load(object sender, EventArgs e)
        {
            roleLab.Text = role.ToString();
            //if(update == 0)
            //{
            //    submitBtn.Text = "Submit";
            //}

            //else
            //{
            //    submitBtn.Text = "Update";
            //}
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            firCRUD fir = new firCRUD();

            fir.saveFIR(
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
    }
}
