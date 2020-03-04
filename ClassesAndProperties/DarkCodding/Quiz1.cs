using System;

namespace ClassesAndProperties.DarkCodding
{
    // C# program to illustrate the operator overloading 
    public class Calculator
    {
        public int number1, number2;
        public Calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }

        // Function to perform addition operation  
        public static Calculator operator +(Calculator p1, Calculator p2)
        {
            var number1 = p1.number1 + p2.number1;
            var number2 = p1.number2 + p1.number2;
            return new Calculator(number1, number2);
        }

        public static Calculator operator ++(Calculator p1)
        {
            p1.number1++;
            p1.number2++;
            return p1;
        }

        // Function to print the numbers 
        public void Print()
        {
            Console.WriteLine("Number1 = " + number1);
            Console.WriteLine("Number2 = " + number2);
        }
    }

    public static class EntryPoint
    {
        // Driver Code 
        public static void Execute()
        {
            // using overloaded - operator with the class object 
            Calculator c1 = new Calculator(15, 25);
            Calculator c2 = new Calculator(20, 20);
            //Sum c1 and c2 objects into c3
            var c3 = c1 + c2;

            // To display the result 
            c3.Print();
            //Increment c3
            c3++;
            c3.Print();
        }
    }
}

