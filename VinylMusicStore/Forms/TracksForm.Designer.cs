namespace VinylMusicStore.Forms
{
    partial class TracksForm
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
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.IdTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.SuspendLayout();
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
            this.dgvTracks.Location = new System.Drawing.Point(53, 13);
            this.dgvTracks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.RowHeadersWidth = 51;
            this.dgvTracks.Size = new System.Drawing.Size(681, 368);
            this.dgvTracks.TabIndex = 5;
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(611, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 42);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TracksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvTracks);
            this.Name = "TracksForm";
            this.Text = "Треки";
            this.Load += new System.EventHandler(this.TracksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Button btnBack;
    }
}