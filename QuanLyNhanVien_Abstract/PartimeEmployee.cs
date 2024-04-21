using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Abstract
{
    public class PartimeEmployee : Staff
    {
        public override float PayWage(float salary)
        {
            return (float)(salary* 0.5);
        }
    }
}
