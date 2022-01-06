using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya Elması";
            

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır Karpuzu";
            

            Product[] products = new Product[] { product1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine(product.Id + " "+ product.Name + " "  +product.Price + " " + product.Explanation);
            }
            Console.WriteLine("FOREACH FINISH");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id + " " +products[i].Name + " " + products[i].Price + " " + products[i].Explanation);
            }
            Console.WriteLine("*/*/*/*/*/*/*/*/");
            foreach (var prods in products)
            {
                Console.WriteLine(prods.Id);
                Console.WriteLine(prods.Name);
                Console.WriteLine(prods.Price);
                Console.WriteLine(prods.Explanation);
                Console.WriteLine("**************************");
            }
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id);
                Console.WriteLine(products[i].Name);
                Console.WriteLine(products[i].Price);
                Console.WriteLine(products[i].Explanation);
                Console.WriteLine("***************************");
            }

            Console.WriteLine("-------------------Methods------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

        }
    }
}