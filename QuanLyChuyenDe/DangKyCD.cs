using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyChuyenDe
{
    public partial class DangKyCD : Form
    {

        BUS_SinhVien bus_sv = new BUS_SinhVien();
        BUS_Nhom bus_nhom = new BUS_Nhom();
        BUS_DangKyNhom bus_dangkynhom = new BUS_DangKyNhom();
        DangKyNhom dkn = new DangKyNhom();
        public DangKyCD()
        {
            InitializeComponent();
            
            Load += DangKyCD_Load1;
         


        }
        public string user;
        public DangKyCD(string use) : this()
        {
            user = use;
        }
        private void DangKyCD_Load1(object sender, EventArgs e)
        {
            DataTable ttsv = new DataTable();
            ttsv = bus_sv.Get(user);
            DataTable nhomsv = new DataTable();
            nhomsv = bus_nhom.Get_nhomsv(user);
            string ngaysinh = ttsv.Rows[0][4].ToString();
            DateTime ns = Convert.ToDateTime(ngaysinh);
            string ngaysinhsv = ns.ToString("dd/M/yyyy", CultureInfo.InvariantCulture); 
         
            this.dataGridView3.DataSource = bus_sv.Get_CD(user);
          // this.dataGridView2.DataSource = bus_sv.Get(user);
            this.label7.Text = ttsv.Rows[0][3].ToString();
            this.label9.Text = ngaysinhsv;
            this.label11.Text= ttsv.Rows[0][6].ToString();
            this.label13.Text= ttsv.Rows[0][8].ToString();
            this.label16.Text=ttsv.Rows[0][5].ToString();
            if (nhomsv.Rows.Count == 0)
            {
               
                this.label5.Text = "Bạn chưa có nhóm";
                this.dataGridView1.DataSource = bus_nhom.Get_Nhom(user);
                tabControl1.TabPages.Remove(tabPage3);
             

            }
            else
            {
                this.label5.Text = nhomsv.Rows[0][3].ToString();
                this.cbNhom.DataSource = bus_nhom.Get_Nhom(user);
                this.cbNhom.DisplayMember = "TENNHOM";
                this.cbNhom.ValueMember = "MANHOM";
                tabControl1.TabPages.Remove(tabPage2);
                
            }
         

        }
        

        private void btchuyennhom_Click(object sender, EventArgs e)
        {
           string ma= cbNhom.SelectedValue.ToString();
            dkn.MANHOM = ma;
            dkn.MSSV = user;
           
           if(bus_dangkynhom.update(dkn) == true)
            {
                MessageBox.Show("Bạn chuyển nhóm thành công");
                DangKyCD_Load1(sender, e);

            }
            else
            {
                MessageBox.Show("Bạn chuyển nhóm không thành công");
            }
           
        }

  
        string ma;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selcdetRow = dataGridView1.Rows[index];
               ma = selcdetRow.Cells["MANHOM"].Value.ToString();
        
            }
        }
        
    

        private void button3_Click_1(object sender, EventArgs e)
        {
            dkn.MANHOM = ma;
            dkn.MSSV = user;
           if(bus_dangkynhom.insert(dkn) == true)
            {
                MessageBox.Show("Bạn đăng ký thành công");
                DangKyCD_Load1(sender, e);
                
            }
            else
            {
                MessageBox.Show("Bạn đăng ký không thành công");
            }
        }

  
    }
}
