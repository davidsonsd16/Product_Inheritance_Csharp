using System;
using Product_Inheritance_Csharp.Entities;

namespace Product_Inheritance_Csharp {
    class Program {
        static void Main(string[] args) {

            Product product = new Product("TV", 1200.00);
            Console.WriteLine(product.PriceTag());
        }
    }
}
