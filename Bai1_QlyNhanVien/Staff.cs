using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QlyNhanVien
{
    public struct Staff
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float PointAverage { get; set; }
        public Staff(string _name, int _age, float _pointAverage)
        {
            Name = _name;
            Age = _age;
            PointAverage = _pointAverage;

        }
    }

}
public enum FunctionApp
{
    Add = 1,
    Show,
    Sort,
    SortCondition,
    Exit,

}

