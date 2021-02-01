using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.DesignPatterns.RepositoryPattern.BaseRep
{
    public abstract class BaseRepository
    {
        protected SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ToString());

        protected void ControlConnection()
        {
            if (con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
              
            }
            else
            {
                con.Close();
              
            }
        }
    }
}
