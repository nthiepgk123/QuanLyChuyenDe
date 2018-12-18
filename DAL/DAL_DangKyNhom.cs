using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
   public class DAL_DangKyNhom:DBConnect
    {
        DataTable dt = new DataTable();
        public DataTable GET()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DANGKYNHOM",_cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
               
            }

            catch (Exception)
            {

                return null;
            }
        }
        public DAL_DangKyNhom()
        {
            dt = GET();

        }
        public DAL_DangKyNhom(DataTable dt)
        {
            this.dt = dt;
        }
        public bool insert (DangKyNhom dkn)
        {
            try
            {
                SqlDataAdapter sql = new SqlDataAdapter("Select * from DANGKYNHOM",_cn);
                DataRow r = dt.NewRow();
                r["MANHOM"] = dkn.MANHOM;
                r["MSSV"] = dkn.MSSV;
                dt.Rows.Add(r);
                SqlCommandBuilder cm = new SqlCommandBuilder(sql);
                sql.Update(dt);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool update(DangKyNhom dkn)
        {
            try
            {
                string mn = dkn.MANHOM;
                string mssv = dkn.MSSV;
                var cmd = new SqlCommand("UPDATE DANGKYNHOM set MANHOM='" +mn + "' where MSSV='" + mssv + "'",_cn);
                int dem=cmd.ExecuteNonQuery();
                if (dem == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                
                return false;
            }
        }
    }
}
