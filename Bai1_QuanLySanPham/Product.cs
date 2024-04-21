using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QuanLySanPham
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int TypeDiscount { get; set; }
        public int PriceAfterDiscount { get; set; }
        public int CaculatorDiscount(int Price,int TypeDiscount)
        {
            try
            {
                switch (TypeDiscount)
                {
                    case 1:
                        if (Price >= 10000 && Price < 100000)
                        {
                            return 10000;
                        }
                        else if (Price >= 100000)
                        {
                            return 5000;
                        }
                        else { return 0; }
                    case 2:
                        if (Price >= 10000 && Price < 100000)
                        {
                            return (int)(Price * 0.01); 
                        }
                        else if (Price >= 100000)
                        {
                            return (int)(Price*0.05);
                        }
                        else { return 0; }
                    default: return 0;
                }
            }catch (Exception e)
            {
                return -1;
            }
            
        }
    }
}
