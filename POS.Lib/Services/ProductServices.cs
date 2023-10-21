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
            List<Products> products = new List<Products>();
            if (!string.IsNullOrEmpty(search))
            {
                sql += " where p.ProductName like @search";
                //
            }

            var parameter = new { search = string.IsNullOrEmpty(search) ? "" : $"%{search}%" };
            products = connection.Query<Products>(sql, parameter).ToList();
            return products;

        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection("Server=TUNGBINHDINH89\\SQLEXPRESS;Database=northwind;Trusted_Connection=True;TrustServerCertificate=True");

        }
    }
}
