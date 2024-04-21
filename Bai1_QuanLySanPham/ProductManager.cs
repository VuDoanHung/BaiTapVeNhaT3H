using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QuanLySanPham
{
    public abstract class ProductManager:Product
    {
        public abstract Product  InputProduct();
        public abstract void ShowListProduct(List<Product> lstProduct);
       
    }
}
