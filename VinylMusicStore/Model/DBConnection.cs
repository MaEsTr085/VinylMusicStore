using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Model
{
    internal class DBConnection
    {
        internal static string connectionStr = @"Server=localhost; Port=5433; DataBase=MusicStore; User Id=postgres; Password=topsecret;";
    }
}
