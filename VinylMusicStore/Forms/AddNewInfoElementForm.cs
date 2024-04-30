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
    public partial class AddNewInfoElementForm : Form
    {
        InfoFromDB infoFromDB = new InfoFromDB();

        public AddNewInfoElementForm(string title, string main)
        {
            InitializeComponent();

            lblTitle.Text = title;
            lblMain.Text = main;

            lblOptional.Visible = false;
            tbOptional.Visible = false;
        }

        public AddNewInfoElementForm(string title, string main, string optional)
        {
            InitializeComponent();

            lblTitle.Text = title;
            lblMain.Text = main;
            lblOptional.Text = optional;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (lblMain.Text)
            {
                case "Исполнитель":
                    Artist artist = new Artist(0, tbMain.Text, tbOptional.Text);
                    infoFromDB.AddArtist(artist);
                    break;
                case "Лейбл":
                    AlbumLabel label = new AlbumLabel(0, tbMain.Text, tbOptional.Text);
                    infoFromDB.AddLabel(label);
                    break;
                case "Жанр":
                    Genre genre = new Genre(0, tbMain.Text);
                    infoFromDB.AddGenre(genre);
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
