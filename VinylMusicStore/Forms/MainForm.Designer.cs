namespace VinylMusicStore
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.IdAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemTracks = new System.Windows.Forms.ToolStripMenuItem();
            this.чекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewReceips = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAllUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemArtists = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLabels = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurUser = new System.Windows.Forms.Label();
            this.ToolStripMenuItemChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.AllowUserToAddRows = false;
            this.dgvAlbums.AllowUserToDeleteRows = false;
            this.dgvAlbums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlbum,
            this.AlbumName,
            this.Artist,
            this.AlbumCount,
            this.Label,
            this.YearOfAlbum,
            this.YearOfRelease,
            this.Genre,
            this.AlbumImage});
            this.dgvAlbums.ContextMenuStrip = this.contextMenu;
            this.dgvAlbums.Location = new System.Drawing.Point(12, 86);
            this.dgvAlbums.MultiSelect = false;
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.RowHeadersWidth = 51;
            this.dgvAlbums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbums.Size = new System.Drawing.Size(540, 353);
            this.dgvAlbums.TabIndex = 0;
            this.dgvAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbums_CellClick);
            this.dgvAlbums.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbums_CellDoubleClick);
            this.dgvAlbums.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvAlbums_MouseDown);
            // 
            // IdAlbum
            // 
            this.IdAlbum.HeaderText = "Id";
            this.IdAlbum.MinimumWidth = 6;
            this.IdAlbum.Name = "IdAlbum";
            // 
            // AlbumName
            // 
            this.AlbumName.HeaderText = "Альбом";
            this.AlbumName.MinimumWidth = 6;
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.ReadOnly = true;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Исполнитель";
            this.Artist.MinimumWidth = 6;
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            // 
            // AlbumCount
            // 
            this.AlbumCount.HeaderText = "В наличии";
            this.AlbumCount.MinimumWidth = 6;
            this.AlbumCount.Name = "AlbumCount";
            this.AlbumCount.ReadOnly = true;
            // 
            // Label
            // 
            this.Label.HeaderText = "Label";
            this.Label.MinimumWidth = 6;
            this.Label.Name = "Label";
            // 
            // YearOfAlbum
            // 
            this.YearOfAlbum.HeaderText = "YearOfAlbum";
            this.YearOfAlbum.MinimumWidth = 6;
            this.YearOfAlbum.Name = "YearOfAlbum";
            // 
            // YearOfRelease
            // 
            this.YearOfRelease.HeaderText = "YearOfRelease";
            this.YearOfRelease.MinimumWidth = 6;
            this.YearOfRelease.Name = "YearOfRelease";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            // 
            // AlbumImage
            // 
            this.AlbumImage.HeaderText = "Image";
            this.AlbumImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.AlbumImage.MinimumWidth = 6;
            this.AlbumImage.Name = "AlbumImage";
            this.AlbumImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AlbumImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(155, 48);
            // 
            // просмотретьToolStripMenuItem
            // 
            this.просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            this.просмотретьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.просмотретьToolStripMenuItem.Text = "Просмотреть";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTracks,
            this.чекToolStripMenuItem,
            this.ToolStripMenuItemSupply,
            this.пользовательToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.ToolStripMenuItemExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemTracks
            // 
            this.ToolStripMenuItemTracks.Name = "ToolStripMenuItemTracks";
            this.ToolStripMenuItemTracks.Size = new System.Drawing.Size(51, 20);
            this.ToolStripMenuItemTracks.Text = "Треки";
            this.ToolStripMenuItemTracks.Click += new System.EventHandler(this.ToolStripMenuItemTracks_Click);
            // 
            // чекToolStripMenuItem
            // 
            this.чекToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCreateReceipt,
            this.ToolStripMenuItemViewReceips});
            this.чекToolStripMenuItem.Name = "чекToolStripMenuItem";
            this.чекToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.чекToolStripMenuItem.Text = "Чек";
            // 
            // ToolStripMenuItemCreateReceipt
            // 
            this.ToolStripMenuItemCreateReceipt.Name = "ToolStripMenuItemCreateReceipt";
            this.ToolStripMenuItemCreateReceipt.Size = new System.Drawing.Size(177, 22);
            this.ToolStripMenuItemCreateReceipt.Text = "Создать чек";
            this.ToolStripMenuItemCreateReceipt.Click += new System.EventHandler(this.ToolStripMenuItemCreateReceipt_Click);
            // 
            // ToolStripMenuItemViewReceips
            // 
            this.ToolStripMenuItemViewReceips.Name = "ToolStripMenuItemViewReceips";
            this.ToolStripMenuItemViewReceips.Size = new System.Drawing.Size(177, 22);
            this.ToolStripMenuItemViewReceips.Text = "Просмотреть чеки";
            // 
            // ToolStripMenuItemSupply
            // 
            this.ToolStripMenuItemSupply.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddSupply,
            this.ToolStripMenuItemViewSupply});
            this.ToolStripMenuItemSupply.Name = "ToolStripMenuItemSupply";
            this.ToolStripMenuItemSupply.Size = new System.Drawing.Size(71, 20);
            this.ToolStripMenuItemSupply.Text = "Поставки";
            // 
            // ToolStripMenuItemAddSupply
            // 
            this.ToolStripMenuItemAddSupply.Name = "ToolStripMenuItemAddSupply";
            this.ToolStripMenuItemAddSupply.Size = new System.Drawing.Size(201, 22);
            this.ToolStripMenuItemAddSupply.Text = "Добавить поставки";
            this.ToolStripMenuItemAddSupply.Click += new System.EventHandler(this.ToolStripMenuItemAddSupply_Click);
            // 
            // ToolStripMenuItemViewSupply
            // 
            this.ToolStripMenuItemViewSupply.Name = "ToolStripMenuItemViewSupply";
            this.ToolStripMenuItemViewSupply.Size = new System.Drawing.Size(201, 22);
            this.ToolStripMenuItemViewSupply.Text = "Просмотреть поставки";
            this.ToolStripMenuItemViewSupply.Click += new System.EventHandler(this.ToolStripMenuItemViewSupply_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemChangePassword,
            this.ToolStripMenuItemAllUsers,
            this.ToolStripMenuItemEditProfile,
            this.ToolStripMenuItemChangeUser});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // ToolStripMenuItemChangePassword
            // 
            this.ToolStripMenuItemChangePassword.Name = "ToolStripMenuItemChangePassword";
            this.ToolStripMenuItemChangePassword.Size = new System.Drawing.Size(207, 22);
            this.ToolStripMenuItemChangePassword.Text = "Сменить пароль";
            this.ToolStripMenuItemChangePassword.Click += new System.EventHandler(this.ToolStripMenuItemChangePassword_Click);
            // 
            // ToolStripMenuItemAllUsers
            // 
            this.ToolStripMenuItemAllUsers.Name = "ToolStripMenuItemAllUsers";
            this.ToolStripMenuItemAllUsers.Size = new System.Drawing.Size(207, 22);
            this.ToolStripMenuItemAllUsers.Text = "Все пользователи";
            this.ToolStripMenuItemAllUsers.Click += new System.EventHandler(this.ToolStripMenuItemAllUsers_Click);
            // 
            // ToolStripMenuItemEditProfile
            // 
            this.ToolStripMenuItemEditProfile.Name = "ToolStripMenuItemEditProfile";
            this.ToolStripMenuItemEditProfile.Size = new System.Drawing.Size(207, 22);
            this.ToolStripMenuItemEditProfile.Text = "Редактировать профиль";
            this.ToolStripMenuItemEditProfile.Click += new System.EventHandler(this.ToolStripMenuItemEditProfile_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemArtists,
            this.ToolStripMenuItemGenres,
            this.ToolStripMenuItemLabels});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // ToolStripMenuItemArtists
            // 
            this.ToolStripMenuItemArtists.Name = "ToolStripMenuItemArtists";
            this.ToolStripMenuItemArtists.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemArtists.Text = "Исполнители";
            this.ToolStripMenuItemArtists.Click += new System.EventHandler(this.ToolStripMenuItemArtists_Click);
            // 
            // ToolStripMenuItemGenres
            // 
            this.ToolStripMenuItemGenres.Name = "ToolStripMenuItemGenres";
            this.ToolStripMenuItemGenres.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemGenres.Text = "Жанры";
            this.ToolStripMenuItemGenres.Click += new System.EventHandler(this.ToolStripMenuItemGenres_Click);
            // 
            // ToolStripMenuItemLabels
            // 
            this.ToolStripMenuItemLabels.Name = "ToolStripMenuItemLabels";
            this.ToolStripMenuItemLabels.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemLabels.Text = "Лейблы";
            this.ToolStripMenuItemLabels.Click += new System.EventHandler(this.ToolStripMenuItemLabels_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название альбома";
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Location = new System.Drawing.Point(722, 319);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(74, 13);
            this.lblAlbumName.TabIndex = 3;
            this.lblAlbumName.Text = "lblAlbumName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Стоимость";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(722, 374);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Исполнитель";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(722, 348);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(40, 13);
            this.lblArtist.TabIndex = 3;
            this.lblArtist.Text = "lblArtist";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "0 из 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Текущий пользователь";
            // 
            // lblCurUser
            // 
            this.lblCurUser.AutoSize = true;
            this.lblCurUser.Location = new System.Drawing.Point(159, 34);
            this.lblCurUser.Name = "lblCurUser";
            this.lblCurUser.Size = new System.Drawing.Size(55, 13);
            this.lblCurUser.TabIndex = 3;
            this.lblCurUser.Text = "lblCurUser";
            // 
            // ToolStripMenuItemChangeUser
            // 
            this.ToolStripMenuItemChangeUser.Name = "ToolStripMenuItemChangeUser";
            this.ToolStripMenuItemChangeUser.Size = new System.Drawing.Size(207, 22);
            this.ToolStripMenuItemChangeUser.Text = "Сменить польователя";
            this.ToolStripMenuItemChangeUser.Click += new System.EventHandler(this.ToolStripMenuItemChangeUser_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(54, 20);
            this.ToolStripMenuItemExit.Text = "Выйти";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // pbAlbum
            // 
            this.pbAlbum.Location = new System.Drawing.Point(602, 86);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(192, 208);
            this.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlbum.TabIndex = 1;
            this.pbAlbum.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 494);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCurUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAlbum);
            this.Controls.Add(this.dgvAlbums);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Магазин Винила";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTracks;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCreateReceipt;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewReceips;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSupply;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewImageColumn AlbumImage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddSupply;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewSupply;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangePassword;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAllUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditProfile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurUser;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemArtists;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGenres;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLabels;
        private System.Windows.Forms.PictureBox pbAlbum;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangeUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
    }
}

