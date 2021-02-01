using Project.LOG.Entity;
using Project.LOG.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.LOG.Manager
{
    public class LogManager
    {

        LogRepository logRepository;
        public LogManager()
        {
            logRepository = new LogRepository();
        }

        public void InsertLog(Log log)
        {
            logRepository.Insert(log);
        }


    }
}
