namespace Web_PhongBan_NhanVien.Models
{
    public class ThongKePhongBanViewModel
    {
        public string TenPhong { get; set; }
        public string ViTri { get; set; }
        public decimal KinhPhi { get; set; }
        public decimal TongLuongChiTra { get; set; }
        public List<NhanVien> DanhSachNhanVien { get; set; }
    }
}
