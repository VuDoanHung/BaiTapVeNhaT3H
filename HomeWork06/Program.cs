using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06
{
    internal class Program
    {
        static GenericClass<Student> genericStudent;
        static CollectionClass<int,Student> collectionStudent;

        static void Main(string[] args)
        {
             genericStudent = new GenericClass<Student>();
             collectionStudent = new CollectionClass<int,Student>();
        
            while (true)
            {
                Console.WriteLine("Choose Function:(1:Add Student;2:Delete Student, 3: Change Propertes Student, 4:Show List Student, 5:Exit Application, 6:AddCollection, 7.GetCollection)");
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
                        AddStudent();
                        Console.WriteLine("Add student Successful!");
                        Console.WriteLine("----------------------------------------------");
                         break;
                    case (int)Funtion.Delete:
                        RemoveStudent(); break;
                    case (int)Funtion.Change:
                        ChangePropStudent(); break;
                    case (int)Funtion.Show:
                        ShowList();
                         break;
                    case (int)Funtion.AddCollection:
                        AddCollection();
                        break;
                    case (int)Funtion.GetCollection:
                        GetCollection();
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

        static void AddStudent()
        {
            Student student = new Student();
            Console.WriteLine("Please input information of Student:");
            Console.WriteLine("---------------------------------");
            while (true)
            {
                checkID:
                Console.WriteLine("ID Student:");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int Id);
               
                if (CheckinputCondition && Id >= 1 )
                {
                    foreach (var item in genericStudent.FindAll())
                    { 
                        if(item.Id == Id)
                        {
                            Console.WriteLine("Id Exist!Please Type Again!");
                            Console.WriteLine("---------------------------------");
                            goto checkID;
                        }
                       
                    }
                    student.Id = Id;
                    break;
                }
                else
                {
                    Console.WriteLine("Input Wrong!Please Type Again!");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

            }
            Console.WriteLine("Name Of Student:");
            student.Name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Age Of Student:");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int age);
                if (CheckinputCondition && age > 18)
                {
                    student.Age = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Input Wrong!Please Type Again!");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

            }
            genericStudent.Add(student);
        }
        static void RemoveStudent()
        {
            
            while (true)
            {
                Console.WriteLine("ID Student:");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int Id);
                if (CheckinputCondition && Id >= 1)
                {
                   
                    foreach(var item in genericStudent.FindAll())
                    {
                        if (item.Id == Id) 
                        {
                            Console.WriteLine($"Delete Success Student : ID.{item.Id}--Name.{item.Name}--Age.{item.Age} ");
                            Console.WriteLine("---------------------------------");
                            genericStudent.Remove(item);
                        }
                    }
                    Console.WriteLine("Have no ID in list Student");
                    Console.WriteLine("---------------------------------");
                    
                }
                else
                {
                    Console.WriteLine("Input Wrong!Please Type Again!");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

            }
        }
        static void ChangePropStudent()
        {
            while (true)
            {
                Student student = new Student();
                Console.WriteLine("ID Student:");
                List<Student> lstStudent = genericStudent.FindAll();
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int Id);
                if (CheckinputCondition && Id >= 1)
                {

                   for(int i = 0; i < lstStudent.Count; i++)
                    {
                        if (lstStudent[i].Id == Id)
                        {
                            Console.WriteLine("Change Name Of Student:");
                            student.Name = Console.ReadLine();

                            while (true)
                            {
                                Console.WriteLine("Change Age Of Student:");
                                 CheckinputCondition = int.TryParse(Console.ReadLine(), out int age);
                                if (CheckinputCondition && age > 18)
                                {
                                    student.Age = age;
                                    Console.WriteLine($"Change Success Student's Properties : ID.{student.Id}--Name.{student.Name}--Age.{student.Age} ");
                                    Console.WriteLine("---------------------------------");
                                    genericStudent.ChangeProperty(i, student);
                                }
                                else
                                {
                                    Console.WriteLine("Input Wrong!Please Type Again!");
                                    Console.WriteLine("---------------------------------");
                                    continue;
                                }

                            }
                           
                        }
                    }
                    Console.WriteLine("Have no ID in list Student");
                    Console.WriteLine("---------------------------------");
                }
                else
                {
                    Console.WriteLine("Input Wrong!Please Type Again!");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

            }
        }
        static void ShowList()
        {
            List<Student> lstStudent = genericStudent.FindAll();
           
                if (lstStudent.Count > 0)
                {
                    Console.WriteLine("Student in ListStudent:");
                    foreach (var student in lstStudent)
                    {

                        Console.WriteLine($"ID: {student.Id}\nName Student: {student.Name}\nAge Student:{student.Age}");
                        Console.WriteLine("-----------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Have no any Student in ListStudent");
                    Console.WriteLine("---------------------------------------------------");
                }

            
        }

        static void AddCollection()
        {
            Student student = new Student();
            int key;
            Console.WriteLine("Please input information of Student:");
            Console.WriteLine("---------------------------------");
            while (true)
            {
            checkID:
                Console.WriteLine("ID Student:");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int Id);

                if (CheckinputCondition && Id >= 1)
                {
                    foreach (var item in genericStudent.FindAll())
                    {
                        if (item.Id == Id)
                        {
                            Console.WriteLine("Id Exist!Please Type Again!");
                            Console.WriteLine("---------------------------------");
                            goto checkID;
                        }

                    }
                    student.Id = Id;
                    key = Id;
                    break;
                }
                else
                {
                    Console.WriteLine("Input Wrong!Please Type Again!");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

            }
            Console.WriteLine("Name Of Student:");
            student.Name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Age Of Student:");
                var CheckinputCondition = int.TryParse(Console.ReadLine(), out int age);
                if (CheckinputCondition && age > 18)
                {
                    student.Age = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Input Wrong!Please Type Again!");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

            }
         
            collectionStudent.AddItem(key,student);
        }
        static void GetCollection()
        {
            Dictionary<int,Student> lstStudent = collectionStudent.GetItem();

            if (lstStudent.Count > 0)
            {
                Console.WriteLine("Student in ListStudent:");
                foreach (var student in lstStudent)
                {

                    Console.WriteLine($"ID: {student.Value.Id}\nName Student: {student.Value.Name}\nAge Student:{student.Value.Age}");
                    Console.WriteLine("-----------------------------");
                }
            }
            else
            {
                Console.WriteLine("Have no any Student in ListStudent");
                Console.WriteLine("---------------------------------------------------");
            }


        }

    }
    public enum Funtion
    {
        Add = 1,
        Delete,
        Change,
        Show,
        Exit,
        AddCollection,
        GetCollection,
    }
}
