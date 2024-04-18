namespace VinylMusicStore.Forms
{
    partial class AlbumForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLabel = new System.Windows.Forms.TextBox();
            this.tbYearAlbum = new System.Windows.Forms.TextBox();
            this.tbYearRelease = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.IdTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tbArtist = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лейбл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Альбом";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Год альбома";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Год релиза";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Жанр";
            // 
            // tbLabel
            // 
            this.tbLabel.Location = new System.Drawing.Point(169, 149);
            this.tbLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(132, 22);
            this.tbLabel.TabIndex = 2;
            // 
            // tbYearAlbum
            // 
            this.tbYearAlbum.Location = new System.Drawing.Point(169, 190);
            this.tbYearAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbYearAlbum.Name = "tbYearAlbum";
            this.tbYearAlbum.Size = new System.Drawing.Size(132, 22);
            this.tbYearAlbum.TabIndex = 2;
            // 
            // tbYearRelease
            // 
            this.tbYearRelease.Location = new System.Drawing.Point(169, 235);
            this.tbYearRelease.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbYearRelease.Name = "tbYearRelease";
            this.tbYearRelease.Size = new System.Drawing.Size(132, 22);
            this.tbYearRelease.TabIndex = 2;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(169, 287);
            this.tbGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(132, 22);
            this.tbGenre.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(116, 388);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 44);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvTracks
            // 
            this.dgvTracks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTrack,
            this.Album,
            this.TrackName,
            this.Duration});
            this.dgvTracks.Location = new System.Drawing.Point(367, 53);
            this.dgvTracks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.RowHeadersWidth = 51;
            this.dgvTracks.Size = new System.Drawing.Size(369, 398);
            this.dgvTracks.TabIndex = 4;
            // 
            // IdTrack
            // 
            this.IdTrack.HeaderText = "Id";
            this.IdTrack.MinimumWidth = 6;
            this.IdTrack.Name = "IdTrack";
            // 
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.MinimumWidth = 6;
            this.Album.Name = "Album";
            // 
            // TrackName
            // 
            this.TrackName.HeaderText = "Track";
            this.TrackName.MinimumWidth = 6;
            this.TrackName.Name = "TrackName";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Исполнитель";
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(169, 105);
            this.tbArtist.Margin = new System.Windows.Forms.Padding(4);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(132, 22);
            this.tbArtist.TabIndex = 2;
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.dgvTracks);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbYearRelease);
            this.Controls.Add(this.tbYearAlbum);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.tbLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlbumForm";
            this.Text = "Альбом";
            this.Load += new System.EventHandler(this.AlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLabel;
        private System.Windows.Forms.TextBox tbYearAlbum;
        private System.Windows.Forms.TextBox tbYearRelease;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbArtist;
    }
}