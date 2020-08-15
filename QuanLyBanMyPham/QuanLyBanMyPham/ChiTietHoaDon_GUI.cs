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
    public partial class ChiTietHoaDon_GUI : Form
    {
        ChiTietHoaDon_BLL ct = new ChiTietHoaDon_BLL();
        HoaDon_BLL hd = new HoaDon_BLL();
        SanPham_BLL sp = new SanPham_BLL();
        public ChiTietHoaDon_GUI()
        {
            InitializeComponent();
        }

        public void load()
        {
            dgvChiTietHD.DataSource = ct.loadCTHD();

            cbMaHD.DataSource = hd.loadHoaDon();
            cbMaHD.DisplayMember = "MaHoaDon";
            cbMaHD.ValueMember = "MaHoaDon";

            cbTenSp.DataSource = sp.loadSanPham();
            cbTenSp.DisplayMember = "TenSanPham";
            cbTenSp.ValueMember = "MaSanPham";
        }
        

        private void ChiTietHoaDon_GUI_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
