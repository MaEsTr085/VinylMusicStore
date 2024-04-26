using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Classes
{
    internal class AlbumLabel
    {
        public int LabelID { get; set; }
        public string LabelName { get; set; }
        public string Country { get; set; }

        public AlbumLabel(int labelID, string labelName, string country)
        {
            LabelID = labelID;
            LabelName = labelName;
            Country = country;
        }
    }
}
