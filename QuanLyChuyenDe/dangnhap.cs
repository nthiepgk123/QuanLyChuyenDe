using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyChuyenDe
{
    public partial class Dangnhap : Form
    {
   
         
        public Dangnhap()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông Báo");
            }
            else
            {
                string tk;
                BUS_TaiKhoan bus_tk = new BUS_TaiKhoan();
                tk = bus_tk.dangnhap(textBox1.Text, textBox2.Text);
                if (tk != "")
                {
                    
                    string ac = tk.Substring(0, 2);
                    if (ac == "SV" || ac == "sv")
                    {
                        Form fsv = new DangKyCD(textBox1.Text);
                        this.Hide();
                        fsv.ShowDialog();
                        this.Show();
                    }
                    else if (ac == "ad")
                    {
                        Form fad = new QuanLy();
                        this.Hide();
                        fad.ShowDialog();
                        this.Show();
                    }
                    else if (ac == "GV" || ac == "gv")
                    {
                        MessageBox.Show("Form GIÁO VIÊN", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đăng nhập sai!", "Thông báo");
                }

            }
        }
    }
}
    

