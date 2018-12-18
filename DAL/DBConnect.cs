using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DBConnect
    {
       protected SqlConnection _cn = new SqlConnection(@"Data Source=DESKTOP-IEFJ41K\SQLEXPRESS;Initial Catalog=QUANLYCHUENDE;Integrated Security=True");
    }
}
