using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;

namespace QuanLyBanMyPham
{
  
    public partial class QL_NhanVien_GUI : Form
    {
        NhanVien_BLL nhanvien = new NhanVien_BLL();
        public QL_NhanVien_GUI()
        {
            InitializeComponent();
        }
        public void loadNhanVien()
        {
            dataGridView1.DataSource = nhanvien.loadNhanVien();
        }
        private void ChucNangNhanVien_GUI_Load(object sender, EventArgs e)
        {
            loadNhanVien();
        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã Thoát");

        }
    }
}
