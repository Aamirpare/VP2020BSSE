using System;

namespace ClassesAndProperties
{
    //The pure java style
    class A
    {
        private string title;
        private int price;



        public void setTitle(string t)
        {
            title = t;
        }


        public string getTitle()
        {
            return title;
        }

        //..................you know better than me...
        public void Print()
        {
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Price : " + price);
        }

        public A()
        {
            Console.WriteLine("Object created....");
        }
        public A(string t, int p)
        {
            title = t;
            price = p;
        }
    }

    //C# style
    class B
    {
        //Auto-Implemented Properties
        //private int Price { get; set; }
        //private string Title { get; set; }
        int _Price;
        string _Title;

        decimal Age = 10;
        //Fully Implemented Property
        private int Price {
            get 
            {
                return _Price;
            }
            set
            {
                _Price = value;
            }
        }
        private string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                if (Age < 18)
                {
                    _Title = value;
                }
            }
        }
            

        public B()
        {
            Console.WriteLine("Object constructed...");
        }

        public B(string t, int p)
        {
            Price = p + 10;
            Title = "class b's " + t;
        }

        public void Print()
        {
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Price : " + Price);
        }
    }
    class SimpleProperties
    {
        static void RunDemo()
        {
            //A obj1 = new A();
            //obj1.Print();

            A obj2 = new A("Mobil App for Dogs", 300);
            
            obj2.Print();

            B obj3 = new B("Mobil App for Cats", 301);
            
            obj3.Print();

            Console.ReadKey();
        }
    }
}
