namespace ClassesAndProperties.Classes
{
    public partial class Product
    {
        public int ProductID { get; set; }
    }


    public static class PartialDemo
    {
        public static void RunDemo(string[] args)
        {
            Product p = new Product
            {
                ProductID = 8,
                Name = "Shumaila Rana",
                Price = 4.59M
            };

            System.Console.ReadKey();
        }
    }

}
