using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Classes
{
    public class Album
    {
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public string Artist { get; set; }
        public int AlbumCount { get; set; }
        public string Label { get; set; }
        public int YearOfAlbum { get; set; }
        public int YearOfRelease { get; set; }
        public string Genre { get; set; }
        public Image Image { get; set; }

        public Album(int idAlbum, string albumName, string artist, int albumCount, string label, int yearOfAlbum, int yearOfRelease, string genre, string image)
        {
            IdAlbum = idAlbum;
            AlbumName = albumName;
            Artist = artist;
            AlbumCount = albumCount;
            Label = label;
            YearOfAlbum = yearOfAlbum;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            if (image != "")
                Image = Image.FromFile(image);
            else
                Image = Image.FromFile(@"..\..\Images\vinyl.png");
        }
    }
}
