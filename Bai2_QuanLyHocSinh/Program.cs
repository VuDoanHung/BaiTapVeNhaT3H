using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_QuanLyHocSinh
{
    internal class Program
    {
        static List<Student> _student;
        static void Main(string[] args)
        {
            _student = new List<Student>();

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
                    case (int)FunctionApp.Search:
                        SearchStudent(); break;
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
            var student = new Student();
            Console.WriteLine("Please input information of Student:");
            Console.WriteLine("---------------------------------");
         
                Console.WriteLine("Name Of Student:");
                student.Name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Age Of Student:");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int age);
                if (CheckinputCondition && age>1)
                {
                    student.Age = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Input Wrong!Please Type Again!");
                    Console.WriteLine("---------------------------------");
                    continue ;
                }
               
            }
            while (true)
            {
                Console.WriteLine("Point Average Of Student:");
                var CheckinputCondition = float.TryParse(Console.ReadLine(), out float pointAvg);
                if (CheckinputCondition && pointAvg >=0)
                {
                    student.PointAverage = pointAvg;
                    break;
                }
                else
                {
                    Console.WriteLine("Input Wrong!Please Type Again!");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

            }
            _student.Add(student);
            Console.WriteLine("Add student Successful!");
            Console.WriteLine("----------------------------------------------");


        }
        private static void ShowListStudent()
        {
            if (_student.Count > 0)
            {
                Console.WriteLine("Students in ListStudent:");
                int count = 1;
                foreach (var student in _student)
                {

                    Console.WriteLine($"{count}.Name: {student.Name}\nAge: {student.Age}\nPoint Average: {student.PointAverage}");
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
                    if (_student.Count > 0)
                    {
                        Console.WriteLine("Student in ListStudent:");
                        int count = 1;
                        foreach (var student in _student)
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

        //private static bool CheckBookDuplicate(Book BookCheck)
        //{
        //    if (_books.Count > 0)
        //    {
        //        foreach (var book in _books)
        //        {
        //            if (BookCheck.Tittle == book.Tittle && BookCheck.Author == book.Author && BookCheck.YearOfPublication == book.YearOfPublication)
        //            {
        //                Console.WriteLine("Book is exist!Please Add Book Again!");
        //                Console.WriteLine("-----------------------------------");
        //                return false;
        //            }

        //        }

        //        return true;
        //    }
        //    else { return false; }

        //}

    }
}
