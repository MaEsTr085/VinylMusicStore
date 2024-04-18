using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using VinylMusicStore.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VinylMusicStore.Forms
{
    public partial class ReceiptForm : Form
    {
        UsersFromDB usersFromDB = new UsersFromDB();
        Random rnd = new Random();

        private string fullSum;

        public ReceiptForm(string fullSum)
        {
            InitializeComponent();
            this.fullSum = fullSum;
        }

        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int width, height;
            width = panelReceipt.Width;
            height = panelReceipt.Height;
            Bitmap receipt = new Bitmap(width, height);
            panelReceipt.DrawToBitmap(receipt, panelReceipt.ClientRectangle);
            saveFileDialog.Title = "Save Your File Here";
            saveFileDialog.Filter = "png image files (*.png)|*.png|jpg image files (*.jpg)|*.jpg";
            saveFileDialog.ShowDialog();
            receipt.Save(saveFileDialog.FileName);
            this.Close();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            GenerateRequisite();

            lblSum.Text = fullSum;

            lblEmployee.Text = usersFromDB.GetUserById(AuthForm.currentUser.UserId);

            lblDateTime.Text = DateTime.Now.ToString();

            string qrtext = "123456";
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(qrtext);
            pbQRCode.Image = qrcode as Image;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateRequisite()
        {
            string FN = "";

            string FD = "";

            string FPD = "";

            for (int i = 0; i < 16; i++)
                FN += rnd.Next(0, 10).ToString();

            for (int i = 0; i < 10; i++)
                FD += rnd.Next(0, 10).ToString();

            for (int i = 0; i < 10; i++)
                FPD += rnd.Next(0, 10).ToString();

            lblFN.Text = FN;
            lblFD.Text = FD;
            lblFPD.Text = FPD;
        }
    }
}
