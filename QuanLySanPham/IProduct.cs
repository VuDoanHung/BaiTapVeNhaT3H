using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public interface IProduct
    {
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id, string name);
        void DeleteMulti(Product product);

    }
}
