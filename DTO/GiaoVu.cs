using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class GiaoVu
    {
        private String _MAGV;
        public String MAGV
        {
            get { return MAGV; }
            set { _MAGV = value; }
        }
        private String _MAGIAOVU;
        public String MAGIAOVU
        {
            get { return MAGIAOVU; }
            set { _MAGIAOVU = value; }
        }
        private string _USENAME;
        public string USENAME
        {
            get { return USENAME; }
            set { _USENAME = value; }
        }
        public GiaoVu(String MAGV,String MAGIAOVU,String USENAME)
        {
            this._MAGV = MAGV;
            this._MAGIAOVU = MAGIAOVU;
            this._USENAME = USENAME;
        }
    }
}
