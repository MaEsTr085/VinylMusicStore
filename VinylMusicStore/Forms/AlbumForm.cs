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
    public partial class AlbumForm : Form
    {
        TracksFromDB tracksFromDB = new TracksFromDB();
        List<Track> tracks = new List<Track>();

        public AlbumForm()
        {
            InitializeComponent();

            dgvTracks.Columns[0].DataPropertyName = "IdTrack";
            dgvTracks.Columns[1].DataPropertyName = "Album";
            dgvTracks.Columns[2].DataPropertyName = "TrackName";
            dgvTracks.Columns[3].DataPropertyName = "Duration";

            dgvTracks.Columns[0].Visible = false;
            dgvTracks.Columns[1].Visible = false;

            tbArtist.Enabled = false;
            tbLabel.Enabled = false;
            tbYearAlbum.Enabled = false;
            tbYearRelease.Enabled = false;
            tbGenre.Enabled = false;
        }

        private void GetTracks(int id)
        {
            tracks = tracksFromDB.GetParticularTrack(id);
            dgvTracks.DataSource = tracks;
        }

        private void AlbumForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Альбом {MainForm.album.AlbumName}";

            tbArtist.Text = MainForm.album.Artist;
            tbLabel.Text = MainForm.album.Label;
            tbYearAlbum.Text = MainForm.album.YearOfAlbum.ToString();
            tbYearRelease.Text = MainForm.album.YearOfRelease.ToString();
            tbGenre.Text = MainForm.album.Genre;

            GetTracks(MainForm.album.IdAlbum);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
