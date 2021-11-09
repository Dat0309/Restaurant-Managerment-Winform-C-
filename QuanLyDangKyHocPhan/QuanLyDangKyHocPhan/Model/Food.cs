using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDangKyHocPhan.Model
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int FoodCateegoryID { get; set; }
        public int Price { get; set; }
        public string Notes { get; set; }
        public string Picture { get; set; }

        public Food()
        {
        }

        public Food(int id, string name, string unit, int foodCateegoryID, int price, string notes, string picture)
        {
            Id = id;
            Name = name;
            Unit = unit;
            FoodCateegoryID = foodCateegoryID;
            Price = price;
            Notes = notes;
            Picture = picture;
        }
    }
}
