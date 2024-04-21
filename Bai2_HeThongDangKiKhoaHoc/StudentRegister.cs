using CommonLibs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLib = CommonLibs.CommonLibs;


namespace Bai2_HeThongDangKiKhoaHoc
{
    public class StudentRegister : IStudentRegister
    {
        public Student Student { get; set; }=new Student();
        public Course Course { get; set; }=new Course();
        public DateTime DateRegister { get; set; }
        public float Discount { get; set; }
        public float TuitionHavetoPay { get; set; }
        public StudentRegister RegisterCourse(List<Course> lstCourse)
        {
            StudentRegister studentRegister = new StudentRegister();
            while (true)
            {
                Console.WriteLine("Input Name Student");
                string nameStudent = Console.ReadLine();
                if (!CommonLib.CheckName(nameStudent))
                {
                    Console.WriteLine("Wrong Input Name!");
                    Console.WriteLine("-----------------");
                    continue;
                }

                CultureInfo provider = CultureInfo.InvariantCulture;

                string format = "dd-MM-yyyy";
                Console.WriteLine("Date Of Birth:dd-MM-yyyy");
                var dateTimeCheck = DateTime.TryParseExact(Console.ReadLine(), format, provider, DateTimeStyles.None, out DateTime dateOfBirth);
                if (!dateTimeCheck)
                {
                    Console.WriteLine("Type Wrong Format DateTime!");
                    Console.WriteLine("Please Input DateTime Again!");
                    Console.WriteLine("-----------------------------");
                    continue;
                }

                Console.WriteLine("Date Register:dd-MM-yyyy");
                var dateRegisterCheck = DateTime.TryParseExact(Console.ReadLine(), format, provider, DateTimeStyles.None, out DateTime dateRegister);
                if (!dateRegisterCheck)
                {
                    Console.WriteLine("Type Wrong Format DateTime!");
                    Console.WriteLine("Please Input DateTime Again!");
                    Console.WriteLine("-----------------------------");
                    continue;
                }
                //-----------------------------------------------------------------------
                Console.WriteLine("Choose Course:");
                int i = 1;
                foreach (var course in lstCourse)
                {
                    Console.WriteLine($"{i}-{course.Name}");
                }
                string nameCourse = Console.ReadLine();
                if (!CommonLib.CheckName(nameCourse))
                {

                    Console.WriteLine("Wrong Input Name!");
                    Console.WriteLine("-----------------");
                    continue;
                }
                else
                {
                    foreach (var course in lstCourse)
                    {
                        if (course.Name.ToUpper() == nameCourse.ToUpper())
                        {
                            studentRegister.Course.Name = nameCourse;
                            studentRegister.Course.Description = course.Description;
                            studentRegister.Course.OpeningDay = course.OpeningDay;
                            studentRegister.Course.Tuition = course.Tuition;
                        }

                    }
                }
                studentRegister.Student.FullName = nameStudent;
                studentRegister.Student.DateOfBirth = dateOfBirth;
                studentRegister.DateRegister = dateRegister;
                studentRegister.Discount = CheckDiscount(dateRegister, studentRegister.Course.OpeningDay);
                studentRegister.TuitionHavetoPay = studentRegister.Course.Tuition - (studentRegister.Course.Tuition*studentRegister.Discount);
                return studentRegister;
            }

        }
        public float CheckDiscount (DateTime dateRegister, DateTime dateCourse)
        {
            var dayCheck = (dateCourse - dateRegister).TotalDays;
            if (dayCheck>10 && dayCheck<=30)
            {
                return (float)0.1;
            }else if(dayCheck> 30)
            {
                return (float)0.15;
            }
            else { return 0; }
        }
       
    }
   
}
