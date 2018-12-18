using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
  public class DAL_TaiKhoan:DBConnect
    {
        public string dangnhap(string use,string pass )
        {
            _cn.Open();
            TaiKhoan tk = new TaiKhoan();
            try
            {
                SqlCommand da = new SqlCommand("select * from TAIKHOAN where USENAME =N'" + use + "'and PASSWORD=N'" + pass + "'", _cn);
                SqlDataReader dt = da.ExecuteReader();
                if (dt.Read())
                {
                    return use;
                }
                else { return ""; }
            }
            catch (Exception)
            {

                return null;
            }
           
        }
    
    }
}
