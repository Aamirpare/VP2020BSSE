using System;

namespace ClassesAndProperties.Properties
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
    }
    public class Student
    {
        //Complex Properties
        public Course[] Courses { get; set; }
        //Simple properties
        public int StudentId { get; set; }
        public string FullName { get; set; }

        public void Print()
        {
            Console.WriteLine("".PadLeft(50, '#'));

            Console.WriteLine("Studnet Information");

            Console.WriteLine(StudentId + "   " + FullName);

            DisplayCourses();
        }

        public void DisplayCourses()
        {
            foreach (var c in Courses)
            {
                Console.WriteLine("".PadLeft(8) + c.Code + "  " + c.Title + "  " + c.Credits);
            }
            //for (int i = 0; i < Courses.Length; i++)
            //{
            //   Console.WriteLine("".PadLeft(8) + Courses[i].Code + "  " + Courses[i].Title + "  " + Courses[i].Credits);
            //}
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("".PadLeft(8) + Courses[i].Code + "  " + Courses[i].Title + "  " + Courses[i].Credits);
            //    i++;
            //}
            //while (i < Courses.Length);

            //while (i < Courses.Length)
            //{
            //    Console.WriteLine("".PadLeft(8) + Courses[i].Code + "  " + Courses[i].Title + "  " + Courses[i].Credits);
            //    i++;
            //}
        }
    }
    public class MoreProperties
    {
        public static void RunPropertiesDemo()
        {
            //Course[] courses = new Course[]
            //{
            //    new Course() { Code="CSC234", Title="System Programming"},
            //    new Course() { Code="CSC232", Title="Visual Programming"},
            //};

            Course[] courses = new Course[2];
            Course c1 = new Course() { Code = "CSC234", Title = "System Programming", Credits = 3 };
            Course c2 = new Course() { Code = "CSC232", Title = "Visual Programming", Credits = 4 };

            courses[0] = c1;
            courses[1] = c2;


            Student s1 = new Student()
            {
                StudentId = 1,
                FullName = "Samreena Ahamed",
                Courses = courses
            };
            s1.Print();
            //s1.DisplayCourseInfo();


            Student s2 = new Student()
            {
                StudentId = 2,
                FullName = "Sunil Mehta",
                Courses = courses
            };

            s2.Print();
            //s2.DisplayCourseInfo();


            //int[] numbers;
            //numbers = new int[4];
            //numbers[0] = 10;
            //numbers[1] = 100;
            //numbers[2] = 1000;
            //numbers[3] = 10000;

            //int[] numbers = { 100, 1000, 10000, 100 };

            int[] numbers = new int[10];
            numbers[9] = 343;
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            string[] names = { "Mango", "Apple", "Peach", "Appricot" };

            foreach (var n in names)
            {

                Console.WriteLine(n);
            }

            Console.ReadKey();
        }

    }
}
