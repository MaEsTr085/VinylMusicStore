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
    public partial class UsersForm : Form
    {
        EmployeesFromDB employeesFromDB = new EmployeesFromDB();
        List<Employee> employees = new List<Employee>();

        public UsersForm()
        {
            InitializeComponent();

            dgvEmployees.Columns[0].DataPropertyName = "EmployeeID";
            dgvEmployees.Columns[1].DataPropertyName = "EmployeeFIO";
            dgvEmployees.Columns[2].DataPropertyName = "Pasport";
            dgvEmployees.Columns[3].DataPropertyName = "Login";
            dgvEmployees.Columns[4].DataPropertyName = "Post";
            dgvEmployees.Columns[5].DataPropertyName = "WorkExp";
            dgvEmployees.Columns[6].DataPropertyName = "StartDate";
            dgvEmployees.Columns[7].DataPropertyName = "Phone";
            dgvEmployees.Columns[8].DataPropertyName = "WorkSchedule";

            dgvEmployees.Columns[0].Visible = false;
            dgvEmployees.Columns[2].Visible = false;
            dgvEmployees.Columns[5].Visible = false;
            dgvEmployees.Columns[6].Visible = false;
            dgvEmployees.Columns[7].Visible = false;
            dgvEmployees.Columns[8].Visible = false;
        }

        private void GetEmployees()
        {
            employees = employeesFromDB.GetEmployees();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Login == "")
                {
                    employees[i].Login = "-- Отсутствует --";
                }
            }
            dgvEmployees.DataSource = employees;

            string[] tmp = employees[0].EmployeeFIO.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            lblSurname.Text = tmp[1];
            lblName.Text = tmp[0];
            lblPatronymic.Text = tmp[2];
            lblLogin.Text = employees[0].Login;
            lblPost.Text = employees[0].Post;
            lblWorkExp.Text = employees[0].WorkExp.ToString();
            lblStartDate.Text = employees[0].StartDate.ToShortDateString();
            lblPhone.Text = employees[0].Phone;
            lblWorkSchedule.Text = employees[0].WorkSchedule;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            GetEmployees();
        }

        private Employee GetSelectedUser()
        {
            return (Employee)dgvEmployees.SelectedRows[0].DataBoundItem;
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int selectedEmployee = GetSelectedUser().EmployeeID;
                int currentID = 0;

                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].EmployeeID == selectedEmployee)
                    {
                        currentID = i;
                    }
                }
                string[] tmp = employees[currentID].EmployeeFIO.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                lblSurname.Text = tmp[1];
                lblName.Text = tmp[0];
                lblPatronymic.Text = tmp[2];
                lblLogin.Text = employees[currentID].Login;
                lblPost.Text = employees[currentID].Post;
                lblWorkExp.Text = employees[currentID].WorkExp.ToString();
                lblStartDate.Text = employees[currentID].StartDate.ToShortDateString();
                lblPhone.Text = employees[currentID].Phone;
                lblWorkSchedule.Text = employees[currentID].WorkSchedule;
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvEmployees.Rows[e.RowIndex].Selected = true;

            if (dgvEmployees.SelectedRows.Count > 0)
            {
                int selectedEmployee = GetSelectedUser().EmployeeID;
                int currentID = 0;

                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].EmployeeID == selectedEmployee)
                    {
                        currentID = i;
                    }
                }
                string[] tmp = employees[currentID].EmployeeFIO.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                lblSurname.Text = tmp[1];
                lblName.Text = tmp[0];
                lblPatronymic.Text = tmp[2];
                lblLogin.Text = employees[currentID].Login;
                lblPost.Text = employees[currentID].Post;
                lblWorkExp.Text = employees[currentID].WorkExp.ToString();
                lblStartDate.Text = employees[currentID].StartDate.ToShortDateString();
                lblPhone.Text = employees[currentID].Phone;
                lblWorkSchedule.Text = employees[currentID].WorkSchedule;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                if (GetSelectedUser().Post != "Администратор")
                {
                    string selectedEmployee = GetSelectedUser().EmployeeFIO;
                    string[] fio = selectedEmployee.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    DialogResult dialogResult = MessageBox.Show($"Вы уверены, что хотите удалить сотрудника {fio[1]} {fio[0]}?", "Удаление сотрудника", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (GetSelectedUser().Login != "-- Отсутствует --")
                        {
                            employeesFromDB.DelEmployeeNUser(GetSelectedUser().EmployeeID);
                            GetEmployees();
                        }
                        else
                        {
                            employeesFromDB.DelEmployee(GetSelectedUser().EmployeeID);
                            GetEmployees();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Нельзя удалить пользователя Администратор!");
                }
            }
            else
            {
                MessageBox.Show("Не выделена строка");
            }
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            AddNewEmployeeForm addNewEmployeeForm = new AddNewEmployeeForm();
            addNewEmployeeForm.ShowDialog();
            GetEmployees();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsersForm_Activated(object sender, EventArgs e)
        {
            GetEmployees();
        }
    }
}
