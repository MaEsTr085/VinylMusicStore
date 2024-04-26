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
        SupplyFromDB supplyFromDB = new SupplyFromDB();
        List<string> albums = new List<string>();
        List<string> labels = new List<string>();

        public SupplyForm()
        {
            InitializeComponent();

            dgvSupply.Columns[0].DataPropertyName = "DateOfSupply";
            dgvSupply.Columns[1].DataPropertyName = "AlbumCount";
            dgvSupply.Columns[2].DataPropertyName = "Label";
            dgvSupply.Columns[3].DataPropertyName = "Album";

            albums = albumsFromDB.GetAlbumsForReceipt();
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            
            cbAlbum.Items.AddRange(albums.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvSupply.Rows.Add(DateTime.Now.ToString(), numCount.Value, cbLabel.Text, cbAlbum.Text);
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
            AddNewAlbumForm addNewAlbumForm = new AddNewAlbumForm();
            addNewAlbumForm.ShowDialog();

            cbAlbum.Items.Clear();
            albums = albumsFromDB.GetAlbumsForReceipt();
            cbAlbum.Items.AddRange(albums.ToArray());
        }

        private void cbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLabel.Items.Clear();

            List<AlbumLabel> albumLabels = albumsFromDB.GetLabelsForAlbum(cbAlbum.Text);
            List<string> items = new List<string>();
            if (albumLabels.Count != 0)
            {
                for (int i = 0; i < albumLabels.Count; i++)
                {
                    items.Add(albumLabels[i].LabelName + ", " + albumLabels[i].Country);
                }
            }

            cbLabel.Items.AddRange(items.ToArray());
        }

        private void cbLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            if (dgvSupply.RowCount != 0)
            {
                for (int i = 0; i < dgvSupply.RowCount; i++)
                {
                    string[] tmp = dgvSupply[2, i].Value.ToString().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    AlbumLabel label = new AlbumLabel(0, tmp[0], tmp[1]);
                    supplyFromDB.AddNewSupply(DateTime.Parse(dgvSupply[0, i].Value.ToString()), int.Parse(dgvSupply[1, i].Value.ToString()), tmp[0], tmp[1], dgvSupply[3, i].Value.ToString());
                }

                dgvSupply.DataSource = null;
                cbAlbum.Items.Clear();
                cbLabel.Items.Clear();
                numCount.Value = 1;
            }
            else
            {
                MessageBox.Show("Не было добавлено ни одной поставки!");
            }
        }
    }
}
