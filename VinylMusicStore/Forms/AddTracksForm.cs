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
    public partial class AddTracksForm : Form
    {
        InfoFromDB infoFromDB = new InfoFromDB();
        TracksFromDB tracksFromDB = new TracksFromDB();

        List<string> items = new List<string>();
        List<string> labels = new List<string>();

        public AddTracksForm()
        {
            InitializeComponent();
        }

        public AddTracksForm(string album, string label)
        {
            InitializeComponent();

            tbAlbum.Text = album;
            cbLabel.Text = label;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAlbum_TextChanged(object sender, EventArgs e)
        {
            lbItems.Items.Clear();

            cbLabel.Items.Clear();
            cbLabel.Text = string.Empty;
            labels.Clear();

            if (tbAlbum.Text == "")
            {
                lbItems.Items.Clear();

                lbItems.Items.AddRange(items.ToArray());
            }
            else
            {
                List<string> tmp = new List<string>();
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].StartsWith(tbAlbum.Text))
                    {
                        tmp.Add(items[i]);
                    }
                }
                lbItems.Items.AddRange(tmp.ToArray());
            }

            if (lbItems.Items.Count == 1)
            {
                List<AlbumLabel> tmp = new List<AlbumLabel>();
                tmp = infoFromDB.GetLabelsForAlbum(tbAlbum.Text);
                for (int i = 0; i < tmp.Count; i++)
                {
                    labels.Add(tmp[i].LabelName + ", " + tmp[i].Country);
                }
                cbLabel.Items.AddRange(labels.ToArray());
            }
            
        }

        private void tbAlbum_Enter(object sender, EventArgs e)
        {
            lbItems.Items.Clear();

            items = infoFromDB.GetAlbums();
            lbItems.Items.AddRange(items.ToArray());
        }

        private void lbItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbAlbum.Text = lbItems.SelectedItem.ToString();
        }

        private void btnAddTracks_Click(object sender, EventArgs e)
        {
            if (tbAlbum.Text != "" && cbLabel.Text != "")
            {
                if (dgvTracks.Rows.Count > 1 && dgvTracks.Rows != null)
                {
                    string[] tmp = cbLabel.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < dgvTracks.RowCount - 1; i++)
                    {
                        tracksFromDB.AddTracks(tbAlbum.Text, tmp[0], tmp[1], dgvTracks[0, i].Value.ToString(), int.Parse(dgvTracks[1, i].Value.ToString()));
                    }
                } else
                {
                    MessageBox.Show("Не добавлены треки");
                }
            }
            else
            {
                MessageBox.Show("Не указан альбом и лейбл для добавления треков");
            }
        }
    }
}
