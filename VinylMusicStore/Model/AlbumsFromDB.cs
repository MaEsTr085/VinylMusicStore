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
    internal class AlbumsFromDB
    {
        public List<Album> GetAlbums()
        {
            List<Album> albums = new List<Album>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from album_instock";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            albums.Add(new Album((int)reader[0], reader[1].ToString(), reader[2].ToString(), (int)reader[3], reader[4].ToString(), (int)reader[5], (int)reader[6], reader[7].ToString(), reader[8].ToString()));
                        }
                        return albums;
                    }
                    reader.Close();
                    return albums;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return albums;
            }
        }

        public List<string> GetAlbumsForReceipt()
        {
            List<string> albums = new List<string>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select album from public.catalogs group by album";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            albums.Add(reader[0].ToString());
                        }
                        return albums;
                    }
                    reader.Close();
                    return albums;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return albums;
            }
        }

        public List<string> GetLabelsForAlbum(string album)
        {
            List<string> labels = new List<string>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from public.get_labels_for_album(@album)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@album", album);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            labels.Add(reader[0].ToString());
                        }
                        return labels;
                    }
                    reader.Close();
                    return labels;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return labels;
            }
        }

        public double GetAlbumPrice(string album, string label)
        {
            double price = 0;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from get_album_cost(@album, @label)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@album", album);
                    command.Parameters.AddWithValue("@label", label);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            price = double.Parse(reader[0].ToString());
                        }
                        return price;
                    }
                    reader.Close();
                    return price;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return price;
            }
        }
    }
}
