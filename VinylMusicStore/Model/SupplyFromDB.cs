using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;

namespace VinylMusicStore.Model
{
    internal class SupplyFromDB
    {
        public void AddNewSupply(DateTime supplydate, int albcount, string lbl, string ctr, string alb)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "call add_supply (@supplydate, @albcount, @lbl, @ctr, @alb) ";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.Add(new NpgsqlParameter("supplydate", NpgsqlTypes.NpgsqlDbType.Date) { Value = supplydate });
                    command.Parameters.Add(new NpgsqlParameter("albcount", NpgsqlTypes.NpgsqlDbType.Integer) { Value = albcount });
                    command.Parameters.Add(new NpgsqlParameter("lbl", NpgsqlTypes.NpgsqlDbType.Text) { Value = lbl });
                    command.Parameters.Add(new NpgsqlParameter("ctr", NpgsqlTypes.NpgsqlDbType.Text) { Value = ctr });
                    command.Parameters.Add(new NpgsqlParameter("alb", NpgsqlTypes.NpgsqlDbType.Text) { Value = alb });

                    int i = command.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Supply> GetSupplies()
        {
            List<Supply> supplies = new List<Supply>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from get_supplies";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            supplies.Add(new Supply((int)reader[0], (DateTime)reader[1], reader[2].ToString(), reader[3].ToString(), (int)reader[4]));
                        }
                        return supplies;
                    }
                    reader.Close();
                    return supplies;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return supplies;
            }
        }
    }
}
