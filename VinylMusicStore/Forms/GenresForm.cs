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
    public partial class GenresForm : Form
    {
        InfoFromDB infoFromDB = new InfoFromDB();

        List<Genre> genres = new List<Genre>();

        public GenresForm()
        {
            InitializeComponent();

            dgvGenres.Columns[0].DataPropertyName = "GenreID";
            dgvGenres.Columns[1].DataPropertyName = "GenreName";

            dgvGenres.Columns[0].Visible = false;
        }

        private void GenresForm_Load(object sender, EventArgs e)
        {
            genres = infoFromDB.GetGenres();
            dgvGenres.DataSource = genres;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewInfoElementForm addNewInfoElementForm = new AddNewInfoElementForm("Добавление жанра", "Жанр");
            addNewInfoElementForm.ShowDialog();

            genres = infoFromDB.GetGenres();
            dgvGenres.DataSource = genres;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
