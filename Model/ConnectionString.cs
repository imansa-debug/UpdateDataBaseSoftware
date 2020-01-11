using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateDataBase.Model
{
    public class ConnectionString
    {
        public int ID { get; set; }
        public string ServerAddress { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string DBName { get; set; }
    }
}
