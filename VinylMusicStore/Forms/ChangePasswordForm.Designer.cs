namespace VinylMusicStore.Forms
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.btnChange = new System.Windows.Forms.Button();
            this.tbConfPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Location = new System.Drawing.Point(158, 210);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(128, 42);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Обновить";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tbConfPassword
            // 
            this.tbConfPassword.BackColor = System.Drawing.Color.IndianRed;
            this.tbConfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbConfPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbConfPassword.Location = new System.Drawing.Point(156, 95);
            this.tbConfPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbConfPassword.Name = "tbConfPassword";
            this.tbConfPassword.Size = new System.Drawing.Size(142, 19);
            this.tbConfPassword.TabIndex = 7;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.BackColor = System.Drawing.Color.IndianRed;
            this.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbNewPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNewPassword.Location = new System.Drawing.Point(156, 57);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(142, 19);
            this.tbNewPassword.TabIndex = 8;
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.BackColor = System.Drawing.Color.IndianRed;
            this.tbOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOldPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbOldPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbOldPassword.Location = new System.Drawing.Point(156, 28);
            this.tbOldPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(142, 19);
            this.tbOldPassword.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Подтверждение\r\nнового пароля";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Новый пароль";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPassword.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.lblOldPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOldPassword.Location = new System.Drawing.Point(20, 28);
            this.lblOldPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(117, 18);
            this.lblOldPassword.TabIndex = 4;
            this.lblOldPassword.Text = "Старый пароль";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.tbConfPassword);
            this.panel1.Controls.Add(this.lblOldPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNewPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbOldPassword);
            this.panel1.Location = new System.Drawing.Point(54, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 152);
            this.panel1.TabIndex = 11;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VinylMusicStore.Properties.Resources.radgradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChange);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.Text = "Изменение пароля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePasswordForm_FormClosed);
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox tbConfPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Panel panel1;
    }
}