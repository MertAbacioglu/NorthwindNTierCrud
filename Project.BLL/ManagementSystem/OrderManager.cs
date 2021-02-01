using Project.DAL.DesignPatterns.RepositoryPattern.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagementSystem
{
    public class OrderManager
    {

        OrderRepository orderRepository;
        public OrderManager()
        {
            orderRepository = new OrderRepository();
        }
        
        public List<Order> GetOrders()
        {
            return orderRepository.GetAll();
        }

        public void DeleteSelectedOrder(Order item)
        {
            orderRepository.Delete(item);

        }

        public int AddOrder(Order item)
        {
            return orderRepository.Add(item);
        }

        public void UpdateOrder(Order item, int id)
        {
            orderRepository.Update(item, id);
        }

        public Order SelectOrder(int id)
        {
            return orderRepository.Select(id);
        }
    }
}
