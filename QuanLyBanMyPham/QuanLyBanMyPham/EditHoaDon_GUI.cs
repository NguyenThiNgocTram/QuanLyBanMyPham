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
    public partial class EditHoaDon_GUI : Form
    {
        HoaDon_BLL hd = new HoaDon_BLL();
        NhanVien_BLL nv = new NhanVien_BLL();
        KhachHang_BLL kh = new KhachHang_BLL();
        public string _ma = "";
        public EditHoaDon_GUI()
        {
            InitializeComponent();
        }

        public void load()
        {
            cbMaNV.DataSource = nv.loadNhanVien();
            cbMaNV.DisplayMember = "TenNhanVien";
            cbMaNV.ValueMember = "MaNhanVien";

            cbMaKH.DataSource = kh.loadKH();
            cbMaKH.DisplayMember = "TenKhachHang";
            cbMaKH.ValueMember = "MaKhachHang";


        }

        private void bnThem_Click(object sender, EventArgs e)
        {
            hd.themHD(txtMaHD.Text, cbMaKH.SelectedValue.ToString(), cbMaKH.SelectedValue.ToString(),double.Parse(txtThanhTien.Text),datime.Value, txtGhiChu.Text);
            MessageBox.Show("Thêm Thành Công");
        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            hd.xoaHD(txtMaHD.Text);
        }

        private void EditHoaDon_GUI_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = _ma;
            load();
        }
    }
}
