using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Forms
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFIO { get; set; }
        public string Pasport { get; set; }
        public string Login { get; set; }
        public string Post { get; set; }
        public int WorkExp { get; set; }
        public DateTime StartDate { get; set; }
        public string Phone { get; set; }
        public string WorkSchedule { get; set; }

        public Employee(int employeeID, string employeeFIO, string pasport, string login, string post, int workExp, DateTime startDate, string phone, string workSchedule)
        {
            EmployeeID = employeeID;
            EmployeeFIO = employeeFIO;
            Pasport = pasport;
            Login = login;
            Post = post;
            WorkExp = workExp;
            StartDate = startDate;
            Phone = phone;
            WorkSchedule = workSchedule;
        }
    }
}
