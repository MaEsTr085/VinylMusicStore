using Npgsql;
using Npgsql.PostgresTypes;
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
                            albums.Add(new Album((int)reader[0], reader[1].ToString(), reader[2].ToString(), (int)reader[3], reader[4].ToString(), reader[5].ToString(), (int)reader[6], (int)reader[7], reader[8].ToString(), reader[9].ToString()));
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

        public void AddNewAlbum(string album, string artist, AlbumLabel label, int yalbum, int yrelease, string genre, string img)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "call add_new_album_and_desc(@alb, @art, @lblname, @lblcountry, @yalbum, @yrelease, @genre, @img)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.Add(new NpgsqlParameter("alb", NpgsqlTypes.NpgsqlDbType.Text) { Value = album });
                    command.Parameters.AddWithValue("art", artist);
                    command.Parameters.Add(new NpgsqlParameter("lblname", NpgsqlTypes.NpgsqlDbType.Text) { Value = label.LabelName });
                    command.Parameters.Add(new NpgsqlParameter("lblcountry", NpgsqlTypes.NpgsqlDbType.Text) { Value = label.Country });
                    command.Parameters.AddWithValue("yalbum", yalbum);
                    command.Parameters.AddWithValue("yrelease", yrelease);
                    command.Parameters.AddWithValue("genre", genre);
                    command.Parameters.AddWithValue("img", img);

                    int i = command.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
