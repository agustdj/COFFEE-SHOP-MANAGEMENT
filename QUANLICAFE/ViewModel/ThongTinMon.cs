using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLICAFE.ViewModel
{
    internal class ThongTinMon
    {
        public int MaMon {  get; set; }
        public string TenMon { get; set; }
        public int SoLuong {  get; set; }
        public int Gia {  get; set; }
        public decimal ThanhTien { get { return Gia * SoLuong; } }
        public string TenDanhMuc { get; set; }
        public int MaDanhMuc{ get; set; }
    }
}
