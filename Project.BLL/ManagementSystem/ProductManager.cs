using Project.DAL.DesignPatterns.RepositoryPattern.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagementSystem
{
    public class ProductManager
    {
        ProductRepository productRepository;
        public ProductManager()
        {
            productRepository = new ProductRepository();
        }

        public List<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public void DeleteSelectedProduct(Product item)
        {
            productRepository.Delete(item);

        }
        public void UpdateProduct(Product item, int id)
        {
            productRepository.Update(item, id);
        }

        public int AddProduct(Product product)
        {
           
            return productRepository.Add(product);

        }
        public List<Product> GetProdutsByCategory(Category category, int id)
        {
            return productRepository.GetProductsByCategory(category, id);
        }
        public Product SelectProduct(int id)
        {
            return productRepository.Select(id);
        }
        public void DeleteProductsByCategory(int id)
        {
            productRepository.DeleteProductsByCategory(id);
        }


    }
}
