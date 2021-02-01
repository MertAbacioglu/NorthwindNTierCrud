using Project.DAL.DesignPatterns.RepositoryPattern.BaseRep;
using Project.DAL.DesignPatterns.RepositoryPattern.IntRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DesignPatterns.RepositoryPattern.ConcRep
{
    public class EmployeeRepository : BaseRepository, IRepository<Employee>
    {
        public int Add(Employee item)
        {
            string commandText = $"Insert Employees (LastName,FirstName,Title,TitleOfCourTesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Notes,ReportsTo) values('{item.LastName}','{item.FirstName}','{item.Title}','{item.TitleOfCourTesy}','{item.BirthDay}','{item.HireDate}','{item.Address}','{item.City}','{item.Region}','{item.PostalCode}','{item.Country}','{item.HomePhone}','{item.Notes}','{item.ReportsTo}');SELECT SCOPE_IDENTITY()";

            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            ControlConnection();
            return id;
        }

        public void Delete(Employee item)
        {
            ControlConnection();
            SqlCommand cmd = new SqlCommand($"Delete From Employees where EmployeeID={item.EmployeeID}", con);
            cmd.ExecuteNonQuery();
            ControlConnection();

        }

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            SqlCommand cmd = new SqlCommand($"select EmployeeID,LastName,FirstName,Title,TitleOfCourTesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Notes,ReportsTo From Employees", con);
            ControlConnection();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Employee incomingData = new Employee();
                    incomingData.EmployeeID = dr.GetInt32(0);
                    incomingData.LastName = dr[1] as string;
                    incomingData.FirstName = dr[2] as string;
                    incomingData.Title = dr[3] as string;
                    incomingData.TitleOfCourTesy = dr[4] as string;
                    incomingData.BirthDay = dr[5] as DateTime?;
                    incomingData.HireDate = dr[6] as DateTime?;
                    incomingData.Address = dr[7] as string;
                    incomingData.City = dr[8] as string;
                    incomingData.Region = dr[9] as string;
                    incomingData.PostalCode = dr[10] as string;
                    incomingData.Country = dr[11] as string;
                    incomingData.HomePhone = dr[12] as string;
                    incomingData.Notes = dr[13] as string;
                    incomingData.ReportsTo = dr.IsDBNull(14) ? incomingData.ReportsTo.GetValueOrDefault() : dr.GetInt32(14);

                    employees.Add(incomingData);
                }
            }
            ControlConnection();

            return employees;
        }

        public Employee Select(int id)
        {
            Employee selectedEmployee = new Employee();

            SqlCommand cmd = new SqlCommand($"select EmployeeID,LastName,FirstName,Title,TitleOfCourTesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Notes,ReportsTo From Employees", con);
            ControlConnection();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    selectedEmployee.EmployeeID = dr.GetInt32(0);
                    selectedEmployee.LastName = dr[1] as string;
                    selectedEmployee.FirstName = dr[2] as string;
                    selectedEmployee.Title = dr[3] as string;
                    selectedEmployee.TitleOfCourTesy = dr[4] as string;
                    selectedEmployee.BirthDay = dr[5] as DateTime?;
                    selectedEmployee.HireDate = dr[6] as DateTime?;
                    selectedEmployee.Address = dr[7] as string;
                    selectedEmployee.City = dr[8] as string;
                    selectedEmployee.Region = dr[9] as string;
                    selectedEmployee.PostalCode = dr[10] as string;
                    selectedEmployee.Country = dr[11] as string;
                    selectedEmployee.HomePhone = dr[12] as string;
                    selectedEmployee.Notes = dr[13] as string;
                    selectedEmployee.ReportsTo = dr.IsDBNull(14) ? selectedEmployee.ReportsTo.GetValueOrDefault() : dr.GetInt32(14);

                }
            }
            ControlConnection();

            return selectedEmployee;
        }

        public void Update(Employee item, int id)
        {
            string commandText = $"Update Employees Set LastName='{item.LastName}',FirstName='{item.FirstName}',Title='{item.Title}',TitleOfCourTesy='{item.TitleOfCourTesy}',BirthDate='{item.BirthDay}',HireDate='{item.HireDate}',Address='{item.Address}',City='{item.City}',Region='{item.Region}',PostalCode='{item.PostalCode}',Country='{item.Country}',HomePhone='{item.HomePhone}',Notes='{item.Notes}',ReportsTo='{item.ReportsTo}' where EmployeeID={id}";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            cmd.ExecuteNonQuery();
            ControlConnection();
        }
    }
}
