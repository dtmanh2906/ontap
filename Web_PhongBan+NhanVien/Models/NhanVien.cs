using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_PhongBan_NhanVien.Models
{
    public class NhanVien
    {
        [Key]
        public int Id { get; set; }
        public int MaPhong { get; set; }
        [ForeignKey("MaPhong")]
        public PhongBan? PhongBan { get; set; }

        [Required, StringLength(100)]
        public string HoTen { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Luong { get; set; }
    }
}
