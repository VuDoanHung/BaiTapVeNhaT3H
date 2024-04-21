using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QuanLyHangHoa
{
    public interface IHangHoa
    {
         int MaHang {  get; set; }
         string TenHang { get; set; }
         float Giatien { get; set; }
         DateTime NgaySx { get; set; }
         DateTime NgayHetHan { get; set; }
            

    }
}
