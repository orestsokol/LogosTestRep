using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter string to output");
            string str = Console.ReadLine();
            Output(str, n, m, k);
        }

        static void Output(string str, int n, int m, int k)
        {
            if ((n + m + k) > 20)
                Console.WriteLine(str);
            else
                Console.WriteLine("Sorry but sum = {0}", n + m + k);
           

        }
    }
}
