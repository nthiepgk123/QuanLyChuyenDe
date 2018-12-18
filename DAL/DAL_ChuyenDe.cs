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
   public class DAL_ChuyenDe : DBConnect
    {
        DataTable dt = new DataTable();
       
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from ChuyenDe",_cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }


      
        public DAL_ChuyenDe(DataTable dt)
        {
            this.dt = dt ?? throw new ArgumentNullException(nameof(dt));
        }
        public DAL_ChuyenDe()
        {
            dt = Get();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
      
        public DataTable GetNganh()
        {
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Nganh", _cn);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public DataTable Select_String(string pMaNganh)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from ChuyenDe where MaNganh = '" + pMaNganh + "'", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                return null;
            }
        }


        // Them Chuyen de
        public bool Insert(ChuyenDe pChuyenDe)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from ChuyenDe", _cn);
                DataRow r = dt.NewRow();
                r["MaCD"] = pChuyenDe.MaChuyenDe;
                r["MaNganh"] = pChuyenDe.MaNganh;
                r["TenCD"] = pChuyenDe.TenChuyenDe;
                r["SoHVMax"] = pChuyenDe.SoHocVienMax;

                dt.Rows.Add(r);

                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(string MaCD)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from ChuyenDe", _cn);
                DataRow r = dt.Rows.Find(MaCD);
                if (r != null)
                {
                    r.Delete();
                }
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(ChuyenDe pChuyenDe)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from ChuyenDe", _cn);
                DataRow r = dt.Rows.Find(pChuyenDe.MaChuyenDe);
                if (r != null)
                {
                    r["MaNganh"] = pChuyenDe.MaNganh;
                    r["TenCD"] = pChuyenDe.TenChuyenDe;
                    r["SoHVMax"] = pChuyenDe.SoHocVienMax;
                }
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
