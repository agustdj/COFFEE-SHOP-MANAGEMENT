namespace QUANLICAFE.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }

        public int MaMon { get; set; }

        public int SoLuong { get; set; }

        public int GiamGia { get; set; }

        public int MaNhanVien { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhanVien { get; set; }

        public DateTime NgayDat { get; set; }

        public int MaBan { get; set; }

        public decimal ThanhTien { get; set; }

        public virtual BAN BAN { get; set; }

        public virtual ChiTietHoaDon ChiTietHoaDon { get; set; }

        public virtual Mon Mon { get; set; }
    }
}
