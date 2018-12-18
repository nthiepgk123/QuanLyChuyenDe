using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string _USERNAME;
        private string _PASSWORD;

        public string USERNAME
        {
            get { return _USERNAME; }
            set { _USERNAME = value; }
        }

        public string PASSWORD
        {
            get { return _PASSWORD; }
            set { _PASSWORD = value; }
        }

        public TaiKhoan(string user , string pass)
        {
            this._USERNAME = user;
            this._PASSWORD = pass;
        }

        public TaiKhoan()
        {
        }
    }
}
