using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenDe
{
    public partial class DangKyCD : Form
    {

        public DangKyCD()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OUGNACU\SQLEXPRESS;Initial Catalog=QuanLyChuyenDe;Integrated Security=True");

        private void InData()
        {
            con.Open();
            string sl = "select cd.MACD , cd.TENCD , mcd.NGAYMO, mcd.NGAYDONG,cd.SOHVMAX " +
                        "from MOCHUYENDE mcd join CHUYENDE cd on mcd.MACD = cd.MACD " +
                        "where mcd.TINHTRANG = 1"; // cau lenh truy xuat du lieu
            SqlCommand com = new SqlCommand(sl, con); // bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); // van chuyen du lieu ve
            DataTable dt = new DataTable();
            // tao kho ao de luu tru du lieu
            da.Fill(dt);
            // ngat ket noi sql
            con.Close();
            // do du lieu vao datagridview

            dtgvDCMo.DataSource = dt;
            
        }

        private void DangKyCD_Load(object sender, EventArgs e)
        {
            InData();
        }
    }
}
