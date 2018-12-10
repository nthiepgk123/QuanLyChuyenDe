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
       protected SqlConnection _cn = new SqlConnection(@"Data Source=DESKTOP-OUGNACU\SQLEXPRESS;Initial Catalog=QuanLyChuyenDe;Integrated Security=True");
    }
}
