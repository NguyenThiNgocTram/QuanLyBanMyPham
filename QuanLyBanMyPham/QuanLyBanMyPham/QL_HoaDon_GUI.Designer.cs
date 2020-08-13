namespace QuanLyBanMyPham
{
    partial class QL_HoaDon_GUI
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bnIn = new System.Windows.Forms.Button();
            this.bnEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.bnCTHD = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // bnIn
            // 
            this.bnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnIn.Location = new System.Drawing.Point(229, 512);
            this.bnIn.Name = "bnIn";
            this.bnIn.Size = new System.Drawing.Size(242, 68);
            this.bnIn.TabIndex = 11;
            this.bnIn.Text = "In Danh Sách";
            this.bnIn.UseVisualStyleBackColor = true;
            // 
            // bnEdit
            // 
            this.bnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnEdit.Location = new System.Drawing.Point(913, 512);
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(236, 68);
            this.bnEdit.TabIndex = 10;
            this.bnEdit.Text = "Chỉnh Sửa ";
            this.bnEdit.UseVisualStyleBackColor = true;
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhanVien);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1273, 493);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 22);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(1267, 468);
            this.dgvNhanVien.TabIndex = 6;
            // 
            // bnCTHD
            // 
            this.bnCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCTHD.Location = new System.Drawing.Point(539, 512);
            this.bnCTHD.Name = "bnCTHD";
            this.bnCTHD.Size = new System.Drawing.Size(308, 68);
            this.bnCTHD.TabIndex = 12;
            this.bnCTHD.Text = "Xem Chi Tiết Hóa Đơn";
            this.bnCTHD.UseVisualStyleBackColor = true;
            this.bnCTHD.Click += new System.EventHandler(this.bnCTHD_Click);
            // 
            // QL_HoaDon_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 592);
            this.Controls.Add(this.bnCTHD);
            this.Controls.Add(this.bnIn);
            this.Controls.Add(this.bnEdit);
            this.Controls.Add(this.groupBox2);
            this.Name = "QL_HoaDon_GUI";
            this.Text = "QL_HoaDon_GUI";
            this.Load += new System.EventHandler(this.QL_HoaDon_GUI_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bnIn;
        private System.Windows.Forms.Button bnEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button bnCTHD;
    }
}