using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace tugasbesar
{
    class Db
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        //public DataTable dt;
        int result;
        private string url = "server=localhost;userid=root;password=;database=wms";
        public MySqlConnection GetConn()
        {
            MySqlConnection Conn = new MySqlConnection(url);
            return Conn;
        }
    }
}

