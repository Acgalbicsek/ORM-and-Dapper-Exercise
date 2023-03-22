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
        public string ProductName { get; set; }
        public int ProductCategoryID { get; set; }
        public decimal ProductPrice { get; set; }
        public int OnSale { get; set; } 
        public string StockLevel { get; set; }
    }
}
