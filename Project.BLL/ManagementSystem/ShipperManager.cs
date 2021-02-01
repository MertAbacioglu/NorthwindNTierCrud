using Project.DAL.DesignPatterns.RepositoryPattern.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagementSystem
{
    public class ShipperManager
    {

        ShipperRepository shipperRepository;
        public ShipperManager()
        {
            shipperRepository = new ShipperRepository();
        }

        public List<Shipper> GetShippers()
        {
            return shipperRepository.GetAll();
        }

        public void DeleteSelectedShipper(Shipper item)
        {
            shipperRepository.Delete(item);

        }
        public void UpdateShipper(Shipper item, int id)
        {
            shipperRepository.Update(item, id);
        }

        public int AddShipper(Shipper item)
        {
            return shipperRepository.Add(item);
        }
        public Shipper SelectShipper(int id)
        {
            return shipperRepository.Select(id);
        }

    }
}

