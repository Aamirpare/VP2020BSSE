using System;

namespace ClassesAndProperties.Variance
{
    public class Employee
    {
        public int EmployeeID { get; set; }

    }

    public class Faculty : Employee
    {
        public string Title { get; set; }
    }

    public static class VarianceDemo
    {
        public static void RunDemo()
        {
            void Example()
            {
                Action<Faculty> fac;
                Action<Employee> emp = x => 
                { 
                    x.EmployeeID = 90;
                    Console.WriteLine(x.EmployeeID); 
                };
                
                //Contra-Variance
                fac = emp;
                fac(new Faculty());
            }

            Example();

            Console.ReadKey();
        }
    }
}
