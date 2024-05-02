using MessagingToolkit.QRCode.Codec.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        UsersFromDB usersFromDB = new UsersFromDB();

        public static List<Album> albums = new List<Album>();
        public static Album album;

        private bool isClosed;
        private static string curPost = "";

        public MainForm()
        {
            InitializeComponent();

            dgvAlbums.Columns[0].DataPropertyName = "IdAlbum";
            dgvAlbums.Columns[1].DataPropertyName = "AlbumName";
            dgvAlbums.Columns[2].DataPropertyName = "Artist";
            dgvAlbums.Columns[3].DataPropertyName = "AlbumCount";
            dgvAlbums.Columns[4].DataPropertyName = "Label";
            dgvAlbums.Columns[5].DataPropertyName = "Country";
            dgvAlbums.Columns[6].DataPropertyName = "YearOfAlbum";
            dgvAlbums.Columns[7].DataPropertyName = "YearOfRelease";
            dgvAlbums.Columns[8].DataPropertyName = "Genre";
            dgvAlbums.Columns[9].DataPropertyName = "Image";

            dgvAlbums.Columns[0].Visible = false;
            dgvAlbums.Columns[4].Visible = false;
            dgvAlbums.Columns[5].Visible = false;
            dgvAlbums.Columns[6].Visible = false;
            dgvAlbums.Columns[7].Visible = false;
            dgvAlbums.Columns[8].Visible = false;
            dgvAlbums.Columns[9].Visible = false;

            curPost = usersFromDB.GetPostByLogin(AuthForm.currentUser.Login);

            switch (curPost)
            {
                case "Продавец-консультант":
                    ToolStripMenuItemAlbum.Visible = false;
                    ToolStripMenuItemSupply.Visible = false;
                    ToolStripMenuItemAllUsers.Visible = false;
                    ToolStripMenuItemAddTracks.Visible = false;
                    ToolStripMenuItemViewReceips.Visible = false;
                    break;
                case "Менеджер по продажам":
                    ToolStripMenuItemAlbum.Visible = false;
                    ToolStripMenuItemAllUsers.Visible = false;
                    ToolStripMenuItemAddTracks.Visible = false;
                    ToolStripMenuItemAddSupply.Visible = false;
                    ToolStripMenuItemCreateReceipt.Visible = false;
                    break;
                case "Специалист по обработке поставок":
                    ToolStripMenuItemAlbum.Visible = false;
                    ToolStripMenuItemAllUsers.Visible = false;
                    ToolStripMenuItemReceipt.Visible = false;
                    ToolStripMenuItemAddTracks.Visible = false;
                    break;
                case "Технический специалист":
                    ToolStripMenuItemAllUsers.Visible = false;
                    ToolStripMenuItemReceipt.Visible = false;
                    ToolStripMenuItemSupply.Visible = false;
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAlbums();
            //Bitmap image = new Bitmap(@"..\..\Images\vinyl.png");
            pbAlbum.Image = new Bitmap(albums[0].Image);

            lblCurUser.Text = usersFromDB.GetUserById(AuthForm.currentUser.Employee);

            lblAlbumName.Text = albums[0].AlbumName;
            lblArtist.Text = albums[0].Artist;
            lblPrice.Text = albumsFromDB.GetAlbumPrice(albums[0].AlbumName, albums[0].Label).ToString();
            if (albums[0].AlbumCount > 0)
                lblInstock.Text = albums[0].AlbumCount.ToString();
            else
                lblInstock.Text = "Нет в наличии";
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(isClosed))
                Application.Exit();
        }

        private void dgvAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvAlbums.CurrentRow.Index;

            album = albums[selectedRowIndex];

            pbAlbum.Image = album.Image;

            lblAlbumName.Text = album.AlbumName;
            lblArtist.Text = album.Artist;
            lblPrice.Text = albumsFromDB.GetAlbumPrice(album.AlbumName, album.Label).ToString();
            if (album.AlbumCount > 0)
                lblInstock.Text = album.AlbumCount.ToString();
            else
                lblInstock.Text = "Нет в наличии";
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

        private void dgvAlbums_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    var hti = dgvAlbums.HitTest(e.X, e.Y);
            //    dgvAlbums.ClearSelection();
            //    dgvAlbums.Rows[hti.RowIndex].Selected = true;
            //    MessageBox.Show(dgvAlbums.CurrentRow.Index.ToString());
            //}
        }

        private void ToolStripMenuItemAddSupply_Click(object sender, EventArgs e)
        {
            AddSupplyForm addSupplyForm = new AddSupplyForm();
            addSupplyForm.Show();
        }

        private void ToolStripMenuItemViewSupply_Click(object sender, EventArgs e)
        {
            SupplyForm supplyForm = new SupplyForm();
            supplyForm.Show();
        }

        private void ToolStripMenuItemAllUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void ToolStripMenuItemEditProfile_Click(object sender, EventArgs e)
        {
            EditUserProfileForm editUserProfileForm = new EditUserProfileForm();
            editUserProfileForm.ShowDialog();

            lblCurUser.Text = usersFromDB.GetUserById(AuthForm.currentUser.Employee);
        }

        private void ToolStripMenuItemChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }

        private void ToolStripMenuItemArtists_Click(object sender, EventArgs e)
        {
            ArtistsForm artistsForm = new ArtistsForm();
            artistsForm.Show();
        }

        private void ToolStripMenuItemGenres_Click(object sender, EventArgs e)
        {
            GenresForm genresForm = new GenresForm();
            genresForm.Show();
        }

        private void ToolStripMenuItemLabels_Click(object sender, EventArgs e)
        {
            LabelsForm labelsForm = new LabelsForm();
            labelsForm.Show();
        }

        private void ToolStripMenuItemChangeUser_Click(object sender, EventArgs e)
        {
            AuthForm.currentUser = null;
            Application.OpenForms[0].Show();
            isClosed = true;
            this.Close();
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItemViewReceips_Click(object sender, EventArgs e)
        {
            AllReceiptsForm allReceiptsForm = new AllReceiptsForm();
            allReceiptsForm.Show();
        }

        private void ToolStripMenuItemAddNewAlbum_Click(object sender, EventArgs e)
        {
            AddNewAlbumForm addNewAlbumForm = new AddNewAlbumForm();
            addNewAlbumForm.Show();
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

        private void ToolStripMenuItemAddTracks_Click(object sender, EventArgs e)
        {
            AddTracksForm addTracksForm = new AddTracksForm();
            addTracksForm.Show();
        }

        private void ToolStripMenuItemAllTracks_Click(object sender, EventArgs e)
        {
            TracksForm tracksForm = new TracksForm();
            tracksForm.Show();
        }

        private void dgvAlbums_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int selectedRowIndex = dgvAlbums.CurrentRow.Index;

                album = albums[selectedRowIndex];

                AlbumForm albumForm = new AlbumForm(true);
                albumForm.Show();
            }
        }
    }
}
