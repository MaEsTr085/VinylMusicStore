using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;
using VinylMusicStore.Model;

namespace VinylMusicStore.Forms
{
    public partial class AuthForm : Form
    {
        UsersFromDB usersFromDB = new UsersFromDB();
        public static User currentUser = null;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (!(tbLogin.Text != "" && tbPassword.Text != ""))
            {
                MessageBox.Show("Введите данные");
                return;
            }
            else
            {
                currentUser = usersFromDB.GetUser(tbLogin.Text, tbPassword.Text);
                if (currentUser != null)
                {
                    tbPassword.Text = "";
                    tbLogin.Text = "";
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Нет такого пользователя");
                }
            }
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPassword.Focus();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAuth.Focus();
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            RecoverPasswordForm recoverPasswordForm = new RecoverPasswordForm();
            recoverPasswordForm.Show();
            this.Hide();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            tbLogin.Focus();
        }
    }
}
