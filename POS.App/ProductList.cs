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
            LoadProductList();

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ProductDetailForm detailForm = new();
            var result = detailForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadProductList();
            }
        }

        private void RenderListProduct(List<Product> products)
        {
            lvProductList.Items.Clear();
            foreach (Product product in products)
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
                item.Tag = product; // boxing
                lvProductList.Items.Add(item);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadProductList();
        }

        private void lvProductList_DoubleClick(object sender, EventArgs e)
        {
            var lvi = lvProductList.SelectedItems[0];
            var product = (Product)lvi.Tag; // unboxing

            ProductDetailForm detailForm = new ProductDetailForm();
            detailForm.Text = "Product: " + product.ProductName;
            detailForm.CurrentProduct = product;
            detailForm.ShowDialog();
        }
        private void LoadProductList()
        {
            RenderListProduct(productServices.GetProductList(txtSearch.Text.Trim()));
        }
    }
}