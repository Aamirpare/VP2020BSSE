using System;

namespace ClassesAndProperties.Classes
{
    public enum StudentGrades
    {
        Standard, Intermdiate, Advanced
    }
    public class Delegates
    {
        //Simple delegate without params
        public delegate void SimplePrintDel();
        
        //Delegate using simple parameters 
        public delegate void PrintDelegate(string message);

        //Delegate using complex paramerters
        public delegate void PrintGrades(StudentGrades grade);
        
        //Simple delegate that returns a value
        public delegate int SumDel(int a, int b);
        
        //C# provided paramless delegate that return no value 
        public static Action ActionDel;

        //C# provided with parameters delegate that return no value 
        public static Action<string> ActionDel2;
       
        //C# provided delegate that returns a value
        public static Func<int, int, int> FuncDel;

        public static void Print()
        {
            Console.WriteLine("Simple print without param");
        }
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Print2(string msg)
        {
            Console.WriteLine(msg + " 2 another messesage");
        }

        public static void Print3(string msg)
        {
            Console.WriteLine(msg + " 3 another messesage");
        }


        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static void ShowGrades(StudentGrades grade)
        {
            if(grade == StudentGrades.Advanced)
            {
                Console.WriteLine("The grade is advanced");
            }
            else if(grade == StudentGrades.Intermdiate)
            {
                Console.WriteLine("The grade is intermediate");
            }
        }
        public static void RunDemo()
        {
            //Executing a Print function using delegate
            SimplePrintDel spd = Print;
            spd.Invoke();

            //Executing a parameteric function using delegate
            PrintDelegate pd = Print;
            string msg = "This is another way of calling parametric delegate";
            pd.Invoke(msg);

            //Executing a complex parametric function using delegate
            PrintGrades pgd = ShowGrades;
            pgd.Invoke(StudentGrades.Intermdiate);
            pgd.Invoke(StudentGrades.Advanced);
            pgd.Invoke(StudentGrades.Standard);

            //Multicasting Delegates
            pd += Print2;
            pd += Print3;

            pd.Invoke("Multi-Casting....");

            //C# delegates
            ActionDel = Print;
            ActionDel2 = Print;
            ActionDel();
            ActionDel2("Action Del 2");

            //Retrun value delegate
            SumDel sum = Sum;
            var rv = sum.Invoke(10, 400);

            Console.WriteLine("Value : " + rv);

            FuncDel = Sum;
            rv = FuncDel.Invoke(103, 500);
            Console.WriteLine("Value : " + rv);

            Console.ReadKey();
        }
    }
}
