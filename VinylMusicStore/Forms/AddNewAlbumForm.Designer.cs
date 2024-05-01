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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewAlbumForm));
            this.tcNewAlbum = new System.Windows.Forms.TabControl();
            this.albumTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbLabel = new System.Windows.Forms.TextBox();
            this.tbYearAlbum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYearRelease = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddAlbumImage = new System.Windows.Forms.Button();
            this.btnAddNewAlbum = new System.Windows.Forms.Button();
            this.btnTracksTab = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbAlbumImage = new System.Windows.Forms.PictureBox();
            this.tracksTabPage = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tcNewAlbum.SuspendLayout();
            this.albumTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumImage)).BeginInit();
            this.tracksTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // tcNewAlbum
            // 
            this.tcNewAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcNewAlbum.Controls.Add(this.albumTabPage);
            this.tcNewAlbum.Controls.Add(this.tracksTabPage);
            this.tcNewAlbum.Location = new System.Drawing.Point(-4, -2);
            this.tcNewAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcNewAlbum.Name = "tcNewAlbum";
            this.tcNewAlbum.SelectedIndex = 0;
            this.tcNewAlbum.Size = new System.Drawing.Size(683, 565);
            this.tcNewAlbum.TabIndex = 18;
            // 
            // albumTabPage
            // 
            this.albumTabPage.BackgroundImage = global::VinylMusicStore.Properties.Resources.radgradient;
            this.albumTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumTabPage.Controls.Add(this.panel1);
            this.albumTabPage.Controls.Add(this.button1);
            this.albumTabPage.Controls.Add(this.btnAddAlbumImage);
            this.albumTabPage.Controls.Add(this.btnAddNewAlbum);
            this.albumTabPage.Controls.Add(this.btnTracksTab);
            this.albumTabPage.Controls.Add(this.btnCreateNew);
            this.albumTabPage.Controls.Add(this.label8);
            this.albumTabPage.Controls.Add(this.lbItems);
            this.albumTabPage.Controls.Add(this.label9);
            this.albumTabPage.Controls.Add(this.panel2);
            this.albumTabPage.Location = new System.Drawing.Point(4, 22);
            this.albumTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.albumTabPage.Name = "albumTabPage";
            this.albumTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.albumTabPage.Size = new System.Drawing.Size(675, 539);
            this.albumTabPage.TabIndex = 0;
            this.albumTabPage.Text = "Информация об альбоме";
            this.albumTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.tbGenre);
            this.panel1.Controls.Add(this.tbArtist);
            this.panel1.Controls.Add(this.tbAlbum);
            this.panel1.Controls.Add(this.tbLabel);
            this.panel1.Controls.Add(this.tbYearAlbum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbYearRelease);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(34, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 249);
            this.panel1.TabIndex = 19;
            // 
            // tbGenre
            // 
            this.tbGenre.BackColor = System.Drawing.Color.IndianRed;
            this.tbGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGenre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbGenre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbGenre.Location = new System.Drawing.Point(171, 195);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(190, 19);
            this.tbGenre.TabIndex = 9;
            this.tbGenre.TextChanged += new System.EventHandler(this.tbGenre_TextChanged);
            this.tbGenre.Enter += new System.EventHandler(this.tbGenre_Enter);
            this.tbGenre.Leave += new System.EventHandler(this.tbGenre_Leave);
            // 
            // tbArtist
            // 
            this.tbArtist.BackColor = System.Drawing.Color.IndianRed;
            this.tbArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArtist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbArtist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbArtist.Location = new System.Drawing.Point(171, 91);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(190, 19);
            this.tbArtist.TabIndex = 12;
            this.tbArtist.TextChanged += new System.EventHandler(this.tbArtist_TextChanged);
            this.tbArtist.Enter += new System.EventHandler(this.tbArtist_Enter);
            this.tbArtist.Leave += new System.EventHandler(this.tbArtist_Leave);
            // 
            // tbAlbum
            // 
            this.tbAlbum.BackColor = System.Drawing.Color.IndianRed;
            this.tbAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAlbum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAlbum.Location = new System.Drawing.Point(171, 66);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(190, 19);
            this.tbAlbum.TabIndex = 12;
            this.tbAlbum.TextChanged += new System.EventHandler(this.tbArtist_TextChanged);
            // 
            // tbLabel
            // 
            this.tbLabel.BackColor = System.Drawing.Color.IndianRed;
            this.tbLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbLabel.Location = new System.Drawing.Point(171, 117);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(190, 19);
            this.tbLabel.TabIndex = 13;
            this.tbLabel.TextChanged += new System.EventHandler(this.tbLabel_TextChanged);
            this.tbLabel.Enter += new System.EventHandler(this.tbLabel_Enter);
            this.tbLabel.Leave += new System.EventHandler(this.tbLabel_Leave);
            // 
            // tbYearAlbum
            // 
            this.tbYearAlbum.BackColor = System.Drawing.Color.IndianRed;
            this.tbYearAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYearAlbum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbYearAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbYearAlbum.Location = new System.Drawing.Point(171, 143);
            this.tbYearAlbum.Name = "tbYearAlbum";
            this.tbYearAlbum.Size = new System.Drawing.Size(190, 19);
            this.tbYearAlbum.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(134, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Новый альбом";
            // 
            // tbYearRelease
            // 
            this.tbYearRelease.BackColor = System.Drawing.Color.IndianRed;
            this.tbYearRelease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYearRelease.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbYearRelease.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbYearRelease.Location = new System.Drawing.Point(171, 169);
            this.tbYearRelease.Name = "tbYearRelease";
            this.tbYearRelease.Size = new System.Drawing.Size(190, 19);
            this.tbYearRelease.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(119, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(75, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Год релиза";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(64, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Исполнитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(112, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Лейбл";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(22, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Название альбома";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(62, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Год альбома";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddAlbumImage
            // 
            this.btnAddAlbumImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAlbumImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAddAlbumImage.FlatAppearance.BorderSize = 0;
            this.btnAddAlbumImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnAddAlbumImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnAddAlbumImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlbumImage.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAddAlbumImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddAlbumImage.Location = new System.Drawing.Point(32, 303);
            this.btnAddAlbumImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAlbumImage.Name = "btnAddAlbumImage";
            this.btnAddAlbumImage.Size = new System.Drawing.Size(149, 55);
            this.btnAddAlbumImage.TabIndex = 16;
            this.btnAddAlbumImage.Text = "Добавить изображение";
            this.btnAddAlbumImage.UseVisualStyleBackColor = false;
            this.btnAddAlbumImage.Click += new System.EventHandler(this.btnAddAlbumImage_Click);
            // 
            // btnAddNewAlbum
            // 
            this.btnAddNewAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAddNewAlbum.FlatAppearance.BorderSize = 0;
            this.btnAddNewAlbum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnAddNewAlbum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnAddNewAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAlbum.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAddNewAlbum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewAlbum.Location = new System.Drawing.Point(498, 465);
            this.btnAddNewAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewAlbum.Name = "btnAddNewAlbum";
            this.btnAddNewAlbum.Size = new System.Drawing.Size(163, 58);
            this.btnAddNewAlbum.TabIndex = 16;
            this.btnAddNewAlbum.Text = "Добавить новый альбом";
            this.btnAddNewAlbum.UseVisualStyleBackColor = false;
            this.btnAddNewAlbum.Click += new System.EventHandler(this.btnAddNewAlbum_Click);
            // 
            // btnTracksTab
            // 
            this.btnTracksTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTracksTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnTracksTab.FlatAppearance.BorderSize = 0;
            this.btnTracksTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnTracksTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnTracksTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTracksTab.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnTracksTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTracksTab.Location = new System.Drawing.Point(498, 393);
            this.btnTracksTab.Margin = new System.Windows.Forms.Padding(2);
            this.btnTracksTab.Name = "btnTracksTab";
            this.btnTracksTab.Size = new System.Drawing.Size(163, 58);
            this.btnTracksTab.TabIndex = 16;
            this.btnTracksTab.Text = "Добавить треки";
            this.btnTracksTab.UseVisualStyleBackColor = false;
            this.btnTracksTab.Click += new System.EventHandler(this.btnTracksTab_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnCreateNew.FlatAppearance.BorderSize = 0;
            this.btnCreateNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCreateNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNew.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnCreateNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateNew.Location = new System.Drawing.Point(490, 266);
            this.btnCreateNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(153, 45);
            this.btnCreateNew.TabIndex = 16;
            this.btnCreateNew.Text = "Создать новый";
            this.btnCreateNew.UseVisualStyleBackColor = false;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(39, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Обложка альбома";
            // 
            // lbItems
            // 
            this.lbItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbItems.BackColor = System.Drawing.Color.Maroon;
            this.lbItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbItems.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 18;
            this.lbItems.Location = new System.Drawing.Point(422, 25);
            this.lbItems.Margin = new System.Windows.Forms.Padding(2);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(221, 200);
            this.lbItems.TabIndex = 17;
            this.lbItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbItems_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(464, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Нет нужного элемента?";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pbAlbumImage);
            this.panel2.Location = new System.Drawing.Point(187, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 230);
            this.panel2.TabIndex = 20;
            // 
            // pbAlbumImage
            // 
            this.pbAlbumImage.BackColor = System.Drawing.Color.Transparent;
            this.pbAlbumImage.Image = global::VinylMusicStore.Properties.Resources.vinyl;
            this.pbAlbumImage.Location = new System.Drawing.Point(15, 15);
            this.pbAlbumImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbAlbumImage.Name = "pbAlbumImage";
            this.pbAlbumImage.Size = new System.Drawing.Size(200, 200);
            this.pbAlbumImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlbumImage.TabIndex = 15;
            this.pbAlbumImage.TabStop = false;
            this.pbAlbumImage.Click += new System.EventHandler(this.pbAlbumImage_Click);
            // 
            // tracksTabPage
            // 
            this.tracksTabPage.BackgroundImage = global::VinylMusicStore.Properties.Resources.radgradient;
            this.tracksTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tracksTabPage.Controls.Add(this.btnBack);
            this.tracksTabPage.Controls.Add(this.dgvTracks);
            this.tracksTabPage.Controls.Add(this.label7);
            this.tracksTabPage.Location = new System.Drawing.Point(4, 22);
            this.tracksTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.tracksTabPage.Name = "tracksTabPage";
            this.tracksTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.tracksTabPage.Size = new System.Drawing.Size(675, 539);
            this.tracksTabPage.TabIndex = 1;
            this.tracksTabPage.Text = "Список треков";
            this.tracksTabPage.UseVisualStyleBackColor = true;
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
            this.btnBack.Location = new System.Drawing.Point(12, 480);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 48);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Вернуться";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvTracks
            // 
            this.dgvTracks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.TrackName,
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
            this.dgvTracks.Location = new System.Drawing.Point(62, 58);
            this.dgvTracks.Margin = new System.Windows.Forms.Padding(2);
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
            this.dgvTracks.RowTemplate.Height = 24;
            this.dgvTracks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTracks.Size = new System.Drawing.Size(551, 373);
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
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(256, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Добавление треков";
            // 
            // AddNewAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(672, 555);
            this.Controls.Add(this.tcNewAlbum);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(688, 594);
            this.Name = "AddNewAlbumForm";
            this.Text = "Добавление нового альбома";
            this.Load += new System.EventHandler(this.AddNewAlbumForm_Load);
            this.tcNewAlbum.ResumeLayout(false);
            this.albumTabPage.ResumeLayout(false);
            this.albumTabPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbumImage)).EndInit();
            this.tracksTabPage.ResumeLayout(false);
            this.tracksTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}