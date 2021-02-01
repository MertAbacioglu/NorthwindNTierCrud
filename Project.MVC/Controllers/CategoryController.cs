using Project.BLL.ManagementSystem;
using Project.ENTITIES.Models;
using Project.MVC.Models.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVC.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryController()
        {
            categoryManager = new CategoryManager();
        }
        CategoryManager categoryManager;

        // GET: Category
        public ActionResult CategoryList()
        {
            CategoryVM categoryVM = new CategoryVM
            {
                Categories = categoryManager.GetCategories()
            };
            return View(categoryVM);
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            categoryManager.AddCategory(category);
            return RedirectToAction("CategoryList");

        }

        public ActionResult DeleteCategory(int id)
        {
            Category toBeDeleted = categoryManager.SelectCategory(id);


            categoryManager.DeleteSelectedCategory(toBeDeleted);
            return RedirectToAction("CategoryList");
        }

        public ActionResult UpdateCategory(int id)
        {


            CategoryVM categoryVM = new CategoryVM
            {
                Category = categoryManager.SelectCategory(id)
               
            };
            return View(categoryVM);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {

            categoryManager.UpdateCategory(category, category.CategoryID);
            
            
            return RedirectToAction("CategoryList");
        }
    }
}