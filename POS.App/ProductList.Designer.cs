namespace POS.App
{
    partial class ProductList
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
            btnAddNew = new Button();
            lvProductList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(31, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(881, 30);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(966, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 32);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1115, 44);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 32);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.Location = new Point(1499, 44);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(194, 32);
            btnAddNew.TabIndex = 3;
            btnAddNew.Text = "Add New Product";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // lvProductList
            // 
            lvProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProductList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lvProductList.FullRowSelect = true;
            lvProductList.GridLines = true;
            lvProductList.Location = new Point(31, 169);
            lvProductList.MultiSelect = false;
            lvProductList.Name = "lvProductList";
            lvProductList.Size = new Size(1662, 729);
            lvProductList.TabIndex = 4;
            lvProductList.UseCompatibleStateImageBehavior = false;
            lvProductList.View = View.Details;
            lvProductList.DoubleClick += lvProductList_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Product Name";
            columnHeader2.Width = 600;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Quantity /Unit";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Unit Price";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Unit Stock";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Unit Order";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Category Name";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Supplier Name";
            columnHeader8.Width = 200;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 984);
            Controls.Add(lvProductList);
            Controls.Add(btnAddNew);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "ProductList";
            Text = "Product List";
            Load += ProductList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
        private Button btnAddNew;
        private ListView lvProductList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
    }
}