using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;
using VinylMusicStore.Model;

namespace VinylMusicStore.Forms
{
    public partial class AllReceiptsForm : Form
    {
        ReceiptsFromDB receiptsFromDB = new ReceiptsFromDB();

        List<Receipt> receipts = new List<Receipt>();

        public AllReceiptsForm()
        {
            InitializeComponent();

            dgvReceipt.Columns[0].DataPropertyName = "ReceiptID";
            dgvReceipt.Columns[1].DataPropertyName = "DateOfCreation";
            dgvReceipt.Columns[2].DataPropertyName = "Sum";
            dgvReceipt.Columns[3].DataPropertyName = "Employee";
            dgvReceipt.Columns[4].DataPropertyName = "FN";
            dgvReceipt.Columns[5].DataPropertyName = "FD";
            dgvReceipt.Columns[6].DataPropertyName = "FPD";

            dgvReceipt.Columns[0].Visible = false;
        }

        private void AllReceiptsForm_Load(object sender, EventArgs e)
        {
            receipts = receiptsFromDB.GetReceipts();
            dgvReceipt.DataSource = receipts;
        }

        private void AllReceiptsForm_Activated(object sender, EventArgs e)
        {
            receipts = receiptsFromDB.GetReceipts();
            dgvReceipt.DataSource = receipts;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
