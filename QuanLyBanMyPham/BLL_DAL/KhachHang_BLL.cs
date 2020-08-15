using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
    public class KhachHang_BLL
    {
        QLBMPDataContext qlbmp = new QLBMPDataContext();
        public KhachHang_BLL()
        {

        }

        public IQueryable<ThongTinKhachHang> loadKH()
        {
            return qlbmp.ThongTinKhachHangs.Select(kh => kh);
        }

        public void themKH (String _makh, String _tenkh, String _diachi, String _sdt, int _tichdiem, String _manhomnd)
        {
            ThongTinKhachHang kh = new ThongTinKhachHang();
            kh.MaKhachHang = _makh;
            kh.TenKhachHang = _tenkh;
            kh.DiaChi = _diachi;
            kh.SoDienThoai = _sdt;
            kh.TichDiem = _tichdiem;
            kh.MaNhomNguoiDung = _manhomnd;
            qlbmp.ThongTinKhachHangs.InsertOnSubmit(kh);
            qlbmp.SubmitChanges();
        }

        public void xoaKH(String _makh)
        {
            ThongTinKhachHang xoakh = qlbmp.ThongTinKhachHangs.Where(kh => kh.MaKhachHang == _makh).FirstOrDefault();
            qlbmp.ThongTinKhachHangs.DeleteOnSubmit(xoakh);
            qlbmp.SubmitChanges();
        }
    }
}
