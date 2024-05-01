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
    public partial class CreateReceiptForm : Form
    {
        AlbumsFromDB albumsFromDB = new AlbumsFromDB();
        InfoFromDB infoFromDB = new InfoFromDB();

        List<string> albums = new List<string>();
        List<string> labels = new List<string>();

        double price = 0;
        double fullSum = 0;
        int maxCount = 1;

        public CreateReceiptForm()
        {
            InitializeComponent();

            dgvReceipt.Columns[0].DataPropertyName = "Album";
            dgvReceipt.Columns[1].DataPropertyName = "Count";
            dgvReceipt.Columns[2].DataPropertyName = "Price";

            albums = albumsFromDB.GetAlbumsForReceipt();

            lblAlbumPrice.Visible = false;
            lblSum.Visible = false;
            lblFullSum.Visible = false;
        }

        private void CreateReceiptForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < albums.Count; i++)
            {
                labels = infoFromDB.GetLabelsForAlbumNoZero(albums[i]);
                if (labels.Count == 0)
                    albums.Remove(albums[i]);
            }
            cbAlbum.Items.AddRange(albums.ToArray());
            
        }

        private void cbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLabel.Items.Clear();
            cbLabel.Text = String.Empty;

            labels = infoFromDB.GetLabelsForAlbumNoZero(cbAlbum.Text);
            cbLabel.Items.AddRange(labels.ToArray());
        }

        private void cbLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAlbumPrice.Visible = true;
            lblAlbumPrice.Text = "";

            lblSum.Visible = true;
            lblSum.Text = "";

            numCount.Value = 1;

            for (int i = 0; i < MainForm.albums.Count; i++)
            {
                if (MainForm.albums[i].AlbumName == cbAlbum.Text && MainForm.albums[i].Label == cbLabel.Text)
                    maxCount = MainForm.albums[i].AlbumCount;
            }

            if (cbAlbum.Text != "" && cbLabel.Text != "")
            {
                price = albumsFromDB.GetAlbumPrice(cbAlbum.Text, cbLabel.Text);
                lblAlbumPrice.Text = price.ToString();

                lblSum.Text = Convert.ToString(price * (int)numCount.Value);
            }
        }

        private void numCount_ValueChanged(object sender, EventArgs e)
        {
            if (numCount.Value > maxCount)
            {
                MessageBox.Show("Выбранное количество не может превышать количества на складе!");
                numCount.Value = maxCount;
            }
            else
            {
                lblSum.Text = "";

                lblSum.Text = Convert.ToString(price * (int)numCount.Value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvReceipt.Rows.Add(cbAlbum.Text, cbLabel.Text, numCount.Value.ToString(), lblSum.Text);

            fullSum = 0;

            for (int i = 0; i < dgvReceipt.Rows.Count; i++)
            {
                if (dgvReceipt[3, i].Value != null)
                {
                    fullSum += double.Parse(dgvReceipt[3, i].Value.ToString());
                }
            }

            lblFullSum.Visible = true;

            lblFullSum.Text = fullSum.ToString();
        }

        private void btnCreateReceipt_Click(object sender, EventArgs e)
        {
            if (dgvReceipt.Rows.Count == 0)
            {
                MessageBox.Show("Нулевой состав чека!");
            }
            else
            {
                int[,] values = new int[dgvReceipt.RowCount, 2];
                for (int i = 0; i < dgvReceipt.RowCount; i++)
                {
                    int id = 0;
                    for (int j = 0; j < MainForm.albums.Count; j++)
                    {
                        if (MainForm.albums[j].AlbumName == cbAlbum.Text && MainForm.albums[j].Label == cbLabel.Text)
                            id = MainForm.albums[j].IdAlbum;
                    }
                    values[i, 0] = id;
                    values[i, 1] = int.Parse(dgvReceipt[2, i].Value.ToString());
                }
                    
                    
                ReceiptForm receiptForm = new ReceiptForm(lblFullSum.Text, values, dgvReceipt.RowCount);
                receiptForm.ShowDialog();
                this.Close();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvReceipt.SelectedRows.Count > 0)
            {
                dgvReceipt.Rows.RemoveAt(dgvReceipt.CurrentRow.Index);

                fullSum = 0;

                for (int i = 0; i < dgvReceipt.Rows.Count; i++)
                {
                    if (dgvReceipt[3, i].Value != null)
                    {
                        fullSum += double.Parse(dgvReceipt[3, i].Value.ToString());
                    }
                }

                lblFullSum.Text = fullSum.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CP = base.CreateParams;
                CP.ExStyle = CP.ExStyle | 0x2000000; // WS_EX_COMPOSITED
                return CP;
            }
        }
    }
}
