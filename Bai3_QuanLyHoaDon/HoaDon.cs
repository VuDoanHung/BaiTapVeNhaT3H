using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_QuanLyHoaDon
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public DateTime NgayPhatHanh { get; set; }
        public int TongTien { get; set; }
        public int SoTienConNo { get; set; }
        public bool TrangThaiNo { get; set; }
        public string TenKhachHang { get; set; }   

    }
    public enum FunctionApp
    {
        AddList = 1,
        CancellationOfDept,
        ShowList,
        Exit,

    }
}
