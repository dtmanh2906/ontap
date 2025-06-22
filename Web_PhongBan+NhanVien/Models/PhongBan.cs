using System.ComponentModel.DataAnnotations;

namespace Web_PhongBan_NhanVien.Models
{
    public class PhongBan
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string TenPhong { get; set; }
        [StringLength(50)]
        public string ViTri { get; set; }
        [Range(0, double.MaxValue)]
        public decimal KinhPhi { get; set; }

        public ICollection<NhanVien>? NhanViens { get; set; }
    }
}
