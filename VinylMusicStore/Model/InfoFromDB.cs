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
    internal class InfoFromDB
    {
        public List<string> GetArtistsForAlbum()
        {
            List<string> artists = new List<string>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select artist_name from public.artists order by artist_name asc";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            artists.Add(reader[0].ToString());
                        }
                        return artists;
                    }
                    reader.Close();
                    return artists;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return artists;
            }
        }

        public List<Artist> GetArtists()
        {
            List<Artist> artists = new List<Artist>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from public.artists order by artist_name asc";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            artists.Add(new Artist((int)reader[0], reader[1].ToString(), reader[2].ToString()));
                        }
                        return artists;
                    }
                    reader.Close();
                    return artists;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return artists;
            }
        }

        public void AddArtist(Artist artist)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "insert into public.artists (artist_name, composition) values (@artistName, @composition)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("artistName", artist.ArtistName);
                    command.Parameters.AddWithValue("composition", artist.Composition);

                    int i = command.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<AlbumLabel> GetLabels()
        {
            List<AlbumLabel> labels = new List<AlbumLabel>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from public.labels order by label_name asc";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            labels.Add(new AlbumLabel((int)reader[0], reader[1].ToString(), reader[2].ToString()));
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

        public List<string> GetLabelsForAlbumNoZero(string album)
        {
            List<string> labels = new List<string>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from public.get_labels_for_album_no_zero(@album)";
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

        public List<AlbumLabel> GetLabelsForAlbum(string album)
        {
            List<AlbumLabel> labels = new List<AlbumLabel>();

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
                            labels.Add(new AlbumLabel(0, reader[0].ToString(), reader[1].ToString()));
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

        public void AddLabel(AlbumLabel label)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "insert into public.labels(label_name, country) values (@label_name, @country)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("label_name", label.LabelName);
                    command.Parameters.AddWithValue("country", label.Country);

                    int i = command.ExecuteNonQuery();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<string> GetGenresForReceipt()
        {
            List<string> genres = new List<string>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select genre_name from public.genres order by genre_name asc";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            genres.Add(reader[0].ToString());
                        }
                        return genres;
                    }
                    reader.Close();
                    return genres;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return genres;
            }
        }

        public List<Genre> GetGenres()
        {
            List<Genre> genres = new List<Genre>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from public.genres order by genre_name asc";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            genres.Add(new Genre((int)reader[0], reader[1].ToString()));
                        }
                        return genres;
                    }
                    reader.Close();
                    return genres;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return genres;
            }
        }

        public void AddGenre(Genre genre)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "insert into public.genres(genre_name) values (@genre_name)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("genre_name", genre.GenreName);

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
