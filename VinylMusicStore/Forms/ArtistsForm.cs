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
    public partial class ArtistsForm : Form
    {
        InfoFromDB infoFromDB = new InfoFromDB();

        List<Artist> artists = new List<Artist>();

        public ArtistsForm()
        {
            InitializeComponent();

            dgvArtists.Columns[0].DataPropertyName = "ArtistID";
            dgvArtists.Columns[1].DataPropertyName = "ArtistName";
            dgvArtists.Columns[2].DataPropertyName = "Composition";

            dgvArtists.Columns[0].Visible = false;
        }

        private void ArtistsForm_Load(object sender, EventArgs e)
        {
            artists = infoFromDB.GetArtists();
            dgvArtists.DataSource = artists;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewInfoElementForm addNewInfoElementForm = new AddNewInfoElementForm("Добавление исполнителя", "Исполнитель", "Состав");
            addNewInfoElementForm.ShowDialog();

            artists = infoFromDB.GetArtists();
            dgvArtists.DataSource = artists;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
