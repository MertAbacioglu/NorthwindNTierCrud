
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DesignPatterns.RepositoryPattern.IntRep
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Delete(T item);
        int Add(T item);
        void Update(T item, int id);
        T Select(int id);
    }
}
