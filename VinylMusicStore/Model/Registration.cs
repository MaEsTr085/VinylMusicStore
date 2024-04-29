using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;

namespace VinylMusicStore.Model
{
    internal class Registration
    {
        public bool CheckPassword(string password, string passwordRepeat)
        {
            if (password.Length < 6)
            {
                MessageBox.Show("Длина пароля не может быть меньше 6 символов");
                return false;
            } else
            {
                bool f, f1, f2;
                f = f1 = f2 = false;
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsDigit(password[i])) f1 = true;
                    if (Char.IsUpper(password[i])) f2 = true;
                    if (f1 && f2) break;
                }
                if (!(f1 && f2))
                {
                    MessageBox.Show("Пароль должен содержать хотя бы одну цифру и одну заглавную букву");
                    return f1 && f2;
                } else
                {
                    string symbol = "!@#$%^";
                    for (int i = 0; i < password.Length; i++)
                    {
                        for (int j = 0; j < symbol.Length; j++)
                        {
                            if (password[i] == symbol[j])
                            {
                                f = true;
                                break;
                            }
                        }
                    }
                    if (!f)
                        MessageBox.Show("Пароль должен содержать один из символов !@#$%^");
                    if ((password == passwordRepeat) && f)
                        return true;
                    else
                        MessageBox.Show("Неверно подтвержден пароль");
                    return false;
                }
            }
        }

        public bool CheckUser(string login)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();

                    string sqlQuery = "select user_login from public.users where user_login = @login";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("login", login);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Такой логин уже существует");
                        return false;
                    } else
                    {
                        reader.Close();
                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void AddEmployeeNUser(string psprt, string f, int wexp, string epost, decimal paym, DateTime sday, string ph, string wsch, string login, string pass)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();

                    string sqlQuery = "call add_employee_user(@psprt, @f, @wexp, @epost, @paym, @sday, @ph, @wsch, @login, @pass)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.Add(new NpgsqlParameter("psprt", NpgsqlTypes.NpgsqlDbType.Text) { Value = psprt });
                    command.Parameters.Add(new NpgsqlParameter("f", NpgsqlTypes.NpgsqlDbType.Text) { Value = f });
                    command.Parameters.Add(new NpgsqlParameter("wexp", NpgsqlTypes.NpgsqlDbType.Integer) { Value = wexp });
                    command.Parameters.Add(new NpgsqlParameter("epost", NpgsqlTypes.NpgsqlDbType.Text) { Value = epost });
                    command.Parameters.Add(new NpgsqlParameter("paym", NpgsqlTypes.NpgsqlDbType.Money) { Value = paym });
                    command.Parameters.Add(new NpgsqlParameter("sday", NpgsqlTypes.NpgsqlDbType.Date) { Value = sday });
                    command.Parameters.Add(new NpgsqlParameter("ph", NpgsqlTypes.NpgsqlDbType.Text) { Value = ph });
                    command.Parameters.Add(new NpgsqlParameter("wsch", NpgsqlTypes.NpgsqlDbType.Text) { Value = wsch });
                    command.Parameters.Add(new NpgsqlParameter("login", NpgsqlTypes.NpgsqlDbType.Text) { Value = login });
                    command.Parameters.Add(new NpgsqlParameter("pass", NpgsqlTypes.NpgsqlDbType.Text) { Value = Verification.GetSHA512Hash(pass) });

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public void AddEmployee(string psprt, string f, int wexp, string epost, decimal paym, DateTime sday, string ph, string wsch)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();

                    string sqlQuery = "call add_employee(@psprt, @f, @wexp, @epost, @paym, @sday, @ph, @wsch)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.Add(new NpgsqlParameter("psprt", NpgsqlTypes.NpgsqlDbType.Text) { Value = psprt });
                    command.Parameters.Add(new NpgsqlParameter("f", NpgsqlTypes.NpgsqlDbType.Text) { Value = f });
                    command.Parameters.Add(new NpgsqlParameter("wexp", NpgsqlTypes.NpgsqlDbType.Integer) { Value = wexp });
                    command.Parameters.Add(new NpgsqlParameter("epost", NpgsqlTypes.NpgsqlDbType.Text) { Value = epost });
                    command.Parameters.Add(new NpgsqlParameter("paym", NpgsqlTypes.NpgsqlDbType.Money) { Value = paym });
                    command.Parameters.Add(new NpgsqlParameter("sday", NpgsqlTypes.NpgsqlDbType.Date) { Value = sday });
                    command.Parameters.Add(new NpgsqlParameter("ph", NpgsqlTypes.NpgsqlDbType.Text) { Value = ph });
                    command.Parameters.Add(new NpgsqlParameter("wsch", NpgsqlTypes.NpgsqlDbType.Text) { Value = wsch });

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public int GetEmployeeCountForPost(string post)
        {
            int count = 0;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();

                    string sqlQuery = "select count(*)::int from public.employees inner join public.posts on public.posts.id_post = public.employees.post group by public.posts.post_name having public.posts.post_name = @post";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("post", post);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            count = (int)reader[0];
                        }
                        return count;
                    }
                    reader.Close();
                    return count;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return count;
            }
        }

        private string CreatePassword()
        {
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digit = "0123456789";
            string specialChars = "!@#$%^";

            StringBuilder password = new StringBuilder();

            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                int random_char = rnd.Next(4);

                switch (random_char)
                {
                    case 0:
                        password.Append(lowerCase[rnd.Next(lowerCase.Length)]); break;
                    case 1:
                        password.Append(upperCase[rnd.Next(upperCase.Length)]); break;
                    case 2:
                        password.Append(digit[rnd.Next(digit.Length)]); break;
                    case 3:
                        password.Append(specialChars[rnd.Next(specialChars.Length)]); break;
                }

                Thread.Sleep(10);
            }

            return password.ToString();
        }

        private bool ValidatePassword(string password)
        {
            if (password.Length == 8)
            {
                int upperCase = 0, digit = 0, lowerCase = 0, specialChar = 0;

                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        upperCase++;
                    }
                    else if (char.IsLower(password[i]))
                    {
                        lowerCase++;
                    }
                    else if (char.IsDigit(password[i]))
                    {
                        digit++;
                    }
                    else
                    {
                        specialChar++;
                    }
                }
                return upperCase >= 1 && digit >= 1 && specialChar > 0;
            }
            else
            {
                return false;
            }
        }

        public string GeneratePassword()
        {
            string password = CreatePassword();
            while (!(ValidatePassword(password)))
            {
                password = GeneratePassword();
            }

            return password;
        }
    }
}
