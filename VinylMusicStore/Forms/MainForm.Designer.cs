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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.IdAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemTracks = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddTracks = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddNewAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewReceips = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAllUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemArtists = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLabels = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurUser = new System.Windows.Forms.Label();
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ToolStripMenuItemAllTracks = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInstock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.AllowUserToAddRows = false;
            this.dgvAlbums.AllowUserToDeleteRows = false;
            this.dgvAlbums.AllowUserToOrderColumns = true;
            this.dgvAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlbums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlbums.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.dgvAlbums.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Concert One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbums.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlbum,
            this.AlbumName,
            this.Artist,
            this.AlbumCount,
            this.Label,
            this.Country,
            this.YearOfAlbum,
            this.YearOfRelease,
            this.Genre,
            this.AlbumImage});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlbums.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlbums.EnableHeadersVisualStyles = false;
            this.dgvAlbums.GridColor = System.Drawing.Color.Firebrick;
            this.dgvAlbums.Location = new System.Drawing.Point(27, 87);
            this.dgvAlbums.MultiSelect = false;
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.ReadOnly = true;
            this.dgvAlbums.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbums.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlbums.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAlbums.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlbums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbums.ShowCellToolTips = false;
            this.dgvAlbums.Size = new System.Drawing.Size(506, 535);
            this.dgvAlbums.TabIndex = 0;
            this.toolTip.SetToolTip(this.dgvAlbums, "Двойной щелчок по элементу для просмотра подробного просмотра\r\nПравой кнопкой - р" +
        "едактирование\r\n\r\n");
            this.dgvAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbums_CellClick);
            this.dgvAlbums.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbums_CellDoubleClick);
            this.dgvAlbums.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlbums_CellMouseClick);
            this.dgvAlbums.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvAlbums_MouseDown);
            // 
            // IdAlbum
            // 
            this.IdAlbum.HeaderText = "Id";
            this.IdAlbum.MinimumWidth = 6;
            this.IdAlbum.Name = "IdAlbum";
            this.IdAlbum.ReadOnly = true;
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
            this.Label.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // YearOfAlbum
            // 
            this.YearOfAlbum.HeaderText = "YearOfAlbum";
            this.YearOfAlbum.MinimumWidth = 6;
            this.YearOfAlbum.Name = "YearOfAlbum";
            this.YearOfAlbum.ReadOnly = true;
            // 
            // YearOfRelease
            // 
            this.YearOfRelease.HeaderText = "YearOfRelease";
            this.YearOfRelease.MinimumWidth = 6;
            this.YearOfRelease.Name = "YearOfRelease";
            this.YearOfRelease.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // AlbumImage
            // 
            this.AlbumImage.HeaderText = "Image";
            this.AlbumImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.AlbumImage.MinimumWidth = 6;
            this.AlbumImage.Name = "AlbumImage";
            this.AlbumImage.ReadOnly = true;
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
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTracks,
            this.ToolStripMenuItemAlbum,
            this.ToolStripMenuItemReceipt,
            this.ToolStripMenuItemSupply,
            this.пользовательToolStripMenuItem,
            this.ToolStripMenuItemInfo,
            this.ToolStripMenuItemExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemTracks
            // 
            this.ToolStripMenuItemTracks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddTracks,
            this.ToolStripMenuItemAllTracks});
            this.ToolStripMenuItemTracks.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemTracks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemTracks.Image = global::VinylMusicStore.Properties.Resources.album_folder;
            this.ToolStripMenuItemTracks.Name = "ToolStripMenuItemTracks";
            this.ToolStripMenuItemTracks.Size = new System.Drawing.Size(83, 24);
            this.ToolStripMenuItemTracks.Text = "Треки";
            // 
            // ToolStripMenuItemAddTracks
            // 
            this.ToolStripMenuItemAddTracks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemAddTracks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemAddTracks.Name = "ToolStripMenuItemAddTracks";
            this.ToolStripMenuItemAddTracks.Size = new System.Drawing.Size(231, 22);
            this.ToolStripMenuItemAddTracks.Text = "Добавить треки";
            this.ToolStripMenuItemAddTracks.Click += new System.EventHandler(this.ToolStripMenuItemAddTracks_Click);
            // 
            // ToolStripMenuItemAlbum
            // 
            this.ToolStripMenuItemAlbum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddNewAlbum});
            this.ToolStripMenuItemAlbum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemAlbum.Image = global::VinylMusicStore.Properties.Resources.vinylico;
            this.ToolStripMenuItemAlbum.Name = "ToolStripMenuItemAlbum";
            this.ToolStripMenuItemAlbum.Size = new System.Drawing.Size(99, 24);
            this.ToolStripMenuItemAlbum.Text = "Альбом";
            // 
            // ToolStripMenuItemAddNewAlbum
            // 
            this.ToolStripMenuItemAddNewAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemAddNewAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemAddNewAlbum.Name = "ToolStripMenuItemAddNewAlbum";
            this.ToolStripMenuItemAddNewAlbum.Size = new System.Drawing.Size(265, 22);
            this.ToolStripMenuItemAddNewAlbum.Text = "Добавить новый альбом";
            this.ToolStripMenuItemAddNewAlbum.Click += new System.EventHandler(this.ToolStripMenuItemAddNewAlbum_Click);
            // 
            // ToolStripMenuItemReceipt
            // 
            this.ToolStripMenuItemReceipt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCreateReceipt,
            this.ToolStripMenuItemViewReceips});
            this.ToolStripMenuItemReceipt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemReceipt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemReceipt.Image = global::VinylMusicStore.Properties.Resources.validating_ticket;
            this.ToolStripMenuItemReceipt.Name = "ToolStripMenuItemReceipt";
            this.ToolStripMenuItemReceipt.Size = new System.Drawing.Size(67, 24);
            this.ToolStripMenuItemReceipt.Text = "Чек";
            // 
            // ToolStripMenuItemCreateReceipt
            // 
            this.ToolStripMenuItemCreateReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemCreateReceipt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemCreateReceipt.Name = "ToolStripMenuItemCreateReceipt";
            this.ToolStripMenuItemCreateReceipt.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItemCreateReceipt.Text = "Создать чек";
            this.ToolStripMenuItemCreateReceipt.Click += new System.EventHandler(this.ToolStripMenuItemCreateReceipt_Click);
            // 
            // ToolStripMenuItemViewReceips
            // 
            this.ToolStripMenuItemViewReceips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemViewReceips.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemViewReceips.Name = "ToolStripMenuItemViewReceips";
            this.ToolStripMenuItemViewReceips.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItemViewReceips.Text = "Просмотреть чеки";
            this.ToolStripMenuItemViewReceips.Click += new System.EventHandler(this.ToolStripMenuItemViewReceips_Click);
            // 
            // ToolStripMenuItemSupply
            // 
            this.ToolStripMenuItemSupply.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddSupply,
            this.ToolStripMenuItemViewSupply});
            this.ToolStripMenuItemSupply.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemSupply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemSupply.Image = global::VinylMusicStore.Properties.Resources.supply_chain;
            this.ToolStripMenuItemSupply.Name = "ToolStripMenuItemSupply";
            this.ToolStripMenuItemSupply.Size = new System.Drawing.Size(113, 24);
            this.ToolStripMenuItemSupply.Text = "Поставки";
            // 
            // ToolStripMenuItemAddSupply
            // 
            this.ToolStripMenuItemAddSupply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemAddSupply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemAddSupply.Name = "ToolStripMenuItemAddSupply";
            this.ToolStripMenuItemAddSupply.Size = new System.Drawing.Size(258, 22);
            this.ToolStripMenuItemAddSupply.Text = "Добавить поставки";
            this.ToolStripMenuItemAddSupply.Click += new System.EventHandler(this.ToolStripMenuItemAddSupply_Click);
            // 
            // ToolStripMenuItemViewSupply
            // 
            this.ToolStripMenuItemViewSupply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemViewSupply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemViewSupply.Name = "ToolStripMenuItemViewSupply";
            this.ToolStripMenuItemViewSupply.Size = new System.Drawing.Size(258, 22);
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
            this.пользовательToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.пользовательToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.пользовательToolStripMenuItem.Image = global::VinylMusicStore.Properties.Resources.user;
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // ToolStripMenuItemChangePassword
            // 
            this.ToolStripMenuItemChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemChangePassword.Name = "ToolStripMenuItemChangePassword";
            this.ToolStripMenuItemChangePassword.Size = new System.Drawing.Size(266, 22);
            this.ToolStripMenuItemChangePassword.Text = "Сменить пароль";
            this.ToolStripMenuItemChangePassword.Click += new System.EventHandler(this.ToolStripMenuItemChangePassword_Click);
            // 
            // ToolStripMenuItemAllUsers
            // 
            this.ToolStripMenuItemAllUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemAllUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemAllUsers.Name = "ToolStripMenuItemAllUsers";
            this.ToolStripMenuItemAllUsers.Size = new System.Drawing.Size(266, 22);
            this.ToolStripMenuItemAllUsers.Text = "Все пользователи";
            this.ToolStripMenuItemAllUsers.Click += new System.EventHandler(this.ToolStripMenuItemAllUsers_Click);
            // 
            // ToolStripMenuItemEditProfile
            // 
            this.ToolStripMenuItemEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemEditProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemEditProfile.Name = "ToolStripMenuItemEditProfile";
            this.ToolStripMenuItemEditProfile.Size = new System.Drawing.Size(266, 22);
            this.ToolStripMenuItemEditProfile.Text = "Редактировать профиль";
            this.ToolStripMenuItemEditProfile.Click += new System.EventHandler(this.ToolStripMenuItemEditProfile_Click);
            // 
            // ToolStripMenuItemChangeUser
            // 
            this.ToolStripMenuItemChangeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemChangeUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemChangeUser.Name = "ToolStripMenuItemChangeUser";
            this.ToolStripMenuItemChangeUser.Size = new System.Drawing.Size(266, 22);
            this.ToolStripMenuItemChangeUser.Text = "Сменить польователя";
            this.ToolStripMenuItemChangeUser.Click += new System.EventHandler(this.ToolStripMenuItemChangeUser_Click);
            // 
            // ToolStripMenuItemInfo
            // 
            this.ToolStripMenuItemInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemArtists,
            this.ToolStripMenuItemGenres,
            this.ToolStripMenuItemLabels});
            this.ToolStripMenuItemInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemInfo.Image = global::VinylMusicStore.Properties.Resources.reference;
            this.ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            this.ToolStripMenuItemInfo.Size = new System.Drawing.Size(142, 24);
            this.ToolStripMenuItemInfo.Text = "Справочники";
            // 
            // ToolStripMenuItemArtists
            // 
            this.ToolStripMenuItemArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemArtists.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemArtists.Name = "ToolStripMenuItemArtists";
            this.ToolStripMenuItemArtists.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemArtists.Text = "Исполнители";
            this.ToolStripMenuItemArtists.Click += new System.EventHandler(this.ToolStripMenuItemArtists_Click);
            // 
            // ToolStripMenuItemGenres
            // 
            this.ToolStripMenuItemGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemGenres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemGenres.Name = "ToolStripMenuItemGenres";
            this.ToolStripMenuItemGenres.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemGenres.Text = "Жанры";
            this.ToolStripMenuItemGenres.Click += new System.EventHandler(this.ToolStripMenuItemGenres_Click);
            // 
            // ToolStripMenuItemLabels
            // 
            this.ToolStripMenuItemLabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemLabels.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemLabels.Name = "ToolStripMenuItemLabels";
            this.ToolStripMenuItemLabels.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemLabels.Text = "Лейблы";
            this.ToolStripMenuItemLabels.Click += new System.EventHandler(this.ToolStripMenuItemLabels_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripMenuItemExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItemExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemExit.Image = global::VinylMusicStore.Properties.Resources.logout;
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(87, 24);
            this.ToolStripMenuItemExit.Text = "Выйти";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Concert One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(67, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название альбома";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAlbumName.AutoEllipsis = true;
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbumName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAlbumName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlbumName.Location = new System.Drawing.Point(63, 274);
            this.lblAlbumName.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblAlbumName.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(150, 18);
            this.lblAlbumName.TabIndex = 3;
            this.lblAlbumName.Text = "lblAlbumName";
            this.lblAlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(95, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Стоимость";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrice.AutoEllipsis = true;
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(63, 422);
            this.lblPrice.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblPrice.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(150, 18);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "lblPrice";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(88, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Исполнитель";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArtist
            // 
            this.lblArtist.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblArtist.AutoEllipsis = true;
            this.lblArtist.AutoSize = true;
            this.lblArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblArtist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArtist.Location = new System.Drawing.Point(63, 348);
            this.lblArtist.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblArtist.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(150, 18);
            this.lblArtist.TabIndex = 3;
            this.lblArtist.Text = "lblArtist";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(24, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Текущий пользователь";
            // 
            // lblCurUser
            // 
            this.lblCurUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurUser.AutoSize = true;
            this.lblCurUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCurUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCurUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurUser.Location = new System.Drawing.Point(202, 51);
            this.lblCurUser.Name = "lblCurUser";
            this.lblCurUser.Size = new System.Drawing.Size(83, 18);
            this.lblCurUser.TabIndex = 3;
            this.lblCurUser.Text = "lblCurUser";
            // 
            // pbAlbum
            // 
            this.pbAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAlbum.BackColor = System.Drawing.Color.Transparent;
            this.pbAlbum.Location = new System.Drawing.Point(10, 10);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(180, 180);
            this.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlbum.TabIndex = 1;
            this.pbAlbum.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblArtist);
            this.panel1.Controls.Add(this.lblAlbumName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblInstock);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Location = new System.Drawing.Point(555, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 535);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pbAlbum);
            this.panel2.Location = new System.Drawing.Point(38, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 4;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 2000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // ToolStripMenuItemAllTracks
            // 
            this.ToolStripMenuItemAllTracks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.ToolStripMenuItemAllTracks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItemAllTracks.Name = "ToolStripMenuItemAllTracks";
            this.ToolStripMenuItemAllTracks.Size = new System.Drawing.Size(231, 22);
            this.ToolStripMenuItemAllTracks.Text = "Просмотреть треки";
            this.ToolStripMenuItemAllTracks.Click += new System.EventHandler(this.ToolStripMenuItemAllTracks_Click);
            // 
            // lblInstock
            // 
            this.lblInstock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInstock.AutoEllipsis = true;
            this.lblInstock.AutoSize = true;
            this.lblInstock.BackColor = System.Drawing.Color.Transparent;
            this.lblInstock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblInstock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInstock.Location = new System.Drawing.Point(63, 496);
            this.lblInstock.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblInstock.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblInstock.Name = "lblInstock";
            this.lblInstock.Size = new System.Drawing.Size(150, 18);
            this.lblInstock.TabIndex = 3;
            this.lblInstock.Text = "lblInstock";
            this.lblInstock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(104, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Наличие";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::VinylMusicStore.Properties.Resources.radgradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCurUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvAlbums);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(876, 694);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTracks;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReceipt;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCreateReceipt;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewReceips;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSupply;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEditProfile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemArtists;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGenres;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLabels;
        private System.Windows.Forms.PictureBox pbAlbum;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChangeUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewImageColumn AlbumImage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAlbum;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddNewAlbum;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddTracks;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAllTracks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInstock;
    }
}

