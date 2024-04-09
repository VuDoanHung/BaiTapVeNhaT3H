using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_QlyNhanVien
{
    internal class Program
    {
        static List<Staff> _lstStaff;
        static void Main(string[] args)
        {
            _lstStaff = new List<Staff>();

            while (true)
            {
                Console.WriteLine("Choose Function:(1:Add Student;2:Show List Student, 3: Search Student, 4:Exit Application)");
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
                        AddStudent(); break;
                    case (int)FunctionApp.Show:
                        ShowListStudent(); break;
                    case (int)FunctionApp.Sort:
                        SearchStudent(); break;
                    case (int)FunctionApp.SortCondition: break;

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
        private static void AddStudent()
        {
            var staff = new Staff();
            Console.WriteLine("Please input information of Student:");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Name Of Student:");
            staff.Name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Age Of Student:");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int age);
                if (CheckinputCondition && age > 1)
                {
                    staff.Age = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Input Wrong!Please Type Again!");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

            }
            while (true)
            {
                Console.WriteLine("Point Average Of Student:");
                var CheckinputCondition = float.TryParse(Console.ReadLine(), out float pointAvg);
                if (CheckinputCondition && pointAvg >= 0)
                {
                    staff.PointAverage = pointAvg;
                    break;
                }
                else
                {
                    Console.WriteLine("Input Wrong!Please Type Again!");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

            }
            _lstStaff.Add(staff);
            Console.WriteLine("Add student Successful!");
            Console.WriteLine("----------------------------------------------");


        }
        private static void ShowListStudent()
        {
            if (_lstStaff.Count > 0)
            {
                Console.WriteLine("Students in ListStudent:");
                int count = 1;
                foreach (var staff in _lstStaff)
                {

                    Console.WriteLine($"{count}.Name: {staff.Name}\nAge: {staff.Age}\nPoint Average: {staff.PointAverage}");
                    Console.WriteLine("-----------------------------");
                    count++;
                }

            }
            else
            {
                Console.WriteLine("Have no any student in ListStudent");
                Console.WriteLine("---------------------------------------------------");
            }

        }
        private static void SearchStudent()
        {
            while (true)
            {
                Console.WriteLine("Input Name student you want to find:");
                string nameSearch = Console.ReadLine();
                if (!string.IsNullOrEmpty(nameSearch))
                {
                    if (_lstStaff.Count > 0)
                    {
                        Console.WriteLine("Student in ListStudent:");
                        int count = 1;
                        foreach (var student in _lstStaff)
                        {
                            if (student.Name.ToUpper() == nameSearch.ToUpper())
                            {
                                Console.WriteLine($"Name: {student.Name}\nAge: {student.Age}\nPoint Average: {student.PointAverage}");
                                Console.WriteLine("-----------------------------");
                            }


                        }
                    }
                    else
                    {
                        Console.WriteLine("Have no any student in ListStudent");
                        Console.WriteLine("---------------------------------------------------");
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Tittle cannot be empty!");
                    Console.WriteLine("-----------------------------");
                    continue;
                }

            }


        }
    }
}
