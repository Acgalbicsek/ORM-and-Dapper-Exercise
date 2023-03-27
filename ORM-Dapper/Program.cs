using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);
           
            var productRepository = new DapperProductRepository(conn);

            //var productToUpdate = productRepository.GetProduct(940);
            //productToUpdate.OnSale = true;
            //productToUpdate.Name = "Update Test";
            //productToUpdate.StockLevel = 3;
            //productToUpdate.Price = 16.99;
            //productToUpdate.ProductID = 940;


            //productRepository.UpdateProduct(productToUpdate);

            productRepository.DeleteProduct(940);
            productRepository.DeleteProduct(941);
            productRepository.DeleteProduct(942);
            productRepository.DeleteProduct(943);
            productRepository.DeleteProduct(944);
            productRepository.DeleteProduct(945);

            

            


            var products = productRepository.GetAllProducts();

            

            foreach(var prod in products)
            {
                Console.WriteLine($"{prod.ProductID} {prod.Name}");
                Console.WriteLine();
            }

          
        }
    }
}
