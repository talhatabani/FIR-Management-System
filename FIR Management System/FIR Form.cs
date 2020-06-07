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
    }
}
