using Project.BLL.ManagementSystem;
using Project.ENTITIES.Models;
using Project.LOG.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class AddProduct : Form
    {
        private LogManager logManager;
        public AddProduct()
        {
            InitializeComponent();
            InitilazeDependencies();

        }
        ProductManager productManager;
        SupplierManager supplierManager;
        CategoryManager categoryManager;

        void InitilazeDependencies()
        {
            productManager = new ProductManager();
            supplierManager = new SupplierManager();
            categoryManager = new CategoryManager();
            logManager = new LogManager();
            FillCategoryComboBox();
            FillSupplierComboBox();

        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            try
            {
                Product product = new Product()
                {
                    ProductName = txtProductName.Text,
                    SupplierID = (cmbxProductSupplier.SelectedItem as Supplier).SupplierID,
                    CategoryID = (cmbxProductCategory.SelectedItem as Category).CategoryID,
                    QuantityPerUnit = txtProductQuantity.Text,
                    UnitPrice = Convert.ToDecimal(nmrcProductPrice.Value),
                    UnitsInStock = Convert.ToInt16(nmrcProductStock.Value),
                    UnitsOnOrder = Convert.ToInt16(nmrcProductOrder.Value),
                    Discontinued = chckbxProductDiscontinued.Checked ? false : true
                };
                if (product.ProductName == string.Empty || product.UnitPrice == 0)
                {
                    MessageBox.Show("check product name or unit price");

                }
                else
                {

                    int productID = productManager.AddProduct(product);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Product Added : {productID}"));
                    ((Form1)Application.OpenForms["Form1"]).RefreshAllTables();
                    MessageBox.Show("product added");
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
                MessageBox.Show("Error occured");
            }
        }

        void FillCategoryComboBox()
        {
            cmbxProductCategory.DataSource = categoryManager.GetCategories();
        }

        void FillSupplierComboBox()
        {

            cmbxProductSupplier.DataSource = supplierManager.GetSuppliers();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }


    }
}
