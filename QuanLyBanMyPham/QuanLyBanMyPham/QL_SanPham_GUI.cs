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
    public partial class QL_SanPham_GUI : Form
    {
        public String _maSP="";
        SanPham_BLL qlsp = new SanPham_BLL();
        public QL_SanPham_GUI()
        {
            InitializeComponent();
        }
       
        public void loaddgv()
        {
            dgvSanPham.DataSource = qlsp.loadSanPham();
        }
        private void bnEdit_Click(object sender, EventArgs e)
        {
            EditSanPham_GUI edit = new EditSanPham_GUI();
            edit.maSP = _maSP;
            edit.ShowDialog();
        }

        private void QL_SanPham_GUI_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            _maSP = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
