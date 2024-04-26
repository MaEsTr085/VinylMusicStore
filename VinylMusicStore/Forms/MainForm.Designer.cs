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
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemTracks = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewReceips = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.dgvAlbums.Location = new System.Drawing.Point(12, 56);
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
            // pbAlbum
            // 
            this.pbAlbum.Location = new System.Drawing.Point(602, 56);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(192, 208);
            this.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum.TabIndex = 1;
            this.pbAlbum.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTracks,
            this.чекToolStripMenuItem,
            this.ToolStripMenuItemSupply,
            this.пользовательToolStripMenuItem});
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
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПарольToolStripMenuItem});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
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
            this.ToolStripMenuItemCreateReceipt.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemCreateReceipt.Text = "Создать чек";
            this.ToolStripMenuItemCreateReceipt.Click += new System.EventHandler(this.ToolStripMenuItemCreateReceipt_Click);
            // 
            // ToolStripMenuItemViewReceips
            // 
            this.ToolStripMenuItemViewReceips.Name = "ToolStripMenuItemViewReceips";
            this.ToolStripMenuItemViewReceips.Size = new System.Drawing.Size(180, 22);
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
            // сменитьПарольToolStripMenuItem
            // 
            this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.PictureBox pbAlbum;
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
        private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
    }
}

