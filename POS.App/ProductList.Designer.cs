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
            textBox1 = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnAddNew = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(881, 30);
            textBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(966, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 32);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1115, 44);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 32);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(1607, 44);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(194, 32);
            btnAddNew.TabIndex = 3;
            btnAddNew.Text = "Add New Product";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(31, 110);
            listView1.Name = "listView1";
            listView1.Size = new Size(1770, 562);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1828, 984);
            Controls.Add(listView1);
            Controls.Add(btnAddNew);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Name = "ProductList";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnSearch;
        private Button btnClear;
        private Button btnAddNew;
        private ListView listView1;
    }
}