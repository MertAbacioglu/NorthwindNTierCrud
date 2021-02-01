using Project.DAL.DesignPatterns.RepositoryPattern.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagementSystem
{
    public class CustomerManager
    {
        CustomerRepository custumerRepository;
        public CustomerManager()
        {
            custumerRepository = new CustomerRepository();
        }
        
        public List<Customer> GetCustomers()
        {
            return custumerRepository.GetAll();
        }

        public void DeleteSelectedCustomer(Customer item)
        {
            custumerRepository.Delete(item);

        }
        public void UpdateCustomer(Customer item, int id)
        {
            custumerRepository.Update(item, id);
        }

        public int AddCustomer(Customer item)
        {
            return custumerRepository.Add(item);
        }
        public Customer SelectCustomer(int id)
        {
            return custumerRepository.Select(id);
        }
    }
}
