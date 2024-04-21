using CommonLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLib = CommonLibs.CommonLibs;


namespace Bai1_QuanLySanPham
{
    public class ProductManegerBUS : ProductManager
    {
        
        public override Product InputProduct()
        {
            while (true)
            {
                Console.WriteLine("Input Name Product");
                string nameProduct = Console.ReadLine();
                if (!CommonLib.CheckName(nameProduct))
                {
                    Console.WriteLine("Wrong Input Name!");
                    Console.WriteLine("-----------------");
                    continue;
                }
                Console.WriteLine("Input Price Product");
                var priceTemp = Console.ReadLine();
                int price = 0;
                if (!CommonLib.CheckIntType(priceTemp))
                {
                    Console.WriteLine("Wrong Input Price!");
                    Console.WriteLine("-----------------");
                    continue;
                }
                else
                {
                    price = int.Parse(priceTemp);
                }
                Console.WriteLine("Input Type Discount Product : 1-Money,2-Percent");
                var typeDiscountTemp = Console.ReadLine();
                int typeDiscount = 0;
                if (!CommonLib.CheckIntType(typeDiscountTemp))
                {
                    Console.WriteLine("Wrong Input Price!");
                    Console.WriteLine("-----------------");
                    continue;
                }
                else
                {
                    typeDiscount = int.Parse(typeDiscountTemp);
                    if (typeDiscount < 0 && typeDiscount > 2)
                    {
                        Console.WriteLine("Wrong Input Price!");
                        Console.WriteLine("-----------------");
                        continue;
                    }
                }
                int Discount = CaculatorDiscount(price, typeDiscount);
                Product product = new Product() { Name = nameProduct, Price = price, TypeDiscount = typeDiscount, PriceAfterDiscount = price - Discount };
               
                return product;
            }
           

        }

        public override void ShowListProduct(List<Product> lstProduct)
        {
            while (true)
            {
                Console.WriteLine("Choose Function:(1:Show Product follow type Discount, 2:Show Product follow sort Discount, 3:Find Product by Name");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int funtion);
                if (!CheckinputCondition)
                {
                    Console.WriteLine("You choose wrong Format of Function!");
                    Console.WriteLine("Please choose option again!");
                    continue;
                }
                switch (funtion)
                {
                    case (int)ShowList.TypeDiscount:
                        ChooseTypeDisscount(lstProduct);
                        Console.WriteLine("----------------------------------------------");
                        return;
                    case (int)ShowList.SortDiscountDecrease:
                        SortDiscountDecrease(lstProduct);
                        return;
                    case(int)ShowList.FindName:
                         FindNameProduct(lstProduct); return;
                    case (int)Funtion.Exit:
                        Environment.Exit(0); return;
                    default:
                        Console.WriteLine("You choose wrong Function!");
                        Console.WriteLine("Please choose option again!");
                        Console.WriteLine("-----------------------------");

                        break;
                }

            }
        }
        private void ChooseTypeDisscount(List<Product> products)
        {
            while (true)
            {
                Console.WriteLine("Choose Function:(1:Discount Money, 2:Discount Percent");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int funtion);
                if (!CheckinputCondition && funtion !=1 && funtion!=2)
                {
                    Console.WriteLine("You choose wrong Format of Function!");
                    Console.WriteLine("Please choose option again!");
                    continue;
                }           
                
               var ProducTypes = products.Where(x=>x.TypeDiscount == funtion).ToArray();
                string TypeDiscountName = funtion==1 ? "Money" : "Percent";
                foreach (var producType in ProducTypes) 
                { 
                    Console.WriteLine($"ProductName-{producType.Name};ProductType-{TypeDiscountName};Price after Discount-{producType.PriceAfterDiscount}\n"); 
                }
                break;
            }
            
           
        }
        private void SortDiscountDecrease(List<Product> products)
        {
            products.Sort(new DisCountComparer());
            foreach(var product in products)
            {
                Console.WriteLine($"ProductName-{product.Name};ProductType-{(product.TypeDiscount == 1 ? "Money" : "Percent")};Price after Discount-{product.PriceAfterDiscount}\n");

            }
        }
        private void FindNameProduct(List<Product> products)
        {
            Console.WriteLine("Input Name Product U want to Find");
            string nameProduct = Console.ReadLine();
            if (CommonLib.CheckName(nameProduct)) 
            { 
                var nameProducts = products.Where(x => x.Name == nameProduct).ToArray();
                foreach (var product in nameProducts)
                {
                    Console.WriteLine($"ProductName-{product.Name};ProductType-{(product.TypeDiscount == 1 ? "Money" : "Percent")};Price after Discount-{product.PriceAfterDiscount}\n");
                }
            };
        }
        public enum ShowList
        {
            TypeDiscount = 1,
            SortDiscountDecrease,
            FindName
        }
        public class DisCountComparer : IComparer<Product>
        {
           
            public int Compare(Product x, Product y)
            {
                return x.PriceAfterDiscount.CompareTo(y.PriceAfterDiscount);
            }
        }
    }
}
