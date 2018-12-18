using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class DAL_Nhom :DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_Nhom()
        {

        }
        public DataTable Get_Nhom (string use)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from NHOM ", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable Get_nhomsv(string use)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DANGKYNHOM dkn join NHOM n on dkn.MANHOM=n.MANHOM where MSSV=N'" +use + "'", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public void upnhom(string ma,string use)
        {
            var cmd = new SqlCommand("update DANGKYNHOM set MANHOM='" + ma + "' where MSSV=N'" + use + "'",_cn);
            cmd.ExecuteNonQuery();
        }
        
    }
}
