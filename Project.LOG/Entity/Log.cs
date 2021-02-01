using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.LOG.Entity
{
    public class Log
    {
        public DateTime CreatedDate { get; set; }
        public string LogText { get; set; }

        public Log()
        {
            CreatedDate = DateTime.Now;
            LogText = string.Empty;
        }

        public Log(DateTime createdDate,string logText)
        {
            CreatedDate = createdDate;
            LogText = logText;
        }
    }
}
