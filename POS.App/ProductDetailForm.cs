using POS.Lib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.App
{
    public partial class ProductDetailForm : Form
    {
        public Products CurrentProduct { get; set; } = null;

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

        }

        private void BindProductData(Products product)
        {
            txtProductName.Text = product.ProductName;
            txtQuantity.Text = product.QuantityPerUnit.ToString();
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtUnitStock.Text = product.UnitsInStock.ToString();
            txtUnitOrder.Text = product.UnitsOnOrder.ToString();

            // todo: show combo box 
            txtCategoryName.Text = product.CategoryName;
            txtSupplierName.Text = product.SupplierName;
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            if (CurrentProduct != null)
            {
                BindProductData(CurrentProduct);
            }
        }


    }
}
