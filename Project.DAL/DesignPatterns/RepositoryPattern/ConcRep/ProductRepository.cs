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
    public class ProductRepository : BaseRepository, IRepository<Product>
    {
        /// <summary>
        /// Sütun isimlerini virgülle yazarak istediginiz sütunları belirtin
        /// </summary>
        /// <param name="columnNames"></param>
        /// <returns></returns>
        /// 
        public int Add(Product item)
        {
            string commandText = $"Insert Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) values('{item.ProductName}','{item.SupplierID}','{item.CategoryID}','{item.QuantityPerUnit}','{item.UnitPrice}','{item.UnitsInStock}','{item.UnitsOnOrder}','{item.ReorderLevel}','{item.Discontinued}');SELECT SCOPE_IDENTITY()";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            ControlConnection();
            return id;
        }

        public void Delete(Product item)
        {
            ControlConnection();
            SqlCommand cmd = new SqlCommand($"Delete From Products where ProductID={item.ProductID}", con);
            cmd.ExecuteNonQuery();
            ControlConnection();

        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            SqlCommand cmd = new SqlCommand($"select ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued from Products", con);

            ControlConnection();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Product incomingData = new Product();
                    incomingData.ProductID = dr.GetInt32(0);
                    incomingData.ProductName = dr.GetString(1);
                    incomingData.SupplierID = dr.IsDBNull(2) ? incomingData.SupplierID.GetValueOrDefault() : dr.GetInt32(2);
                    incomingData.CategoryID = dr.IsDBNull(3) ? incomingData.CategoryID.GetValueOrDefault() : dr.GetInt32(3);
                    incomingData.QuantityPerUnit = dr[4] as string;
                    incomingData.UnitPrice = dr.IsDBNull(5) ? incomingData.UnitPrice.GetValueOrDefault() : dr.GetDecimal(5);
                    incomingData.UnitsInStock = dr.IsDBNull(6) ? incomingData.UnitsInStock.GetValueOrDefault() : dr.GetInt16(6);
                    incomingData.UnitsOnOrder = dr.IsDBNull(7) ? incomingData.UnitsOnOrder.GetValueOrDefault() : dr.GetInt16(7);

                    incomingData.ReorderLevel = dr.IsDBNull(8) ? incomingData.ReorderLevel.GetValueOrDefault() : dr.GetInt16(7);

                    incomingData.Discontinued = dr.IsDBNull(9) ? incomingData.Discontinued.GetValueOrDefault() : Convert.ToBoolean(dr[9]);

                    products.Add(incomingData);
                }
            }
            ControlConnection();
            return products;
        }

        public void Update(Product item, int id)
        {
            string commandText = $"Update Products Set ProductName='{item.ProductName}',SupplierID='{item.SupplierID}',CategoryID='{item.CategoryID}',QuantityPerUnit='{item.QuantityPerUnit}',UnitPrice='{item.UnitPrice}',UnitsInStock='{item.UnitsInStock}',UnitsOnOrder='{item.UnitsOnOrder}',ReorderLevel='{item.ReorderLevel}',Discontinued='{item.Discontinued}' where ProductID={id}";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            cmd.ExecuteNonQuery();
            ControlConnection();
        }

        public List<Product> GetProductsByCategory(Category category, int id)
        {
            List<Product> products = new List<Product>();

            SqlCommand cmd = new SqlCommand($"select ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued from Products where CategoryID={id}", con);
            ControlConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Product incomingData = new Product();
                    incomingData.ProductID = dr.GetInt32(0);
                    incomingData.ProductName = dr.GetString(1);
                    incomingData.SupplierID = dr.IsDBNull(2) ? incomingData.SupplierID.GetValueOrDefault() : dr.GetInt32(2);
                    incomingData.CategoryID = dr.IsDBNull(3) ? incomingData.CategoryID.GetValueOrDefault() : dr.GetInt32(3);
                    incomingData.QuantityPerUnit = dr[4] as string;
                    incomingData.UnitPrice = dr.IsDBNull(5) ? incomingData.UnitPrice.GetValueOrDefault() : dr.GetDecimal(5);
                    incomingData.UnitsInStock = dr.IsDBNull(6) ? incomingData.UnitsInStock.GetValueOrDefault() : dr.GetInt16(6);
                    incomingData.UnitsOnOrder = dr.IsDBNull(7) ? incomingData.UnitsOnOrder.GetValueOrDefault() : dr.GetInt16(7);
                    incomingData.ReorderLevel = dr.IsDBNull(8) ? incomingData.ReorderLevel.GetValueOrDefault() : dr.GetInt16(7);
                    incomingData.Discontinued = dr.IsDBNull(9) ? incomingData.Discontinued.GetValueOrDefault() : Convert.ToBoolean(dr[9]);
                    products.Add(incomingData);

                }
            }
            ControlConnection();
            return products;
        }

        public Product Select(int id)
        {
            Product selectedProduct = new Product();

            SqlCommand cmd = new SqlCommand($"select ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued from Products", con);
            ControlConnection();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    selectedProduct.ProductID = dr.GetInt32(0);
                    selectedProduct.ProductName = dr.GetString(1);
                    selectedProduct.SupplierID = dr.IsDBNull(2) ? selectedProduct.SupplierID.GetValueOrDefault() : dr.GetInt32(2);
                    selectedProduct.CategoryID = dr.IsDBNull(3) ? selectedProduct.CategoryID.GetValueOrDefault() : dr.GetInt32(3);
                    selectedProduct.QuantityPerUnit = dr[4] as string;
                    selectedProduct.UnitPrice = dr.IsDBNull(5) ? selectedProduct.UnitPrice.GetValueOrDefault() : dr.GetDecimal(5);
                    selectedProduct.UnitsInStock = dr.IsDBNull(6) ? selectedProduct.UnitsInStock.GetValueOrDefault() : dr.GetInt16(6);
                    selectedProduct.UnitsOnOrder = dr.IsDBNull(7) ? selectedProduct.UnitsOnOrder.GetValueOrDefault() : dr.GetInt16(7);

                    selectedProduct.ReorderLevel = dr.IsDBNull(8) ? selectedProduct.ReorderLevel.GetValueOrDefault() : dr.GetInt16(7);

                    selectedProduct.Discontinued = dr.IsDBNull(9) ? selectedProduct.Discontinued.GetValueOrDefault() : Convert.ToBoolean(dr[9]);
                }
            }
            ControlConnection();
            return selectedProduct;
        }

        public void DeleteProductsByCategory(int id)
        {
            ControlConnection();
            SqlCommand cmd = new SqlCommand($"Delete From Products where CategoryID={id}", con);
            cmd.ExecuteNonQuery();
            ControlConnection();
        }
    }
}
