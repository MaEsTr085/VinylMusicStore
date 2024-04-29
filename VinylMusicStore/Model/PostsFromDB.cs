using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinylMusicStore.Classes;
using VinylMusicStore.Forms;

namespace VinylMusicStore.Model
{
    internal class PostsFromDB
    {
        public List<Post> GetPosts()
        {
            List<Post> posts = new List<Post>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DBConnection.connectionStr))
                {
                    connection.Open();
                    string sqlQuery = "select * from public.posts";
                    NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            posts.Add(new Post((int)reader[0], reader[1].ToString(), double.Parse(reader[2].ToString()), (int)reader[3], (bool)reader[4]));
                        }
                        return posts;
                    }
                    reader.Close();
                    return posts;
                }
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return posts;
            }
        }
    }
}
