using System;

namespace ClassesAndProperties
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
        //Auto-implemented complex properties
        public Course [] Courses { get; set; }

        //Auto-implemented simple properties
        public int StudentId { get; set; }
        public string FullName { get; set; }
        private string Message { get => "You are not allowed to access this resource."; }

        //Backing variable for Age property
        private int _Age;
        //Fully implemented property
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value >= 18)
                {
                    Console.WriteLine(Message);
                    Console.WriteLine("".PadRight(Message.Length, '='));
                }
                _Age = value;
            }
        }
        public void Print()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Id : " + StudentId);
            Console.WriteLine("Name : " + FullName);
            Console.WriteLine("Age : " + _Age);

            DisplayCourses();
        }

        public void DisplayCourses() 
        {
            Console.WriteLine("".PadLeft(5) + "Registered Courses");
            foreach (var c in Courses)
            {
                Console.WriteLine("".PadLeft(5) + c.Code + " " + c.Title);
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
    public class ComplexProperties
    {
        public static void RunDemo()
        {
            Course[] courses = new Course[] 
            { 
                new Course()
                { 
                    CourseId = 1,
                    Code = "CSC421",
                    Title = "System Programming",
                    Credits = 3
                },
                new Course()
                {
                    CourseId = 2,
                    Code = "CSC231",
                    Title = "Visual Programming",
                    Credits = 3
                }
            }; 

            Student s1 = new Student();
            s1.StudentId = 100;
            s1.FullName = "Sara Ali";
            s1.Age = 1;
            s1.Courses = courses;
            
            s1.Print();

            Student s2 = new Student()
            {
                StudentId = 101,
                FullName = "Aamir Pare",
                Age = 23,
                Courses = courses
            };

            s2.Print();

            Console.ReadKey();
        }
    }
}
