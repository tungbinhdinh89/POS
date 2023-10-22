using POS.Lib.Models;
using POS.Lib.Services;

namespace POS.App
{
    public partial class ProductDetailForm : Form
    {
        public CategoryService categoryService = new CategoryService();
        public SupplierService supplierService = new SupplierService();
        public ProductServices productServices = new ProductServices();
        public Product CurrentProduct { get; set; } = null;

        public ProductDetailForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product current = new()
            {
                ProductName = txtProductName.Text.Trim(),
                CategoryID = (int)cbCategory.SelectedValue,
                SupplierID = (int)cbSupplier.SelectedValue,
                QuantityPerUnit = txtQuantity.Text.Trim(),
                UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim()),
                UnitsInStock = int.Parse(txtUnitStock.Text.Trim()),
                UnitsOnOrder = int.Parse(txtUnitStock.Text.Trim())
            };

            productServices.AddProduct(current);
            DialogResult = DialogResult.OK;
            Close();

        }



        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
            LoadSupplierList();
            if (CurrentProduct != null)
            {
                BindProductData(CurrentProduct);
            }
        }

        private void BindProductData(Product product)
        {
            txtProductName.Text = product.ProductName;
            txtQuantity.Text = product.QuantityPerUnit.ToString();
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtUnitStock.Text = product.UnitsInStock.ToString();
            txtUnitOrder.Text = product.UnitsOnOrder.ToString();

            // todo: show combo box 
            cbCategory.SelectedValue = product.CategoryID;
            cbSupplier.SelectedValue = product.SupplierID;
        }

        private void LoadCategoryList()
        {
            var categories = categoryService.GetCategoryList();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "Id";
        }

        private void LoadSupplierList()
        {
            var suppliers = supplierService.GetSupplierList();
            cbSupplier.DataSource = suppliers;
            cbSupplier.DisplayMember = "SupplierName";
            cbSupplier.ValueMember = "Id";
        }



    }
}
