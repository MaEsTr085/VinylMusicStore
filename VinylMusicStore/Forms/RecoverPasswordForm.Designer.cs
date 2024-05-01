namespace VinylMusicStore.Forms
{
    partial class RecoverPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverPasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCheckNum4 = new System.Windows.Forms.TextBox();
            this.tbCheckNum3 = new System.Windows.Forms.TextBox();
            this.tbCheckNum2 = new System.Windows.Forms.TextBox();
            this.tbCheckNum1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEtherealEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEtherealPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCode = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите логин";
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.IndianRed;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbLogin.Location = new System.Drawing.Point(225, 19);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(143, 19);
            this.tbLogin.TabIndex = 1;
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnSendCode.FlatAppearance.BorderSize = 0;
            this.btnSendCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnSendCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCode.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnSendCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendCode.Location = new System.Drawing.Point(174, 236);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(157, 54);
            this.btnSendCode.TabIndex = 2;
            this.btnSendCode.Text = "Отправить код";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(70, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Укажите почту\r\nдля подтверждения";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.IndianRed;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbEmail.Location = new System.Drawing.Point(225, 61);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(143, 19);
            this.tbEmail.TabIndex = 1;
            // 
            // tbCheckNum4
            // 
            this.tbCheckNum4.BackColor = System.Drawing.Color.IndianRed;
            this.tbCheckNum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheckNum4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCheckNum4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckNum4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCheckNum4.Location = new System.Drawing.Point(137, 51);
            this.tbCheckNum4.MaxLength = 1;
            this.tbCheckNum4.Name = "tbCheckNum4";
            this.tbCheckNum4.Size = new System.Drawing.Size(28, 31);
            this.tbCheckNum4.TabIndex = 0;
            this.tbCheckNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCheckNum4.TextChanged += new System.EventHandler(this.tbCheckNum4_TextChanged);
            this.tbCheckNum4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheckNum4_KeyPress);
            this.tbCheckNum4.Leave += new System.EventHandler(this.tbCheckNum4_Leave);
            // 
            // tbCheckNum3
            // 
            this.tbCheckNum3.BackColor = System.Drawing.Color.IndianRed;
            this.tbCheckNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheckNum3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCheckNum3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckNum3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCheckNum3.Location = new System.Drawing.Point(103, 51);
            this.tbCheckNum3.MaxLength = 1;
            this.tbCheckNum3.Name = "tbCheckNum3";
            this.tbCheckNum3.Size = new System.Drawing.Size(28, 31);
            this.tbCheckNum3.TabIndex = 0;
            this.tbCheckNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCheckNum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheckNum3_KeyPress);
            // 
            // tbCheckNum2
            // 
            this.tbCheckNum2.BackColor = System.Drawing.Color.IndianRed;
            this.tbCheckNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheckNum2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCheckNum2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckNum2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCheckNum2.Location = new System.Drawing.Point(69, 51);
            this.tbCheckNum2.MaxLength = 1;
            this.tbCheckNum2.Name = "tbCheckNum2";
            this.tbCheckNum2.Size = new System.Drawing.Size(28, 31);
            this.tbCheckNum2.TabIndex = 0;
            this.tbCheckNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCheckNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheckNum2_KeyPress);
            // 
            // tbCheckNum1
            // 
            this.tbCheckNum1.BackColor = System.Drawing.Color.IndianRed;
            this.tbCheckNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheckNum1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCheckNum1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckNum1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbCheckNum1.Location = new System.Drawing.Point(35, 51);
            this.tbCheckNum1.MaxLength = 1;
            this.tbCheckNum1.Name = "tbCheckNum1";
            this.tbCheckNum1.Size = new System.Drawing.Size(28, 31);
            this.tbCheckNum1.TabIndex = 0;
            this.tbCheckNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCheckNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheckNum1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(25, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Код подтверждения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(45, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Укажите почту ethereal\r\n(Тестовое)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEtherealEmail
            // 
            this.tbEtherealEmail.BackColor = System.Drawing.Color.IndianRed;
            this.tbEtherealEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEtherealEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbEtherealEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbEtherealEmail.Location = new System.Drawing.Point(225, 112);
            this.tbEtherealEmail.Name = "tbEtherealEmail";
            this.tbEtherealEmail.Size = new System.Drawing.Size(143, 19);
            this.tbEtherealEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Concert One", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(34, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Укажите пароль ethereal\r\n(Тестовое)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEtherealPassword
            // 
            this.tbEtherealPassword.BackColor = System.Drawing.Color.IndianRed;
            this.tbEtherealPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEtherealPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbEtherealPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbEtherealPassword.Location = new System.Drawing.Point(225, 163);
            this.tbEtherealPassword.Name = "tbEtherealPassword";
            this.tbEtherealPassword.Size = new System.Drawing.Size(143, 19);
            this.tbEtherealPassword.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbLogin);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbEtherealEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbEtherealPassword);
            this.panel1.Location = new System.Drawing.Point(54, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 209);
            this.panel1.TabIndex = 4;
            // 
            // pnlCode
            // 
            this.pnlCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.pnlCode.Controls.Add(this.tbCheckNum4);
            this.pnlCode.Controls.Add(this.label3);
            this.pnlCode.Controls.Add(this.tbCheckNum3);
            this.pnlCode.Controls.Add(this.tbCheckNum1);
            this.pnlCode.Controls.Add(this.tbCheckNum2);
            this.pnlCode.Location = new System.Drawing.Point(155, 296);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(200, 100);
            this.pnlCode.TabIndex = 5;
            // 
            // RecoverPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VinylMusicStore.Properties.Resources.radgradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 417);
            this.Controls.Add(this.pnlCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSendCode);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecoverPasswordForm";
            this.Text = "Восстановление пароля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecoverPasswordForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCode.ResumeLayout(false);
            this.pnlCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCheckNum1;
        private System.Windows.Forms.TextBox tbCheckNum4;
        private System.Windows.Forms.TextBox tbCheckNum3;
        private System.Windows.Forms.TextBox tbCheckNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEtherealEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEtherealPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCode;
    }
}