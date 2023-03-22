using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

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
            var repo = new DapperDepartmentRepository(conn);

            repo.CreateDepartment(Console.ReadLine());

            var departments = repo.GetAllDepartments();

            foreach(var prod in products)
            {
                Console.WriteLine($"{prod.ProductID} {prod.Name}");
            }

           repo.GetAllProducts();
        }
    }
}
