using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dal_taikhoan = new DAL_TaiKhoan();
        public string dangnhap(string use, string pass)
        {
            return dal_taikhoan.dangnhap(use, pass);
        }
    }
}
