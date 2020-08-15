using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
    public class ChiTietHoaDon_BLL
    {
        QLBMPDataContext qlbmp = new QLBMPDataContext();
        
        public ChiTietHoaDon_BLL() { }

        public IQueryable<ChiTietHoaDon> loadCTHD()
        {
            return qlbmp.ChiTietHoaDons.Select(k => k);
        }

        public void themCTHD(string _maHD, string _maSP, int _sl, double _giaban)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.MaHoaDon = _maHD;
            cthd.MaSanPham = _maSP;
            cthd.SL = _sl;
            cthd.GiaBan = _giaban;
            qlbmp.ChiTietHoaDons.InsertOnSubmit(cthd);
            qlbmp.SubmitChanges();
        }
    }
}
