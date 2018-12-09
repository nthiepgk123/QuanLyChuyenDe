using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DBConnect
    {
       protected SqlConnection _cn = new SqlConnection(@"DESKTOP-OUGNACU\SQLEXPRESS; Database=QuanLyHocVien; Trusted_Connection=True;");
    }
}
