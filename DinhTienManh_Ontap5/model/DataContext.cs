using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DinhTienManh_Ontap5.model
{
    internal class DataContext : DbContext
    {
        public DbSet<TrinhBayBaiHat> TrinhBayBaiHats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=localhost\MSSQLSERVER01;Initial Catalog=Ontap;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TrinhBayBaiHat>().HasData(
                new TrinhBayBaiHat { MaTrinhBay = 1, TenBaiHat = "Thuyen khong ben doi", CaSiTrinhBay = "Trung", NgayTrinhBay = DateTime.Now, DiaDiem = "Ha Noi", ThoiLuong = 60 },
                new TrinhBayBaiHat { MaTrinhBay = 2, TenBaiHat = "Thuyen khong ben doi", CaSiTrinhBay = "Trung", NgayTrinhBay = new DateTime(2025, 7, 10), DiaDiem = "Da Nang", ThoiLuong = 60 },
                new TrinhBayBaiHat { MaTrinhBay = 3, TenBaiHat = "Thuyen khong ben doi", CaSiTrinhBay = "Trung", NgayTrinhBay = new DateTime(2025, 7, 29), DiaDiem = "TP HCM", ThoiLuong = 60 }
                );
        }
    }
}
