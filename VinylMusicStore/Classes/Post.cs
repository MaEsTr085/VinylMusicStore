using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Classes
{
    internal class Post
    {
        public int PostID { get; set; }
        public string PostName { get; set; }
        public double MinExp { get; set; }
        public int MaxCountEmp { get; set; }
        public bool HasUser { get; set; }

        public Post(int postID, string postName, double minExp, int maxCountEmp, bool hasUser)
        {
            PostID = postID;
            PostName = postName;
            MinExp = minExp;
            MaxCountEmp = maxCountEmp;
            HasUser = hasUser;
        }
    }
}
