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
            this.IsMdiContainer = true;
        }

        //private void gioiThieuToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ManHinhGioiThieu_GUI frmGioiThieu = new ManHinhGioiThieu_GUI();
        //    frmGioiThieu.MdiParent = this;
        //    frmGioiThieu.WindowState = FormWindowState.Maximized;
        //    frmGioiThieu.Show();
        //}
    }
}
