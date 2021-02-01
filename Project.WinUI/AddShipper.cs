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
   
    public partial class AddShipper : Form
    {
        private LogManager logManager;
        public AddShipper()
        {
            InitializeComponent();
            InitilazeDependencies();
        }
        ShipperManager shipperManager;
        void InitilazeDependencies()
        {
            shipperManager = new ShipperManager();
            logManager = new LogManager();
        }

        private void btnAddShipper_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtShipperName.Text != string.Empty)
                {
                    Shipper shipper = new Shipper()
                    {

                        CompanyName = txtShipperName.Text,
                        Phone = txtShipperPhone.Text
                    };

                    int shipperID = shipperManager.AddShipper(shipper);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Category Added : {shipperID}"));
                    MessageBox.Show("Shipper added");
                    ((Form1)Application.OpenForms["Form1"]).FillShipperCombobox();
                    ((Form1)Application.OpenForms["Form1"]).FillShipperList();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter company name");
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
