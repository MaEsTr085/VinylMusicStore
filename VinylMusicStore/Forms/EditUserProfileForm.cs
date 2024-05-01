using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Model;

namespace VinylMusicStore.Forms
{
    public partial class EditUserProfileForm : Form
    {
        EmployeesFromDB employeesFromDB = new EmployeesFromDB();
        Employee editEmployee = null;

        public EditUserProfileForm()
        {
            InitializeComponent();
        }

        private void EditUserProfileForm_Load(object sender, EventArgs e)
        {
            editEmployee = employeesFromDB.GetEmployeeById(AuthForm.currentUser.Employee);

            string[] tmp = editEmployee.EmployeeFIO.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            lblCurUser.Text = tmp[1] + " " + tmp[0] + " - " + editEmployee.Login;

            tbSurname.Text = tmp[1];
            tbName.Text = tmp[0];
            tbPatronymic.Text = tmp[2];
            tbPasport.Text = editEmployee.Pasport;
            tbLogin.Text = editEmployee.Login;
            tbPhone.Text = editEmployee.Phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employeesFromDB.UpdateEmployeeNUser(editEmployee.EmployeeID, tbPasport.Text, tbName.Text + " " + tbSurname.Text + " " + tbPatronymic.Text, tbPhone.Text, tbLogin.Text);
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
