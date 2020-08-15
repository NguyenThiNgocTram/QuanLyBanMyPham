using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
    public class NhomNguoiDung_BLL
    {
        QLBMPDataContext qlbmp = new QLBMPDataContext();
       
        public NhomNguoiDung_BLL()
        { }
        
        public IQueryable<NhomNguoiDung> loadNhomNguoiDung()
        {
            return (qlbmp.NhomNguoiDungs.Select(k => k));
        }
    }
}
