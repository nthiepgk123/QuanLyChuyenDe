using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
   public class BUS_SinhVien
    {
        DAL_SinhVien dal_sv = new DAL_SinhVien();
        public DataTable Get(string use)
        {
            return dal_sv.Get(use);
        }
        public DataTable Get_CD(string USE)
        {
            return dal_sv.Get_CD(USE);
        }
      

    }
}
