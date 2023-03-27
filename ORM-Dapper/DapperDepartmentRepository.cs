using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _conn; 

        public DapperDepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }
       
        public IEnumerable<Department> GetAllDepartments()
        {
            return _conn.Query<Department>("SELECT * FROM departments");
        }

        public void InsertDepartment(string name)
        {
            _conn.Execute("INSERT INTO departments (Name) VALUES (@name)", new { name = name });
        }

        public void CreateDepartment(string name, decimal price, int categoryID)
        {
            throw new NotImplementedException();
        }

        public string GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public object GetProduct(int v)
        {
            throw new NotImplementedException();
        }

        
    }
}
