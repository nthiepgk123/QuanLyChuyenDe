using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Nganh
    {   
        private string _MANGANH;
        public string MANGANH
        {
            get { return _MANGANH; }
            set { _MANGANH = value; }
        }
        private string _TENNGANH;
        public string TENNGANH
        {
            get { return _TENNGANH; }
            set { _TENNGANH = value; }
        }
        private int _SOHV;
        public int SOHV
        {
            get { return _SOHV; }
            set { _SOHV = value; }
        }
        public Nganh(string MANGANH,string TENNGANH,int SOHV)
        {
            this._MANGANH = MANGANH;
            this._TENNGANH = TENNGANH;
            this._SOHV = SOHV;
        }
    }
}
