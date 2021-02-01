namespace Project.WinUI
{
    partial class Form1
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
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.btnGetAllCategories = new System.Windows.Forms.Button();
            this.btnDeleteSCategory = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
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
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnGetAllProducts = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lstProductsByCategory = new System.Windows.Forms.ListBox();
            this.txtUpdateCatDescription = new System.Windows.Forms.RichTextBox();
            this.txtUpdateCatName = new System.Windows.Forms.TextBox();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.Fax = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.txtSupplierHomePage = new System.Windows.Forms.TextBox();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.txtSupplierCountry = new System.Windows.Forms.TextBox();
            this.txtSupplierPostalCode = new System.Windows.Forms.TextBox();
            this.txtSupplierFax = new System.Windows.Forms.TextBox();
            this.txtSupplierRegion = new System.Windows.Forms.TextBox();
            this.txtSupplierCity = new System.Windows.Forms.TextBox();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierTitle = new System.Windows.Forms.TextBox();
            this.txtSupplierContact = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnGetAllSuppliers = new System.Windows.Forms.Button();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbxEmployeeReportsTo = new System.Windows.Forms.ComboBox();
            this.txtEmployeeExtensions = new System.Windows.Forms.TextBox();
            this.txtEmployeePhone = new System.Windows.Forms.TextBox();
            this.txtEmployeeCountry = new System.Windows.Forms.TextBox();
            this.txtEmployeePostal = new System.Windows.Forms.TextBox();
            this.txtEmployeeRegion = new System.Windows.Forms.TextBox();
            this.txtEmployeeCity = new System.Windows.Forms.TextBox();
            this.txtEmployeeNotes = new System.Windows.Forms.RichTextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.RichTextBox();
            this.dateTimeHired = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBirth = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.brnGetAllEmployees = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.txtEmployeeCourTesy = new System.Windows.Forms.TextBox();
            this.txtEmployeeTitle = new System.Windows.Forms.TextBox();
            this.txtEmployeeFName = new System.Windows.Forms.TextBox();
            this.txtEmployeeLName = new System.Windows.Forms.TextBox();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtOrderAddress = new System.Windows.Forms.RichTextBox();
            this.nmrcOrderFreight = new System.Windows.Forms.NumericUpDown();
            this.cmbxOrderShippers = new System.Windows.Forms.ComboBox();
            this.cmbxOrderEmployee = new System.Windows.Forms.ComboBox();
            this.cmbxOrderCustomer = new System.Windows.Forms.ComboBox();
            this.txtOrderShippedDate = new System.Windows.Forms.MaskedTextBox();
            this.txtOrderRequiredDate = new System.Windows.Forms.MaskedTextBox();
            this.txtOrderOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnGetAllOrders = new System.Windows.Forms.Button();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.txtOrderPostalCode = new System.Windows.Forms.TextBox();
            this.txtOrderShipRegion = new System.Windows.Forms.TextBox();
            this.txtOrderShipCity = new System.Windows.Forms.TextBox();
            this.txtOrderShipCountry = new System.Windows.Forms.TextBox();
            this.tabShippers = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteShipper = new System.Windows.Forms.Button();
            this.btnAddNewShipper = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtShipperPhone = new System.Windows.Forms.TextBox();
            this.txtShipperName = new System.Windows.Forms.TextBox();
            this.btnGetAllShippers = new System.Windows.Forms.Button();
            this.lstShippers = new System.Windows.Forms.ListBox();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerContact = new System.Windows.Forms.TextBox();
            this.txtCustomerCompany = new System.Windows.Forms.TextBox();
            this.btnGetAllCustomers = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.tabMain.SuspendLayout();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductReorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductPrice)).BeginInit();
            this.tabCategories.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcOrderFreight)).BeginInit();
            this.tabShippers.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(6, 19);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(335, 147);
            this.lstCategory.TabIndex = 0;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstResult_SelectedIndexChanged);
            // 
            // btnGetAllCategories
            // 
            this.btnGetAllCategories.Location = new System.Drawing.Point(6, 190);
            this.btnGetAllCategories.Name = "btnGetAllCategories";
            this.btnGetAllCategories.Size = new System.Drawing.Size(70, 23);
            this.btnGetAllCategories.TabIndex = 1;
            this.btnGetAllCategories.Text = "Get All";
            this.btnGetAllCategories.UseVisualStyleBackColor = true;
            this.btnGetAllCategories.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnDeleteSCategory
            // 
            this.btnDeleteSCategory.Location = new System.Drawing.Point(6, 255);
            this.btnDeleteSCategory.Name = "btnDeleteSCategory";
            this.btnDeleteSCategory.Size = new System.Drawing.Size(138, 23);
            this.btnDeleteSCategory.TabIndex = 2;
            this.btnDeleteSCategory.Text = "Delete Selected Category";
            this.btnDeleteSCategory.UseVisualStyleBackColor = true;
            this.btnDeleteSCategory.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabProducts);
            this.tabMain.Controls.Add(this.tabCategories);
            this.tabMain.Controls.Add(this.tabSuppliers);
            this.tabMain.Controls.Add(this.tabEmployees);
            this.tabMain.Controls.Add(this.tabOrders);
            this.tabMain.Controls.Add(this.tabShippers);
            this.tabMain.Controls.Add(this.tabCustomers);
            this.tabMain.Location = new System.Drawing.Point(38, 23);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(889, 408);
            this.tabMain.TabIndex = 3;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.btnUpdateProduct);
            this.tabProducts.Controls.Add(this.nmrcProductReorder);
            this.tabProducts.Controls.Add(this.txtProductQuantity);
            this.tabProducts.Controls.Add(this.label9);
            this.tabProducts.Controls.Add(this.label8);
            this.tabProducts.Controls.Add(this.label4);
            this.tabProducts.Controls.Add(this.label7);
            this.tabProducts.Controls.Add(this.label3);
            this.tabProducts.Controls.Add(this.label6);
            this.tabProducts.Controls.Add(this.label2);
            this.tabProducts.Controls.Add(this.label5);
            this.tabProducts.Controls.Add(this.label1);
            this.tabProducts.Controls.Add(this.cmbxProductCategory);
            this.tabProducts.Controls.Add(this.cmbxProductSupplier);
            this.tabProducts.Controls.Add(this.chckbxProductDiscontinued);
            this.tabProducts.Controls.Add(this.nmrcProductOrder);
            this.tabProducts.Controls.Add(this.nmrcProductStock);
            this.tabProducts.Controls.Add(this.nmrcProductPrice);
            this.tabProducts.Controls.Add(this.txtProductName);
            this.tabProducts.Controls.Add(this.btnAddNewProduct);
            this.tabProducts.Controls.Add(this.btnDeleteProduct);
            this.tabProducts.Controls.Add(this.btnGetAllProducts);
            this.tabProducts.Controls.Add(this.lstProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(881, 382);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(524, 293);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(164, 23);
            this.btnUpdateProduct.TabIndex = 26;
            this.btnUpdateProduct.Text = "Update Selected Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // nmrcProductReorder
            // 
            this.nmrcProductReorder.Location = new System.Drawing.Point(568, 242);
            this.nmrcProductReorder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcProductReorder.Name = "nmrcProductReorder";
            this.nmrcProductReorder.Size = new System.Drawing.Size(120, 20);
            this.nmrcProductReorder.TabIndex = 25;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(570, 118);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtProductQuantity.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(471, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Discontinued";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(472, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "ReorderLevel";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(472, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "QuantityPerUnit";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(471, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "UnitsOnOrder";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(471, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Category";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(471, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "UnitsInStock";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(471, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(474, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "UnitPrice";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(474, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Name";
            // 
            // cmbxProductCategory
            // 
            this.cmbxProductCategory.FormattingEnabled = true;
            this.cmbxProductCategory.Location = new System.Drawing.Point(570, 86);
            this.cmbxProductCategory.Name = "cmbxProductCategory";
            this.cmbxProductCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbxProductCategory.TabIndex = 15;
            this.cmbxProductCategory.Text = "Select Category";
            // 
            // cmbxProductSupplier
            // 
            this.cmbxProductSupplier.FormattingEnabled = true;
            this.cmbxProductSupplier.Location = new System.Drawing.Point(570, 54);
            this.cmbxProductSupplier.Name = "cmbxProductSupplier";
            this.cmbxProductSupplier.Size = new System.Drawing.Size(121, 21);
            this.cmbxProductSupplier.TabIndex = 14;
            this.cmbxProductSupplier.Text = "Select Supplier";
            // 
            // chckbxProductDiscontinued
            // 
            this.chckbxProductDiscontinued.AutoSize = true;
            this.chckbxProductDiscontinued.Location = new System.Drawing.Point(576, 267);
            this.chckbxProductDiscontinued.Name = "chckbxProductDiscontinued";
            this.chckbxProductDiscontinued.Size = new System.Drawing.Size(42, 17);
            this.chckbxProductDiscontinued.TabIndex = 13;
            this.chckbxProductDiscontinued.Text = "yes";
            this.chckbxProductDiscontinued.UseVisualStyleBackColor = true;
            // 
            // nmrcProductOrder
            // 
            this.nmrcProductOrder.Location = new System.Drawing.Point(570, 211);
            this.nmrcProductOrder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcProductOrder.Name = "nmrcProductOrder";
            this.nmrcProductOrder.Size = new System.Drawing.Size(120, 20);
            this.nmrcProductOrder.TabIndex = 11;
            // 
            // nmrcProductStock
            // 
            this.nmrcProductStock.Location = new System.Drawing.Point(570, 180);
            this.nmrcProductStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcProductStock.Name = "nmrcProductStock";
            this.nmrcProductStock.Size = new System.Drawing.Size(120, 20);
            this.nmrcProductStock.TabIndex = 10;
            // 
            // nmrcProductPrice
            // 
            this.nmrcProductPrice.DecimalPlaces = 3;
            this.nmrcProductPrice.Location = new System.Drawing.Point(570, 149);
            this.nmrcProductPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcProductPrice.Name = "nmrcProductPrice";
            this.nmrcProductPrice.Size = new System.Drawing.Size(120, 20);
            this.nmrcProductPrice.TabIndex = 12;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(570, 23);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 8;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.ForeColor = System.Drawing.Color.Red;
            this.btnAddNewProduct.Location = new System.Drawing.Point(6, 233);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(135, 23);
            this.btnAddNewProduct.TabIndex = 5;
            this.btnAddNewProduct.Text = "Add New Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(6, 261);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(147, 23);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Delete Selected Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGetAllProducts
            // 
            this.btnGetAllProducts.Location = new System.Drawing.Point(6, 204);
            this.btnGetAllProducts.Name = "btnGetAllProducts";
            this.btnGetAllProducts.Size = new System.Drawing.Size(75, 23);
            this.btnGetAllProducts.TabIndex = 1;
            this.btnGetAllProducts.Text = "Get All";
            this.btnGetAllProducts.UseVisualStyleBackColor = true;
            this.btnGetAllProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(6, 21);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(386, 160);
            this.lstProducts.TabIndex = 0;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // tabCategories
            // 
            this.tabCategories.Controls.Add(this.btnAddNewCategory);
            this.tabCategories.Controls.Add(this.btnDeleteSCategory);
            this.tabCategories.Controls.Add(this.label41);
            this.tabCategories.Controls.Add(this.label40);
            this.tabCategories.Controls.Add(this.label39);
            this.tabCategories.Controls.Add(this.lstProductsByCategory);
            this.tabCategories.Controls.Add(this.txtUpdateCatDescription);
            this.tabCategories.Controls.Add(this.txtUpdateCatName);
            this.tabCategories.Controls.Add(this.btnUpdateCategory);
            this.tabCategories.Controls.Add(this.lstCategory);
            this.tabCategories.Controls.Add(this.btnGetAllCategories);
            this.tabCategories.Location = new System.Drawing.Point(4, 22);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategories.Size = new System.Drawing.Size(881, 382);
            this.tabCategories.TabIndex = 0;
            this.tabCategories.Text = "Categories";
            this.tabCategories.UseVisualStyleBackColor = true;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.ForeColor = System.Drawing.Color.Red;
            this.btnAddNewCategory.Location = new System.Drawing.Point(6, 222);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(115, 27);
            this.btnAddNewCategory.TabIndex = 10;
            this.btnAddNewCategory.Text = "Add New Category";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(356, 51);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(86, 23);
            this.label41.TabIndex = 9;
            this.label41.Text = "Description";
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(356, 19);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(86, 23);
            this.label40.TabIndex = 9;
            this.label40.Text = "Category Name";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(320, 222);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(204, 17);
            this.label39.TabIndex = 8;
            this.label39.Text = "Products By Selected Category";
            // 
            // lstProductsByCategory
            // 
            this.lstProductsByCategory.FormattingEnabled = true;
            this.lstProductsByCategory.Location = new System.Drawing.Point(323, 242);
            this.lstProductsByCategory.Name = "lstProductsByCategory";
            this.lstProductsByCategory.Size = new System.Drawing.Size(552, 134);
            this.lstProductsByCategory.TabIndex = 7;
            // 
            // txtUpdateCatDescription
            // 
            this.txtUpdateCatDescription.Location = new System.Drawing.Point(459, 51);
            this.txtUpdateCatDescription.Name = "txtUpdateCatDescription";
            this.txtUpdateCatDescription.Size = new System.Drawing.Size(154, 96);
            this.txtUpdateCatDescription.TabIndex = 6;
            this.txtUpdateCatDescription.Text = "";
            // 
            // txtUpdateCatName
            // 
            this.txtUpdateCatName.Location = new System.Drawing.Point(459, 16);
            this.txtUpdateCatName.Name = "txtUpdateCatName";
            this.txtUpdateCatName.Size = new System.Drawing.Size(154, 20);
            this.txtUpdateCatName.TabIndex = 5;
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(459, 153);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(154, 23);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "Update Selected Category";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateSCategory_Click);
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.label54);
            this.tabSuppliers.Controls.Add(this.label53);
            this.tabSuppliers.Controls.Add(this.label51);
            this.tabSuppliers.Controls.Add(this.label47);
            this.tabSuppliers.Controls.Add(this.label50);
            this.tabSuppliers.Controls.Add(this.label45);
            this.tabSuppliers.Controls.Add(this.label52);
            this.tabSuppliers.Controls.Add(this.Fax);
            this.tabSuppliers.Controls.Add(this.label46);
            this.tabSuppliers.Controls.Add(this.label48);
            this.tabSuppliers.Controls.Add(this.Label44);
            this.tabSuppliers.Controls.Add(this.txtSupplierHomePage);
            this.tabSuppliers.Controls.Add(this.txtSupplierPhone);
            this.tabSuppliers.Controls.Add(this.txtSupplierCountry);
            this.tabSuppliers.Controls.Add(this.txtSupplierPostalCode);
            this.tabSuppliers.Controls.Add(this.txtSupplierFax);
            this.tabSuppliers.Controls.Add(this.txtSupplierRegion);
            this.tabSuppliers.Controls.Add(this.txtSupplierCity);
            this.tabSuppliers.Controls.Add(this.txtSupplierAddress);
            this.tabSuppliers.Controls.Add(this.txtSupplierTitle);
            this.tabSuppliers.Controls.Add(this.txtSupplierContact);
            this.tabSuppliers.Controls.Add(this.txtSupplierName);
            this.tabSuppliers.Controls.Add(this.btnGetAllSuppliers);
            this.tabSuppliers.Controls.Add(this.btnUpdateSupplier);
            this.tabSuppliers.Controls.Add(this.btnDeleteSupplier);
            this.tabSuppliers.Controls.Add(this.btnAddSupplier);
            this.tabSuppliers.Controls.Add(this.lstSuppliers);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(881, 382);
            this.tabSuppliers.TabIndex = 2;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(418, 275);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(94, 20);
            this.label54.TabIndex = 6;
            this.label54.Text = "Home Page";
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(418, 249);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(94, 20);
            this.label53.TabIndex = 6;
            this.label53.Text = "Phone";
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(418, 197);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(94, 20);
            this.label51.TabIndex = 6;
            this.label51.Text = "Postal Code";
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(418, 95);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(94, 20);
            this.label47.TabIndex = 6;
            this.label47.Text = "Address";
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(418, 145);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(94, 20);
            this.label50.TabIndex = 6;
            this.label50.Text = "Region";
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(418, 44);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(94, 20);
            this.label45.TabIndex = 6;
            this.label45.Text = "Contact";
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(418, 223);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(94, 20);
            this.label52.TabIndex = 6;
            this.label52.Text = "Country";
            // 
            // Fax
            // 
            this.Fax.Location = new System.Drawing.Point(418, 170);
            this.Fax.Name = "Fax";
            this.Fax.Size = new System.Drawing.Size(94, 20);
            this.Fax.TabIndex = 6;
            this.Fax.Text = "Fax";
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(418, 70);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(94, 20);
            this.label46.TabIndex = 6;
            this.label46.Text = "Title";
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(418, 120);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(94, 20);
            this.label48.TabIndex = 6;
            this.label48.Text = "City";
            // 
            // Label44
            // 
            this.Label44.Location = new System.Drawing.Point(418, 16);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(94, 20);
            this.Label44.TabIndex = 6;
            this.Label44.Text = "Name";
            // 
            // txtSupplierHomePage
            // 
            this.txtSupplierHomePage.Location = new System.Drawing.Point(528, 275);
            this.txtSupplierHomePage.Name = "txtSupplierHomePage";
            this.txtSupplierHomePage.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierHomePage.TabIndex = 5;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(528, 249);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierPhone.TabIndex = 5;
            // 
            // txtSupplierCountry
            // 
            this.txtSupplierCountry.Location = new System.Drawing.Point(528, 223);
            this.txtSupplierCountry.Name = "txtSupplierCountry";
            this.txtSupplierCountry.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierCountry.TabIndex = 5;
            // 
            // txtSupplierPostalCode
            // 
            this.txtSupplierPostalCode.Location = new System.Drawing.Point(528, 197);
            this.txtSupplierPostalCode.Name = "txtSupplierPostalCode";
            this.txtSupplierPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierPostalCode.TabIndex = 5;
            // 
            // txtSupplierFax
            // 
            this.txtSupplierFax.Location = new System.Drawing.Point(528, 171);
            this.txtSupplierFax.Name = "txtSupplierFax";
            this.txtSupplierFax.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierFax.TabIndex = 5;
            // 
            // txtSupplierRegion
            // 
            this.txtSupplierRegion.Location = new System.Drawing.Point(528, 145);
            this.txtSupplierRegion.Name = "txtSupplierRegion";
            this.txtSupplierRegion.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierRegion.TabIndex = 5;
            // 
            // txtSupplierCity
            // 
            this.txtSupplierCity.Location = new System.Drawing.Point(528, 119);
            this.txtSupplierCity.Name = "txtSupplierCity";
            this.txtSupplierCity.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierCity.TabIndex = 5;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(528, 93);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierAddress.TabIndex = 5;
            // 
            // txtSupplierTitle
            // 
            this.txtSupplierTitle.Location = new System.Drawing.Point(528, 67);
            this.txtSupplierTitle.Name = "txtSupplierTitle";
            this.txtSupplierTitle.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierTitle.TabIndex = 5;
            // 
            // txtSupplierContact
            // 
            this.txtSupplierContact.Location = new System.Drawing.Point(528, 41);
            this.txtSupplierContact.Name = "txtSupplierContact";
            this.txtSupplierContact.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierContact.TabIndex = 5;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(528, 16);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierName.TabIndex = 5;
            // 
            // btnGetAllSuppliers
            // 
            this.btnGetAllSuppliers.Location = new System.Drawing.Point(20, 247);
            this.btnGetAllSuppliers.Name = "btnGetAllSuppliers";
            this.btnGetAllSuppliers.Size = new System.Drawing.Size(75, 23);
            this.btnGetAllSuppliers.TabIndex = 4;
            this.btnGetAllSuppliers.Text = "Get All";
            this.btnGetAllSuppliers.UseVisualStyleBackColor = true;
            this.btnGetAllSuppliers.Click += new System.EventHandler(this.btnGetAllSuppliers_Click);
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Location = new System.Drawing.Point(505, 301);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(151, 23);
            this.btnUpdateSupplier.TabIndex = 3;
            this.btnUpdateSupplier.Text = "Update Selected Supplier";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(20, 301);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteSupplier.TabIndex = 2;
            this.btnDeleteSupplier.Text = "Delete Selected Supplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.ForeColor = System.Drawing.Color.Red;
            this.btnAddSupplier.Location = new System.Drawing.Point(20, 273);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(105, 22);
            this.btnAddSupplier.TabIndex = 1;
            this.btnAddSupplier.Text = "Add New Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.Location = new System.Drawing.Point(29, 16);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(211, 212);
            this.lstSuppliers.TabIndex = 0;
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.label22);
            this.tabEmployees.Controls.Add(this.label21);
            this.tabEmployees.Controls.Add(this.label20);
            this.tabEmployees.Controls.Add(this.label19);
            this.tabEmployees.Controls.Add(this.label18);
            this.tabEmployees.Controls.Add(this.label17);
            this.tabEmployees.Controls.Add(this.label16);
            this.tabEmployees.Controls.Add(this.label15);
            this.tabEmployees.Controls.Add(this.label14);
            this.tabEmployees.Controls.Add(this.label13);
            this.tabEmployees.Controls.Add(this.label12);
            this.tabEmployees.Controls.Add(this.label11);
            this.tabEmployees.Controls.Add(this.label10);
            this.tabEmployees.Controls.Add(this.cmbxEmployeeReportsTo);
            this.tabEmployees.Controls.Add(this.txtEmployeeExtensions);
            this.tabEmployees.Controls.Add(this.txtEmployeePhone);
            this.tabEmployees.Controls.Add(this.txtEmployeeCountry);
            this.tabEmployees.Controls.Add(this.txtEmployeePostal);
            this.tabEmployees.Controls.Add(this.txtEmployeeRegion);
            this.tabEmployees.Controls.Add(this.txtEmployeeCity);
            this.tabEmployees.Controls.Add(this.txtEmployeeNotes);
            this.tabEmployees.Controls.Add(this.txtEmployeeAddress);
            this.tabEmployees.Controls.Add(this.dateTimeHired);
            this.tabEmployees.Controls.Add(this.dateTimeBirth);
            this.tabEmployees.Controls.Add(this.btnUpdateEmployee);
            this.tabEmployees.Controls.Add(this.btnAddNewEmployee);
            this.tabEmployees.Controls.Add(this.brnGetAllEmployees);
            this.tabEmployees.Controls.Add(this.lstEmployees);
            this.tabEmployees.Controls.Add(this.txtEmployeeCourTesy);
            this.tabEmployees.Controls.Add(this.txtEmployeeTitle);
            this.tabEmployees.Controls.Add(this.txtEmployeeFName);
            this.tabEmployees.Controls.Add(this.txtEmployeeLName);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Size = new System.Drawing.Size(881, 382);
            this.tabEmployees.TabIndex = 4;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(696, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 20);
            this.label22.TabIndex = 9;
            this.label22.Text = "Reports To ";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(446, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 20);
            this.label21.TabIndex = 9;
            this.label21.Text = "Notes";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(446, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 20);
            this.label20.TabIndex = 9;
            this.label20.Text = "Adress";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(201, 289);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 20);
            this.label19.TabIndex = 9;
            this.label19.Text = "Country";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(201, 263);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 20);
            this.label18.TabIndex = 9;
            this.label18.Text = "Postal Code";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(201, 237);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "Region";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(201, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "City";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(201, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "Title Of Courtesy";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(201, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Title";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(201, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Hire Date";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(201, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Birth Date";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(201, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "First Name";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(201, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Name";
            // 
            // cmbxEmployeeReportsTo
            // 
            this.cmbxEmployeeReportsTo.FormattingEnabled = true;
            this.cmbxEmployeeReportsTo.Location = new System.Drawing.Point(699, 50);
            this.cmbxEmployeeReportsTo.Name = "cmbxEmployeeReportsTo";
            this.cmbxEmployeeReportsTo.Size = new System.Drawing.Size(121, 21);
            this.cmbxEmployeeReportsTo.TabIndex = 8;
            // 
            // txtEmployeeExtensions
            // 
            this.txtEmployeeExtensions.Location = new System.Drawing.Point(316, 344);
            this.txtEmployeeExtensions.Name = "txtEmployeeExtensions";
            this.txtEmployeeExtensions.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeExtensions.TabIndex = 7;
            // 
            // txtEmployeePhone
            // 
            this.txtEmployeePhone.Location = new System.Drawing.Point(316, 315);
            this.txtEmployeePhone.Name = "txtEmployeePhone";
            this.txtEmployeePhone.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeePhone.TabIndex = 7;
            // 
            // txtEmployeeCountry
            // 
            this.txtEmployeeCountry.Location = new System.Drawing.Point(316, 286);
            this.txtEmployeeCountry.Name = "txtEmployeeCountry";
            this.txtEmployeeCountry.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeCountry.TabIndex = 7;
            // 
            // txtEmployeePostal
            // 
            this.txtEmployeePostal.Location = new System.Drawing.Point(316, 260);
            this.txtEmployeePostal.Name = "txtEmployeePostal";
            this.txtEmployeePostal.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeePostal.TabIndex = 7;
            // 
            // txtEmployeeRegion
            // 
            this.txtEmployeeRegion.Location = new System.Drawing.Point(316, 234);
            this.txtEmployeeRegion.Name = "txtEmployeeRegion";
            this.txtEmployeeRegion.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeRegion.TabIndex = 7;
            // 
            // txtEmployeeCity
            // 
            this.txtEmployeeCity.Location = new System.Drawing.Point(316, 208);
            this.txtEmployeeCity.Name = "txtEmployeeCity";
            this.txtEmployeeCity.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeCity.TabIndex = 7;
            // 
            // txtEmployeeNotes
            // 
            this.txtEmployeeNotes.Location = new System.Drawing.Point(449, 200);
            this.txtEmployeeNotes.Name = "txtEmployeeNotes";
            this.txtEmployeeNotes.Size = new System.Drawing.Size(188, 96);
            this.txtEmployeeNotes.TabIndex = 6;
            this.txtEmployeeNotes.Text = "";
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(449, 52);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(188, 96);
            this.txtEmployeeAddress.TabIndex = 6;
            this.txtEmployeeAddress.Text = "";
            // 
            // dateTimeHired
            // 
            this.dateTimeHired.Location = new System.Drawing.Point(316, 123);
            this.dateTimeHired.Mask = "00/00/0000";
            this.dateTimeHired.Name = "dateTimeHired";
            this.dateTimeHired.Size = new System.Drawing.Size(100, 20);
            this.dateTimeHired.TabIndex = 5;
            this.dateTimeHired.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(316, 88);
            this.dateTimeBirth.Mask = "00/00/0000";
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(100, 20);
            this.dateTimeBirth.TabIndex = 5;
            this.dateTimeBirth.ValidatingType = typeof(System.DateTime);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(708, 297);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(156, 23);
            this.btnUpdateEmployee.TabIndex = 4;
            this.btnUpdateEmployee.Text = "Update Selected Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.ForeColor = System.Drawing.Color.Red;
            this.btnAddNewEmployee.Location = new System.Drawing.Point(19, 302);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(148, 23);
            this.btnAddNewEmployee.TabIndex = 4;
            this.btnAddNewEmployee.Text = "Add New Employee";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // brnGetAllEmployees
            // 
            this.brnGetAllEmployees.Location = new System.Drawing.Point(19, 273);
            this.brnGetAllEmployees.Name = "brnGetAllEmployees";
            this.brnGetAllEmployees.Size = new System.Drawing.Size(75, 23);
            this.brnGetAllEmployees.TabIndex = 3;
            this.brnGetAllEmployees.Text = "Get All";
            this.brnGetAllEmployees.UseVisualStyleBackColor = true;
            this.brnGetAllEmployees.Click += new System.EventHandler(this.brnGetAllEmployees_Click);
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.Location = new System.Drawing.Point(19, 46);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(160, 199);
            this.lstEmployees.TabIndex = 2;
            this.lstEmployees.SelectedIndexChanged += new System.EventHandler(this.lstEmployees_SelectedIndexChanged);
            // 
            // txtEmployeeCourTesy
            // 
            this.txtEmployeeCourTesy.Location = new System.Drawing.Point(316, 182);
            this.txtEmployeeCourTesy.Name = "txtEmployeeCourTesy";
            this.txtEmployeeCourTesy.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeCourTesy.TabIndex = 0;
            // 
            // txtEmployeeTitle
            // 
            this.txtEmployeeTitle.Location = new System.Drawing.Point(316, 156);
            this.txtEmployeeTitle.Name = "txtEmployeeTitle";
            this.txtEmployeeTitle.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeTitle.TabIndex = 0;
            // 
            // txtEmployeeFName
            // 
            this.txtEmployeeFName.Location = new System.Drawing.Point(316, 62);
            this.txtEmployeeFName.Name = "txtEmployeeFName";
            this.txtEmployeeFName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeFName.TabIndex = 0;
            // 
            // txtEmployeeLName
            // 
            this.txtEmployeeLName.Location = new System.Drawing.Point(316, 36);
            this.txtEmployeeLName.Name = "txtEmployeeLName";
            this.txtEmployeeLName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeLName.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.txtShipName);
            this.tabOrders.Controls.Add(this.label34);
            this.tabOrders.Controls.Add(this.label33);
            this.tabOrders.Controls.Add(this.label29);
            this.tabOrders.Controls.Add(this.label32);
            this.tabOrders.Controls.Add(this.label28);
            this.tabOrders.Controls.Add(this.label31);
            this.tabOrders.Controls.Add(this.label27);
            this.tabOrders.Controls.Add(this.label30);
            this.tabOrders.Controls.Add(this.label26);
            this.tabOrders.Controls.Add(this.label25);
            this.tabOrders.Controls.Add(this.label24);
            this.tabOrders.Controls.Add(this.label35);
            this.tabOrders.Controls.Add(this.label23);
            this.tabOrders.Controls.Add(this.txtOrderAddress);
            this.tabOrders.Controls.Add(this.nmrcOrderFreight);
            this.tabOrders.Controls.Add(this.cmbxOrderShippers);
            this.tabOrders.Controls.Add(this.cmbxOrderEmployee);
            this.tabOrders.Controls.Add(this.cmbxOrderCustomer);
            this.tabOrders.Controls.Add(this.txtOrderShippedDate);
            this.tabOrders.Controls.Add(this.txtOrderRequiredDate);
            this.tabOrders.Controls.Add(this.txtOrderOrderDate);
            this.tabOrders.Controls.Add(this.btnUpdateOrder);
            this.tabOrders.Controls.Add(this.btnAddNewOrder);
            this.tabOrders.Controls.Add(this.btnDeleteOrder);
            this.tabOrders.Controls.Add(this.btnGetAllOrders);
            this.tabOrders.Controls.Add(this.lstOrders);
            this.tabOrders.Controls.Add(this.txtOrderPostalCode);
            this.tabOrders.Controls.Add(this.txtOrderShipRegion);
            this.tabOrders.Controls.Add(this.txtOrderShipCity);
            this.tabOrders.Controls.Add(this.txtOrderShipCountry);
            this.tabOrders.Location = new System.Drawing.Point(4, 22);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Size = new System.Drawing.Size(881, 382);
            this.tabOrders.TabIndex = 3;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(351, 15);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(120, 20);
            this.txtShipName.TabIndex = 8;
            // 
            // label34
            // 
            this.label34.AutoEllipsis = true;
            this.label34.Location = new System.Drawing.Point(511, 162);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(51, 18);
            this.label34.TabIndex = 7;
            this.label34.Text = "Adress";
            // 
            // label33
            // 
            this.label33.AutoEllipsis = true;
            this.label33.Location = new System.Drawing.Point(511, 130);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(51, 18);
            this.label33.TabIndex = 7;
            this.label33.Text = "Country";
            // 
            // label29
            // 
            this.label29.AutoEllipsis = true;
            this.label29.Location = new System.Drawing.Point(255, 234);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 18);
            this.label29.TabIndex = 7;
            this.label29.Text = "Freight";
            // 
            // label32
            // 
            this.label32.AutoEllipsis = true;
            this.label32.Location = new System.Drawing.Point(511, 103);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(51, 18);
            this.label32.TabIndex = 7;
            this.label32.Text = "PostalCode";
            // 
            // label28
            // 
            this.label28.AutoEllipsis = true;
            this.label28.Location = new System.Drawing.Point(255, 196);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 18);
            this.label28.TabIndex = 7;
            this.label28.Text = "Ship Via";
            // 
            // label31
            // 
            this.label31.AutoEllipsis = true;
            this.label31.Location = new System.Drawing.Point(511, 74);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(51, 18);
            this.label31.TabIndex = 7;
            this.label31.Text = "Region";
            // 
            // label27
            // 
            this.label27.AutoEllipsis = true;
            this.label27.Location = new System.Drawing.Point(255, 167);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 18);
            this.label27.TabIndex = 7;
            this.label27.Text = "Shipped Date";
            // 
            // label30
            // 
            this.label30.AutoEllipsis = true;
            this.label30.Location = new System.Drawing.Point(511, 48);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 18);
            this.label30.TabIndex = 7;
            this.label30.Text = "City";
            // 
            // label26
            // 
            this.label26.AutoEllipsis = true;
            this.label26.Location = new System.Drawing.Point(255, 141);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 18);
            this.label26.TabIndex = 7;
            this.label26.Text = "Required Date";
            // 
            // label25
            // 
            this.label25.AutoEllipsis = true;
            this.label25.Location = new System.Drawing.Point(255, 115);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 18);
            this.label25.TabIndex = 7;
            this.label25.Text = "Order Date";
            // 
            // label24
            // 
            this.label24.AutoEllipsis = true;
            this.label24.Location = new System.Drawing.Point(255, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 18);
            this.label24.TabIndex = 7;
            this.label24.Text = "Employee";
            // 
            // label35
            // 
            this.label35.AutoEllipsis = true;
            this.label35.Location = new System.Drawing.Point(255, 15);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(68, 18);
            this.label35.TabIndex = 7;
            this.label35.Text = "Ship Name";
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.Location = new System.Drawing.Point(255, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 18);
            this.label23.TabIndex = 7;
            this.label23.Text = "Customer";
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Location = new System.Drawing.Point(568, 162);
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.Size = new System.Drawing.Size(250, 89);
            this.txtOrderAddress.TabIndex = 6;
            this.txtOrderAddress.Text = "";
            // 
            // nmrcOrderFreight
            // 
            this.nmrcOrderFreight.DecimalPlaces = 3;
            this.nmrcOrderFreight.Location = new System.Drawing.Point(351, 232);
            this.nmrcOrderFreight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcOrderFreight.Name = "nmrcOrderFreight";
            this.nmrcOrderFreight.Size = new System.Drawing.Size(120, 20);
            this.nmrcOrderFreight.TabIndex = 5;
            this.nmrcOrderFreight.ThousandsSeparator = true;
            // 
            // cmbxOrderShippers
            // 
            this.cmbxOrderShippers.FormattingEnabled = true;
            this.cmbxOrderShippers.Location = new System.Drawing.Point(350, 192);
            this.cmbxOrderShippers.Name = "cmbxOrderShippers";
            this.cmbxOrderShippers.Size = new System.Drawing.Size(121, 21);
            this.cmbxOrderShippers.TabIndex = 4;
            // 
            // cmbxOrderEmployee
            // 
            this.cmbxOrderEmployee.FormattingEnabled = true;
            this.cmbxOrderEmployee.Location = new System.Drawing.Point(350, 85);
            this.cmbxOrderEmployee.Name = "cmbxOrderEmployee";
            this.cmbxOrderEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbxOrderEmployee.TabIndex = 4;
            // 
            // cmbxOrderCustomer
            // 
            this.cmbxOrderCustomer.FormattingEnabled = true;
            this.cmbxOrderCustomer.Location = new System.Drawing.Point(350, 48);
            this.cmbxOrderCustomer.Name = "cmbxOrderCustomer";
            this.cmbxOrderCustomer.Size = new System.Drawing.Size(121, 21);
            this.cmbxOrderCustomer.TabIndex = 4;
            // 
            // txtOrderShippedDate
            // 
            this.txtOrderShippedDate.Location = new System.Drawing.Point(351, 164);
            this.txtOrderShippedDate.Mask = "00/00/0000";
            this.txtOrderShippedDate.Name = "txtOrderShippedDate";
            this.txtOrderShippedDate.Size = new System.Drawing.Size(100, 20);
            this.txtOrderShippedDate.TabIndex = 3;
            this.txtOrderShippedDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtOrderRequiredDate
            // 
            this.txtOrderRequiredDate.Location = new System.Drawing.Point(351, 138);
            this.txtOrderRequiredDate.Mask = "00/00/0000";
            this.txtOrderRequiredDate.Name = "txtOrderRequiredDate";
            this.txtOrderRequiredDate.Size = new System.Drawing.Size(100, 20);
            this.txtOrderRequiredDate.TabIndex = 3;
            this.txtOrderRequiredDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtOrderOrderDate
            // 
            this.txtOrderOrderDate.Location = new System.Drawing.Point(351, 112);
            this.txtOrderOrderDate.Mask = "00/00/0000";
            this.txtOrderOrderDate.Name = "txtOrderOrderDate";
            this.txtOrderOrderDate.Size = new System.Drawing.Size(100, 20);
            this.txtOrderOrderDate.TabIndex = 3;
            this.txtOrderOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(689, 294);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(129, 23);
            this.btnUpdateOrder.TabIndex = 2;
            this.btnUpdateOrder.Text = "Update Selected Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.ForeColor = System.Drawing.Color.Red;
            this.btnAddNewOrder.Location = new System.Drawing.Point(19, 170);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(102, 23);
            this.btnAddNewOrder.TabIndex = 2;
            this.btnAddNewOrder.Text = "Add New Order";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(19, 199);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(121, 23);
            this.btnDeleteOrder.TabIndex = 2;
            this.btnDeleteOrder.Text = "Delete Selected Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnGetAllOrders
            // 
            this.btnGetAllOrders.Location = new System.Drawing.Point(19, 141);
            this.btnGetAllOrders.Name = "btnGetAllOrders";
            this.btnGetAllOrders.Size = new System.Drawing.Size(75, 23);
            this.btnGetAllOrders.TabIndex = 2;
            this.btnGetAllOrders.Text = "Get All";
            this.btnGetAllOrders.UseVisualStyleBackColor = true;
            this.btnGetAllOrders.Click += new System.EventHandler(this.btnGetAllOrders_Click);
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(19, 15);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(230, 108);
            this.lstOrders.TabIndex = 1;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // txtOrderPostalCode
            // 
            this.txtOrderPostalCode.Location = new System.Drawing.Point(568, 101);
            this.txtOrderPostalCode.Name = "txtOrderPostalCode";
            this.txtOrderPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtOrderPostalCode.TabIndex = 0;
            // 
            // txtOrderShipRegion
            // 
            this.txtOrderShipRegion.Location = new System.Drawing.Point(568, 75);
            this.txtOrderShipRegion.Name = "txtOrderShipRegion";
            this.txtOrderShipRegion.Size = new System.Drawing.Size(100, 20);
            this.txtOrderShipRegion.TabIndex = 0;
            // 
            // txtOrderShipCity
            // 
            this.txtOrderShipCity.Location = new System.Drawing.Point(568, 49);
            this.txtOrderShipCity.Name = "txtOrderShipCity";
            this.txtOrderShipCity.Size = new System.Drawing.Size(100, 20);
            this.txtOrderShipCity.TabIndex = 0;
            // 
            // txtOrderShipCountry
            // 
            this.txtOrderShipCountry.Location = new System.Drawing.Point(568, 127);
            this.txtOrderShipCountry.Name = "txtOrderShipCountry";
            this.txtOrderShipCountry.Size = new System.Drawing.Size(100, 20);
            this.txtOrderShipCountry.TabIndex = 0;
            // 
            // tabShippers
            // 
            this.tabShippers.Controls.Add(this.btnUpdate);
            this.tabShippers.Controls.Add(this.btnDeleteShipper);
            this.tabShippers.Controls.Add(this.btnAddNewShipper);
            this.tabShippers.Controls.Add(this.label43);
            this.tabShippers.Controls.Add(this.label42);
            this.tabShippers.Controls.Add(this.txtShipperPhone);
            this.tabShippers.Controls.Add(this.txtShipperName);
            this.tabShippers.Controls.Add(this.btnGetAllShippers);
            this.tabShippers.Controls.Add(this.lstShippers);
            this.tabShippers.Location = new System.Drawing.Point(4, 22);
            this.tabShippers.Name = "tabShippers";
            this.tabShippers.Size = new System.Drawing.Size(881, 382);
            this.tabShippers.TabIndex = 5;
            this.tabShippers.Text = "Shippers";
            this.tabShippers.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(431, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Selected Shipper";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteShipper
            // 
            this.btnDeleteShipper.Location = new System.Drawing.Point(25, 241);
            this.btnDeleteShipper.Name = "btnDeleteShipper";
            this.btnDeleteShipper.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteShipper.TabIndex = 5;
            this.btnDeleteShipper.Text = "Delete Selected Shipper";
            this.btnDeleteShipper.UseVisualStyleBackColor = true;
            this.btnDeleteShipper.Click += new System.EventHandler(this.btnDeleteShipper_Click);
            // 
            // btnAddNewShipper
            // 
            this.btnAddNewShipper.ForeColor = System.Drawing.Color.Red;
            this.btnAddNewShipper.Location = new System.Drawing.Point(25, 212);
            this.btnAddNewShipper.Name = "btnAddNewShipper";
            this.btnAddNewShipper.Size = new System.Drawing.Size(118, 23);
            this.btnAddNewShipper.TabIndex = 4;
            this.btnAddNewShipper.Text = "Add New Shipper";
            this.btnAddNewShipper.UseVisualStyleBackColor = true;
            this.btnAddNewShipper.Click += new System.EventHandler(this.btnAddNewShipper_Click_1);
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(428, 71);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(100, 23);
            this.label43.TabIndex = 3;
            this.label43.Text = "Phone";
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(428, 21);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(100, 23);
            this.label42.TabIndex = 3;
            this.label42.Text = "Company Name";
            // 
            // txtShipperPhone
            // 
            this.txtShipperPhone.Location = new System.Drawing.Point(554, 68);
            this.txtShipperPhone.Name = "txtShipperPhone";
            this.txtShipperPhone.Size = new System.Drawing.Size(100, 20);
            this.txtShipperPhone.TabIndex = 2;
            this.txtShipperPhone.Text = ",";
            // 
            // txtShipperName
            // 
            this.txtShipperName.Location = new System.Drawing.Point(554, 21);
            this.txtShipperName.Name = "txtShipperName";
            this.txtShipperName.Size = new System.Drawing.Size(100, 20);
            this.txtShipperName.TabIndex = 2;
            // 
            // btnGetAllShippers
            // 
            this.btnGetAllShippers.Location = new System.Drawing.Point(25, 187);
            this.btnGetAllShippers.Name = "btnGetAllShippers";
            this.btnGetAllShippers.Size = new System.Drawing.Size(75, 23);
            this.btnGetAllShippers.TabIndex = 1;
            this.btnGetAllShippers.Text = "Get All";
            this.btnGetAllShippers.UseVisualStyleBackColor = true;
            this.btnGetAllShippers.Click += new System.EventHandler(this.btnGetAllShippers_Click);
            // 
            // lstShippers
            // 
            this.lstShippers.FormattingEnabled = true;
            this.lstShippers.Location = new System.Drawing.Point(25, 21);
            this.lstShippers.Name = "lstShippers";
            this.lstShippers.Size = new System.Drawing.Size(355, 160);
            this.lstShippers.TabIndex = 0;
            this.lstShippers.SelectedIndexChanged += new System.EventHandler(this.lstShippers_SelectedIndexChanged);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.label38);
            this.tabCustomers.Controls.Add(this.label37);
            this.tabCustomers.Controls.Add(this.label36);
            this.tabCustomers.Controls.Add(this.txtCustomerPhone);
            this.tabCustomers.Controls.Add(this.txtCustomerContact);
            this.tabCustomers.Controls.Add(this.txtCustomerCompany);
            this.tabCustomers.Controls.Add(this.btnGetAllCustomers);
            this.tabCustomers.Controls.Add(this.lstCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(881, 382);
            this.tabCustomers.TabIndex = 6;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(329, 102);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(93, 23);
            this.label38.TabIndex = 3;
            this.label38.Text = "Phone";
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(329, 61);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(93, 23);
            this.label37.TabIndex = 3;
            this.label37.Text = "Contact Name";
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(329, 22);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(93, 23);
            this.label36.TabIndex = 3;
            this.label36.Text = "Company Name";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(428, 99);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(145, 20);
            this.txtCustomerPhone.TabIndex = 2;
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Location = new System.Drawing.Point(428, 58);
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.Size = new System.Drawing.Size(145, 20);
            this.txtCustomerContact.TabIndex = 2;
            // 
            // txtCustomerCompany
            // 
            this.txtCustomerCompany.Location = new System.Drawing.Point(428, 22);
            this.txtCustomerCompany.Name = "txtCustomerCompany";
            this.txtCustomerCompany.Size = new System.Drawing.Size(145, 20);
            this.txtCustomerCompany.TabIndex = 2;
            // 
            // btnGetAllCustomers
            // 
            this.btnGetAllCustomers.Location = new System.Drawing.Point(31, 164);
            this.btnGetAllCustomers.Name = "btnGetAllCustomers";
            this.btnGetAllCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnGetAllCustomers.TabIndex = 1;
            this.btnGetAllCustomers.Text = "Get All";
            this.btnGetAllCustomers.UseVisualStyleBackColor = true;
            this.btnGetAllCustomers.Click += new System.EventHandler(this.btnGetAllCustomers_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(31, 22);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(273, 121);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 477);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductReorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcProductPrice)).EndInit();
            this.tabCategories.ResumeLayout(false);
            this.tabCategories.PerformLayout();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcOrderFreight)).EndInit();
            this.tabShippers.ResumeLayout(false);
            this.tabShippers.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Button btnGetAllCategories;
        private System.Windows.Forms.Button btnDeleteSCategory;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.RichTextBox txtUpdateCatDescription;
        private System.Windows.Forms.TextBox txtUpdateCatName;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnGetAllProducts;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
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
        private System.Windows.Forms.ListBox lstProductsByCategory;
        private System.Windows.Forms.Button btnGetAllSuppliers;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.TextBox txtSupplierHomePage;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.TextBox txtSupplierCountry;
        private System.Windows.Forms.TextBox txtSupplierPostalCode;
        private System.Windows.Forms.TextBox txtSupplierFax;
        private System.Windows.Forms.TextBox txtSupplierRegion;
        private System.Windows.Forms.TextBox txtSupplierCity;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierTitle;
        private System.Windows.Forms.TextBox txtSupplierContact;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtOrderPostalCode;
        private System.Windows.Forms.TextBox txtOrderShipRegion;
        private System.Windows.Forms.TextBox txtOrderShipCity;
        private System.Windows.Forms.TextBox txtOrderShipCountry;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnGetAllOrders;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabShippers;
        private System.Windows.Forms.TextBox txtEmployeeCourTesy;
        private System.Windows.Forms.TextBox txtEmployeeTitle;
        private System.Windows.Forms.TextBox txtEmployeeFName;
        private System.Windows.Forms.TextBox txtEmployeeLName;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Button brnGetAllEmployees;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.MaskedTextBox dateTimeHired;
        private System.Windows.Forms.MaskedTextBox dateTimeBirth;
        private System.Windows.Forms.TextBox txtEmployeeExtensions;
        private System.Windows.Forms.TextBox txtEmployeePhone;
        private System.Windows.Forms.TextBox txtEmployeeCountry;
        private System.Windows.Forms.TextBox txtEmployeePostal;
        private System.Windows.Forms.TextBox txtEmployeeRegion;
        private System.Windows.Forms.TextBox txtEmployeeCity;
        private System.Windows.Forms.RichTextBox txtEmployeeNotes;
        private System.Windows.Forms.RichTextBox txtEmployeeAddress;
        private System.Windows.Forms.ComboBox cmbxEmployeeReportsTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtOrderShippedDate;
        private System.Windows.Forms.MaskedTextBox txtOrderRequiredDate;
        private System.Windows.Forms.MaskedTextBox txtOrderOrderDate;
        private System.Windows.Forms.ComboBox cmbxOrderShippers;
        private System.Windows.Forms.ComboBox cmbxOrderEmployee;
        private System.Windows.Forms.ComboBox cmbxOrderCustomer;
        private System.Windows.Forms.RichTextBox txtOrderAddress;
        private System.Windows.Forms.NumericUpDown nmrcOrderFreight;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.Button btnGetAllCustomers;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtCustomerContact;
        private System.Windows.Forms.TextBox txtCustomerCompany;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Button btnGetAllShippers;
        private System.Windows.Forms.ListBox lstShippers;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtShipperPhone;
        private System.Windows.Forms.TextBox txtShipperName;
        private System.Windows.Forms.Button btnAddNewCategory;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteShipper;
        private System.Windows.Forms.Button btnAddNewShipper;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label Fax;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label Label44;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
    }
}

