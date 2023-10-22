using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Lib.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null;
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; } = null;
        public decimal? UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }

        public string CategoryName { get; set; } = null;
        public string SupplierName { get; set; } = null;

    }
}
