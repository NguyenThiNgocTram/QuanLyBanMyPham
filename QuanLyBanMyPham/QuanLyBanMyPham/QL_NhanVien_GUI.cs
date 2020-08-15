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
        public String _maNVien = "";
        public QL_NhanVien_GUI()
        {
            InitializeComponent();
        }
        public void loadNhanVien()
        {
            
            dgvNhanVien.DataSource = nhanvien.loadNhanVien();

        }
        private void ChucNangNhanVien_GUI_Load(object sender, EventArgs e)
        {
            loadNhanVien();
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            EditNhanVien_GUI edit = new EditNhanVien_GUI();
            edit._maNV = _maNVien;
            edit.ShowDialog();
        }

        private void bnIn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadNhanVien();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            _maNVien = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
        }


    }
}
