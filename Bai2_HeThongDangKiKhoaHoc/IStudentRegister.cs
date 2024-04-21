using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_HeThongDangKiKhoaHoc
{
    public interface IStudentRegister
    {
       StudentRegister RegisterCourse(List<Course> lstCourse);
    }
}
