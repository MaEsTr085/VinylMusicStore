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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.gbCode = new System.Windows.Forms.GroupBox();
            this.tbCheckNum4 = new System.Windows.Forms.TextBox();
            this.tbCheckNum3 = new System.Windows.Forms.TextBox();
            this.tbCheckNum2 = new System.Windows.Forms.TextBox();
            this.tbCheckNum1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEtherealEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEtherealPassword = new System.Windows.Forms.TextBox();
            this.gbCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(191, 12);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // btnSendCode
            // 
            this.btnSendCode.Location = new System.Drawing.Point(131, 176);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(120, 42);
            this.btnSendCode.TabIndex = 2;
            this.btnSendCode.Text = "Отправить код";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Укажите почту \r\nдля подтверждения";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(191, 57);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 1;
            // 
            // gbCode
            // 
            this.gbCode.Controls.Add(this.tbCheckNum4);
            this.gbCode.Controls.Add(this.tbCheckNum3);
            this.gbCode.Controls.Add(this.tbCheckNum2);
            this.gbCode.Controls.Add(this.tbCheckNum1);
            this.gbCode.Controls.Add(this.label3);
            this.gbCode.Location = new System.Drawing.Point(95, 238);
            this.gbCode.Name = "gbCode";
            this.gbCode.Size = new System.Drawing.Size(199, 99);
            this.gbCode.TabIndex = 3;
            this.gbCode.TabStop = false;
            // 
            // tbCheckNum4
            // 
            this.tbCheckNum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheckNum4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCheckNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckNum4.Location = new System.Drawing.Point(140, 39);
            this.tbCheckNum4.MaxLength = 1;
            this.tbCheckNum4.Name = "tbCheckNum4";
            this.tbCheckNum4.Size = new System.Drawing.Size(28, 29);
            this.tbCheckNum4.TabIndex = 0;
            this.tbCheckNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCheckNum4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheckNum4_KeyPress);
            this.tbCheckNum4.Leave += new System.EventHandler(this.tbCheckNum4_Leave);
            // 
            // tbCheckNum3
            // 
            this.tbCheckNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheckNum3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCheckNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckNum3.Location = new System.Drawing.Point(106, 39);
            this.tbCheckNum3.MaxLength = 1;
            this.tbCheckNum3.Name = "tbCheckNum3";
            this.tbCheckNum3.Size = new System.Drawing.Size(28, 29);
            this.tbCheckNum3.TabIndex = 0;
            this.tbCheckNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCheckNum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheckNum3_KeyPress);
            // 
            // tbCheckNum2
            // 
            this.tbCheckNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheckNum2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCheckNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckNum2.Location = new System.Drawing.Point(72, 39);
            this.tbCheckNum2.MaxLength = 1;
            this.tbCheckNum2.Name = "tbCheckNum2";
            this.tbCheckNum2.Size = new System.Drawing.Size(28, 29);
            this.tbCheckNum2.TabIndex = 0;
            this.tbCheckNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCheckNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheckNum2_KeyPress);
            // 
            // tbCheckNum1
            // 
            this.tbCheckNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheckNum1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCheckNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCheckNum1.Location = new System.Drawing.Point(38, 39);
            this.tbCheckNum1.MaxLength = 1;
            this.tbCheckNum1.Name = "tbCheckNum1";
            this.tbCheckNum1.Size = new System.Drawing.Size(28, 29);
            this.tbCheckNum1.TabIndex = 0;
            this.tbCheckNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCheckNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCheckNum1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Код подтверждения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "(клиент) Укажите почту ethereal";
            // 
            // tbEtherealEmail
            // 
            this.tbEtherealEmail.Location = new System.Drawing.Point(191, 101);
            this.tbEtherealEmail.Name = "tbEtherealEmail";
            this.tbEtherealEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEtherealEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "(клиент) Укажите пароль ethereal";
            // 
            // tbEtherealPassword
            // 
            this.tbEtherealPassword.Location = new System.Drawing.Point(191, 127);
            this.tbEtherealPassword.Name = "tbEtherealPassword";
            this.tbEtherealPassword.Size = new System.Drawing.Size(100, 20);
            this.tbEtherealPassword.TabIndex = 1;
            // 
            // RecoverPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 376);
            this.Controls.Add(this.gbCode);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEtherealPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEtherealEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.Name = "RecoverPasswordForm";
            this.Text = "Восстановление пароля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecoverPasswordForm_FormClosed);
            this.gbCode.ResumeLayout(false);
            this.gbCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.GroupBox gbCode;
        private System.Windows.Forms.TextBox tbCheckNum1;
        private System.Windows.Forms.TextBox tbCheckNum4;
        private System.Windows.Forms.TextBox tbCheckNum3;
        private System.Windows.Forms.TextBox tbCheckNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEtherealEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEtherealPassword;
    }
}