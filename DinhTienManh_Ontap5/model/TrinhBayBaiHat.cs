using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhTienManh_Ontap5.model
{
    internal class TrinhBayBaiHat
    {
        [Key]
        public int MaTrinhBay { get; set; }
        public string TenBaiHat { get; set; }
        public string CaSiTrinhBay { get; set; }
        public DateTime NgayTrinhBay { get; set; }
        public string DiaDiem { get; set; }
        public int ThoiLuong { get; set; }
    }
}
