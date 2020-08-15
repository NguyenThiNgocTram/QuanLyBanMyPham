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
    public partial class QL_NCC_GUI : Form
    {
        NhaCungCap_BLL ncc = new NhaCungCap_BLL();
        public QL_NCC_GUI()
        {
            InitializeComponent();
        }

        private void bnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         public void loaddgv()
        {
            dgvNCC.DataSource = ncc.loadNCC();
        }
        private void QL_NCC_GUI_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void bnThem_Click(object sender, EventArgs e)
        {
            ncc.themNCC(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtGhiChu.Text);
            MessageBox.Show("Thêm thành công!");
            loaddgv();
            txtMaNCC.Text = "";

        }

        private void bnSua_Click(object sender, EventArgs e)
        {

        }

        private void bnXoa_Click(object sender, EventArgs e)
        {
            ncc.xoaNCC(txtMaNCC.Text);
            MessageBox.Show("Xóa thành công");
            loaddgv();
        }

        private void dgvNCC_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
