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
    public partial class TracksForm : Form
    {
        TracksFromDB tracksFromDB = new TracksFromDB();
        List<Track> tracks = new List<Track>();

        public TracksForm()
        {
            InitializeComponent();

            dgvTracks.Columns[0].DataPropertyName = "IdTrack";
            dgvTracks.Columns[1].DataPropertyName = "Album";
            dgvTracks.Columns[2].DataPropertyName = "TrackName";
            dgvTracks.Columns[3].DataPropertyName = "Duration";

            dgvTracks.Columns[0].Visible = false;
        }

        private void GetTracks()
        {
            tracks = tracksFromDB.GetTracks();
            dgvTracks.DataSource = tracks;
        }

        private void TracksForm_Load(object sender, EventArgs e)
        {
            GetTracks();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
