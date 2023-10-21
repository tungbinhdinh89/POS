using POS.Lib.Models;
using POS.Lib.Services;

namespace POS.App
{
    public partial class ProductList : Form
    {
        public ProductServices productServices = new ProductServices();
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            var product = productServices.GetProductList();
            RenderListProduct(product);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ProductDetailForm detailForm = new();
            detailForm.ShowDialog();
        }

        private void RenderListProduct(List<Products> products)
        {
            lvProductList.Items.Clear();
            foreach (Products product in products)
            {
                //var item = new ListViewItem(product.Id.ToString());
                ListViewItem item = new(product.Id.ToString());
                item.SubItems.Add(product.ProductName);
                item.SubItems.Add(product.QuantityPerUnit);
                item.SubItems.Add(product.UnitPrice.ToString());
                item.SubItems.Add(product.UnitsInStock.ToString());
                item.SubItems.Add(product.UnitsOnOrder.ToString());
                item.SubItems.Add(product.CategoryName);
                item.SubItems.Add(product.SupplierName);
                item.Tag = product;
                lvProductList.Items.Add(item);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void lvProductList_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

     
    }
}