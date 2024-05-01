namespace VinylMusicStore.Forms
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.panelReceipt = new System.Windows.Forms.Panel();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFPD = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReceiptNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddInDB = new System.Windows.Forms.Button();
            this.panelReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReceipt
            // 
            this.panelReceipt.BackColor = System.Drawing.Color.White;
            this.panelReceipt.Controls.Add(this.pbQRCode);
            this.panelReceipt.Controls.Add(this.lblDateTime);
            this.panelReceipt.Controls.Add(this.label15);
            this.panelReceipt.Controls.Add(this.label16);
            this.panelReceipt.Controls.Add(this.label1);
            this.panelReceipt.Controls.Add(this.lblEmployee);
            this.panelReceipt.Controls.Add(this.label5);
            this.panelReceipt.Controls.Add(this.label14);
            this.panelReceipt.Controls.Add(this.lblSum);
            this.panelReceipt.Controls.Add(this.label12);
            this.panelReceipt.Controls.Add(this.lblFPD);
            this.panelReceipt.Controls.Add(this.label10);
            this.panelReceipt.Controls.Add(this.label8);
            this.panelReceipt.Controls.Add(this.lblFD);
            this.panelReceipt.Controls.Add(this.label6);
            this.panelReceipt.Controls.Add(this.lblFN);
            this.panelReceipt.Controls.Add(this.label4);
            this.panelReceipt.Controls.Add(this.lblReceiptNum);
            this.panelReceipt.Controls.Add(this.label2);
            this.panelReceipt.Location = new System.Drawing.Point(55, 21);
            this.panelReceipt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new System.Drawing.Size(286, 566);
            this.panelReceipt.TabIndex = 0;
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(68, 39);
            this.pbQRCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(150, 150);
            this.pbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQRCode.TabIndex = 1;
            this.pbQRCode.TabStop = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblDateTime.Location = new System.Drawing.Point(130, 440);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblDateTime.MinimumSize = new System.Drawing.Size(140, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(140, 15);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "lblDateTime";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label15.Location = new System.Drawing.Point(130, 478);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.MaximumSize = new System.Drawing.Size(140, 0);
            this.label15.MinimumSize = new System.Drawing.Size(140, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "www.nalog.ru";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F);
            this.label16.Location = new System.Drawing.Point(92, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Кассовый чек";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 531);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Спасибо за покупку!";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblEmployee.Location = new System.Drawing.Point(130, 402);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployee.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblEmployee.MinimumSize = new System.Drawing.Size(140, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(140, 15);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "lblEmployee";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label5.Location = new System.Drawing.Point(17, 440);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дата Время";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label14.Location = new System.Drawing.Point(17, 478);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Сайт ФНС";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblSum.Location = new System.Drawing.Point(130, 364);
            this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSum.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblSum.MinimumSize = new System.Drawing.Size(140, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(140, 15);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "lblSum";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label12.Location = new System.Drawing.Point(17, 402);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Кассир";
            // 
            // lblFPD
            // 
            this.lblFPD.AutoSize = true;
            this.lblFPD.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblFPD.Location = new System.Drawing.Point(130, 326);
            this.lblFPD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFPD.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblFPD.MinimumSize = new System.Drawing.Size(140, 0);
            this.lblFPD.Name = "lblFPD";
            this.lblFPD.Size = new System.Drawing.Size(140, 15);
            this.lblFPD.TabIndex = 0;
            this.lblFPD.Text = "lblFPD";
            this.lblFPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label10.Location = new System.Drawing.Point(17, 364);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Сумма";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label8.Location = new System.Drawing.Point(17, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "ФПД";
            // 
            // lblFD
            // 
            this.lblFD.AutoSize = true;
            this.lblFD.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblFD.Location = new System.Drawing.Point(130, 288);
            this.lblFD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFD.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblFD.MinimumSize = new System.Drawing.Size(140, 0);
            this.lblFD.Name = "lblFD";
            this.lblFD.Size = new System.Drawing.Size(140, 15);
            this.lblFD.TabIndex = 0;
            this.lblFD.Text = "lblFD";
            this.lblFD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label6.Location = new System.Drawing.Point(17, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "ФД №";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblFN.Location = new System.Drawing.Point(130, 250);
            this.lblFN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFN.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblFN.MinimumSize = new System.Drawing.Size(140, 0);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(140, 15);
            this.lblFN.TabIndex = 0;
            this.lblFN.Text = "lblFN";
            this.lblFN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label4.Location = new System.Drawing.Point(17, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ФН №";
            // 
            // lblReceiptNum
            // 
            this.lblReceiptNum.AutoSize = true;
            this.lblReceiptNum.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblReceiptNum.Location = new System.Drawing.Point(130, 212);
            this.lblReceiptNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiptNum.MaximumSize = new System.Drawing.Size(140, 0);
            this.lblReceiptNum.MinimumSize = new System.Drawing.Size(140, 0);
            this.lblReceiptNum.Name = "lblReceiptNum";
            this.lblReceiptNum.Size = new System.Drawing.Size(140, 15);
            this.lblReceiptNum.TabIndex = 0;
            this.lblReceiptNum.Text = "1";
            this.lblReceiptNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер чека";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(118, 608);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 36);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Распечатать";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(11, 608);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddInDB
            // 
            this.btnAddInDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAddInDB.FlatAppearance.BorderSize = 0;
            this.btnAddInDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnAddInDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(0)))));
            this.btnAddInDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInDB.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAddInDB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddInDB.Location = new System.Drawing.Point(239, 608);
            this.btnAddInDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddInDB.Name = "btnAddInDB";
            this.btnAddInDB.Size = new System.Drawing.Size(147, 36);
            this.btnAddInDB.TabIndex = 1;
            this.btnAddInDB.Text = "Добавить в базу";
            this.btnAddInDB.UseVisualStyleBackColor = false;
            this.btnAddInDB.Click += new System.EventHandler(this.btnAddInDB_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VinylMusicStore.Properties.Resources.radgradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(397, 655);
            this.Controls.Add(this.btnAddInDB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelReceipt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReceiptForm";
            this.Text = "Чек";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.panelReceipt.ResumeLayout(false);
            this.panelReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReceipt;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFPD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReceiptNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddInDB;
    }
}