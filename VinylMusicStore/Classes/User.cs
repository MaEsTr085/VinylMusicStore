using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Classes
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Employee { get; set; }

        public User(int userId, string login, string password, int employee)
        {
            UserId = userId;
            Login = login;
            Password = password;
            Employee = employee;
        }
    }
}
