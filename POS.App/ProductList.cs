namespace POS.App
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ProductDetailForm detailForm = new();
            detailForm.ShowDialog();
        }


    }
}