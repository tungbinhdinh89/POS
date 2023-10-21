using Dapper;
using Microsoft.Data.SqlClient;
using POS.Lib.Models;

namespace POS.Lib.Services
{
    public class ProductServices
    {
        public List<Products> GetProductList(string? search = "")
        {
            var sql = """
                select p.ProductId as Id , p.ProductName, p.CategoryID, p.SupplierID, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, c.CategoryName, s.CompanyName as SupplierName
                from products as p
                join Categories as c on c.CategoryID = p.CategoryID
                join Suppliers as s on s.SupplierID = p.SupplierID
                """;

            var connection = GetConnection();
            var product = connection.Query<Products>(sql).ToList();
            return product;

        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection("Server=TUNGBINHDINH89\\SQLEXPRESS;Database=northwind;Trusted_Connection=True;TrustServerCertificate=True");

        }
    }
}
