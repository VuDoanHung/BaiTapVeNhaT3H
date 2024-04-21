using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QuanLyHangHoa
{
    public class HangDienTu : IHangHoa
    {
        public int MaHang { get ; set; }
        public string TenHang { get ; set ; }
        public float Giatien { get; set; }
        public DateTime NgaySx { get; set ; }
        public DateTime NgayHetHan { get ; set ; }
    }
}
