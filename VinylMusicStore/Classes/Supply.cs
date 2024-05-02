using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Classes
{
    internal class Supply
    {
        public int SupplyID { get; set; }
        public DateTime DateOfSupply { get; set; }
        public string Album { get; set; }
        public string Label { get; set; }
        public int AlbumCount { get; set; }

        public Supply(int supplyID, DateTime dateOfSupply, string album, string label, int albumCount)
        {
            SupplyID = supplyID;
            DateOfSupply = dateOfSupply;
            Album = album;
            Label = label;
            AlbumCount = albumCount;
        }
    }
}
