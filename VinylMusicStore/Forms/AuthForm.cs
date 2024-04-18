using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
