using Project.DAL.DesignPatterns.RepositoryPattern.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagementSystem
{
    public class EmployeeManager
    {
        EmployeeRepository employeeRepository;

        public EmployeeManager()
        {
            employeeRepository = new EmployeeRepository();
        }
        public List<Employee> GetEmployees()
        {
            return employeeRepository.GetAll();
        }

        public void DeleteSelectedEmployee(Employee item)
        {
            employeeRepository.Delete(item);

        }

        public int AddEmployee(Employee item)
        {
            return employeeRepository.Add(item);
        }

        public void UpdateEmployee(Employee item, int id)
        {
            employeeRepository.Update(item, id);
        }
        public Employee SelectEmployee(int id)
        {
            return employeeRepository.Select(id);
        }
    }
}
