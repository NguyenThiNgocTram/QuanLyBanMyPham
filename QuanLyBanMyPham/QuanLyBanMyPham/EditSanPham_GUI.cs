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
    public partial class EditSanPham_GUI : Form
    {
        SanPham_BLL sp = new SanPham_BLL();
        NhaCungCap_BLL ncc = new NhaCungCap_BLL();
        LoaiSanPham_BLL lsp = new LoaiSanPham_BLL();
        public string maSP = "";
        public EditSanPham_GUI()
        {
            InitializeComponent();
        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnThem_Click(object sender, EventArgs e)
        {
            sp.themSanPham(txtMaSP.Text, txtTenSP.Text, float.Parse(txtGiaBan.Text), float.Parse(txtGiaNhap.Text), int.Parse(txtSL.Text), cbLoai.SelectedValue.ToString(), cbNCC.SelectedValue.ToString(), txtXuatXu.Text);
            MessageBox.Show("Thêm Thành Công");
        }

        private void EditSanPham_GUI_Load(object sender, EventArgs e)
        {
            cbNCC.DataSource = ncc.loadNCC();
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "MaNCC";

            cbLoai.DataSource = lsp.loadLoaiSP();
            cbLoai.DisplayMember = "TenLoaiSanPham";
            cbLoai.ValueMember = "MaLoaiSanPham";

            txtMaSP.Text = maSP;
        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            sp.xoaSP(txtMaSP.Text);
            MessageBox.Show("Xoá thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
