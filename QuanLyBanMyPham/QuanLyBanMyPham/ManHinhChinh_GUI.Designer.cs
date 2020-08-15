namespace QuanLyBanMyPham
{
    partial class ManHinhChinh_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChinh_GUI));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNhanVien = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolItemEditNV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolKhachHang = new System.Windows.Forms.ToolStripButton();
            this.toolHoaDon = new System.Windows.Forms.ToolStripButton();
            this.toolPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.toolSanPham = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolItemEditSP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolItemThemNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDangxuat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNhanVien,
            this.toolKhachHang,
            this.toolHoaDon,
            this.toolPhieuNhap,
            this.toolSanPham,
            this.toolDangxuat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1162, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolNhanVien
            // 
            this.toolNhanVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemEditNV});
            this.toolNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("toolNhanVien.Image")));
            this.toolNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNhanVien.Name = "toolNhanVien";
            this.toolNhanVien.Size = new System.Drawing.Size(119, 33);
            this.toolNhanVien.Text = "Nhân Viên ";
            this.toolNhanVien.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ToolItemEditNV
            // 
            this.ToolItemEditNV.Name = "ToolItemEditNV";
            this.ToolItemEditNV.Size = new System.Drawing.Size(356, 34);
            this.ToolItemEditNV.Text = "Chỉnh sửa thông tin Nhân Viên";
            this.ToolItemEditNV.Click += new System.EventHandler(this.ToolItemEditNV_Click);
            // 
            // toolKhachHang
            // 
            this.toolKhachHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("toolKhachHang.Image")));
            this.toolKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolKhachHang.Name = "toolKhachHang";
            this.toolKhachHang.Size = new System.Drawing.Size(111, 33);
            this.toolKhachHang.Text = "Khách Hàng";
            this.toolKhachHang.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolHoaDon
            // 
            this.toolHoaDon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("toolHoaDon.Image")));
            this.toolHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHoaDon.Name = "toolHoaDon";
            this.toolHoaDon.Size = new System.Drawing.Size(88, 33);
            this.toolHoaDon.Text = "Hóa Đơn";
            this.toolHoaDon.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolPhieuNhap
            // 
            this.toolPhieuNhap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("toolPhieuNhap.Image")));
            this.toolPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPhieuNhap.Name = "toolPhieuNhap";
            this.toolPhieuNhap.Size = new System.Drawing.Size(107, 33);
            this.toolPhieuNhap.Text = "Phiếu Nhập";
            // 
            // toolSanPham
            // 
            this.toolSanPham.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemEditSP,
            this.ToolItemThemNCC});
            this.toolSanPham.Image = ((System.Drawing.Image)(resources.GetObject("toolSanPham.Image")));
            this.toolSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSanPham.Name = "toolSanPham";
            this.toolSanPham.Size = new System.Drawing.Size(112, 33);
            this.toolSanPham.Text = "Sản Phẩm";
            this.toolSanPham.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // ToolItemEditSP
            // 
            this.ToolItemEditSP.Name = "ToolItemEditSP";
            this.ToolItemEditSP.Size = new System.Drawing.Size(362, 34);
            this.ToolItemEditSP.Text = "Chỉnh Sửa Thông Tin Sản Phẩm";
            this.ToolItemEditSP.Click += new System.EventHandler(this.ToolItemEditSP_Click);
            // 
            // ToolItemThemNCC
            // 
            this.ToolItemThemNCC.Name = "ToolItemThemNCC";
            this.ToolItemThemNCC.Size = new System.Drawing.Size(362, 34);
            this.ToolItemThemNCC.Text = "Thêm Nhà Cung Cấp";
            this.ToolItemThemNCC.Click += new System.EventHandler(this.ToolItemThemNCC_Click);
            // 
            // toolDangxuat
            // 
            this.toolDangxuat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDangxuat.Image = ((System.Drawing.Image)(resources.GetObject("toolDangxuat.Image")));
            this.toolDangxuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDangxuat.Name = "toolDangxuat";
            this.toolDangxuat.Size = new System.Drawing.Size(100, 33);
            this.toolDangxuat.Text = "Đăng Xuất";
            this.toolDangxuat.Click += new System.EventHandler(this.toolDangxuat_Click);
            // 
            // ManHinhChinh_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 507);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ManHinhChinh_GUI";
            this.Text = "Màn Hình Chính";
            this.Load += new System.EventHandler(this.ManHinhChinh_GUI_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolKhachHang;
        private System.Windows.Forms.ToolStripButton toolHoaDon;
        private System.Windows.Forms.ToolStripButton toolPhieuNhap;
        private System.Windows.Forms.ToolStripSplitButton toolNhanVien;
        private System.Windows.Forms.ToolStripMenuItem ToolItemEditNV;
        private System.Windows.Forms.ToolStripSplitButton toolSanPham;
        private System.Windows.Forms.ToolStripMenuItem ToolItemThemNCC;
        private System.Windows.Forms.ToolStripMenuItem ToolItemEditSP;
        private System.Windows.Forms.ToolStripButton toolDangxuat;
    }
}