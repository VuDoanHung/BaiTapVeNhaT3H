using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QuanLyHangHoa
{
    internal class Program
    {
        static List<IHangHoa> hangHoas;
        static void Main(string[] args)
        {
            hangHoas = new List<IHangHoa>();
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Chọn menu:(1:ThemHang;2:Mua hang, 3:Thong ke hang sap het han, 4:Exit Application)");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int funtion);
                if (!CheckinputCondition)
                {
                    Console.WriteLine("Ban chon sai dinh dang!");
                    Console.WriteLine("Xin hay chọn lại");
                    continue;
                }
                switch (funtion)
                {
                    case (int)FunctionApp.Add:
                        AddBook(); break;
                    case (int)FunctionApp.Show:
                        ShowListBook(); break;
                    case (int)FunctionApp.Search:
                        SearchBook(); break;
                    case (int)FunctionApp.Exit:
                        Environment.Exit(0); break;
                    default:
                        Console.WriteLine("You choose wrong Function!");
                        Console.WriteLine("Please choose option again!");
                        Console.WriteLine("-----------------------------");

                        break;
                }

            }
        }
        static void NhapHang()
        {
            for
        }
        public enum FunctionApp
        {
            Add = 1,
            Show,
            Search,
            Exit,

        }
    }
}
