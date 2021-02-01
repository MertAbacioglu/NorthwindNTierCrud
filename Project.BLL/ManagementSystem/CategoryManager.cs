using Project.DAL.DesignPatterns.RepositoryPattern.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagementSystem
{
    public class CategoryManager
    {
        CategoryRepository categoryRepository;

        public CategoryManager()
        {
            categoryRepository = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
            return categoryRepository.GetAll();
        }

        public void DeleteSelectedCategory(Category item)
        {
            categoryRepository.Delete(item);

        }

        public int AddCategory(Category item)
        {
            return categoryRepository.Add(item);
        }

        public void UpdateCategory(Category item,int id)
        {
            categoryRepository.Update(item, id);
        }

        public Category SelectCategory(int id)
        {
            return categoryRepository.Select(id);
        }


    }
}
