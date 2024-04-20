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
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemTracks = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewReceips = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSupply = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.AllowUserToAddRows = false;
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
            this.dgvAlbums.Location = new System.Drawing.Point(16, 69);
            this.dgvAlbums.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.RowHeadersWidth = 51;
            this.dgvAlbums.Size = new System.Drawing.Size(720, 434);
            this.dgvAlbums.TabIndex = 0;
            this.dgvAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbums_CellClick);
            this.dgvAlbums.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbums_CellDoubleClick);
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
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Исполнитель";
            this.Artist.MinimumWidth = 6;
            this.Artist.Name = "Artist";
            // 
            // AlbumCount
            // 
            this.AlbumCount.HeaderText = "В наличии";
            this.AlbumCount.MinimumWidth = 6;
            this.AlbumCount.Name = "AlbumCount";
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
            // pbAlbum
            // 
            this.pbAlbum.Location = new System.Drawing.Point(803, 69);
            this.pbAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(256, 256);
            this.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum.TabIndex = 1;
            this.pbAlbum.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTracks,
            this.пользовательToolStripMenuItem,
            this.чекToolStripMenuItem,
            this.ToolStripMenuItemSupply});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1127, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemTracks
            // 
            this.ToolStripMenuItemTracks.Name = "ToolStripMenuItemTracks";
            this.ToolStripMenuItemTracks.Size = new System.Drawing.Size(64, 24);
            this.ToolStripMenuItemTracks.Text = "Треки";
            this.ToolStripMenuItemTracks.Click += new System.EventHandler(this.ToolStripMenuItemTracks_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // чекToolStripMenuItem
            // 
            this.чекToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCreateReceipt,
            this.ToolStripMenuItemViewReceips});
            this.чекToolStripMenuItem.Name = "чекToolStripMenuItem";
            this.чекToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.чекToolStripMenuItem.Text = "Чек";
            // 
            // ToolStripMenuItemCreateReceipt
            // 
            this.ToolStripMenuItemCreateReceipt.Name = "ToolStripMenuItemCreateReceipt";
            this.ToolStripMenuItemCreateReceipt.Size = new System.Drawing.Size(221, 26);
            this.ToolStripMenuItemCreateReceipt.Text = "Создать чек";
            this.ToolStripMenuItemCreateReceipt.Click += new System.EventHandler(this.ToolStripMenuItemCreateReceipt_Click);
            // 
            // ToolStripMenuItemViewReceips
            // 
            this.ToolStripMenuItemViewReceips.Name = "ToolStripMenuItemViewReceips";
            this.ToolStripMenuItemViewReceips.Size = new System.Drawing.Size(221, 26);
            this.ToolStripMenuItemViewReceips.Text = "Просмотреть чеки";
            // 
            // ToolStripMenuItemSupply
            // 
            this.ToolStripMenuItemSupply.Name = "ToolStripMenuItemSupply";
            this.ToolStripMenuItemSupply.Size = new System.Drawing.Size(88, 24);
            this.ToolStripMenuItemSupply.Text = "Поставки";
            this.ToolStripMenuItemSupply.Click += new System.EventHandler(this.ToolStripMenuItemSupply_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 554);
            this.Controls.Add(this.pbAlbum);
            this.Controls.Add(this.dgvAlbums);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Магазин Винила";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewImageColumn AlbumImage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSupply;
    }
}

