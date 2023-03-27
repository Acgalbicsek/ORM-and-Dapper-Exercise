using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * from PRODUCTS;");  //anything in () needs to be SQL syntax
        }

        public void CreateProduct(string name, double price, int categoryID)
        {
            _connection.Execute("INSERT INTO products (Name, Price, CategoryID) VALUES (@name, @price, @categoryID);",
                new { name = name, price = price, categoryId = categoryID });
        }

        public Product GetProduct(int ID)
        {
            return _connection.QuerySingle<Product>("SELECT * FROM products WHERE ProductID = @ID;", 
                new { ID = ID });
        }

        public void UpdateProduct(Product product)
        {
            _connection.Execute("UPDATE products SET Name = @name, Price = @price, CategoryID = @catID, OnSale = @onSale, StockLevel = @stocklevel WHERE ProductID = @ID;",
                new { name = product.Name, price = product.Price, catID = product.CategoryID, onSale = product.OnSale, stocklevel = product.StockLevel, ID = product.ProductID});
        }

        
    }
}
