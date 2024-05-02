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
    public partial class AddNewAlbumForm : Form
    {
        AlbumsFromDB albumsFromDB = new AlbumsFromDB();
        TracksFromDB tracksFromDB = new TracksFromDB();
        InfoFromDB infoFromDB = new InfoFromDB();

        List<string> items = new List<string>();

        public enum Control
        {
            Artist,
            Label,
            Genre
        }

        public static Control currentTB = 0;

        string picFileName = "vinyl.png";

        public AddNewAlbumForm()
        {
            InitializeComponent();
        }

        private void UpdateListBox(TextBox tb)
        {
            lbItems.Items.Clear();

            if (tb.Text == "")
            {
                lbItems.Items.Clear();

                lbItems.Items.AddRange(items.ToArray());
            }
            else
            {
                List<string> tmp = new List<string>();
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].StartsWith(tb.Text))
                    {
                        tmp.Add(items[i]);
                    }
                }
                lbItems.Items.AddRange(tmp.ToArray());
            }
        }

        private void AddNewAlbumForm_Load(object sender, EventArgs e)
        {

        }

        private void tbArtist_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox(tbArtist);
        }

        private void tbLabel_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox(tbLabel);
        }

        private void tbGenre_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox(tbGenre);
        }

        private void btnAddAlbumImage_Click(object sender, EventArgs e)
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

                pbAlbumImage.Image = Image.FromFile(distinPath);
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            AddNewInfoElementForm addNewInfoElementForm;
            DialogResult dialogResult;

            switch (currentTB)
            {
                case Control.Artist:
                    addNewInfoElementForm = new AddNewInfoElementForm("Добавление исполнителя", "Исполнитель", "Состав");
                    dialogResult = addNewInfoElementForm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        UpdateListBox(tbArtist);
                    }
                    break;
                case Control.Label:
                    addNewInfoElementForm = new AddNewInfoElementForm("Добавление лейбла", "Лейбл", "Страна");
                    dialogResult = addNewInfoElementForm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        UpdateListBox(tbLabel);
                    }
                    break;
                case Control.Genre:
                    addNewInfoElementForm = new AddNewInfoElementForm("Добавление жанра", "Жанр");
                    dialogResult = addNewInfoElementForm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        UpdateListBox(tbGenre);
                    }
                    break;
            }
        }

        private void btnAddNewAlbum_Click(object sender, EventArgs e)
        {
            if (tbAlbum.Text != "" && tbArtist.Text != "" && tbLabel.Text != "" && tbYearAlbum.Text != "" && tbYearRelease.Text != "" && tbGenre.Text != "")
            {
                if (!(dgvTracks.Rows.Count > 1 && dgvTracks.Rows != null))
                {
                    DialogResult dialogResult =  MessageBox.Show("Список треков не был добавлен. Добавить треки?", "Добавление треков", MessageBoxButtons.OKCancel);

                    if (dialogResult == DialogResult.OK)
                    {
                        tcNewAlbum.SelectedTab = tcNewAlbum.TabPages["tracksTabPage"];
                    } 
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        string picPath = @"..\..\Images\" + picFileName;

                        string[] tmp = tbLabel.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        AlbumLabel label = new AlbumLabel(0, tmp[0], tmp[1]);

                        albumsFromDB.AddNewAlbum(tbAlbum.Text, tbArtist.Text, label, int.Parse(tbYearAlbum.Text), int.Parse(tbYearRelease.Text), tbGenre.Text, picPath);

                        this.Close();
                    }
                    else
                    {
                        string picPath = @"..\..\Images\" + picFileName;

                        string[] tmp = tbLabel.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        AlbumLabel label = new AlbumLabel(0, tmp[0], tmp[1]);

                        albumsFromDB.AddNewAlbum(tbAlbum.Text, tbArtist.Text, label, int.Parse(tbYearAlbum.Text), int.Parse(tbYearRelease.Text), tbGenre.Text, picPath);

                        this.Close();
                    }
                }
                else
                {
                    string picPath = @"..\..\Images\" + picFileName;

                    string[] tmp = tbLabel.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    AlbumLabel label = new AlbumLabel(0, tmp[0], tmp[1]);

                    albumsFromDB.AddNewAlbum(tbAlbum.Text, tbArtist.Text, label, int.Parse(tbYearAlbum.Text), int.Parse(tbYearRelease.Text), tbGenre.Text, picPath);

                    for (int i = 0; i < dgvTracks.RowCount - 1; i++)
                    {
                        tracksFromDB.AddTracks(dgvTracks[0, i].Value.ToString(), int.Parse(dgvTracks[1, i].Value.ToString()));
                    }

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля");
            }
        }

        private void lbItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (currentTB)
            {
                case Control.Artist:
                    tbArtist.Text = lbItems.SelectedItem.ToString();
                    break;
                case Control.Label:
                    tbLabel.Text = lbItems.SelectedItem.ToString();
                    break;
                case Control.Genre:
                    tbGenre.Text = lbItems.SelectedItem.ToString();
                    break;
            }
        }

        private void tbArtist_Enter(object sender, EventArgs e)
        {
            currentTB = Control.Artist;

            lbItems.Items.Clear();

            items = infoFromDB.GetArtistsForAlbum();
            lbItems.Items.AddRange(items.ToArray());
        }

        private void tbLabel_Enter(object sender, EventArgs e)
        {
            currentTB = Control.Label;

            lbItems.Items.Clear();

            items.Clear();

            List<AlbumLabel> albumLabels = infoFromDB.GetLabels();

            if (albumLabels.Count != 0)
            {
                for (int i = 0; i < albumLabels.Count; i++)
                {
                    items.Add(albumLabels[i].LabelName + ", " + albumLabels[i].Country);
                }
            }

            lbItems.Items.AddRange(items.ToArray());
        }

        private void tbGenre_Enter(object sender, EventArgs e)
        {
            currentTB = Control.Genre;

            lbItems.Items.Clear();

            items = infoFromDB.GetGenresForReceipt();
            lbItems.Items.AddRange(items.ToArray());
        }

        private void CheckItem(TextBox tb, string title, string main)
        {
            if (items.Contains(tb.Text) == false)
            {
                DialogResult dialogResult = MessageBox.Show("Такого элемента не существует. Добавить новый?", "Создание нового элемента", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    AddNewInfoElementForm addNewInfoElementForm = new AddNewInfoElementForm(title, main);
                    DialogResult dr = addNewInfoElementForm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        UpdateListBox(tb);
                    }
                }
            }
        }

        //private void CheckItem(TextBox tb, string title, string main, string optional)
        //{
        //    if (items.Contains(tb.Text) == false)
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Такого элемента не существует. Добавить новый?", "Создание нового элемента", MessageBoxButtons.OKCancel);

        //        if (dialogResult == DialogResult.OK)
        //        {
        //            AddNewInfoElementForm addNewInfoElementForm = new AddNewInfoElementForm(title, main, optional);
        //            DialogResult dr = addNewInfoElementForm.ShowDialog();
        //            if (dr == DialogResult.OK)
        //            {
        //                UpdateListBox(tb);
        //            }
        //        }
        //    }
        //}

        private void tbArtist_Leave(object sender, EventArgs e)
        {
            //CheckItem(tbArtist, "Добавление исполнителя", "Исполнитель", "Состав");
        }

        private void tbLabel_Leave(object sender, EventArgs e)
        {
            //CheckItem(tbLabel, "Добавление лейбла", "Лейбл");
        }

        private void tbGenre_Leave(object sender, EventArgs e)
        {
            //CheckItem(tbGenre, "Добавление жанра", "Жанр");
        }

        private void pbAlbumImage_Click(object sender, EventArgs e)
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

                pbAlbumImage.Image = Image.FromFile(distinPath);
            }
        }

        private void btnTracksTab_Click(object sender, EventArgs e)
        {
            tcNewAlbum.SelectedTab = tcNewAlbum.TabPages["tracksTabPage"];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcNewAlbum.SelectedTab = tcNewAlbum.TabPages["albumTabPage"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
