using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKyNhom
    {
        private string _MSSV;
        public string MSSV
        {
            get { return MSSV; }
            set { _MSSV = value; }
        }
        private string _MANHOM;
        public string MANHOM
        {
            get { return MANHOM; }
            set { _MANHOM = value; }
        }
        public DangKyNhom(string MANHOM,string MSSV)
        {
            this._MANHOM = MANHOM;
            this._MSSV = MSSV;
        }


    }
}
