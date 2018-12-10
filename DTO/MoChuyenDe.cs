using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class MoChuyenDe
    {
        private string _MACD;
        public string MACD
        {
            get { return MACD; }
            set { _MACD = value; }
        }
        private string _MAGIAOVU;
        public string MAGIAOVU
        {
            get { return MAGIAOVU; }
            set { _MAGIAOVU = value; }

        }
        private bool _TINHTRANG;
        public bool TINHTRANG
        {
            get { return TINHTRANG; }
            set { _TINHTRANG = value; }
        }
        private DateTime _NGAYMO = new DateTime();
        public DateTime NGAYMO
        {
            get { return _NGAYMO; }
            set { _NGAYMO = value; }
        }
        private DateTime _NGAYDONG = new DateTime();
        public DateTime NGAYDONG
        {
            get { return _NGAYDONG; }
            set { _NGAYDONG = value; }
        }
        public 
    }
}
