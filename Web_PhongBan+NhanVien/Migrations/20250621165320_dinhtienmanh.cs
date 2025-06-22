using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_PhongBan_NhanVien.Migrations
{
    public partial class dinhtienmanh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhongBan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KinhPhi = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhong = table.Column<int>(type: "int", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Luong = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_PhongBan_MaPhong",
                        column: x => x.MaPhong,
                        principalTable: "PhongBan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PhongBan",
                columns: new[] { "Id", "KinhPhi", "TenPhong", "ViTri" },
                values: new object[] { 1, 5000000m, "Phòng Kế Toán", "Tầng 1" });

            migrationBuilder.InsertData(
                table: "PhongBan",
                columns: new[] { "Id", "KinhPhi", "TenPhong", "ViTri" },
                values: new object[] { 2, 7000000m, "Phòng Nhân Sự", "Tầng 2" });

            migrationBuilder.InsertData(
                table: "PhongBan",
                columns: new[] { "Id", "KinhPhi", "TenPhong", "ViTri" },
                values: new object[] { 3, 10000000m, "Phòng IT", "Tầng 3" });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "HoTen", "Luong", "MaPhong" },
                values: new object[] { 1, "Nguyen Van A", 15000000m, 1 });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "HoTen", "Luong", "MaPhong" },
                values: new object[] { 2, "Nguyen Van B", 25000000m, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaPhong",
                table: "NhanVien",
                column: "MaPhong");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "PhongBan");
        }
    }
}
