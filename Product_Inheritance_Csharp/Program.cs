using System;
using Product_Inheritance_Csharp.Entities;

namespace Product_Inheritance_Csharp {
    class Program {
        static void Main(string[] args) {

            Product product = new Product("TV", 1200.00);
            Console.WriteLine(product.PriceTag());

            Product product1 = new ImportedProduct("Notebook", 260.00, 20.00);
            Console.WriteLine(product1.PriceTag());

            Product product2 = new UsedProduct("Iphone", 400.00, DateTime.Parse("15/03/2017"));
            Console.WriteLine(product2.PriceTag());
        }
    }
}
