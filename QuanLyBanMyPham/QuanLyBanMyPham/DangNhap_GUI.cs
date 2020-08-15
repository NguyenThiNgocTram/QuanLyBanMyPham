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
    public partial class DangNhap_GUI : Form
    {
        NhanVien_BLL nv = new NhanVien_BLL();
        public DangNhap_GUI()
        {
            InitializeComponent();
        }

        public void load()
        {
            cbUser.DataSource = nv.loadNhanVien();
            cbUser.DisplayMember = "TenNhanVien";
            cbUser.ValueMember = "MaNhanVien";
        }

        private void DangNhap_GUI_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool dn = nv.dangNhap(cbUser.SelectedValue.ToString(), txbPass.Text);
            if (dn == true)
            {
                MessageBox.Show("Dang nhap thanh cong");
                ManHinhChinh_GUI tram = new ManHinhChinh_GUI();
                tram.Show();
               
            }
            else MessageBox.Show("Sai pass rồi");


        }
    }
}
