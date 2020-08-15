using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
    public class NhanVien_BLL
    {
        QLBMPDataContext qlbmp = new QLBMPDataContext();

        public NhanVien_BLL()
        { }

        public IQueryable<NhanVien> loadNhanVien()
        {
            return qlbmp.NhanViens.Select(k => k);
        }

        public void ThemNhanVien(String _maNV, String _TenNV, String _SDT, String _pass, String _diachi, DateTime _Ngaysinh, String _cmnd, String _maNhom)
        {
            NhanVien themNV = new NhanVien();
            themNV.MaNhanVien = _maNV;
            themNV.TenNhanVien = _TenNV;
            themNV.SoDienThoai = _SDT;
            themNV.MatKhau = _pass;
            themNV.DiaChi = _diachi;
            themNV.NgaySinh = _Ngaysinh;
            themNV.CMND = _cmnd;
            themNV.MaNhomNguoiDung = _maNhom;
            qlbmp.NhanViens.InsertOnSubmit(themNV);
            qlbmp.SubmitChanges();
        }

        public void SuaNhanVien(String _maNV, String _TenNV, String _SDT, String _pass, String _diachi, DateTime _Ngaysinh, String _cmnd, String _maNhom)
        {
            NhanVien suaNV = qlbmp.NhanViens.Where(k => k.MaNhanVien == _maNV).FirstOrDefault();
            suaNV.TenNhanVien = _TenNV;
            suaNV.SoDienThoai = _SDT;
            suaNV.MatKhau = _pass;
            suaNV.DiaChi = _diachi;
            suaNV.NgaySinh = _Ngaysinh;
            suaNV.CMND = _cmnd;
            suaNV.MaNhomNguoiDung = _maNhom;
            qlbmp.SubmitChanges();
        }

        public void xoaNhanVien(String _maNV)
        {
            NhanVien xoaNV = qlbmp.NhanViens.Where(k => k.MaNhanVien == _maNV).FirstOrDefault();
            qlbmp.NhanViens.DeleteOnSubmit(xoaNV);
            qlbmp.SubmitChanges();
        }

        public bool dangNhap(string _manv, string _pass)
        {
            int timkiem = qlbmp.NhanViens.Where(k => k.MaNhanVien == _manv && k.MatKhau == _pass).Count();
            if (timkiem > 0)
            {
                return true;
            }
            return false;
        }
    }
}
