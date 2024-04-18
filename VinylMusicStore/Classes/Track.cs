using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Classes
{
    public class Track
    {
        public int IdTrack { get; set; }
        public string Album { get; set; }
        public string TrackName { get; set; }
        public int Duration { get; set; }

        public Track(int idTrack, string album, string trackName, int duration)
        {
            IdTrack = idTrack;
            Album = album;
            TrackName = trackName;
            Duration = duration;
        }
    }
}
