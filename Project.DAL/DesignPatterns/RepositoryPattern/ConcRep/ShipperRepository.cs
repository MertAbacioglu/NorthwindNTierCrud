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
    public class ShipperRepository : BaseRepository, IRepository<Shipper>
    {
        public int Add(Shipper item)
        {
            string commandText = $"Insert Shippers (CompanyName,Phone) values('{item.CompanyName}','{item.Phone}');SELECT SCOPE_IDENTITY()";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            ControlConnection();
            return id;
        }

        public void Delete(Shipper item)
        {
            ControlConnection();
            SqlCommand cmd = new SqlCommand($"Delete From Shippers where ShipperID={item.ShipperID}", con);
            cmd.ExecuteNonQuery();
            ControlConnection();

        }

        public List<Shipper> GetAll()
        {
            List<Shipper> shippers = new List<Shipper>();

            SqlCommand cmd = new SqlCommand($"select ShipperID,CompanyName,Phone from Shippers", con);

            ControlConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Shipper incomingData = new Shipper();
                    incomingData.ShipperID = dr.GetInt32(0);
                    incomingData.CompanyName = dr[1] as string;
                    incomingData.Phone = dr[2] as string;
                    shippers.Add(incomingData);
                }
            }
            ControlConnection();
            return shippers;
        }

        public Shipper Select(int id)
        {
            Shipper selectedShipper = new Shipper();

            SqlCommand cmd = new SqlCommand($"select ShipperID,CompanyName,Phone from Shippers", con);

            ControlConnection();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    selectedShipper.ShipperID = dr.GetInt32(0);
                    selectedShipper.CompanyName = dr[1] as string;
                    selectedShipper.Phone = dr[2] as string;

                }
            }
            ControlConnection();
            return selectedShipper;
        }

        public void Update(Shipper item, int id)
        {
            string commandText = $"Update Shippers Set CompanyName='{item.CompanyName}',Phone='{item.Phone}'";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            cmd.ExecuteNonQuery();
            ControlConnection();
        }
    }
}
