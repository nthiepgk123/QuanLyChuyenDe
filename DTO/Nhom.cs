using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Nhom
    {
        private string _MANHOM;
        public string MANHOM
        {
            get { return MANHOM; }
            set { _MANHOM = value; }
        }
        private string _TENNHOM;
        public string TENNHOM
        {
            get { return TENNHOM; }
            set { _TENNHOM = value; }
        }
        public Nhom(string MANHOM,string TENNHOM)
        {
            this._MANHOM = MANHOM;
            this._TENNHOM = TENNHOM;
        }
    }
}
