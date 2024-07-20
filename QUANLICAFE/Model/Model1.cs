using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QUANLICAFE.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BAN> BANs { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BAN>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.BAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BAN>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.BAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.ThanhTien)
                .HasPrecision(9, 0);

            modelBuilder.Entity<DanhMuc>()
                .HasMany(e => e.Mons)
                .WithRequired(e => e.DanhMuc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.ThanhTien)
                .HasPrecision(9, 0);

            modelBuilder.Entity<HoaDon>()
                .HasOptional(e => e.ChiTietHoaDon)
                .WithRequired(e => e.HoaDon);

            modelBuilder.Entity<Mon>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.Mon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mon>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.Mon)
                .WillCascadeOnDelete(false);
        }
    }
}
