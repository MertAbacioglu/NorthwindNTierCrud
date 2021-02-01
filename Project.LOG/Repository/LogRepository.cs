using Project.LOG.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.LOG.Repository
{
    public class LogRepository
    {

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnection"].ToString());

        protected void ControlConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();

            }
            else
            {
                con.Close();

            }
        }
        public void Insert(Log log)
        {
            string commandText = $"Insert Log(CreatedDate,LogText) values('{log.CreatedDate}','{log.LogText}')";
            ControlConnection();
            SqlCommand cmd = new SqlCommand(commandText, con);
            cmd.ExecuteNonQuery();
            ControlConnection();
        }

    }
}
