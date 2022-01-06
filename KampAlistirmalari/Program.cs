using System;

namespace KampAlistirmalari
{

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProdId = 1;
            product1.ProdName = "Elma";
            product1.ProdPrice = 5;

            Product product2 = new Product();
            product2.ProdId = 2;
            product2.ProdName = "armut";
            product2.ProdPrice = 6;

            Console.WriteLine("**Ürün Listeleme**");
            Product[] products = new Product[] {product1,product2};
            foreach (var product in products)
            {
                Console.WriteLine(product.ProdId+" "+product.ProdName+" "+product.ProdPrice);
            }
        }
    }
    
    class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdPrice { get; set; }
    }
}