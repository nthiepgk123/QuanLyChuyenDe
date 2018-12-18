using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
namespace BUS
{
    
   public class BUS_DangKyNhom
    {
        DAL_DangKyNhom dal_dangkynhom = new DAL_DangKyNhom();
        public bool insert(DangKyNhom dkn)
        {
            return dal_dangkynhom.insert(dkn);
        }
        public bool update(DangKyNhom dkn)
        {
            return dal_dangkynhom.update(dkn);
        }
   }
}
