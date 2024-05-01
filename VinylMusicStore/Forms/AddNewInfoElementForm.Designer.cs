namespace VinylMusicStore.Forms
{
    partial class AddNewInfoElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewInfoElementForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblOptional = new System.Windows.Forms.Label();
            this.tbOptional = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(59, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.MaximumSize = new System.Drawing.Size(130, 0);
            this.lblTitle.MinimumSize = new System.Drawing.Size(130, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMain
            // 
            this.tbMain.BackColor = System.Drawing.Color.IndianRed;
            this.tbMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMain.Location = new System.Drawing.Point(101, 53);
            this.tbMain.Margin = new System.Windows.Forms.Padding(2);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(131, 19);
            this.tbMain.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(222, 174);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.lblMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMain.Location = new System.Drawing.Point(16, 53);
            this.lblMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMain.MaximumSize = new System.Drawing.Size(70, 0);
            this.lblMain.MinimumSize = new System.Drawing.Size(70, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(70, 18);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "label1";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOptional
            // 
            this.lblOptional.AutoSize = true;
            this.lblOptional.BackColor = System.Drawing.Color.Transparent;
            this.lblOptional.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.lblOptional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOptional.Location = new System.Drawing.Point(16, 86);
            this.lblOptional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOptional.MaximumSize = new System.Drawing.Size(70, 0);
            this.lblOptional.MinimumSize = new System.Drawing.Size(70, 0);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(70, 18);
            this.lblOptional.TabIndex = 0;
            this.lblOptional.Text = "label1";
            this.lblOptional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbOptional
            // 
            this.tbOptional.BackColor = System.Drawing.Color.IndianRed;
            this.tbOptional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOptional.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbOptional.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbOptional.Location = new System.Drawing.Point(101, 86);
            this.tbOptional.Margin = new System.Windows.Forms.Padding(2);
            this.tbOptional.Name = "tbOptional";
            this.tbOptional.Size = new System.Drawing.Size(131, 19);
            this.tbOptional.TabIndex = 1;
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
            this.btnBack.Location = new System.Drawing.Point(12, 174);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 36);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.tbMain);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblMain);
            this.panel1.Controls.Add(this.tbOptional);
            this.panel1.Controls.Add(this.lblOptional);
            this.panel1.Location = new System.Drawing.Point(44, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 124);
            this.panel1.TabIndex = 9;
            // 
            // AddNewInfoElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VinylMusicStore.Properties.Resources.radgradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 222);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddNewInfoElementForm";
            this.Text = "Добавление";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblOptional;
        private System.Windows.Forms.TextBox tbOptional;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}