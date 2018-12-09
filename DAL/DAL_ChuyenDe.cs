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
    class DAL_ChuyenDe : DBConnect
    {
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

        DataTable dt = new DataTable();
        // Them Chuyen de
        public bool Insert(ChuyenDe pChuyenDe)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from ChuyenDe", _cn);
                DataRow r = new DataRow();
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
