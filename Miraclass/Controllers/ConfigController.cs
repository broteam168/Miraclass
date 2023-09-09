using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miraclass.Controllers
{
    class ConfigController
    {
        public ConfigController() { }
        public bool checkConnection(string server, string data, string user, string pass)
        {
            String con = "Data Source=" + server + ";Initial Catalog=" + data + ";User ID=" + user + ";Password=" + pass + ";";
            SqlConnection conSQL = new SqlConnection(con);
            try
            {
                conSQL.Open();
                conSQL.Close();
                return true;
            }
            catch (Exception)
            {
                conSQL.Close();
                return false;
               
            }
           
        }
    }
}
