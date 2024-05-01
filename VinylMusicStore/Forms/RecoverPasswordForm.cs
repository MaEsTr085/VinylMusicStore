using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using VinylMusicStore.Model;

namespace VinylMusicStore.Forms
{
    public partial class RecoverPasswordForm : Form
    {
        UsersFromDB usersFromDB = new UsersFromDB();

        private int code = 0;

        public RecoverPasswordForm()
        {
            InitializeComponent();

            pnlCode.Visible = false;

            code = GenCode();
        }

        private void tbCheckNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            else
            {
                tbCheckNum2.Focus();
            }
        }

        private void tbCheckNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            else
            {
                tbCheckNum3.Focus();
            }
        }

        private void tbCheckNum3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;                
            }
            else
            {
                tbCheckNum4.Focus();
            }
        }

        private void tbCheckNum4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }            
        }

        private void RecoverPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbCheckNum4_Leave(object sender, EventArgs e)
        {
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            AuthForm.currentUser = usersFromDB.GetUserByLogin(tbLogin.Text);
            if (AuthForm.currentUser != null)
            {
                pnlCode.Visible = true;

                SendEmail(code, tbEmail.Text, tbEtherealEmail.Text, tbEtherealPassword.Text).GetAwaiter();

                MessageBox.Show("На заданную почту отправлен код подтверждения");
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует!");
            }
        }

        private int GenCode()
        {
            string code = "";

            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                code += rnd.Next(0, 10);
            }

            return int.Parse(code);
        }

        private async Task SendEmail(int code, string email, string etherealEmail, string etherealPassword)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("VinylMusicStore", etherealEmail));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = "Подтверждение смены пароля";
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = $"<h3>Код подтверждения:</h3> {code}"
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.ethereal.email", 587, false);
                await client.AuthenticateAsync(etherealEmail, etherealPassword); // ethereal.email
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }

        private void tbCheckNum4_TextChanged(object sender, EventArgs e)
        {
            if (tbCheckNum1.Text != "" && tbCheckNum2.Text != "" && tbCheckNum3.Text != "" && tbCheckNum4.Text != "")
            {
                int curCode = int.Parse(tbCheckNum1.Text + tbCheckNum2.Text + tbCheckNum3.Text + tbCheckNum4.Text);
                if (code == curCode)
                {
                    Thread.Sleep(1000);

                    tbCheckNum1.BackColor = ColorTranslator.FromHtml("#37B537");
                    tbCheckNum2.BackColor = ColorTranslator.FromHtml("#37B537");
                    tbCheckNum3.BackColor = ColorTranslator.FromHtml("#37B537");
                    tbCheckNum4.BackColor = ColorTranslator.FromHtml("#37B537");

                    tbCheckNum1.Refresh();
                    tbCheckNum2.Refresh();
                    tbCheckNum3.Refresh();
                    tbCheckNum4.Refresh();

                    Thread.Sleep(1000);

                    ChangePasswordForm changePasswordForm = new ChangePasswordForm(true);
                    changePasswordForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
