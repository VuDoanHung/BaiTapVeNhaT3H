using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Abstract
{
    public class FullTimeEmployee : Staff
    {
        public override float PayWage(float salary)
        {
          return salary;
        }
    }
}
