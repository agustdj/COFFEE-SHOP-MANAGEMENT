using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLICAFE.ViewModel
{
    internal class PhieuDatBan
    {
        public int MaBan {  get; set; }
        public float PhanTramGiamGia { get; set; }
        public List<ThongTinMon> DanhSachMon {  get; set; }
        public PhieuDatBan()
        {
            DanhSachMon = new List<ThongTinMon>();
        }
        public void CapNhatMon(ThongTinMon monmoi)
        {
            ThongTinMon mon = DanhSachMon.FirstOrDefault(x=>x.MaMon==monmoi.MaMon);
            if (mon != null)
            {
                mon.SoLuong += monmoi.SoLuong;
            }
            else
            {
                DanhSachMon.Add(monmoi);
            }
        }
    }
}
