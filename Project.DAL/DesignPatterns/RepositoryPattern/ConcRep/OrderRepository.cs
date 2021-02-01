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
    public class OrderRepository : BaseRepository, IRepository<Order>
    {
        public int Add(Order item)
        {
            string commandText = $"Insert Orders (CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry) values('{item.CustomerID}','{item.EmployeeID}','{item.OrderDate}','{item.RequiredDate}','{item.ShippedDate}','{item.ShipVia}','{item.Freight}','{item.ShipName}','{item.ShipAddress}','{item.ShipCity}','{item.ShipRegion}','{item.ShipPostalCode}','{item.ShipCountry}');SELECT SCOPE_IDENTITY()";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            ControlConnection();
            return id;
        }

        public void Delete(Order item)
        {
            SqlCommand cmd = new SqlCommand($"Delete from Orders where OrderID={item.OrderID}", con);
            ControlConnection();
            cmd.ExecuteNonQuery();
            ControlConnection();
        }

        public List<Order> GetAll()
        {
            List<Order> orders = new List<Order>();
            string commandText = $"Select OrderID,CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry From Orders";
            SqlCommand cmd = new SqlCommand(commandText, con);
            ControlConnection();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Order incomingData = new Order();
                    incomingData.OrderID = dr.GetInt32(0);
                    incomingData.CustomerID = dr[1] as string;
                    incomingData.EmployeeID = dr.IsDBNull(2) ? incomingData.EmployeeID.GetValueOrDefault() : dr.GetInt32(2);
                    incomingData.OrderDate = dr[3] as DateTime?;
                    incomingData.RequiredDate = dr[4] as DateTime?;
                    incomingData.ShippedDate = dr[5] as DateTime?;
                    incomingData.ShipVia = dr.GetInt32(6);
                    incomingData.Freight = dr.IsDBNull(7) ? incomingData.Freight.GetValueOrDefault() : dr.GetDecimal(7);
                    incomingData.ShipName = dr[8] as string;
                    incomingData.ShipAddress = dr[9] as string;
                    incomingData.ShipCity = dr[10] as string;
                    incomingData.ShipRegion = dr[11] as string;
                    incomingData.ShipPostalCode = dr[12] as string;
                    incomingData.ShipCountry = dr[13] as string;
                    orders.Add(incomingData);
                }
            }
            ControlConnection();

            return orders;
        }

        public Order Select(int id)
        {
            Order selectedOrder = new Order();
            string commandText = $"Select OrderID,CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry From Orders";
            SqlCommand cmd = new SqlCommand(commandText, con);
            ControlConnection();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    selectedOrder.OrderID = dr.GetInt32(0);
                    selectedOrder.CustomerID = dr[1] as string;
                    selectedOrder.EmployeeID = dr.IsDBNull(2) ? selectedOrder.EmployeeID.GetValueOrDefault() : dr.GetInt32(2);
                    selectedOrder.OrderDate = dr[3] as DateTime?;
                    selectedOrder.RequiredDate = dr[4] as DateTime?;
                    selectedOrder.ShippedDate = dr[5] as DateTime?;
                    selectedOrder.ShipVia = dr.GetInt32(6);
                    selectedOrder.Freight = dr.IsDBNull(7) ? selectedOrder.Freight.GetValueOrDefault() : dr.GetDecimal(7);
                    selectedOrder.ShipName = dr[8] as string;
                    selectedOrder.ShipAddress = dr[9] as string;
                    selectedOrder.ShipCity = dr[10] as string;
                    selectedOrder.ShipRegion = dr[11] as string;
                    selectedOrder.ShipPostalCode = dr[12] as string;
                    selectedOrder.ShipCountry = dr[13] as string;


                }
            }
            ControlConnection();

            return selectedOrder;
        }

        public void Update(Order item, int id)
        {
            string commandText = $"Update Orders Set CustomerID='{item.CustomerID}',EmployeeID='{item.EmployeeID}',OrderDate='{item.OrderDate}',RequiredDate='{item.RequiredDate}',ShippedDate='{item.ShippedDate}',ShipVia='{item.ShipVia}',Freight='{item.Freight}',ShipName='{item.ShipName}',ShipAddress='{item.ShipAddress}',ShipCity='{item.ShipCity}',ShipRegion='{item.ShipRegion}',ShipPostalCode='{item.ShipPostalCode}',ShipCountry='{item.ShipCountry}' where OrderID={id}";

            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            cmd.ExecuteNonQuery();
            ControlConnection();
        }
    }
}

