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
    public partial class AddEmployee : Form
    {
        private LogManager logManager;
        public AddEmployee()
        {
            InitializeComponent();
            InitilazeDependencies();


        }
        EmployeeManager employeeManager;
        void InitilazeDependencies()
        {
            employeeManager = new EmployeeManager();
            logManager = new LogManager();
            FillReportsToCombobox();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmployeeLName.Text != string.Empty && txtEmployeeLName.Text != string.Empty)
                {
                    Employee employeeReportsTo = cmbxEmployeeReportsTo.SelectedItem as Employee;

                    Employee employee = new Employee
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

                    int employeeID = employeeManager.AddEmployee(employee);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Employee Added : {employeeID}"));
                    ((Form1)Application.OpenForms["Form1"]).FillEmployeeCombobox();
                    ((Form1)Application.OpenForms["Form1"]).FillEmployeeList();
                    MessageBox.Show("employee added");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("check name areas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
            }

        }

        void FillReportsToCombobox()
        {
            cmbxEmployeeReportsTo.DataSource = employeeManager.GetEmployees();
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
