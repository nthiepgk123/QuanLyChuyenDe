using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenDe
    {
        private string _MaChuyenDe;
        private string _MaNganh;
        private string _TenChuyenDe;
        private int _SoHocVienMax;

        public string MaChuyenDe
        {
            get { return _MaChuyenDe; }
            set { _MaChuyenDe = value; }
        }

        public string MaNganh
        {
            get { return _MaNganh; }
            set { _MaNganh = value; }
        }

        public string TenChuyenDe
        {
            get { return _TenChuyenDe; }
            set { _TenChuyenDe = value; }
        }

        public int SoHocVienMax
        {
            get { return _SoHocVienMax; }
            set { _SoHocVienMax = value; }
        }

        public ChuyenDe(string MaCD , string MaNganh , string TenCD , int HVMax)
        {
            this._MaChuyenDe = MaCD;
            this._MaNganh = MaNganh;
            this._TenChuyenDe = TenCD;
            this._SoHocVienMax = HVMax;
        }
    }
}
