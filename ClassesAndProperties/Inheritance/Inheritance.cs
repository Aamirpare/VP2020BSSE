using System;

namespace ClassesAndProperties.Inheritance
{
    //Base Class
    public class Car
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        
        //protected members are accessible from the same class and the child class 
        //protected decimal Price { get; set; }
        public decimal Price { get; set; }
        //private int EngineCapacity { get; set; }
        public int EngineCapacity { get; set; }

        public virtual void Print()
        {
            string content = $"Price : {Price}, Engine Power : {EngineCapacity}";
            Console.WriteLine(content);
        }
        public virtual void Print(string which)
        {
            Console.WriteLine("Overloading and overriding...");
        }
        public void Print(int id)
        {
            Console.WriteLine("One more print ....");
        }
        public Car(string which)
        {
            Console.WriteLine("Report Analysis");
        }

    }

    //Child class, means inheriting form base class
    class HondCity : Car
    {
        //public void Print()
        //{
        //    string content = $"Price : {Price}, Engine Power : {EngineCapacity}";
        //    Console.WriteLine(Price);
        //}
        public HondCity():base("print")
        {
            
        }
        public override void Print()
        {
            Console.WriteLine("I have killed...");
            base.Print();       
        }


    }

    class A
    {
        public A():this("sdfas")
        {

        }

        public A(string s)
        {

        }
    }

    class Toyota: Car
    {
        public Toyota(): this("sdaf")
        {

        }

        public Toyota(string xx): base("")
        {

        }
        //public void Print()
        //{
        //    string content = $"Price : {Price}, Engine Power : {EngineCapacity}";
        //    Console.WriteLine(content);
        //}
    }

    class InheritanceDemo
    {
        public static void RunInheritaceDemo()
        {
            HondCity c1 = new HondCity()
            {
                CarID = 5,
                Model = "2019",
                EngineCapacity = 1300,
                Price = 2300000
            };
            
            Toyota c2 = new Toyota()
            {
                CarID = 8,
                Model = "2019",
                EngineCapacity = 1500,
                Price = 2800300
            };

            c1.Print();
            c2.Print();
            c1.Print("");
            c2.Print(1);

            Console.ReadKey();
        }
    }
}
