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
            this.panelReceipt.Location = new System.Drawing.Point(72, 12);
            this.panelReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new System.Drawing.Size(381, 647);
            this.panelReceipt.TabIndex = 0;
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(96, 69);
            this.pbQRCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(200, 199);
            this.pbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQRCode.TabIndex = 1;
            this.pbQRCode.TabStop = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(181, 519);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(81, 16);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "lblDateTime";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(181, 546);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "www.nalog.ru";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(144, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Кассовый чек";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Спасибо за покупку!";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(181, 490);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(83, 16);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "lblEmployee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дата Время";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 546);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Сайт ФНС";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(181, 463);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(48, 16);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "lblSum";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Кассир";
            // 
            // lblFPD
            // 
            this.lblFPD.AutoSize = true;
            this.lblFPD.Location = new System.Drawing.Point(181, 428);
            this.lblFPD.Name = "lblFPD";
            this.lblFPD.Size = new System.Drawing.Size(48, 16);
            this.lblFPD.TabIndex = 0;
            this.lblFPD.Text = "lblFPD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Сумма";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "ФПД";
            // 
            // lblFD
            // 
            this.lblFD.AutoSize = true;
            this.lblFD.Location = new System.Drawing.Point(181, 386);
            this.lblFD.Name = "lblFD";
            this.lblFD.Size = new System.Drawing.Size(39, 16);
            this.lblFD.TabIndex = 0;
            this.lblFD.Text = "lblFD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "ФД №";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(181, 347);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(39, 16);
            this.lblFN.TabIndex = 0;
            this.lblFN.Text = "lblFN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ФН №";
            // 
            // lblReceiptNum
            // 
            this.lblReceiptNum.AutoSize = true;
            this.lblReceiptNum.Location = new System.Drawing.Point(181, 302);
            this.lblReceiptNum.Name = "lblReceiptNum";
            this.lblReceiptNum.Size = new System.Drawing.Size(14, 16);
            this.lblReceiptNum.TabIndex = 0;
            this.lblReceiptNum.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер чека";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(59, 686);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(141, 41);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Распечатать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(353, 686);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddInDB
            // 
            this.btnAddInDB.Location = new System.Drawing.Point(206, 686);
            this.btnAddInDB.Name = "btnAddInDB";
            this.btnAddInDB.Size = new System.Drawing.Size(141, 41);
            this.btnAddInDB.TabIndex = 2;
            this.btnAddInDB.Text = "Добавить в базу";
            this.btnAddInDB.UseVisualStyleBackColor = true;
            this.btnAddInDB.Click += new System.EventHandler(this.btnAddInDB_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 754);
            this.Controls.Add(this.btnAddInDB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelReceipt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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