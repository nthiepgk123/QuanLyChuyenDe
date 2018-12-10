using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_ChuyenDe
    {
        DAL_ChuyenDe dal_chuyende = new DAL_ChuyenDe();
        public bool Insert(ChuyenDe pChuyenDe)
        {
            return dal_chuyende.Insert(pChuyenDe);
        }

        public bool Delete(string pMa)
        {
            return dal_chuyende.Delete(pMa);
        }

        public bool Update(ChuyenDe pChuyenDe)
        {
            return dal_chuyende.Update(pChuyenDe);
        }

        public DataTable Get_Nganh()
        {
            return dal_chuyende.GetNganh();
        }

        public DataTable Get_ChuyenDe(string pMaNganh)
        {
            return dal_chuyende.Select_String(pMaNganh);
        }

       
    }
}
