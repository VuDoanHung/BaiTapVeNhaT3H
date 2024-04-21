using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    internal class Program
    {
      static List<Product> products;
        static void Main(string[] args)
        {
            products = new List<Product>();
        }

        static void AddProduct()
        {
            while (true)
            {
                Console.WriteLine("Nhập số lượng sản phẩm cần thêm:");
                bool checkConditionInput = int.TryParse(Console.ReadLine(), out int quantityProduct);
                if (checkConditionInput && quantityProduct > 0)
                {

                    for (int i = 0; i < quantityProduct; i++)
                    {
                        Console.WriteLine($"Nhập thông tin sản phẩm số:{i + 1}");
                        staffs.Add(CheckConditionAddStaff());
                        Console.WriteLine($"Bạn đã nhập thành công nhân viên số {i + 1}");
                        Console.WriteLine("------------------------------------------------");

                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Bạn nhập sai! Xin hãy nhập lại.");
                    Console.WriteLine("-------------------------------");
                    continue;
                }
            }
        }
    }
}
