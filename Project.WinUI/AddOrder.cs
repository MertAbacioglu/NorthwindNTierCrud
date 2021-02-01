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
    public partial class AddOrder : Form
    {
        private LogManager logManager;
        public AddOrder()
        {
            InitializeComponent();
            InitilazeDependencies();
        }
        OrderManager orderManager;
        EmployeeManager employeeManager;
        ShipperManager shipperManager;
        CustomerManager customerManager;

        void InitilazeDependencies()
        {
            orderManager = new OrderManager();
            employeeManager = new EmployeeManager();
            shipperManager = new ShipperManager();
            customerManager = new CustomerManager();
            FillAllCombobox();
            logManager = new LogManager();
        }
        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        void FillAllCombobox()
        {
            cmbxOrderEmployee.DataSource = employeeManager.GetEmployees();
            cmbxOrderShippers.DataSource = shipperManager.GetShippers();
            cmbxOrderCustomer.DataSource = customerManager.GetCustomers();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order()
                {
                    CustomerID = (cmbxOrderCustomer.SelectedItem as Customer).CustomerID as string,
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

                int orderID = orderManager.AddOrder(order);
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Order Added : {orderID}"));
                ((Form1)Application.OpenForms["Form1"]).FillOrderList();
                MessageBox.Show("order added");
                this.Hide();


            }
            catch (Exception ex)
            {
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
                MessageBox.Show("Error occured");

            }
        }
    }
}
