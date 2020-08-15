using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
    public class NhaCungCap_BLL
    {
        QLBMPDataContext qlbmp = new QLBMPDataContext();

        public   NhaCungCap_BLL() { }

        public IQueryable<NhaCungCap> loadNCC()
        {
            return (qlbmp.NhaCungCaps.Select(ncc => ncc));
        }

        public void themNCC (String _mancc,String _tenncc, String _diachi, String _ghichu)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = _mancc;
            ncc.TenNCC = _tenncc;
            ncc.DiaChi = _diachi;
            ncc.GhiChu = _ghichu;
            qlbmp.NhaCungCaps.InsertOnSubmit(ncc);
            qlbmp.SubmitChanges();
        }

        public void xoaNCC (String _mancc)
        {
            NhaCungCap xoaNCC = qlbmp.NhaCungCaps.Where(ncc => ncc.MaNCC == _mancc).FirstOrDefault();
            qlbmp.NhaCungCaps.DeleteOnSubmit(xoaNCC);
            qlbmp.SubmitChanges();
            
        }



    }
}
