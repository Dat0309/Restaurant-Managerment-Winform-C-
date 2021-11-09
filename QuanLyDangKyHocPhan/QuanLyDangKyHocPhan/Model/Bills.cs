using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDangKyHocPhan.Model
{
    public class Bills
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int TableID { get; set; }
        public int Amount { get; set; } = 0;
        public float Discount { get;set; } = 0;
        public float Tax { get; set; } = 0;
        public bool Status { get; set; } = false;
        public DateTime dateTime { get; set; } = DateTime.Now;
        public string Account { get; set; }

        public Bills()
        {
        }

        public Bills(int id, string name, int tableID, int amount, float discount, float tax, bool status, DateTime dateTime, string account)
        {
            this.id = id;
            Name = name;
            TableID = tableID;
            Amount = amount;
            Discount = discount;
            Tax = tax;
            Status = status;
            this.dateTime = dateTime;
            Account = account;
        }
    }
}
