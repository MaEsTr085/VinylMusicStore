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
        UsersFromDB usersFromDB = new UsersFromDB();

        public static List<Album> albums = new List<Album>();
        public static Album album;

        private bool isClosed;
        private string curPost = "";

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

            lblAlbumName.Visible = false;
            lblArtist.Visible = false;
            lblPrice.Visible = false;

            curPost = usersFromDB.GetPostByLogin(AuthForm.currentUser.Login);

            switch (curPost)
            {
                case "Продавец-консультант":
                    ToolStripMenuItemAlbum.Visible = false;
                    ToolStripMenuItemSupply.Visible = false;
                    ToolStripMenuItemAllUsers.Visible = false;
                    break;
                case "Менеджер по продажам":
                    ToolStripMenuItemTracks.Visible = false;
                    ToolStripMenuItemAlbum.Visible = false;
                    ToolStripMenuItemAllUsers.Visible = false;
                    ToolStripMenuItemArtists.Visible = false;
                    ToolStripMenuItemGenres.Visible = false;
                    ToolStripMenuItemLabels.Visible = false;
                    break;
                case "Специалист по обработке поставок":
                    ToolStripMenuItemTracks.Visible = false;
                    ToolStripMenuItemAlbum.Visible = false;
                    ToolStripMenuItemAllUsers.Visible = false;
                    ToolStripMenuItemArtists.Visible = false;
                    ToolStripMenuItemGenres.Visible = false;
                    ToolStripMenuItemLabels.Visible = false;
                    ToolStripMenuItemReceipt.Visible = false;
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
            Bitmap image = new Bitmap(@"..\..\Images\vinyl.png");
            pbAlbum.Image = image;

            lblCurUser.Text = usersFromDB.GetUserById(AuthForm.currentUser.Employee);
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
            if (!(isClosed))
                Application.Exit();
        }

        private void dgvAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgvAlbums.CurrentRow.Index;

            album = albums[selectedRowIndex];

            pbAlbum.Image = album.Image;

            lblAlbumName.Visible = true;
            lblArtist.Visible = true;
            lblPrice.Visible = true;

            lblAlbumName.Text = album.AlbumName;
            lblArtist.Text = album.Artist;
            lblPrice.Text = albumsFromDB.GetAlbumPrice(album.AlbumName, album.Label).ToString();
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
            SupplyForm supplyForm = new SupplyForm();
            supplyForm.Show();
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
    }
}
