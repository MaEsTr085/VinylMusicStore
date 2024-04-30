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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblOptional = new System.Windows.Forms.Label();
            this.tbOptional = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(116, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(118, 53);
            this.tbMain.Margin = new System.Windows.Forms.Padding(2);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(106, 20);
            this.tbMain.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(55, 119);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(63, 55);
            this.lblMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(35, 13);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "label1";
            // 
            // lblOptional
            // 
            this.lblOptional.AutoSize = true;
            this.lblOptional.Location = new System.Drawing.Point(63, 88);
            this.lblOptional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(35, 13);
            this.lblOptional.TabIndex = 0;
            this.lblOptional.Text = "label1";
            // 
            // tbOptional
            // 
            this.tbOptional.Location = new System.Drawing.Point(118, 85);
            this.tbOptional.Margin = new System.Windows.Forms.Padding(2);
            this.tbOptional.Name = "tbOptional";
            this.tbOptional.Size = new System.Drawing.Size(106, 20);
            this.tbOptional.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBack.Location = new System.Drawing.Point(154, 119);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 28);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Закрыть";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddNewInfoElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 168);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbOptional);
            this.Controls.Add(this.lblOptional);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddNewInfoElementForm";
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblOptional;
        private System.Windows.Forms.TextBox tbOptional;
        private System.Windows.Forms.Button btnBack;
    }
}