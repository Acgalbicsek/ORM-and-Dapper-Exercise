using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class Product
    {
        //add each column from our products table as properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public double Price { get; set; }
        public bool OnSale { get; set; } 
        public int StockLevel { get; set; }
    }
}
