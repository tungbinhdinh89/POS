//using Dapper;
//using Microsoft.Data.SqlClient;
//using POS.Lib.Models;

//namespace POS.Lib.Services
//{
//    public class ProductSevice
//    {
//        public List<Product> GetProductList(string? keyword = "")
//        {
//            var connection = GetConnection();
//            var sql = """
//                SELECT p.[ProductId] as Id, p.[ProductName], p.[SupplierId], p.[CategoryId], p.[QuantityPerUnit], p.[UnitPrice], p.[UnitsInStock], p.[UnitsOnOrder], p.[ReorderLevel], p.[Discontinued],
//                c.CategoryName, s.CompanyName as SupplierName
//                FROM [Products] as p
//                join [Categories] as c on c.CategoryID = p.CategoryID
//                join [Suppliers] as s on s.SupplierID = p.SupplierID
//                """;
//            List<Product> products;
//            if (string.IsNullOrEmpty(keyword))
//            {
//                products = connection.Query<Product>(sql).ToList();
                
//            }
//            else
//            {
//                sql += " where p.ProductName like @keyword";
//                products = connection.Query<Product>(sql, new { query = $"%{keyword}%" }).ToList();
//            }

            
//            return products;
//        }

//        private SqlConnection GetConnection()
//        {
//            return new SqlConnection("Server=TUNGBINHDINH89\\SQLEXPRESS;Database=northwind;Trusted_Connection=True;TrustServerCertificate=True");
//        }
//    }
//}
