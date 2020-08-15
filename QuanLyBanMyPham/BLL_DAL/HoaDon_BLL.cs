using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
   
    public class HoaDon_BLL
    {
        QLBMPDataContext qlbmp = new QLBMPDataContext();
        public HoaDon_BLL()
        {

        }

        public IQueryable<HoaDon> loadHoaDon()
        {
            return qlbmp.HoaDons.Select(k => k);
        }
        public void themHD(String _maHD, String _maNV, String _maKH, Double _ThanhTien, DateTime _NgayLap, String _ghiChu)
        {
            HoaDon hd = new HoaDon();
            hd.MaKhachHang = _maHD;
            hd.MaNhanVien = _maNV;
            hd.MaKhachHang = _maKH;
            hd.ThanhTien = _ThanhTien;
            hd.NgayLap = _NgayLap;
            hd.GhiChu = _ghiChu;
            qlbmp.HoaDons.InsertOnSubmit(hd);
            qlbmp.SubmitChanges();
        }

        public void xoaHD(String _maHD)
        {
            HoaDon hd = qlbmp.HoaDons.Where(k => k.MaHoaDon == _maHD).FirstOrDefault();
            qlbmp.HoaDons.DeleteOnSubmit(hd);
            qlbmp.SubmitChanges();

        }
    }
}
