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
    public class CustomerRepository : BaseRepository, IRepository<Customer>
    {

        public int Add(Customer item)
        {
            string commandText = $"Insert Customers (CompanyName,ContactName,Phone) values('{item.CompanyName}','{item.ContactName}','{item.Phone}');SELECT SCOPE_IDENTITY()";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            ControlConnection();
            return id;
        }

        public void Delete(Customer item)
        {
            ControlConnection();
            SqlCommand cmd = new SqlCommand($"Delete From Customers where CustomerID={item.CustomerID}", con);
            cmd.ExecuteNonQuery();
            ControlConnection();
        }

        public List<Customer> GetAll()
        {
            List<Customer> musteriler = new List<Customer>();


            SqlCommand cmd = new SqlCommand($"select CustomerID,CompanyName,ContactName,Phone from Customers", con);



            ControlConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Customer incomingData = new Customer();
                    incomingData.CustomerID = dr[0] as string;
                    incomingData.CompanyName = dr.GetString(1) as string;
                    incomingData.ContactName = dr[2] as string;
                    incomingData.Phone = dr[3] as string;

                    musteriler.Add(incomingData);
                }
            }
            ControlConnection();

            return musteriler;
        }

        public Customer Select(int id)
        {

            Customer selectedCustomer = new Customer();


            SqlCommand cmd = new SqlCommand($"select CustomerID,CompanyName,ContactName,Phone from Customers", con);

            ControlConnection();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    selectedCustomer.CustomerID = dr[0] as string;
                    selectedCustomer.CompanyName = dr.GetString(1) as string;
                    selectedCustomer.ContactName = dr[2] as string;
                    selectedCustomer.Phone = dr[3] as string;

                }
            }
            ControlConnection();

            return selectedCustomer;
        }

        public void Update(Customer item, int id)
        {
            string commandText = $"Update Customers Set CompanyName='{item.CompanyName}',ContactName='{item.ContactName}',Phone='{item.Phone}' where CustomerID={id}";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            cmd.ExecuteNonQuery();
            ControlConnection();
        }
    }
}
