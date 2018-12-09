using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKy
    {
        private string _MSSV;
        public string MSSV
        {
            get { return MSSV; }
            set { _MSSV = value; }

        }
        private string _MACD;
        public string MACD
        {
            get { return MACD; }
            set { _MACD = value; }

        }
        private int _NAM;
        public int NAM
        {
            get { return NAM; }
            set { _NAM = value; }

        }
        private int _HOCKY;
        public int HOCKY
        {
            get { return HOCKY; }
            set { _HOCKY = value; }

        }
        private float _DIEM;
        public int DIEM
        {
            get { return DIEM; }
            set { _DIEM = value; }

        }
        public DangKy (string MSSV, string MACD, int NAM, int HOCKY,float DIEM)
        {
            this._MSSV = MSSV;
            this._MACD = MACD;
            this._NAM = NAM;
            this._HOCKY = HOCKY;
            this._DIEM = DIEM;
        }

    }
}
