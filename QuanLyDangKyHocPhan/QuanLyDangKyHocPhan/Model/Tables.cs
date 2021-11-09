using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDangKyHocPhan.Model
{
    public class Tables
    {
        public int id { get; set; }
        public string name { get; set; }
        public int status { get; set; }
        public int capacity { get; set; }

        public Tables()
        {
        }

        public Tables(int id, string name, int status, int capacity)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.capacity = capacity;
        }
    }
}
