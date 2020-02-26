using System;
using System.Collections.Generic;

namespace ClassesAndProperties.Collections
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
    public class ShoppingCart
    {
        private List<Product> Products { get; set; }
        public ShoppingCart()
        {
            Products = new List<Product>();
        }
        public void Add(Product p)
        {
            Products.Add(p);
        }

        public bool AddRange(List<Product> products)
        {
            Products.AddRange(products);
            return true;
        }

        public void Remove(Product p)
        {
            Products.Remove(p);
        }
        public void Print()
        {
            Console.WriteLine("Showing Invoice");
            foreach (var p in Products)
            {
                Console.WriteLine("ProductID : " + p.ProductId);
                Console.WriteLine("Title : " + p.Title);
                Console.WriteLine("Price : " + p.Price);
            }

            Console.WriteLine("End of Invoice...");
        }
    }


    public class MyCollections<U>
    {
        //List<Product> products = new List<Product>();
        public void Print<T>(T param)
        {
            Console.WriteLine(param);
        }

    }


    public static class CollectionsDemo
    {
        public static void RunDemo()
        {
            ShoppingCart cart = new ShoppingCart();
            var p1 = new Product() { ProductId = 100, Title = "Peaches", Price = 210M };
            cart.Add(p1);

            var p2 = new Product() { ProductId = 101, Title = "Mangoes", Price = 310M };
            cart.Add(p2);
           //==============================================
            List<Product> listProducts = new List<Product> {
               new Product() { ProductId = 103, Title = "Peaches 3", Price = 210M },
               new Product() { ProductId = 104, Title = "Peaches 4", Price = 210M },
               new Product() { ProductId = 105, Title = "Peaches  5", Price = 210M },
               new Product() { ProductId = 106, Title = "Peaches 6", Price = 210M },
            };
            cart.AddRange(listProducts);

            cart.Remove(listProducts[1]);
            cart.Print();
            
            Console.ReadKey();
        }
        public static void RunDemo1()
        {
            Product p = new Product { ProductId = 100 };
            MyCollections<Product> mc = new MyCollections<Product>();
            mc.Print<int>(90);
            mc.Print<string>("This is a generic parameter");
            mc.Print<decimal>(899.99M);
            mc.Print<float>(899.99f);
            mc.Print<Product>(p);
            Console.ReadKey();
        }
    }
}
