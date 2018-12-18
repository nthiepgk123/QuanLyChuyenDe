using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DangKyNhom
    {
        private string _MANHOM;
        public string MANHOM
        {
            get { return _MANHOM; }
            set { _MANHOM = value; }
        }
        private string _MSSV;
        public string MSSV
        {
            get { return _MSSV; }
            set { _MSSV = value; }
        }
        public DangKyNhom()
        {
            this._MANHOM = MANHOM;
            this._MSSV = MSSV;
        }
    }
}
