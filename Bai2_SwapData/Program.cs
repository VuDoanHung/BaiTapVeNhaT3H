using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_SwapData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Nhập a = ");
            var a = Console.ReadLine();
         
            Console.WriteLine($"Nhập b ");
            var b = Console.ReadLine();
           
            Swap<string> swap = new Swap<string>();
            Console.WriteLine($"Trước khi swap a={a};b={b}");
            swap.SwapData(ref a,ref b);
            Console.WriteLine($"Sau khi swap a={a};b={b}");
            Console.ReadKey();

        }
    }
}
