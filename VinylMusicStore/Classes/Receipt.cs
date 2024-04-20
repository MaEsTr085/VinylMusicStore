using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylMusicStore.Classes
{
    internal class Receipt
    {
        public int ReceiptID { get; set; }
        public string DateOfCreation { get; set; }
        public double Sum { get; set; }
        public int Employee { get; set; }
        public string FN { get; set; }
        public string FD { get; set; }
        public string FPD { get; set; }

        public Receipt(int receiptID, string dateOfCreation, double sum, int employee, string FN, string FD, string FPD)
        {
            ReceiptID = receiptID;
            DateOfCreation = dateOfCreation;
            Sum = sum;
            Employee = employee;
            this.FN = FN;
            this.FD = FD;
            this.FPD = FPD;
        }
    }
}
