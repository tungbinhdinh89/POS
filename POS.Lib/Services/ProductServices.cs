using Dapper;
using Microsoft.Data.SqlClient;
using POS.Lib.Models;

namespace POS.Lib.Services
{
    public class ProductServices
    {

        public List<Product> GetProductList(string? search = "")
        {
            var sql = """
                select p.ProductId as Id , p.ProductName, p.CategoryID, p.SupplierID, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, c.CategoryName, s.CompanyName as SupplierName
                from products as p
                join Categories as c on c.CategoryID = p.CategoryID
                join Suppliers as s on s.SupplierID = p.SupplierID
                """;

            var connection = GetConnection();
            List<Product> products = new List<Product>();
            if (!string.IsNullOrEmpty(search))
            {
                sql += " where p.ProductName like @search";
    
            }

            var parameter = new { search = string.IsNullOrEmpty(search) ? "" : $"%{search}%" };
            products = connection.Query<Product>(sql, parameter).ToList();
            return products;

        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection("Server=TUNGBINHDINH89\\SQLEXPRESS;Database=northwind;Trusted_Connection=True;TrustServerCertificate=True");

        }

        public void AddProduct(Product product)
        {
            var sql = """
                insert into products (ProductName, CategoryID, SupplierID, QuantityPerUnit, UnitPrice, UnitsInStock)
                values (@productName, @categoryId, @supplierId, @quantityPerUnit, @unitPrice, @unitsInStock)
                """;
            var parameter = new
            {
                productName = product.ProductName,
                categoryId = product.CategoryID,
                supplierId = product.SupplierID,
                quantityPerUnit = product.QuantityPerUnit,
                unitPrice = product.UnitPrice,
                unitsInStock = product.UnitsInStock,
                unitsOnOrder = product.UnitsOnOrder
            };
            var connection = GetConnection();
            connection.Execute(sql, parameter);
        }
    }
}
