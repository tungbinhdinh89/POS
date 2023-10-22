using Dapper;
using POS.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Lib.Services
{
   
    public class SupplierService
    {
        public ProductServices productServices = new ProductServices();
        public List<Supplier> GetSupplierList()
        {
            var connection = productServices.GetConnection();
            var sql = "select s.SupplierID as Id, s.CompanyName as SupplierName from Suppliers as s";
            var suppliers = connection.Query<Supplier>(sql).ToList();
            return suppliers;
        }
    }
}
