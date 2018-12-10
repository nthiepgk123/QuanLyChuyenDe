using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVu
    {
        private string _MAGV;
        public string MAGV
        {
            get { return _MAGV; }
            set { _MAGV = value; }
        }
        private string _MAGIAOVU;
        public string MAGIAOVU
        {
            get { return _MAGIAOVU; }
            set { _MAGIAOVU = value; }

        }
        private string _USENAME;
        public string USENAME
        {
            get { return _USENAME; }
            set { _USENAME = value; }
        }
        public GiaoVu(string MAGV,string MAGIAOVU,string USENAME)
        {
            this._MAGV = MAGV;
            this._USENAME = USENAME;
            this._MAGIAOVU = MAGIAOVU;
        }
      
    }
}
