using System;

namespace ClassesAndProperties.Overloading
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public void Print()
        {
            Console.WriteLine("ProductID : " + ProductId);
            Console.WriteLine("Title : " + Title);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine();
        }

        public static Product operator +(Product a, Product b)
        {
            var p = new Product();
            p.ProductId = a.ProductId + b.ProductId;
            p.Price = a.Price + b.Price;
            p.Title = $"{a.Title} - {b.Title}";
            return p;
        }

        public static Product operator /(Product a, Product b)
        {
            var p = new Product();
            p.ProductId = a.ProductId / b.ProductId;
            p.Price = a.Price / b.Price;
            p.Title = $"{a.Title} - {b.Title}";
            return p;
        }
    }


    public class OverLoadingDemo
    {
        public static void RunDemo()
        {
            var p1 = new Product() { ProductId = 100, Title = "Peaches", Price = 210M };
            p1.Print();
            var p2 = new Product() { ProductId = 101, Title = "Mangoes", Price = 310M };
            p2.Print();

            var x = p1 + p2;
            var b = p1 / p2;
            x.Print();

            Console.ReadKey();
        }
    }
}
