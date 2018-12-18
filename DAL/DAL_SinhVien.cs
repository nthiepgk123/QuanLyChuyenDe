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
   public class DAL_SinhVien:DBConnect
    {
        DataTable dt = new DataTable();

        public DAL_SinhVien()
        {

        }

        public DAL_SinhVien(DataTable dt)
        {
            this.dt = dt ?? throw new ArgumentNullException(nameof(dt));
        }
        //public DAL_SinhVien()
        //{
        //    dt = Get();
        //    dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        //}
        public DataTable Get(string USE)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from SINHVIEN sv  join NGANH n on sv.MANGANH = n.MANGANH where sv.USENAME =N'" + USE + "'", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable Get_CD(string USE)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select  cd.MACD, cd.TENCD, mcd.NGAYMO,mcd.NGAYDONG from SINHVIEN sv join CHUYENDE cd on sv.MANGANH=cd.MANGANH join MOCHUYENDE mcd on cd.MACD = mcd.MACD where mcd.TINHTRANG = 1 and sv.USENAME = '"+USE+"'", _cn);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                return dt2;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
