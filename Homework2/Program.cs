using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radious of circule");
            int radious = int.Parse(Console.ReadLine());
            double circuit = 2 * Math.PI * radious; 

            Console.WriteLine("The circuit is: " + circuit);
        }
    }
}
