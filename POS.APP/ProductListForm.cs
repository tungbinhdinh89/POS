

using POS.Lib.Models;
using POS.Lib.Services;

namespace POS.APP
{
    public partial class ProductListForm : Form
    {
        private ProductSevice productService = new();
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            var product = productService.GetProductList();
            RenderProductListView(product);


        }

        private void RenderProductListView(List<Product> products)
        {
            listProduct.Items.Clear();
            foreach (Product product in products)
            {
                var item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.ProductName);
                item.SubItems.Add(product.UnitPrice.ToString());
                item.SubItems.Add(product.UnitsInStock.ToString());
                item.SubItems.Add(product.UnitsOnOrder.ToString());
                item.SubItems.Add(product.CategoryName);
                item.SubItems.Add(product.SupplierName);
                listProduct.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var product = productService.GetProductList(btnSearch.Text.Trim());
            RenderProductListView(product);
        }
    }
}