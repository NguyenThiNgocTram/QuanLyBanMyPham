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
    public partial class QL_HoaDon_GUI : Form
    {
        HoaDon_BLL hd = new HoaDon_BLL();
        public string ma = "";
        public QL_HoaDon_GUI()
        {
            InitializeComponent();
        }
        public void loaddgv ()
        {
            dgvHoaDon.DataSource = hd.loadHoaDon();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void QL_HoaDon_GUI_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            EditHoaDon_GUI edit = new EditHoaDon_GUI();
            edit._ma = ma;
            edit.ShowDialog();
        }

        private void bnCTHD_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon_GUI cthd = new ChiTietHoaDon_GUI();
            cthd.ShowDialog();
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            ma = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
