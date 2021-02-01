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
    public class SupplierRepository : BaseRepository, IRepository<Supplier>
    {
        public int Add(Supplier item)
        {
            string commandText = $"Insert Suppliers (CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage) values('{item.CompanyName}','{item.ContactName}','{item.ContactTitle}','{item.Address}','{item.City}','{item.Region}','{item.PostalCode}','{item.Country}','{item.Phone}','{item.Fax}','{item.HomePage}');SELECT SCOPE_IDENTITY()";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            ControlConnection();
            return id;
        }

        public void Delete(Supplier item)
        {
            SqlCommand cmd = new SqlCommand($"Delete from Suppliers where SupplierID={item.SupplierID}", con);
            ControlConnection();
            cmd.ExecuteNonQuery();
            ControlConnection();
        }

        public List<Supplier> GetAll()
        {
            List<Supplier> suppliers = new List<Supplier>();

            SqlCommand cmd = new SqlCommand($"select * from Suppliers", con);

            ControlConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Supplier incomingData = new Supplier();


                    incomingData.SupplierID = dr.GetInt32(0);
                    incomingData.CompanyName = dr[1] as string;
                    incomingData.ContactName = dr[2] as string;
                    incomingData.ContactTitle = dr[3] as string;
                    incomingData.Address = dr[4] as string;
                    incomingData.City = dr[5] as string;
                    incomingData.Region = dr[6] as string; ;
                    incomingData.PostalCode = dr[7] as string;
                    incomingData.Country = dr[8] as string;
                    incomingData.Phone = dr[9] as string;
                    incomingData.Fax = dr[10] as string;
                    incomingData.HomePage = dr[11] as string;

                    suppliers.Add(incomingData);

                }
            }
            ControlConnection();
            return suppliers;
        }

        public Supplier Select(int id)
        {
            Supplier selectedSupplier = new Supplier();

            SqlCommand cmd = new SqlCommand($"select * from Suppliers", con);

            ControlConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Supplier incomingData = new Supplier();
                    incomingData.SupplierID = dr.GetInt32(0);
                    incomingData.CompanyName = dr[1] as string;
                    incomingData.ContactName = dr[2] as string;
                    incomingData.ContactTitle = dr[3] as string;
                    incomingData.Address = dr[4] as string;
                    incomingData.City = dr[5] as string;
                    incomingData.Region = dr[6] as string; ;
                    incomingData.PostalCode = dr[7] as string;
                    incomingData.Country = dr[8] as string;
                    incomingData.Phone = dr[9] as string;
                    incomingData.Fax = dr[10] as string;
                    incomingData.HomePage = dr[11] as string;
                }
            }
            ControlConnection();
            return selectedSupplier;
        }

        public void Update(Supplier item, int id)
        {
            string commandText = $"Update Suppliers Set CompanyName='{item.CompanyName}',ContactName='{item.ContactName}',ContactTitle='{item.ContactTitle}',Address='{item.Address}',City='{item.City}',Region='{item.Region}',PostalCode='{item.PostalCode}',Country='{item.Country}',Phone='{item.Phone}',Fax='{item.Fax}',HomePage='{item.HomePage}' where SupplierID={id}";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            cmd.ExecuteNonQuery();
            ControlConnection();
        }


    }
}
