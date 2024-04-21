using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Abstract
{
    public abstract class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float TypeStaff { get; set; }    
        public abstract float PayWage(float salary);
    }
    public enum TypeStaff
    {
        FullTime = 1,
        Partime = 2,
        Intern = 3,
    }
}
