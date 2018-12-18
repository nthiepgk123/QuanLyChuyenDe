using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
   public class BUS_Nhom
    {
        DAL_Nhom dal_nhom = new DAL_Nhom();
        public DataTable Get_Nhom(string USE)
        {
            return dal_nhom.Get_Nhom(USE);
        }
        public DataTable Get_nhomsv(string use)
        {
            return dal_nhom.Get_nhomsv(use);
        }
        public void upnhom(string ma, string use) { }
    }
}
