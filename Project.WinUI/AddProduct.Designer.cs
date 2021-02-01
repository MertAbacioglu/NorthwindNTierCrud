
namespace Project.WinUI
{
    partial class AddProduct
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.nmrcProductReorder = new System.Windows.Forms.NumericUpDown();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxProductCategory = new System.Windows.Forms.ComboBox();
            this.cmbxProductSupplier = new System.Windows.Forms.ComboBox();
            this.chckbxProductDiscontinued = new System.Windows.Forms.CheckBox();
            this.nmrcProductOrder = new System.Windows.Forms.NumericUpDown();
            this.nmrcProductStock = new System.Windows.Forms.NumericUpDown();
            this.nmrcProductPrice = new System.Windows.Forms.NumericUpDown();
            this.txtProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductReorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(64, 300);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(82, 23);
            this.btnAddProduct.TabIndex = 45;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // nmrcProductReorder
            // 
            this.nmrcProductReorder.Location = new System.Drawing.Point(158, 249);
            this.nmrcProductReorder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcProductReorder.Name = "nmrcProductReorder";
            this.nmrcProductReorder.Size = new System.Drawing.Size(120, 20);
            this.nmrcProductReorder.TabIndex = 44;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(160, 125);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtProductQuantity.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(61, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "Discontinued";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(62, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "ReorderLevel";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(62, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "QuantityPerUnit";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(61, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "UnitsOnOrder";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(61, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Category";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(61, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "UnitsInStock";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(61, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(64, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "UnitPrice";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Product Name";
            // 
            // cmbxProductCategory
            // 
            this.cmbxProductCategory.FormattingEnabled = true;
            this.cmbxProductCategory.Location = new System.Drawing.Point(160, 93);
            this.cmbxProductCategory.Name = "cmbxProductCategory";
            this.cmbxProductCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbxProductCategory.TabIndex = 34;
            this.cmbxProductCategory.Text = "Select Category";
            // 
            // cmbxProductSupplier
            // 
            this.cmbxProductSupplier.FormattingEnabled = true;
            this.cmbxProductSupplier.Location = new System.Drawing.Point(160, 61);
            this.cmbxProductSupplier.Name = "cmbxProductSupplier";
            this.cmbxProductSupplier.Size = new System.Drawing.Size(121, 21);
            this.cmbxProductSupplier.TabIndex = 33;
            this.cmbxProductSupplier.Text = "Select Supplier";
            // 
            // chckbxProductDiscontinued
            // 
            this.chckbxProductDiscontinued.AutoSize = true;
            this.chckbxProductDiscontinued.Location = new System.Drawing.Point(166, 274);
            this.chckbxProductDiscontinued.Name = "chckbxProductDiscontinued";
            this.chckbxProductDiscontinued.Size = new System.Drawing.Size(42, 17);
            this.chckbxProductDiscontinued.TabIndex = 32;
            this.chckbxProductDiscontinued.Text = "yes";
            this.chckbxProductDiscontinued.UseVisualStyleBackColor = true;
            // 
            // nmrcProductOrder
            // 
            this.nmrcProductOrder.Location = new System.Drawing.Point(160, 218);
            this.nmrcProductOrder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcProductOrder.Name = "nmrcProductOrder";
            this.nmrcProductOrder.Size = new System.Drawing.Size(120, 20);
            this.nmrcProductOrder.TabIndex = 30;
            // 
            // nmrcProductStock
            // 
            this.nmrcProductStock.Location = new System.Drawing.Point(160, 187);
            this.nmrcProductStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcProductStock.Name = "nmrcProductStock";
            this.nmrcProductStock.Size = new System.Drawing.Size(120, 20);
            this.nmrcProductStock.TabIndex = 29;
            // 
            // nmrcProductPrice
            // 
            this.nmrcProductPrice.Location = new System.Drawing.Point(160, 156);
            this.nmrcProductPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcProductPrice.Name = "nmrcProductPrice";
            this.nmrcProductPrice.Size = new System.Drawing.Size(120, 20);
            this.nmrcProductPrice.TabIndex = 31;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(160, 30);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 27;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.nmrcProductReorder);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxProductCategory);
            this.Controls.Add(this.cmbxProductSupplier);
            this.Controls.Add(this.chckbxProductDiscontinued);
            this.Controls.Add(this.nmrcProductOrder);
            this.Controls.Add(this.nmrcProductStock);
            this.Controls.Add(this.nmrcProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductReorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.NumericUpDown nmrcProductReorder;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxProductCategory;
        private System.Windows.Forms.ComboBox cmbxProductSupplier;
        private System.Windows.Forms.CheckBox chckbxProductDiscontinued;
        private System.Windows.Forms.NumericUpDown nmrcProductOrder;
        private System.Windows.Forms.NumericUpDown nmrcProductStock;
        private System.Windows.Forms.NumericUpDown nmrcProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
    }
}