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
    public partial class QuanLy : Form
    {
        string temp;
        BUS_ChuyenDe bus_chuyende = new BUS_ChuyenDe();
        public QuanLy()
        {

            InitializeComponent();
            Load += QuanLy_Load;
            //dataGridView1 += dataGridView1;
           

        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bus_chuyende.Get_Nganh();
            comboBox1.DisplayMember = "MaNganh";
            temp = comboBox1.ValueMember = "MaNganh";
            MessageBox.Show(temp);
            //dataGridView1.DataSource = bus_chuyende.Get_ChuyenDe(temp);
        }



        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }


        }

        
    }
}
