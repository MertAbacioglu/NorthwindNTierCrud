using Project.BLL.ManagementSystem;
using Project.ENTITIES.Models;
using Project.LOG.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitilazeDependencies();

        }

        CategoryManager categoryManager;
        ProductManager productManager;
        SupplierManager supplierManager;
        EmployeeManager employeeManager;
        OrderManager orderManager;
        CustomerManager customerManager;
        ShipperManager shipperManager;
        LogManager logManager;

        void InitilazeDependencies()
        {
            categoryManager = new CategoryManager();
            productManager = new ProductManager();
            supplierManager = new SupplierManager();
            employeeManager = new EmployeeManager();
            orderManager = new OrderManager();
            customerManager = new CustomerManager();
            shipperManager = new ShipperManager();
            logManager = new LogManager();
            RefreshAllTables();
            RefreshAllComboBoxes();

        }
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            lstCategory.DataSource = categoryManager.GetCategories();
        }
        public void RefreshAllTables()
        {
            lstCategory.DataSource = categoryManager.GetCategories();
            lstProducts.DataSource = productManager.GetProducts();
            lstSuppliers.DataSource = supplierManager.GetSuppliers();
            lstEmployees.DataSource = employeeManager.GetEmployees();
            lstOrders.DataSource = orderManager.GetOrders();
            lstCustomers.DataSource = customerManager.GetCustomers();
            lstShippers.DataSource = shipperManager.GetShippers();
        }
        public void RefreshAllComboBoxes()
        {
            cmbxProductCategory.DataSource = categoryManager.GetCategories();
            cmbxEmployeeReportsTo.DataSource = employeeManager.GetEmployees();
            cmbxOrderEmployee.DataSource = employeeManager.GetEmployees();
            cmbxOrderCustomer.DataSource = customerManager.GetCustomers();
            cmbxOrderShippers.DataSource = shipperManager.GetShippers();
            cmbxProductSupplier.DataSource = supplierManager.GetSuppliers();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                Category toBeDeleted = lstCategory.SelectedItem as Category;
                if (toBeDeleted != null)
                {
                    categoryManager.DeleteSelectedCategory(toBeDeleted);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Category Deleted : {toBeDeleted.CategoryID}"));
                    MessageBox.Show("category deleted");
                    FillCategoryComboBox();
                    FillProductListByCategory();
                    FillCategoryList();

                }
                else
                {
                    MessageBox.Show("select a category from list to delete");

                }

            }
            catch (Exception ex)
            {
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
                MessageBox.Show("first delete the products belonging to the selected category ");


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// İstenilen form'u açar.
        /// </summary>
        /// <typeparam name="T"> Açılması istenilen form'un adını girin</typeparam>
        private void ShowForm<T>() where T : Form, new()
        {
            T form = new T();
            form.MdiParent = this.MdiParent;
            form.ShowDialog();
        }

        private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProductListByCategory();
        }

        private void btnUpdateSCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Category toBeUpdated = lstCategory.SelectedItem as Category;

                Category category = new Category
                {
                    CategoryName = txtUpdateCatName.Text,
                    Description = txtUpdateCatDescription.Text

                };
                if (category.CategoryName != string.Empty)
                {
                    categoryManager.UpdateCategory(category, toBeUpdated.CategoryID);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Category Updated : {toBeUpdated.CategoryID}"));
                    MessageBox.Show("category updated");

                    FillCategoryComboBox();
                    FillCategoryList();
                    FillCategoryList();
                }
                else
                {
                    MessageBox.Show("enter a category name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
            }
        }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            lstProducts.DataSource = productManager.GetProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Product toBeDeleted = lstProducts.SelectedItem as Product;
                productManager.DeleteSelectedProduct(toBeDeleted);
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Product Deleted : {toBeDeleted.ProductID}"));
                MessageBox.Show("product deleted");
                FillProductList();
                FillProductListByCategory();

            }
            catch (Exception ex)
            {
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
                MessageBox.Show("Before deleting this product, you must remove it from orders.\nYou can add new products first and then delete them  ");
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = lstProducts.SelectedItem as Product;

            if (selectedProduct != null)
            {
                txtProductName.Text = selectedProduct.ProductName;

                foreach (Supplier item in cmbxProductSupplier.Items)
                {
                    if (item.SupplierID == selectedProduct.SupplierID)
                    {
                        cmbxProductSupplier.SelectedItem = item;
                    }
                }

                foreach (Category item in cmbxProductCategory.Items)
                {
                    if (item.CategoryID == selectedProduct.CategoryID)
                    {
                        cmbxProductCategory.SelectedItem = item;
                    }
                }
                txtProductQuantity.Text = selectedProduct.QuantityPerUnit;
                nmrcProductPrice.Value = Convert.ToDecimal(selectedProduct.UnitPrice);
                nmrcProductStock.Value = Convert.ToInt16(selectedProduct.UnitsInStock);
                nmrcProductOrder.Value = Convert.ToInt16(selectedProduct.UnitsOnOrder);
                nmrcProductReorder.Value = Convert.ToInt16(selectedProduct.ReorderLevel);
                if (selectedProduct.Discontinued == true)
                {
                    chckbxProductDiscontinued.Checked = false;
                }
                else
                    chckbxProductDiscontinued.Checked = true;
            }


        }
        #region ComboBoxFillingMethods
        public void FillCategoryComboBox()
        {
            cmbxProductCategory.DataSource = categoryManager.GetCategories();
        }
        public void FillSupplierComboBox()
        {
            cmbxProductSupplier.DataSource = supplierManager.GetSuppliers();
        }
        public void FillEmployeeCombobox()
        {
            cmbxEmployeeReportsTo.DataSource = employeeManager.GetEmployees();
            cmbxOrderEmployee.DataSource = employeeManager.GetEmployees();
        }
        public void FillCustomerCombobox()
        {
            cmbxOrderCustomer.DataSource = customerManager.GetCustomers();

        }
        public void FillShipperCombobox()
        {
            cmbxOrderShippers.DataSource = shipperManager.GetShippers();
        }
        #endregion

        #region ListboxFillingMethods
        public void FillCategoryList()
        {
            lstCategory.DataSource = categoryManager.GetCategories();

        }
        public void FillProductListByCategory()
        {
            Category category = lstCategory.SelectedItem as Category;
            int id = category.CategoryID;
            lstProductsByCategory.DataSource = productManager.GetProdutsByCategory(category, id);
            if (lstCategory.SelectedItem as Category != null)
            {
                txtUpdateCatName.Text = (lstCategory.SelectedItem as Category).CategoryName;
                txtUpdateCatDescription.Text = (lstCategory.SelectedItem as Category).Description;
            }
        }
        public void FillProductList()
        {
            lstProducts.DataSource = productManager.GetProducts();
        }
        public void FillSupplierList()
        {
            lstSuppliers.DataSource = supplierManager.GetSuppliers();
        }
        public void FillOrderList()
        {
            lstOrders.DataSource = orderManager.GetOrders();
        }
        public void FillCustomerList()
        {
            lstCustomers.DataSource = customerManager.GetCustomers();
        }
        public void FillEmployeeList()
        {
            lstEmployees.DataSource = employeeManager.GetEmployees();
        }
        public void FillShipperList()
        {
            lstShippers.DataSource = shipperManager.GetShippers();
        }
        #endregion
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {

            ShowForm<AddProduct>();

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product toBeUpdated = lstProducts.SelectedItem as Product;

                Product product = new Product()
                {
                    ProductName = txtProductName.Text,
                    SupplierID = (cmbxProductSupplier.SelectedItem as Supplier).SupplierID,
                    CategoryID = (cmbxProductCategory.SelectedItem as Category).CategoryID,
                    QuantityPerUnit = txtProductQuantity.Text,
                    UnitPrice = nmrcProductPrice.Value,
                    UnitsInStock = Convert.ToInt16(nmrcProductStock.Value),
                    UnitsOnOrder = Convert.ToInt16(nmrcProductOrder.Value),
                    Discontinued = chckbxProductDiscontinued.Checked ? false : true

                };
                if (product.ProductName == string.Empty || product.UnitPrice == 0)
                {

                    productManager.UpdateProduct(product, toBeUpdated.ProductID);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Product Updated : {toBeUpdated.ProductID}"));
                    MessageBox.Show("check product name or unit price");
                    FillProductList();
                    FillProductListByCategory();
                }
                else
                {
                    productManager.UpdateProduct(product, toBeUpdated.ProductID);
                    MessageBox.Show("product updated");
                    FillProductList();
                    FillProductListByCategory();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
            }
        }

        private void btnGetAllSuppliers_Click(object sender, EventArgs e)
        {
            lstSuppliers.DataSource = supplierManager.GetSuppliers();

        }

        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier supplier = lstSuppliers.SelectedItem as Supplier;
            if (supplier != null)
            {
                txtSupplierName.Text = supplier.CompanyName;
                txtSupplierContact.Text = supplier.ContactName;
                txtSupplierTitle.Text = supplier.ContactTitle;
                txtSupplierAddress.Text = supplier.Address;
                txtSupplierCity.Text = supplier.City;
                txtSupplierRegion.Text = supplier.Region;
                txtSupplierPostalCode.Text = supplier.PostalCode;
                txtSupplierCountry.Text = supplier.Country;
                txtSupplierPhone.Text = supplier.Phone;
                txtSupplierFax.Text = supplier.Fax;
                txtSupplierHomePage.Text = supplier.HomePage;

            }

        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier toBeDeleted = lstSuppliers.SelectedItem as Supplier;
                supplierManager.DeleteSupplier(toBeDeleted);
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Supplier Deleted : {toBeDeleted.SupplierID}"));
                MessageBox.Show("supplier deleted");
                FillSupplierComboBox();
                FillSupplierList();
            }
            catch (Exception ex)
            {
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
                MessageBox.Show("Error occured");

            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            ShowForm<AddSupplier>();
        }

        private void brnGetAllEmployees_Click(object sender, EventArgs e)
        {
            lstEmployees.DataSource = employeeManager.GetEmployees();
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmployee = lstEmployees.SelectedItem as Employee;
            if (selectedEmployee != null)
            {
                txtEmployeeLName.Text = selectedEmployee.LastName;
                txtEmployeeFName.Text = selectedEmployee.FirstName;
                txtEmployeeTitle.Text = selectedEmployee.Title;
                txtEmployeeLName.Text = selectedEmployee.LastName;
                txtEmployeeCourTesy.Text = selectedEmployee.TitleOfCourTesy;
                dateTimeBirth.Text = string.Format("{0:dd/MM/yyyy}", selectedEmployee.BirthDay);
                dateTimeHired.Text = string.Format("{0:dd/MM/yyyy}", selectedEmployee.HireDate);
                txtEmployeeAddress.Text = selectedEmployee.Address;
                txtEmployeeCity.Text = selectedEmployee.City;
                txtEmployeeRegion.Text = selectedEmployee.Region;
                txtEmployeePostal.Text = selectedEmployee.PostalCode;
                txtEmployeeCountry.Text = selectedEmployee.Country;
                txtEmployeeExtensions.Text = selectedEmployee.Extension;
                txtEmployeeNotes.Text = selectedEmployee.Notes;


                foreach (Employee item in cmbxEmployeeReportsTo.Items)
                {
                    if (item.EmployeeID == selectedEmployee.ReportsTo)
                    {
                        cmbxEmployeeReportsTo.SelectedItem = item;
                    }
                }
            }


        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            ShowForm<AddEmployee>();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee toBeUpdated = cmbxEmployeeReportsTo.SelectedItem as Employee;
                Employee employeeReportsTo = lstEmployees.SelectedItem as Employee;
                if (employeeReportsTo.EmployeeID == toBeUpdated.EmployeeID)
                {
                    MessageBox.Show("you cannot report to yourself");
                    return;
                }
                if (txtEmployeeLName.Text != string.Empty && txtEmployeeLName.Text != string.Empty)
                {
                    Employee employee = new Employee   //Todo : ekle
                    {
                        LastName = txtEmployeeLName.Text,
                        FirstName = txtEmployeeFName.Text,
                        Title = txtEmployeeTitle.Text,
                        TitleOfCourTesy = txtEmployeeCourTesy.Text,
                        BirthDay = DateTime.TryParse(dateTimeBirth.Text, out DateTime birthDate)
                    ? birthDate
                    : default(DateTime?),
                        HireDate = DateTime.TryParse(dateTimeHired.Text, out DateTime hireDate)
                    ? hireDate
                    : default(DateTime?),
                        Address = txtEmployeeAddress.Text,
                        City = txtEmployeeCity.Text,
                        Region = txtEmployeeRegion.Text,
                        PostalCode = txtEmployeePostal.Text,
                        Country = txtEmployeeCountry.Text,
                        HomePhone = txtEmployeePhone.Text,
                        Extension = txtEmployeeExtensions.Text,
                        Notes = txtEmployeeNotes.Text,
                        ReportsTo = employeeReportsTo.EmployeeID,
                    };
                    employeeManager.UpdateEmployee(employee, toBeUpdated.EmployeeID);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Employee Updated: {toBeUpdated.EmployeeID}"));
                    FillEmployeeCombobox();
                    FillEmployeeList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
            }




        }

        private void btnGetAllOrders_Click(object sender, EventArgs e)
        {

            lstOrders.DataSource = orderManager.GetOrders();
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order selectedOrder = lstOrders.SelectedItem as Order;
            if (selectedOrder != null)
            {
                txtOrderAddress.Text = selectedOrder.ShipAddress;
                txtOrderShipCity.Text = selectedOrder.ShipCity;
                txtShipName.Text = selectedOrder.ShipName;
                txtOrderShipCountry.Text = selectedOrder.ShipCountry;
                txtOrderShipRegion.Text = selectedOrder.ShipRegion;
                txtOrderOrderDate.Text = string.Format("{0:dd/MM/yyyy}", selectedOrder.OrderDate);
                txtOrderRequiredDate.Text = string.Format("{0:dd/MM/yyyy}", selectedOrder.RequiredDate);
                txtOrderShippedDate.Text = string.Format("{0:dd/MM/yyyy}", selectedOrder.ShippedDate);
                txtOrderPostalCode.Text = selectedOrder.ShipPostalCode;
                nmrcOrderFreight.Value = Convert.ToDecimal(selectedOrder.Freight.Value);

                foreach (Employee item in cmbxOrderEmployee.Items)
                {
                    if (item.EmployeeID == selectedOrder.EmployeeID)
                    {
                        cmbxOrderEmployee.SelectedItem = item;
                    }
                }

                foreach (Customer item in cmbxOrderCustomer.Items)
                {
                    if (item.CustomerID == selectedOrder.CustomerID)
                    {
                        cmbxOrderCustomer.SelectedItem = item;
                    }
                }


                foreach (Shipper item in cmbxOrderShippers.Items)
                {
                    if (item.ShipperID == selectedOrder.ShipVia)
                    {
                        cmbxOrderShippers.SelectedItem = item;
                    }
                }
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order toBeDeleted = lstOrders.SelectedItem as Order;
                orderManager.DeleteSelectedOrder(toBeDeleted);
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Category Deleted : {toBeDeleted.OrderID}"));
                MessageBox.Show("order deleted");
                FillOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
            }

        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            ShowForm<AddOrder>();
        }

        private void btnGetAllCustomers_Click(object sender, EventArgs e)
        {
            lstCustomers.DataSource = customerManager.GetCustomers();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer selectedCustomer = lstCustomers.SelectedItem as Customer;
            txtCustomerCompany.Text = selectedCustomer.CompanyName;
            txtCustomerContact.Text = selectedCustomer.ContactName;
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier toBeUpdated = lstSuppliers.SelectedItem as Supplier;
                if (txtSupplierName.Text != string.Empty)
                {
                    Supplier supplier = new Supplier()
                    {
                        CompanyName = txtSupplierName.Text,
                        ContactName = txtSupplierContact.Text,
                        ContactTitle = txtSupplierContact.Text,
                        Address = txtSupplierAddress.Text,
                        City = txtSupplierCity.Text,
                        Region = txtSupplierRegion.Text,
                        PostalCode = txtSupplierPostalCode.Text,
                        Country = txtSupplierCountry.Text,
                        Phone = txtSupplierPhone.Text,
                        Fax = txtSupplierFax.Text,
                        HomePage = txtSupplierHomePage.Text
                    };
                    supplierManager.UpdateSupplier(supplier, toBeUpdated.SupplierID);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Supplier Updated : " +
                        $"{toBeUpdated.SupplierID}"));
                    MessageBox.Show("supplier updated");
                    ((Form1)Application.OpenForms["Form1"]).FillSupplierList();


                }
                else
                {
                    MessageBox.Show("enter company name");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error occured");
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order toBeUpdated = lstOrders.SelectedItem as Order;
                Order order = new Order()
                {
                    //todo:customer id ekle
                    EmployeeID = (cmbxOrderEmployee.SelectedItem as Employee).EmployeeID,
                    OrderDate = DateTime.TryParse(txtOrderOrderDate.Text, out DateTime orderDate)
                       ? orderDate
                       : default(DateTime?),
                    RequiredDate = DateTime.TryParse(txtOrderRequiredDate.Text, out DateTime requiredDate)
                       ? requiredDate
                       : default(DateTime?),
                    ShippedDate = DateTime.TryParse(txtOrderShippedDate.Text, out DateTime shipedDate)
                       ? shipedDate
                       : default(DateTime?),
                    ShipVia = (cmbxOrderShippers.SelectedItem as Shipper).ShipperID,
                    Freight = Convert.ToDecimal(nmrcOrderFreight.Value),
                    ShipName = txtShipName.Text,
                    ShipAddress = txtOrderAddress.Text,
                    ShipCity = txtOrderShipCity.Text,
                    ShipRegion = txtOrderShipRegion.Text,
                    ShipPostalCode = txtOrderPostalCode.Text,
                    ShipCountry = txtOrderShipCountry.Text
                };
                orderManager.UpdateOrder(order, toBeUpdated.OrderID);
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Order Updated : {toBeUpdated.OrderID}"));
                MessageBox.Show("order updated");
                FillOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
            }
        }

        private void btnGetAllShippers_Click(object sender, EventArgs e)
        {
            lstShippers.DataSource = shipperManager.GetShippers();
        }

        private void lstShippers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shipper selectedShipper = lstShippers.SelectedItem as Shipper;
            txtShipperName.Text = selectedShipper.CompanyName;
            txtShipperPhone.Text = selectedShipper.Phone;
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            ShowForm<AddCategory>();
        }

        private void btnAddNewShipper_Click_1(object sender, EventArgs e)
        {
            ShowForm<AddShipper>();
        }

        private void btnDeleteShipper_Click(object sender, EventArgs e)
        {
            try
            {
                Shipper toBeDeleted = lstShippers.SelectedItem as Shipper;
                shipperManager.DeleteSelectedShipper(toBeDeleted);
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Shipper Deleted : {toBeDeleted.ShipperID}"));
                MessageBox.Show("shipper deleted");
                FillShipperList();
                FillShipperCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Shipper toBeUpdated = lstShippers.SelectedItem as Shipper;

                Shipper shipper = new Shipper
                {
                    CompanyName = txtShipName.Text,
                    Phone = txtShipperPhone.Text

                };
                if (shipper.CompanyName != string.Empty)
                {
                    shipperManager.UpdateShipper(shipper, toBeUpdated.ShipperID);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Shipper Updated : {toBeUpdated.ShipperID}"));
                    MessageBox.Show("Shipper updated");

                    FillShipperCombobox();
                    FillShipperList();
                }
                else
                {
                    MessageBox.Show("enter a company name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
            }
        }


    }
}
