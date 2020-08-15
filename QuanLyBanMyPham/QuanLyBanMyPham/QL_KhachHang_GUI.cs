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
    public partial class QL_KhachHang_GUI : Form
    {
        KhachHang_BLL kh = new KhachHang_BLL();
        NhomNguoiDung_BLL n = new NhomNguoiDung_BLL();
        public QL_KhachHang_GUI()
        {
            InitializeComponent();
        }
        public void loadgv ()
        {
            dgvKhachHang.DataSource = kh.loadKH();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kh.themKH(txtMaKH.Text, txtTenKH.Text, txtDC.Text, txtSDT.Text, int.Parse(txtTD.Text), cbNhomnd.SelectedValue.ToString());
            MessageBox.Show("Thêm thành công");
            loadgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kh.xoaKH(txtMaKH.Text);
            MessageBox.Show("Xóa thành công!");
            loadgv();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QL_KhachHang_GUI_Load(object sender, EventArgs e)
        {
            cbNhomnd.DataSource = n.loadNhomNguoiDung();
            cbNhomnd.DisplayMember = "TenNhomNguoiDung";
            cbNhomnd.ValueMember = "MaNhomNguoiDung";
            loadgv();
        }
    }
}
