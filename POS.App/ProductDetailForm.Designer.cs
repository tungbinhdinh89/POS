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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(34, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(410, 30);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 30);
            textBox2.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(34, 258);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 30);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 219);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(34, 353);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 30);
            textBox4.TabIndex = 7;
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
            // textBox5
            // 
            textBox5.Location = new Point(34, 450);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(215, 30);
            textBox5.TabIndex = 9;
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
            // textBox6
            // 
            textBox6.Location = new Point(34, 543);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(343, 30);
            textBox6.TabIndex = 11;
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
            // textBox7
            // 
            textBox7.Location = new Point(34, 641);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(343, 30);
            textBox7.TabIndex = 13;
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
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirm.Location = new Point(457, 743);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(105, 32);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
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
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 806);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ProductDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Button btnConfirm;
        private Button btnCancel;
    }
}