namespace VinylMusicStore.Forms
{
    partial class AddNewAlbumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbYearRelease = new System.Windows.Forms.TextBox();
            this.tbYearAlbum = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.pbAlbumImage = new System.Windows.Forms.PictureBox();
            this.btnAddAlbumImage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.tcNewAlbum = new System.Windows.Forms.TabControl();
            this.albumTabPage = new System.Windows.Forms.TabPage();
            this.btnAddNewAlbum = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tracksTabPage = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTracksTab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumImage)).BeginInit();
            this.tcNewAlbum.SuspendLayout();
            this.albumTabPage.SuspendLayout();
            this.tracksTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(211, 199);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(4);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(155, 22);
            this.tbGenre.TabIndex = 9;
            this.tbGenre.TextChanged += new System.EventHandler(this.tbGenre_TextChanged);
            this.tbGenre.Enter += new System.EventHandler(this.tbGenre_Enter);
            this.tbGenre.Leave += new System.EventHandler(this.tbGenre_Leave);
            // 
            // tbYearRelease
            // 
            this.tbYearRelease.Location = new System.Drawing.Point(211, 169);
            this.tbYearRelease.Margin = new System.Windows.Forms.Padding(4);
            this.tbYearRelease.Name = "tbYearRelease";
            this.tbYearRelease.Size = new System.Drawing.Size(155, 22);
            this.tbYearRelease.TabIndex = 10;
            // 
            // tbYearAlbum
            // 
            this.tbYearAlbum.Location = new System.Drawing.Point(211, 138);
            this.tbYearAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.tbYearAlbum.Name = "tbYearAlbum";
            this.tbYearAlbum.Size = new System.Drawing.Size(155, 22);
            this.tbYearAlbum.TabIndex = 11;
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(211, 78);
            this.tbArtist.Margin = new System.Windows.Forms.Padding(4);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(155, 22);
            this.tbArtist.TabIndex = 12;
            this.tbArtist.TextChanged += new System.EventHandler(this.tbArtist_TextChanged);
            this.tbArtist.Enter += new System.EventHandler(this.tbArtist_Enter);
            this.tbArtist.Leave += new System.EventHandler(this.tbArtist_Leave);
            // 
            // tbLabel
            // 
            this.tbLabel.Location = new System.Drawing.Point(211, 108);
            this.tbLabel.Margin = new System.Windows.Forms.Padding(4);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(155, 22);
            this.tbLabel.TabIndex = 13;
            this.tbLabel.TextChanged += new System.EventHandler(this.tbLabel_TextChanged);
            this.tbLabel.Enter += new System.EventHandler(this.tbLabel_Enter);
            this.tbLabel.Leave += new System.EventHandler(this.tbLabel_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Альбом";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Год релиза";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Исполнитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Год альбома";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Лейбл";
            // 
            // dgvTracks
            // 
            this.dgvTracks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackName,
            this.Duration});
            this.dgvTracks.Location = new System.Drawing.Point(51, 43);
            this.dgvTracks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.RowHeadersWidth = 51;
            this.dgvTracks.RowTemplate.Height = 24;
            this.dgvTracks.Size = new System.Drawing.Size(387, 430);
            this.dgvTracks.TabIndex = 14;
            // 
            // TrackName
            // 
            this.TrackName.HeaderText = "Название трека";
            this.TrackName.MinimumWidth = 6;
            this.TrackName.Name = "TrackName";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Длительность";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Треки";
            // 
            // pbAlbumImage
            // 
            this.pbAlbumImage.BackColor = System.Drawing.Color.Transparent;
            this.pbAlbumImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAlbumImage.Image = global::VinylMusicStore.Properties.Resources.vinyl;
            this.pbAlbumImage.Location = new System.Drawing.Point(109, 273);
            this.pbAlbumImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAlbumImage.Name = "pbAlbumImage";
            this.pbAlbumImage.Size = new System.Drawing.Size(255, 256);
            this.pbAlbumImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlbumImage.TabIndex = 15;
            this.pbAlbumImage.TabStop = false;
            this.pbAlbumImage.Click += new System.EventHandler(this.pbAlbumImage_Click);
            // 
            // btnAddAlbumImage
            // 
            this.btnAddAlbumImage.Location = new System.Drawing.Point(371, 474);
            this.btnAddAlbumImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAlbumImage.Name = "btnAddAlbumImage";
            this.btnAddAlbumImage.Size = new System.Drawing.Size(149, 55);
            this.btnAddAlbumImage.TabIndex = 16;
            this.btnAddAlbumImage.Text = "Добавить изображение";
            this.btnAddAlbumImage.UseVisualStyleBackColor = true;
            this.btnAddAlbumImage.Click += new System.EventHandler(this.btnAddAlbumImage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 439);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Обложка альбома";
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 16;
            this.lbItems.Location = new System.Drawing.Point(383, 46);
            this.lbItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(249, 212);
            this.lbItems.TabIndex = 17;
            this.lbItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbItems_MouseDoubleClick);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(639, 209);
            this.btnCreateNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(165, 49);
            this.btnCreateNew.TabIndex = 16;
            this.btnCreateNew.Text = "Создать новый";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // tcNewAlbum
            // 
            this.tcNewAlbum.Controls.Add(this.albumTabPage);
            this.tcNewAlbum.Controls.Add(this.tracksTabPage);
            this.tcNewAlbum.Location = new System.Drawing.Point(-1, 2);
            this.tcNewAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcNewAlbum.Name = "tcNewAlbum";
            this.tcNewAlbum.SelectedIndex = 0;
            this.tcNewAlbum.Size = new System.Drawing.Size(935, 578);
            this.tcNewAlbum.TabIndex = 18;
            // 
            // albumTabPage
            // 
            this.albumTabPage.Controls.Add(this.tbGenre);
            this.albumTabPage.Controls.Add(this.btnAddAlbumImage);
            this.albumTabPage.Controls.Add(this.btnAddNewAlbum);
            this.albumTabPage.Controls.Add(this.btnTracksTab);
            this.albumTabPage.Controls.Add(this.btnCreateNew);
            this.albumTabPage.Controls.Add(this.pbAlbumImage);
            this.albumTabPage.Controls.Add(this.label8);
            this.albumTabPage.Controls.Add(this.lbItems);
            this.albumTabPage.Controls.Add(this.label1);
            this.albumTabPage.Controls.Add(this.label3);
            this.albumTabPage.Controls.Add(this.label10);
            this.albumTabPage.Controls.Add(this.label6);
            this.albumTabPage.Controls.Add(this.label4);
            this.albumTabPage.Controls.Add(this.label5);
            this.albumTabPage.Controls.Add(this.tbYearRelease);
            this.albumTabPage.Controls.Add(this.label9);
            this.albumTabPage.Controls.Add(this.label2);
            this.albumTabPage.Controls.Add(this.tbYearAlbum);
            this.albumTabPage.Controls.Add(this.tbLabel);
            this.albumTabPage.Controls.Add(this.tbAlbum);
            this.albumTabPage.Controls.Add(this.tbArtist);
            this.albumTabPage.Location = new System.Drawing.Point(4, 25);
            this.albumTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.albumTabPage.Name = "albumTabPage";
            this.albumTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.albumTabPage.Size = new System.Drawing.Size(927, 549);
            this.albumTabPage.TabIndex = 0;
            this.albumTabPage.Text = "Информация об альбоме";
            this.albumTabPage.UseVisualStyleBackColor = true;
            // 
            // btnAddNewAlbum
            // 
            this.btnAddNewAlbum.Location = new System.Drawing.Point(701, 476);
            this.btnAddNewAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewAlbum.Name = "btnAddNewAlbum";
            this.btnAddNewAlbum.Size = new System.Drawing.Size(217, 49);
            this.btnAddNewAlbum.TabIndex = 16;
            this.btnAddNewAlbum.Text = "Добавить новый альбом";
            this.btnAddNewAlbum.UseVisualStyleBackColor = true;
            this.btnAddNewAlbum.Click += new System.EventHandler(this.btnAddNewAlbum_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Название альбома";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Нет нужного элемента?";
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(211, 48);
            this.tbAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(155, 22);
            this.tbAlbum.TabIndex = 12;
            this.tbAlbum.TextChanged += new System.EventHandler(this.tbArtist_TextChanged);
            // 
            // tracksTabPage
            // 
            this.tracksTabPage.Controls.Add(this.btnBack);
            this.tracksTabPage.Controls.Add(this.dgvTracks);
            this.tracksTabPage.Controls.Add(this.label7);
            this.tracksTabPage.Location = new System.Drawing.Point(4, 25);
            this.tracksTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tracksTabPage.Name = "tracksTabPage";
            this.tracksTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tracksTabPage.Size = new System.Drawing.Size(927, 549);
            this.tracksTabPage.TabIndex = 1;
            this.tracksTabPage.Text = "Список треков";
            this.tracksTabPage.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(445, 43);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 50);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Вернуться";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTracksTab
            // 
            this.btnTracksTab.Location = new System.Drawing.Point(701, 423);
            this.btnTracksTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTracksTab.Name = "btnTracksTab";
            this.btnTracksTab.Size = new System.Drawing.Size(217, 49);
            this.btnTracksTab.TabIndex = 16;
            this.btnTracksTab.Text = "Добавить треки";
            this.btnTracksTab.UseVisualStyleBackColor = true;
            this.btnTracksTab.Click += new System.EventHandler(this.btnTracksTab_Click);
            // 
            // AddNewAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 603);
            this.Controls.Add(this.tcNewAlbum);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewAlbumForm";
            this.Text = "Добавление нового альбома";
            this.Load += new System.EventHandler(this.AddNewAlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumImage)).EndInit();
            this.tcNewAlbum.ResumeLayout(false);
            this.albumTabPage.ResumeLayout(false);
            this.albumTabPage.PerformLayout();
            this.tracksTabPage.ResumeLayout(false);
            this.tracksTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbYearRelease;
        private System.Windows.Forms.TextBox tbYearAlbum;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbAlbumImage;
        private System.Windows.Forms.Button btnAddAlbumImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.TabControl tcNewAlbum;
        private System.Windows.Forms.TabPage albumTabPage;
        private System.Windows.Forms.TabPage tracksTabPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddNewAlbum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Button btnTracksTab;
    }
}