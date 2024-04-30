using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Classes
{
    internal class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        public Genre(int genreID, string genreName)
        {
            GenreID = genreID;
            GenreName = genreName;
        }
    }
}
