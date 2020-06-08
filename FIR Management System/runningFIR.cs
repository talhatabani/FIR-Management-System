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
    public partial class RunningFIR : Form
    {
        private int firID;
        private int role = users.getRole();
        public RunningFIR()
        {
            InitializeComponent();
        }

        private void runningFIR_Load(object sender, EventArgs e)
        {
            firCRUD fir = new firCRUD();
            fir.rnFIR = this;
            fir.showRunningFir();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                FIR_Form ff = new FIR_Form();
                int index = (int) dgv.Rows[e.RowIndex].Cells[0].Value;
                this.firID = index;
                firCRUD fir = new firCRUD();
                fir.fillFirForm(firID);
            }
        }

        private void generateFIRBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
