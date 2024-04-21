using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CommonLib=CommonLibs.CommonLibs;

namespace Bai1_QuanLySanPham
{
    internal class Program
    {
       static List<Product> products;
        static ProductManegerBUS productManegerBUS;
        static void Main(string[] args)
        {
            productManegerBUS = new ProductManegerBUS();
            products= new List<Product>();
            while (true)
            {
                Console.WriteLine("Choose Function:(1:Add Product, 4:Show List Product, 5:Exit Application");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int funtion);
                if (!CheckinputCondition)
                {
                    Console.WriteLine("You choose wrong Format of Function!");
                    Console.WriteLine("Please choose option again!");
                    continue;
                }
                switch (funtion)
                {
                    case (int)Funtion.Add:
                        AddProduct();
                        Console.WriteLine("Add Product Successful!");
                        Console.WriteLine("----------------------------------------------");
                        break;
                    case (int)Funtion.Show:
                        ShowListProduct(products);
                        break;
                    case (int)Funtion.Exit:
                        Environment.Exit(0); break;
                    default:
                        Console.WriteLine("You choose wrong Function!");
                        Console.WriteLine("Please choose option again!");
                        Console.WriteLine("-----------------------------");

                        break;
                }
                
            }
        }

        private static void AddProduct()
        {
            try
            {
                products.Add(productManegerBUS.InputProduct());

            }catch (Exception ex)
            {

            }
        }

        private static void ShowListProduct(List<Product> lstProduct)
        {
            productManegerBUS.ShowListProduct(lstProduct);
        }
    }
    public enum Funtion
    {
        Add=1,
        Show=4,
        Exit
    }
}
