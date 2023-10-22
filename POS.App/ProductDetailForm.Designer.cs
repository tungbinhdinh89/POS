namespace POS.App
{
    partial class ProductDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            label2 = new Label();
            txtUnitPrice = new TextBox();
            label3 = new Label();
            txtUnitStock = new TextBox();
            label4 = new Label();
            txtUnitOrder = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            cbCategory = new ComboBox();
            cbSupplier = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 33);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(34, 72);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(410, 30);
            txtProductName.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(34, 163);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(172, 30);
            txtQuantity.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 124);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 2;
            label2.Text = "Quantity /Unit";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(34, 258);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(172, 30);
            txtUnitPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 219);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 4;
            label3.Text = "Unit Price";
            // 
            // txtUnitStock
            // 
            txtUnitStock.Location = new Point(34, 353);
            txtUnitStock.Name = "txtUnitStock";
            txtUnitStock.Size = new Size(215, 30);
            txtUnitStock.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 314);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 6;
            label4.Text = "Unit Stock";
            // 
            // txtUnitOrder
            // 
            txtUnitOrder.Location = new Point(34, 450);
            txtUnitOrder.Name = "txtUnitOrder";
            txtUnitOrder.Size = new Size(215, 30);
            txtUnitOrder.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 411);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 8;
            label5.Text = "Unit Order";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 504);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 10;
            label6.Text = "Category Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 602);
            label7.Name = "label7";
            label7.Size = new Size(123, 23);
            label7.TabIndex = 12;
            label7.Text = "Supplier Name";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(457, 743);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 32);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(587, 743);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 32);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(37, 553);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(212, 31);
            cbCategory.TabIndex = 16;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(37, 641);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(212, 31);
            cbSupplier.TabIndex = 17;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 806);
            ControlBox = false;
            Controls.Add(cbSupplier);
            Controls.Add(cbCategory);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtUnitOrder);
            Controls.Add(label5);
            Controls.Add(txtUnitStock);
            Controls.Add(label4);
            Controls.Add(txtUnitPrice);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Name = "ProductDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Product";
            Load += ProductDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private Label label2;
        private TextBox txtUnitPrice;
        private Label label3;
        private TextBox txtUnitStock;
        private Label label4;
        private TextBox txtUnitOrder;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cbCategory;
        private ComboBox cbSupplier;
    }
}