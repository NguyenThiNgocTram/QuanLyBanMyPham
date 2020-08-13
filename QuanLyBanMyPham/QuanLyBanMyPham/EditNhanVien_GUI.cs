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
    public partial class EditNhanVien_GUI : Form
    {
        NhanVien_BLL nv = new NhanVien_BLL();
        NhomNguoiDung_BLL nnd = new NhomNguoiDung_BLL();
        public EditNhanVien_GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnThem_Click(object sender, EventArgs e)
        {
                nv.ThemNhanVien(txtMa.Text, txtTen.Text, txtSDT.Text, txtPass.Text, txtDC.Text, txtNgaySinh.Value, txtCMND.Text, cbNhom.SelectedValue.ToString());
                MessageBox.Show("Thêm Thành Công");

        }


        private void bnSua_Click(object sender, EventArgs e)
        {
            nv.SuaNhanVien(txtMa.Text, txtTen.Text, txtSDT.Text, txtPass.Text, txtDC.Text, txtNgaySinh.Value, txtCMND.Text, cbNhom.SelectedValue.ToString());
            MessageBox.Show("Sửa Thành Công");
        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            nv.xoaNhanVien(txtMa.Text);
            MessageBox.Show("Xóa Thành Công");
        }

        private void EditNhanVien_GUI_Load(object sender, EventArgs e)
        {
            cbNhom.DataSource = nnd.loadNhomNguoiDung();
            cbNhom.DisplayMember = "TenNhomNguoiDung";
            cbNhom.ValueMember = "MaNhomNguoiDung";
        }
    }
}
