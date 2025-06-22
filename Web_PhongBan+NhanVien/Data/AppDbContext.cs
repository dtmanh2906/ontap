using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_PhongBan_NhanVien.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PhongBan>().HasData(
            new PhongBan { Id = 1, TenPhong = "Phòng Kế Toán", ViTri = "Tầng 1", KinhPhi = 5000000 },
            new PhongBan { Id = 2, TenPhong = "Phòng Nhân Sự", ViTri = "Tầng 2", KinhPhi = 7000000 },
            new PhongBan { Id = 3, TenPhong = "Phòng IT", ViTri = "Tầng 3", KinhPhi = 10000000 }
            );
        modelBuilder.Entity<NhanVien>().HasData(
            new NhanVien { Id = 1, MaPhong = 1, HoTen = "Nguyen Van A", Luong = 15000000 },
            new NhanVien { Id = 2, MaPhong = 2, HoTen = "Nguyen Van B", Luong = 25000000 }
            );
    }

    public DbSet<Web_PhongBan_NhanVien.Models.NhanVien> NhanVien { get; set; } = default!;

    public DbSet<Web_PhongBan_NhanVien.Models.PhongBan>? PhongBan { get; set; }
}
