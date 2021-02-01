using Project.DAL.DesignPatterns.RepositoryPattern.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagementSystem
{
    public class SupplierManager
    {
        SupplierRepository supplierRepository;
        public SupplierManager()
        {
            supplierRepository = new SupplierRepository();
        }

        public List<Supplier> GetSuppliers()
        {
            return supplierRepository.GetAll();
        }

        public void DeleteSupplier(Supplier supplier)
        {
            supplierRepository.Delete(supplier);
        }

        public int AddSupplier(Supplier supplier)
        {
            return supplierRepository.Add(supplier);
        }
        public Supplier SelectSupplier(int id)
        {
            return supplierRepository.Select(id);
        }
        public void UpdateSupplier(Supplier item, int id)
        {
            supplierRepository.Update(item, id);
        }


    }
}
