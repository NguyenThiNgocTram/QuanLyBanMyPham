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
    public partial class QL_HoaDon_GUI : Form
    {
        public QL_HoaDon_GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void QL_HoaDon_GUI_Load(object sender, EventArgs e)
        {

        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            EditHoaDon_GUI edit = new EditHoaDon_GUI();
            edit.ShowDialog();
        }

        private void bnCTHD_Click(object sender, EventArgs e)
        {

        }
    }
}
