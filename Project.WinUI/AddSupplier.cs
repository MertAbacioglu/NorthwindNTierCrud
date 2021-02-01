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
    public partial class AddSupplier : Form
    {
        private LogManager logManager;
        public AddSupplier()
        {
            InitializeComponent();
            InitilazeDependencies();


        }
        SupplierManager supplierManager;
        void InitilazeDependencies()
        {
            logManager = new LogManager();
            supplierManager = new SupplierManager();
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
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
                    int supplierID = supplierManager.AddSupplier(supplier);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Supplier Added : {supplierID}"));
                    MessageBox.Show("supplier added");
                    ((Form1)Application.OpenForms["Form1"]).FillSupplierList();
                    this.Hide();
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

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
