namespace POS.APP
{
    partial class ProductListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnDetail = new Button();
            btnGridView = new Button();
            btnAdd = new Button();
            listProduct = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(47, 47);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1139, 30);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1248, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 34);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1401, 49);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 32);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDetail
            // 
            btnDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDetail.Location = new Point(1604, 130);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(105, 34);
            btnDetail.TabIndex = 3;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            // 
            // btnGridView
            // 
            btnGridView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGridView.Location = new Point(1748, 130);
            btnGridView.Name = "btnGridView";
            btnGridView.Size = new Size(105, 34);
            btnGridView.TabIndex = 4;
            btnGridView.Text = "Grid View";
            btnGridView.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(1748, 47);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // listProduct
            // 
            listProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listProduct.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listProduct.FullRowSelect = true;
            listProduct.GridLines = true;
            listProduct.Location = new Point(47, 217);
            listProduct.Name = "listProduct";
            listProduct.Size = new Size(1806, 645);
            listProduct.TabIndex = 6;
            listProduct.UseCompatibleStateImageBehavior = false;
            listProduct.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Product Name";
            columnHeader2.Width = 500;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Unit Price";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Stock Unit";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Order Unit";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Category";
            columnHeader6.Width = 300;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Supplier";
            columnHeader7.Width = 300;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 977);
            Controls.Add(listProduct);
            Controls.Add(btnAdd);
            Controls.Add(btnGridView);
            Controls.Add(btnDetail);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "ProductListForm";
            Text = "Product List";
            Load += ProductListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private Button btnDetail;
        private Button btnGridView;
        private Button btnAdd;
        private ListView listProduct;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}