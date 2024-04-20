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
using VinylMusicStore.Forms;
using VinylMusicStore.Model;

namespace VinylMusicStore
{
    public partial class MainForm : Form
    {
        AlbumsFromDB albumsFromDB = new AlbumsFromDB();
        public static List<Album> albums = new List<Album>();
        public static Album album;

        public MainForm()
        {
            InitializeComponent();

            dgvAlbums.Columns[0].DataPropertyName = "IdAlbum";
            dgvAlbums.Columns[1].DataPropertyName = "AlbumName";
            dgvAlbums.Columns[2].DataPropertyName = "Artist";
            dgvAlbums.Columns[3].DataPropertyName = "AlbumCount";
            dgvAlbums.Columns[4].DataPropertyName = "Label";
            dgvAlbums.Columns[5].DataPropertyName = "YearOfAlbum";
            dgvAlbums.Columns[6].DataPropertyName = "YearOfRelease";
            dgvAlbums.Columns[7].DataPropertyName = "Genre";
            dgvAlbums.Columns[8].DataPropertyName = "Image";

            dgvAlbums.Columns[0].Visible = false;
            dgvAlbums.Columns[4].Visible = false;
            dgvAlbums.Columns[5].Visible = false;
            dgvAlbums.Columns[6].Visible = false;
            dgvAlbums.Columns[7].Visible = false;
            dgvAlbums.Columns[8].Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAlbums();
            Bitmap image = new Bitmap(@"..\..\Images\vinyl.png");
            pbAlbum.Image = image;
        }

        private void GetAlbums()
        {
            albums = albumsFromDB.GetAlbums();
            dgvAlbums.DataSource = albums;
        }

        private void dgvAlbums_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvAlbums.CurrentRow.Index;

            album = albums[selectedRowIndex];

            AlbumForm albumForm = new AlbumForm();
            albumForm.Show();
        }

        private void ToolStripMenuItemTracks_Click(object sender, EventArgs e)
        {
            TracksForm tracksForm = new TracksForm();
            tracksForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvAlbums.CurrentRow.Index;

            album = albums[selectedRowIndex];

            pbAlbum.Image = album.Image;
        }

        private void ToolStripMenuItemCreateReceipt_Click(object sender, EventArgs e)
        {
            CreateReceiptForm createReceiptForm = new CreateReceiptForm();
            createReceiptForm.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            GetAlbums();
        }

        private void ToolStripMenuItemSupply_Click(object sender, EventArgs e)
        {
            SupplyForm supplyForm = new SupplyForm();
            supplyForm.Show();
        }
    }
}
