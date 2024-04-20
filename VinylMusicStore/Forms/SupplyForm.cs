using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;
using VinylMusicStore.Model;

namespace VinylMusicStore.Forms
{
    public partial class SupplyForm : Form
    {
        AlbumsFromDB albumsFromDB = new AlbumsFromDB();
        List<string> albums = new List<string>();
        List<string> labels = new List<string>();

        public SupplyForm()
        {
            InitializeComponent();

            dgvSupply.Columns[0].DataPropertyName = "DateOfSupply";
            dgvSupply.Columns[1].DataPropertyName = "AlbumCost";
            dgvSupply.Columns[2].DataPropertyName = "AlbumCount";
            dgvSupply.Columns[3].DataPropertyName = "Label";
            dgvSupply.Columns[4].DataPropertyName = "Album";

            albums = albumsFromDB.GetAlbumsForReceipt();
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            
            cbAlbum.Items.AddRange(albums.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAlbumCost.Text != "") 
                dgvSupply.Rows.Add(DateTime.Now.ToString(), tbAlbumCost.Text, numCount.Value, cbLabel.Text, cbAlbum.Text);
            else
                MessageBox.Show("Стоимость альбома не может быть нулевой");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvSupply.SelectedRows.Count > 0)
            {
                dgvSupply.Rows.RemoveAt(dgvSupply.CurrentRow.Index);
            }
        }

        private void btnAddNewAlbum_Click(object sender, EventArgs e)
        {

        }

        private void cbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLabel.Items.Clear();
            cbLabel.Text = String.Empty;

            labels = albumsFromDB.GetLabelsForAlbum(cbAlbum.Text);
            cbLabel.Items.AddRange(labels.ToArray());
        }

        private void cbLabel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
