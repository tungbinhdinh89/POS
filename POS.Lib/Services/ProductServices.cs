using POS.Lib.Models;

namespace POS.Lib.Services
{
    public class ProductServices
    {
        public List<Products> GetProductList(string? search = "")
        {
            return new List<Products>
            {
                new() { Id = 1, ProductName = "Chai", QuantityPerUnit = "10 boxes x 20 bags", UnitPrice = 20000, UnitsInStock = 39, UnitsOnOrder = 0, CategoryName = "1", SupplierName= "2"}

            };
        }

        //private Sql GetConnection()
        //{
        //    var sqlConnection connection

        //}
    }
}
