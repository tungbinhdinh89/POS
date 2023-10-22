using Dapper;
using POS.Lib.Models;

namespace POS.Lib.Services
{
    public class CategoryService
    {
        public ProductServices productService = new ProductServices();
        public List<Category> GetCategoryList()
        {
            var connection = productService.GetConnection();
            var sql = "select c.CategoryID as Id, c.CategoryName, c.Description from Categories as c";
            var categories = connection.Query<Category>(sql).ToList();
            return categories;
        }
    }
}
