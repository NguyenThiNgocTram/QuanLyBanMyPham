﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanMyPham
{
    public partial class QL_SanPham_GUI : Form
    {
        public QL_SanPham_GUI()
        {
            InitializeComponent();
        }

        private void bnEdit_Click(object sender, EventArgs e)
        {
            EditSanPham_GUI edit = new EditSanPham_GUI();
            edit.ShowDialog();
        }
    }
}
