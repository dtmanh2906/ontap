using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinhTienManh_Ontap5.Migrations
{
    public partial class dinhtienmanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrinhBayBaiHats",
                columns: table => new
                {
                    MaTrinhBay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBaiHat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaSiTrinhBay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTrinhBay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaDiem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrinhBayBaiHats", x => x.MaTrinhBay);
                });

            migrationBuilder.InsertData(
                table: "TrinhBayBaiHats",
                columns: new[] { "MaTrinhBay", "CaSiTrinhBay", "DiaDiem", "NgayTrinhBay", "TenBaiHat", "ThoiLuong" },
                values: new object[] { 1, "Trung", "Ha Noi", new DateTime(2025, 6, 21, 16, 8, 35, 420, DateTimeKind.Local).AddTicks(6585), "Thuyen khong ben doi", 60 });

            migrationBuilder.InsertData(
                table: "TrinhBayBaiHats",
                columns: new[] { "MaTrinhBay", "CaSiTrinhBay", "DiaDiem", "NgayTrinhBay", "TenBaiHat", "ThoiLuong" },
                values: new object[] { 2, "Trung", "Da Nang", new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thuyen khong ben doi", 60 });

            migrationBuilder.InsertData(
                table: "TrinhBayBaiHats",
                columns: new[] { "MaTrinhBay", "CaSiTrinhBay", "DiaDiem", "NgayTrinhBay", "TenBaiHat", "ThoiLuong" },
                values: new object[] { 3, "Trung", "TP HCM", new DateTime(2025, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thuyen khong ben doi", 60 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrinhBayBaiHats");
        }
    }
}
