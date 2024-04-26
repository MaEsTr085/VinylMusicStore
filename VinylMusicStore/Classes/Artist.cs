using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Classes
{
    internal class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string Composition { get; set; }

        public Artist(int artistID, string artistName, string composition)
        {
            ArtistID = artistID;
            ArtistName = artistName;
            Composition = composition;
        }
    }
}
