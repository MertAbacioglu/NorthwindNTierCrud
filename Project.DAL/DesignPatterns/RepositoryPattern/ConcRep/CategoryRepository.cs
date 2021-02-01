using Project.DAL.DesignPatterns.RepositoryPattern.BaseRep;
using Project.DAL.DesignPatterns.RepositoryPattern.IntRep;

using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DesignPatterns.RepositoryPattern.ConcRep
{
    public class CategoryRepository : BaseRepository, IRepository<Category>
    {



        /// <summary>
        /// Sütun isimlerini virgülle yazarak istediginiz sütunları belirtin
        /// </summary>
        /// <param name="columnNames"></param>
        /// <returns></returns>

        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();

            SqlCommand cmd = new SqlCommand($"select CategoryID,CategoryName,Description from Categories", con);
            ControlConnection();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Category incomingData = new Category();
                    incomingData.CategoryID = dr.GetInt32(0);
                    incomingData.CategoryName = dr.GetString(1);
                    incomingData.Description = dr[2] as string;//null reference exp. önlemek için

                    categories.Add(incomingData);
                }
            }
            ControlConnection();

            return categories;

        }

        public void Delete(Category item)
        {
            ControlConnection();
            SqlCommand cmd = new SqlCommand($"Delete From Categories where CategoryID={item.CategoryID}", con);
            cmd.ExecuteNonQuery();
            ControlConnection();

        }

        public int Add(Category item)
        {

            string commandText = $"Insert Categories (CategoryName,Description) values('{item.CategoryName}','{item.Description}');SELECT SCOPE_IDENTITY()";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            ControlConnection();
            return id;

        }

        public void Update(Category item, int id)
        {

            string commandText = $"Update Categories Set CategoryName='{item.CategoryName}',Description='{item.Description}' where CategoryID={id}";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            cmd.ExecuteNonQuery();
            ControlConnection();
        }

        public Category Select(int id)
        {

            string commandText = $"Select CategoryID,CategoryName,Description from Categories where CategoryID={id}";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            SqlDataReader dr = cmd.ExecuteReader();
            Category selectedCategory = new Category();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    selectedCategory.CategoryID = dr.GetInt32(0);
                    selectedCategory.CategoryName = dr.GetString(1);
                    selectedCategory.Description = dr[2] as string;

                }
            }
            ControlConnection();

            return selectedCategory;
        }
    }
}
