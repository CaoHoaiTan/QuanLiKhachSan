using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace QuanLiKhachSan
{
    public class KhachSanContext : DbContext
    {
        public KhachSanContext() : base("name = QuanLyKhachSan")
        {
            
        }
        public DbSet<NhanVien> NhanViens;
        public DbSet<NhomNV> NhomNVs;
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // NhomNV one-to-many NhanVien (NhomNV có nhiều NV)
            modelBuilder.Entity<NhanVien>()
                .HasOptional<NhomNV>(nv => nv.NhomNV)
                .WithMany(n => n.nhanViens)
                .HasForeignKey<int?>(nv => nv.idNhom);

            // NhomNV one-to-one NhanVien (NhomNV có 1 Trưởng nhóm)
            modelBuilder.Entity<NhomNV>()
                .HasRequired(n => n.TruongNhom)
                .WithOptional(nv => nv.NhomNV);
        }
    }
}
