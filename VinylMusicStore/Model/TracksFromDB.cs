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
    internal class TracksFromDB
    {
        public List<Track> GetTracks()
        {
            List<Track> tracks = new List<Track>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from track_list";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tracks.Add(new Track((int)reader[0], reader[1].ToString(), reader[2].ToString(), (int)reader[3]));
                        }
                        return tracks;
                    }
                    reader.Close();
                    return tracks;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return tracks;
            }
        }

        public List<Track> GetParticularTrack(int id)
        {
            List<Track> tracks = new List<Track>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from public.track_list_particular(@id)";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("id", id);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tracks.Add(new Track((int)reader[0], reader[1].ToString(), reader[2].ToString(), (int)reader[3]));
                        }
                        return tracks;
                    }
                    reader.Close();
                    return tracks;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return tracks;
            }
        }

        public void AddTracks(string track, int duration)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "insert into public.tracks(id_track, album, track_name, duration) values ((select id_track + 1 from public.tracks order by id_track desc limit 1), (select id_catalog from public.catalogs order by id_catalog desc limit 1), @track, @duration);";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("track", track);
                    command.Parameters.AddWithValue("duration", duration);

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
