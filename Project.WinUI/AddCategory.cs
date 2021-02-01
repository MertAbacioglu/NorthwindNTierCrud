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
    public partial class AddCategory : Form
    {
        private LogManager logManager;
        public AddCategory()
        {
            InitializeComponent();
            InitilazeDependencies();

        }
        CategoryManager categoryManager;
        void InitilazeDependencies()
        {
            categoryManager = new CategoryManager();
            logManager = new LogManager();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCategoryName.Text != string.Empty)
                {
                    Category category = new Category()
                    {

                        CategoryName = txtCategoryName.Text,
                        Description = txtCategoryDesc.Text
                    };

                    int categoryID = categoryManager.AddCategory(category);
                    logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, $"Category Added : {categoryID}"));
                    //categoryManager.GetCategories();
                    MessageBox.Show("Category added");
                    ((Form1)Application.OpenForms["Form1"]).FillCategoryComboBox();
                    ((Form1)Application.OpenForms["Form1"]).FillCategoryList();
                    ((Form1)Application.OpenForms["Form1"]).FillCategoryComboBox();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter category name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured");
                logManager.InsertLog(new LOG.Entity.Log(DateTime.Now, ex.Message));
            }
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
