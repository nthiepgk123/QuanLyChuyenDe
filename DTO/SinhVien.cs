using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        private string _MSSV;
        private string _Nganh;
        private string _UserName;
        private string _TenSv;
        // ngya sinh
        private string _Phai;
        private string _DiaChi;

        public string MSSV
        {
            get { return _MSSV; }
            set { _MSSV = value; }
        }

        public string Nganh
        {
            get { return _Nganh; }
            set { _Nganh = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string TenSv
        {
            get { return _TenSv; }
            set { _TenSv = value; }
        }

        public string Phai
        {
            get { return _Phai; }
            set { _Phai = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
    }
}
