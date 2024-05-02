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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.IdTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Track = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTracks = new System.Windows.Forms.Button();
            this.tbLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbYearAlbum = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.tbYearRelease = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnImage = new System.Windows.Forms.Panel();
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(12, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 36);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvTracks
            // 
            this.dgvTracks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTracks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTracks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.dgvTracks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Concert One", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTracks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTrack,
            this.Album,
            this.Track,
            this.Duration});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTracks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTracks.EnableHeadersVisualStyles = false;
            this.dgvTracks.GridColor = System.Drawing.Color.Firebrick;
            this.dgvTracks.Location = new System.Drawing.Point(617, 38);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTracks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTracks.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTracks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTracks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTracks.Size = new System.Drawing.Size(277, 323);
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
            // Track
            // 
            this.Track.HeaderText = "Трек";
            this.Track.MinimumWidth = 6;
            this.Track.Name = "Track";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Длительность (мин)";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            // 
            // btnAddTracks
            // 
            this.btnAddTracks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTracks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAddTracks.FlatAppearance.BorderSize = 0;
            this.btnAddTracks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnAddTracks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnAddTracks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTracks.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTracks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddTracks.Location = new System.Drawing.Point(720, 367);
            this.btnAddTracks.Name = "btnAddTracks";
            this.btnAddTracks.Size = new System.Drawing.Size(174, 41);
            this.btnAddTracks.TabIndex = 1;
            this.btnAddTracks.Text = "Добавить треки";
            this.btnAddTracks.UseVisualStyleBackColor = false;
            this.btnAddTracks.Click += new System.EventHandler(this.btnAddTracks_Click);
            // 
            // tbLabel
            // 
            this.tbLabel.BackColor = System.Drawing.Color.IndianRed;
            this.tbLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbLabel.Location = new System.Drawing.Point(132, 127);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(158, 19);
            this.tbLabel.TabIndex = 2;
            this.tbLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(121, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Альбом";
            // 
            // tbCountry
            // 
            this.tbCountry.BackColor = System.Drawing.Color.IndianRed;
            this.tbCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCountry.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbCountry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCountry.Location = new System.Drawing.Point(132, 163);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(158, 19);
            this.tbCountry.TabIndex = 2;
            this.tbCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(70, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Жанр";
            // 
            // tbArtist
            // 
            this.tbArtist.BackColor = System.Drawing.Color.IndianRed;
            this.tbArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArtist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbArtist.Location = new System.Drawing.Point(132, 91);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(158, 19);
            this.tbArtist.TabIndex = 2;
            this.tbArtist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(28, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Год релиза";
            // 
            // tbYearAlbum
            // 
            this.tbYearAlbum.BackColor = System.Drawing.Color.IndianRed;
            this.tbYearAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYearAlbum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbYearAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbYearAlbum.Location = new System.Drawing.Point(132, 199);
            this.tbYearAlbum.Name = "tbYearAlbum";
            this.tbYearAlbum.Size = new System.Drawing.Size(158, 19);
            this.tbYearAlbum.TabIndex = 2;
            this.tbYearAlbum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lblAlbum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlbum.Location = new System.Drawing.Point(77, 39);
            this.lblAlbum.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblAlbum.MinimumSize = new System.Drawing.Size(150, 0);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(150, 18);
            this.lblAlbum.TabIndex = 1;
            this.lblAlbum.Text = "lblAlbum";
            this.lblAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbYearRelease
            // 
            this.tbYearRelease.BackColor = System.Drawing.Color.IndianRed;
            this.tbYearRelease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYearRelease.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbYearRelease.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbYearRelease.Location = new System.Drawing.Point(132, 235);
            this.tbYearRelease.Name = "tbYearRelease";
            this.tbYearRelease.Size = new System.Drawing.Size(158, 19);
            this.tbYearRelease.TabIndex = 2;
            this.tbYearRelease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(15, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Исполнитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(58, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Страна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(15, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Год альбома";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(63, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Лейбл";
            // 
            // tbGenre
            // 
            this.tbGenre.BackColor = System.Drawing.Color.IndianRed;
            this.tbGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGenre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbGenre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbGenre.Location = new System.Drawing.Point(132, 271);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(158, 19);
            this.tbGenre.TabIndex = 2;
            this.tbGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.tbGenre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbYearRelease);
            this.panel2.Controls.Add(this.lblAlbum);
            this.panel2.Controls.Add(this.tbYearAlbum);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbArtist);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbCountry);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbLabel);
            this.panel2.Location = new System.Drawing.Point(33, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 323);
            this.panel2.TabIndex = 5;
            // 
            // pnImage
            // 
            this.pnImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.pnImage.Controls.Add(this.pbAlbum);
            this.pnImage.Location = new System.Drawing.Point(343, 38);
            this.pnImage.Name = "pnImage";
            this.pnImage.Size = new System.Drawing.Size(268, 268);
            this.pnImage.TabIndex = 6;
            // 
            // pbAlbum
            // 
            this.pbAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbAlbum.BackColor = System.Drawing.Color.Transparent;
            this.pbAlbum.Location = new System.Drawing.Point(19, 19);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(230, 230);
            this.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlbum.TabIndex = 1;
            this.pbAlbum.TabStop = false;
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnChangeImage.FlatAppearance.BorderSize = 0;
            this.btnChangeImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnChangeImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeImage.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangeImage.Location = new System.Drawing.Point(390, 312);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(174, 49);
            this.btnChangeImage.TabIndex = 1;
            this.btnChangeImage.Text = "Изменить обложку";
            this.btnChangeImage.UseVisualStyleBackColor = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(390, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 49);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VinylMusicStore.Properties.Resources.radgradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 447);
            this.Controls.Add(this.pnImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTracks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.btnAddTracks);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(686, 486);
            this.Name = "AlbumForm";
            this.Text = "Альбом";
            this.Activated += new System.EventHandler(this.AlbumForm_Activated);
            this.Load += new System.EventHandler(this.AlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.Button btnAddTracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Track;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.TextBox tbLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbYearAlbum;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox tbYearRelease;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.PictureBox pbAlbum;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnSave;
    }
}