using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;
using VinylMusicStore.Model;

namespace VinylMusicStore.Forms
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAdd("admin");
        }

        public void UserAdd(string passw)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();

                    string sqlQuery = "insert into public.users (user_login, user_password, employee) values ('Admin', @passw, 6)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.Add(new NpgsqlParameter("@passw", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = Verification.GetSHA512Hash(passw) });

                    command.ExecuteNonQuery();
                    MessageBox.Show("Вы успешно зарегистрировались");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
