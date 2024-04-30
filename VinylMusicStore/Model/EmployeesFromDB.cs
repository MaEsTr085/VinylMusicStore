using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;
using VinylMusicStore.Forms;

namespace VinylMusicStore.Model
{
    internal class EmployeesFromDB
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from view_users_empoyees";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), (int)reader[5], DateTime.Parse(reader[6].ToString()), reader[7].ToString(), reader[8].ToString()));
                        }
                        return employees;
                    }
                    reader.Close();
                    return employees;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return employees;
            }
        }

        public Employee GetEmployeeById(int id)
        {
            Employee employee = null;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from view_users_empoyees where emp_id = @id";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("id", id);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            employee = new Employee((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), (int)reader[5], DateTime.Parse(reader[6].ToString()), reader[7].ToString(), reader[8].ToString());
                        }
                        return employee;
                    }
                    reader.Close();
                    return employee;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return employee;
            }
        }

        public void UpdateEmployeeNUser(int id, string passport, string fio, string phone, string login)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();

                    string sqlQuery = "call update_employees_users(@id, @passport, @fio, @phone, @login)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id });
                    command.Parameters.Add(new NpgsqlParameter("passport", NpgsqlTypes.NpgsqlDbType.Text) { Value = passport });
                    command.Parameters.Add(new NpgsqlParameter("fio", NpgsqlTypes.NpgsqlDbType.Text) { Value = fio });
                    command.Parameters.Add(new NpgsqlParameter("phone", NpgsqlTypes.NpgsqlDbType.Text) { Value = phone });
                    command.Parameters.Add(new NpgsqlParameter("login", NpgsqlTypes.NpgsqlDbType.Text) { Value = login });

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void DelEmployeeNUser(int id)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();

                    string sqlQuery = "call del_employee_user(@id)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id });

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void DelEmployee(int id)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();

                    string sqlQuery = "call del_employee(@id)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.Add(new NpgsqlParameter("id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id });

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
