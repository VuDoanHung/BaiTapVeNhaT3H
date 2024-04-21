using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Abstract
{
    internal class Program
    {
        static List<Staff> staffs;
        static void Main(string[] args)
        {
            staffs = new List<Staff>();
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Choose Function:(1:Add Staff;2:Show Salary,4:Exit Application)");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int funtion);
                if (!CheckinputCondition)
                {
                    Console.WriteLine("You choose wrong Format of Function!");
                    Console.WriteLine("Please choose option again!");
                    continue;
                }
                switch (funtion)
                {
                    case (int)FunctionApp.Add:
                        AddStaff(); break;
                    case (int)FunctionApp.Show:
                        ShowSalary(); break;
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
        static void AddStaff()
        {
            while (true)
            {
                Console.WriteLine("Nhập số lượng nhân viên cần thêm:");
                bool checkConditionInput = int.TryParse(Console.ReadLine(), out int quantityStaff);
                if (checkConditionInput && quantityStaff > 0)
                {
                    
                    for(int i = 0; i < quantityStaff; i++)
                    {
                        Console.WriteLine($"Nhập thông tin nhân viên số:{i+1}");
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
        static void ShowSalary()
        {
            Console.WriteLine("Nhập lương nhân viên cơ bản:");
            var CheckinputCondition = float.TryParse(Console.ReadLine(), out float salaryBase);
            if(CheckinputCondition && salaryBase >= 0)
            {
                foreach(var staff in staffs)
                {
                    Console.WriteLine($"Lương của nhân viên {staff.Name} là : {staff.PayWage(salaryBase)} VNĐ");
                    Console.WriteLine("--------------------------------------------------------------------");
                      
                }
            }
        }
        static Staff CheckConditionAddStaff()
        {
            
            nhaplaiIdNhanVien:
                Console.WriteLine("Nhập Id nhân viên:");
                bool checkIdInput = int.TryParse(Console.ReadLine(), out int Id);
                if (checkIdInput && Id > 0)
                {
                   
                }else
                {
                    Console.WriteLine("Bạn nhập sai! Xin hãy nhập lại.");
                    Console.WriteLine("-------------------------------");
                    goto nhaplaiIdNhanVien; ;
                }

                Console.WriteLine("Nhập Tên nhân viên:");
                var Name = Console.ReadLine();
                nhaplaikieunhanvien:
                Console.WriteLine("Nhập kiểu nhân viên: 1-FULL TIME; 2-PART TIME; 3: INTERNSHIP");
                bool checkTypeInput = int.TryParse(Console.ReadLine(), out int typeStaff);
                if (checkIdInput && typeStaff > 0)
                {
                 switch(typeStaff)
                {
                    case (int)TypeStaff.FullTime:
                        var FulltimeStaff = new FullTimeEmployee();
                        FulltimeStaff.Name = Name;
                        FulltimeStaff.Id = Id;
                        return FulltimeStaff;
                    case (int)TypeStaff.Partime:
                        var PartTimeStaff = new PartimeEmployee();
                        PartTimeStaff.Name = Name;
                        PartTimeStaff.Id = Id;
                        return PartTimeStaff;
                    case (int)TypeStaff.Intern:
                        var InterShip = new Internship();
                        InterShip.Name = Name;
                        InterShip.Id = Id;
                        return InterShip;
                     default:
                        Console.WriteLine("Bạn nhập sai! Xin hãy nhập lại.");
                        Console.WriteLine("-------------------------------");
                        goto nhaplaikieunhanvien;
                }
                }
                else
                {
                Console.WriteLine("Bạn nhập sai! Xin hãy nhập lại.");
                Console.WriteLine("-------------------------------");
                goto nhaplaikieunhanvien;
            }
            
        }
        public enum FunctionApp
        {
            Add = 1,
            Show,
            Exit,

        }
    }
}
