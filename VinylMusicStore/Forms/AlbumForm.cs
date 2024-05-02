using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;
using VinylMusicStore.Model;

namespace VinylMusicStore.Forms
{
    public partial class AlbumForm : Form
    {
        AlbumsFromDB albumsFromDB = new AlbumsFromDB();
        TracksFromDB tracksFromDB = new TracksFromDB();
        List<Track> tracks = new List<Track>();

        private bool isEdit = false;

        string picFileName = "vinyl.png";

        public AlbumForm()
        {
            InitializeComponent();

            dgvTracks.Columns[0].DataPropertyName = "IdTrack";
            dgvTracks.Columns[1].DataPropertyName = "Album";
            dgvTracks.Columns[2].DataPropertyName = "TrackName";
            dgvTracks.Columns[3].DataPropertyName = "Duration";

            dgvTracks.Columns[0].Visible = false;
            dgvTracks.Columns[1].Visible = false;

            tbArtist.ReadOnly = true;
            tbLabel.ReadOnly = true;
            tbCountry.ReadOnly = true;
            tbYearAlbum.ReadOnly = true;
            tbYearRelease.ReadOnly = true;
            tbGenre.ReadOnly = true;

            pnImage.Visible = false;
            btnChangeImage.Visible = false;
            btnSave.Visible = false;

            this.Width = 686;
            this.Height = 486;

            this.MinimumSize = new System.Drawing.Size(686, 486);

            //686; 486
        }

        public AlbumForm(bool isEdit = false)
        {
            InitializeComponent();

            this.isEdit = isEdit;

            dgvTracks.Columns[0].DataPropertyName = "IdTrack";
            dgvTracks.Columns[1].DataPropertyName = "Album";
            dgvTracks.Columns[2].DataPropertyName = "TrackName";
            dgvTracks.Columns[3].DataPropertyName = "Duration";

            dgvTracks.Columns[0].Visible = false;
            dgvTracks.Columns[1].Visible = false;

            if (this.isEdit)
            {
                tbArtist.ReadOnly = false;
                tbLabel.ReadOnly = false;
                tbCountry.ReadOnly = false;
                tbYearAlbum.ReadOnly = false;
                tbYearRelease.ReadOnly = false;
                tbGenre.ReadOnly = false;

                this.Width = 942;
                this.Height = 486;

                this.MinimumSize = new System.Drawing.Size(942, 486);

                //942; 486
            }
        }

        private void GetTracks(int id)
        {
            tracks = tracksFromDB.GetParticularTrack(id);
            dgvTracks.DataSource = tracks;
        }

        private void AlbumForm_Load(object sender, EventArgs e)
        {
            if (!isEdit)
                this.Text = $"Альбом {MainForm.album.AlbumName}";
            else
                this.Text = $"Редактирование альбома {MainForm.album.AlbumName}";

            lblAlbum.Text = MainForm.album.AlbumName;

            tbArtist.Text = MainForm.album.Artist;
            tbLabel.Text = MainForm.album.Label;
            tbCountry.Text = MainForm.album.Country;
            tbYearAlbum.Text = MainForm.album.YearOfAlbum.ToString();
            tbYearRelease.Text = MainForm.album.YearOfRelease.ToString();
            tbGenre.Text = MainForm.album.Genre;

            GetTracks(MainForm.album.IdAlbum);

            if (isEdit)
            {
                pbAlbum.Image = MainForm.album.Image;
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

        private void btnAddTracks_Click(object sender, EventArgs e)
        {
            AddTracksForm addTracksForm = new AddTracksForm(lblAlbum.Text, tbLabel.Text + ", " + tbCountry.Text);
            addTracksForm.Show();
        }

        private void AlbumForm_Activated(object sender, EventArgs e)
        {
            GetTracks(MainForm.album.IdAlbum);
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                picFileName = Path.GetFileName(openFileDialog.FileName);

                string distinPath = @"..\..\Images\" + picFileName;

                if (!(File.Exists(distinPath)))
                {
                    fileInfo.CopyTo(distinPath);
                }

                pbAlbum.Image = Image.FromFile(distinPath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string picPath = @"..\..\Images\" + picFileName;

            albumsFromDB.UpdateAlbumImage(lblAlbum.Text, tbLabel.Text, tbCountry.Text, picPath);
        }
    }
}
