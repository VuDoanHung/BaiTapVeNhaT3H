using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLib = CommonLibs.CommonLibs;

namespace Bai2_HeThongDangKiKhoaHoc
{
    internal class Program
    {
        static List<Course> lstCourse;
        static List<StudentRegister> lstStudentRegister;
        static void Main(string[] args)
        {
           lstCourse = new List<Course>();
            lstStudentRegister = new List<StudentRegister>();
            while (true)
            {
                Console.WriteLine("Choose Function:(1:Add Course,2: Student Register,3:Show List,4:Exit Application");
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
                        AddCourse();
                        Console.WriteLine("Add Course Successful!");
                        Console.WriteLine("----------------------------------------------");
                        break;
                    case (int)Funtion.Register:
                        RegisterCourse(lstCourse);
                        break;
                    case (int)Funtion.ShowList:
                        ShowListStudentRegister(lstStudentRegister);break;
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
        private static void AddCourse()
        {
           
            while (true)
            {
                Console.WriteLine("Input Name Course");
                string nameProduct = Console.ReadLine();
                if (!CommonLib.CheckName(nameProduct))
                {
                    Console.WriteLine("Wrong Input Name!");
                    Console.WriteLine("-----------------");
                    continue;
                }
                Console.WriteLine("Input Description Course");
                string description = Console.ReadLine();
                if (!CommonLib.CheckName(description))
                {
                    Console.WriteLine("Wrong Input Description!");
                    Console.WriteLine("-----------------");
                    continue;
                }
                Console.WriteLine("Input Tuition Course");
                var tuitionTemp =float.TryParse(Console.ReadLine(),out float tuition); 

                if (!tuitionTemp && tuition<=0)
                {
                    Console.WriteLine("Wrong Input Tuition!");
                    Console.WriteLine("-----------------");
                    continue;
                }
                CultureInfo provider = CultureInfo.InvariantCulture;

                string format = "dd-MM-yyyy";
                Console.WriteLine("Opening Day:dd-MM-yyyy");
                var dateTimeCheck = DateTime.TryParseExact(Console.ReadLine(), format, provider, DateTimeStyles.None, out DateTime openingDay);
                if (!dateTimeCheck)
                {
                    Console.WriteLine("Type Wrong Format DateTime!");
                    Console.WriteLine("Please Input DateTime Again!");
                    Console.WriteLine("-----------------------------");
                    continue;
                }              
                Course course = new Course() { Name = nameProduct, Description = description, Tuition = tuition, OpeningDay = openingDay };

               lstCourse.Add(course);
                break;
            }
        }
        private static void RegisterCourse(List<Course> lstCourse)
        {
            StudentRegister studenRegister = new StudentRegister();

            lstStudentRegister.Add(studenRegister.RegisterCourse(lstCourse));
        }
        private static void ShowListStudentRegister(List<StudentRegister> lstStudentRegister)
        {
            var sortlstRegister = lstStudentRegister.OrderByDescending(x => x.Discount);
            Console.WriteLine("List Student Register");
            foreach(StudentRegister studentRegister in sortlstRegister)
            {
                Console.WriteLine($"Name Student:{studentRegister.Student.FullName}, Date Of Birth:{studentRegister.Student.DateOfBirth}, Date Register:{studentRegister.DateRegister.ToString("dd-MM-yyyy")}, Tuition:{studentRegister.Course.Tuition}, Tuition After Discount{studentRegister.TuitionHavetoPay}\n");
            }
        }
    }
    public enum Funtion
    {
        Add = 1,
        Register ,
        ShowList,
        Exit
    }

}
