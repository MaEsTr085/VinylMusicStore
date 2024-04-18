using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;

namespace VinylMusicStore.Model
{
    internal class UsersFromDB
    {
        public User GetUser(string login, string password)
        {
            User user = null;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from get_user(@login)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("login", login);

                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();

                        if (password != "")
                        {
                            if (Verification.VerifySHA512Hash(password, (string)reader["user_password"]))
                            {
                                user = new User((int)reader[0], reader[1].ToString(), reader[2].ToString(), (int)reader[3]);
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль");
                            }
                        }

                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Нет такого пользователя");
                    }
                    return user;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return user;
            }
        }

        public string GetUserById(int id)
        {
            string employee = null;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select fio from public.employees where emp_id = @id";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("id", id);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            employee = reader[0].ToString();
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
    }
}
