using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
    public class LoaiSanPham_BLL
    {
        QLBMPDataContext qlbmp = new QLBMPDataContext();

        public  LoaiSanPham_BLL() { }

        public IQueryable<LoaiSanPham> loadLoaiSP()
        {
            return qlbmp.LoaiSanPhams.Select(l => l);
        }
    }
}
