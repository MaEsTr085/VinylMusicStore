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
    public partial class ChangePasswordForm : Form
    {
        Registration registration = new Registration();
        UsersFromDB usersFromDB = new UsersFromDB();
        private bool recover = false;

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public ChangePasswordForm(bool recover = false)
        {
            InitializeComponent();

            this.recover = recover;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (recover)
            {
                if (tbNewPassword.Text == tbConfPassword.Text && registration.CheckPassword(tbNewPassword.Text, tbConfPassword.Text))
                {
                    usersFromDB.UpdatePassword(Verification.GetSHA512Hash(tbNewPassword.Text), AuthForm.currentUser.UserId);

                    this.Close();
                    Application.OpenForms[0].Show();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают или не соответствуют требованиям");
                }
            }
            else
            {
                if (Verification.GetSHA512Hash(tbOldPassword.Text) == AuthForm.currentUser.Password)
                {
                    if (tbNewPassword.Text == tbConfPassword.Text && registration.CheckPassword(tbNewPassword.Text, tbConfPassword.Text))
                    {
                        usersFromDB.UpdatePassword(Verification.GetSHA512Hash(tbNewPassword.Text), AuthForm.currentUser.UserId);
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают или не соответствуют требованиям");
                    }
                }
                else
                {
                    MessageBox.Show("Текущий пароль не совпадает с веденным");
                }
            }
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            if (recover)
            {
                lblOldPassword.Visible = false;
                tbOldPassword.Visible = false;
            }
        }
    }
}
