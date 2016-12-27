using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size of array with products");

            int arrSize = int.Parse(Console.ReadLine());
            Product[] arrWithProducts = new Product[arrSize];

            Console.WriteLine("Please fill array");

            arrWithProducts = FillArray(arrWithProducts);

            foreach (Product prod in arrWithProducts)
            {
                if (prod.category == "For Kids")
                    prod.PrintGeneralInfo();

            }
        }

        static Product[] FillArray(Product[] a)
        {
            int arrSize = a.Length;
            
            string name;
            string category;
            float price;

            for(int i=0; i < arrSize;i++)
            {
                
                Console.WriteLine("Please enter name:");
                name = Console.ReadLine();

                Console.WriteLine("Please enter category:");
                category = Console.ReadLine();

                Console.WriteLine("Please enter price:");
                price = float.Parse(Console.ReadLine());

                Product prod = new Product(name, category, price);
                a[i] = prod;
            }

            return a;
        }
        
    }
}
