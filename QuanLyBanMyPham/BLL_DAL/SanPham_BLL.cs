using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
    public class SanPham_BLL
    {
        QLBMPDataContext qlbmp = new QLBMPDataContext();
        public SanPham_BLL()
        {
            loadSanPham();
        }

        public IQueryable<SanPham> loadSanPham()
        {
            return qlbmp.SanPhams.Select(sp => sp);
        }

        public void themSanPham(String _masp, String _tensp, float _giaban, float _gianhap, int _SL, String _maloai, String _mancc, String _xuatsu)
        {
            SanPham themsp = new SanPham();
            themsp.MaSanPham = _masp;
            themsp.TenSanPham = _tensp;
            themsp.GiaBan = _giaban;
            themsp.GiaNhap = _gianhap;
            themsp.SL =_SL;
            themsp.MaLoaiSanPham = _maloai;
            themsp.MaNCC = _mancc;
            themsp.XuatSu = _xuatsu;
            qlbmp.SanPhams.InsertOnSubmit(themsp);
            qlbmp.SubmitChanges();
        }

        public void xoaSP (String _masp)
        {
            SanPham xoasp = qlbmp.SanPhams.Where(l => l.MaSanPham == _masp).FirstOrDefault();
            qlbmp.SanPhams.DeleteOnSubmit(xoasp);
            qlbmp.SubmitChanges();
        }
       
    }
}
