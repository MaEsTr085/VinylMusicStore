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
    public partial class SupplyForm : Form
    {
        SupplyFromDB supplyFromDB = new SupplyFromDB();

        List<Supply> supplies = new List<Supply>();

        public SupplyForm()
        {
            InitializeComponent();

            dgvSupply.Columns[0].DataPropertyName = "SupplyID";
            dgvSupply.Columns[1].DataPropertyName = "DateOfSupply";
            dgvSupply.Columns[2].DataPropertyName = "Album";
            dgvSupply.Columns[3].DataPropertyName = "Label";
            dgvSupply.Columns[4].DataPropertyName = "AlbumCount";

            dgvSupply.Columns[0].Visible = false;
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            supplies = supplyFromDB.GetSupplies();
            dgvSupply.DataSource = supplies;
        }

        private void SupplyForm_Activated(object sender, EventArgs e)
        {
            supplies = supplyFromDB.GetSupplies();
            dgvSupply.DataSource = supplies;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewSupply_Click(object sender, EventArgs e)
        {
            AddSupplyForm addSupplyForm = new AddSupplyForm();
            addSupplyForm.Show();
            this.Close();
        }
    }
}
