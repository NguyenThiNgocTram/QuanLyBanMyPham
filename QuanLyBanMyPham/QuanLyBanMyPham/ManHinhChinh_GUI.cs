using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanMyPham
{
    public partial class ManHinhChinh_GUI : Form
    {
        public ManHinhChinh_GUI()
        {
            InitializeComponent();
        }

        private void ManHinhChinh_GUI_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            QL_NhanVien_GUI qL= new QL_NhanVien_GUI();
            qL.MdiParent = this;
            //qL.WindowState = FormWindowState.Maximized;
            qL.Dock = DockStyle.Fill;
            qL.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            QL_HoaDon_GUI ql = new QL_HoaDon_GUI();
            ql.MdiParent = this;
            ql.Dock = DockStyle.Fill;
            ql.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            QL_SanPham_GUI ql = new QL_SanPham_GUI();
            ql.MdiParent = this;
            ql.Dock = DockStyle.Fill;
            ql.Show();
        }

        private void ToolItemThemNCC_Click(object sender, EventArgs e)
        {
            QL_NCC_GUI ql = new QL_NCC_GUI();
            ql.ShowDialog();
        }

        private void ToolItemEditNV_Click(object sender, EventArgs e)
        {
            EditNhanVien_GUI edit = new EditNhanVien_GUI();
            edit.ShowDialog();
        }
    }
}
