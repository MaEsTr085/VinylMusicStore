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
    public partial class AddNewEmployeeForm : Form
    {
        PostsFromDB postsFromDB = new PostsFromDB();
        List<Post> posts = new List<Post>();

        public AddNewEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddNewEmployeeForm_Load(object sender, EventArgs e)
        {
            posts = postsFromDB.GetPosts();
            for (int i = 0; i < posts.Count; i++)
            {
                if (posts[i].PostName == "Администратор")
                {
                    posts.RemoveAt(i);
                }
            }
            cbPosts.DisplayMember = "PostName";
            cbPosts.DataSource = posts;
        }

        private void btnGenPassword_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            string password = registration.GeneratePassword();
            tbPassword.Text = password;
            tbRepPassword.Text = password;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            if (tbSurname.Text == "" || tbName.Text == "" || tbPatronymic.Text == "" || tbPasport.Text == "" || tbLogin.Text == "" || tbPassword.Text == "" || tbRepPassword.Text == "" || 
                cbPosts.Text == "" || tbPayment.Text == "" || tbWorkExp.Text == "" || tbPhone.Text == "" || tbWorkSchedule.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            double minExp = posts[posts.IndexOf((Post)cbPosts.SelectedItem)].MinExp;
            if (minExp > double.Parse(tbWorkExp.Text)) {
                MessageBox.Show("Опыт работы меньше минимального на данную должность");
                return;
            }
            int employeeCount = registration.GetEmployeeCountForPost(cbPosts.Text);
            int postEmployeeCount = posts[posts.IndexOf((Post)cbPosts.SelectedItem)].MaxCountEmp;
            if (employeeCount == postEmployeeCount)
            {
                MessageBox.Show("Достигнут максимум количества сотрудников на данную должность!");
                return;
            }
            bool rez = registration.CheckPassword(tbPassword.Text, tbRepPassword.Text);
            if (!rez) return;
            else
            {
                if (registration.CheckUser(tbLogin.Text))
                {
                    if (posts[posts.IndexOf((Post)cbPosts.SelectedItem)].HasUser)
                    {
                        registration.AddEmployeeNUser(tbPasport.Text, tbName.Text + " " + tbSurname.Text + " " + tbPatronymic.Text, int.Parse(tbWorkExp.Text), 
                            cbPosts.Text, decimal.Parse(tbPayment.Text), DateTime.Now, tbPhone.Text, tbWorkSchedule.Text, tbLogin.Text, tbPassword.Text);
                    }
                    else
                    {
                        registration.AddEmployee(tbPasport.Text, tbName.Text + " " + tbSurname.Text + " " + tbPatronymic.Text, int.Parse(tbWorkExp.Text),
                            cbPosts.Text, decimal.Parse(tbPayment.Text), DateTime.Now, tbPhone.Text, tbWorkSchedule.Text);
                    }
                }
                else
                    return;
            }

            this.Close();
        }
    }
}
