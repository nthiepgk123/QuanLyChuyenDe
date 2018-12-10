using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class GiaoVien
    {
        private string _MAGV;
        public string MAGV
        {
            get { return _MAGV; }
            set { _MAGV = value; }
        }
        private string _USENAME;
        public string USENAME
        {
            get { return _USENAME; }
            set { _USENAME = value; }
        }
        private string _TENGV;
        public string TENGV
        {
            get { return _TENGV; }
            set { _TENGV = value; }
        }
        public GiaoVien(string MAGV,string USENAME,string TENGV)
        {
            this._MAGV = MAGV;
            this._USENAME = USENAME;
            this._TENGV = TENGV;
        }
    }
}
