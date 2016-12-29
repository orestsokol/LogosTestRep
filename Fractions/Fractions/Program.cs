using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction frac = new Fraction();
            Console.WriteLine(frac.Add(1.5f, 1.5f));
            Console.WriteLine(frac.Divide(1.5f, 1.5f));
            Console.WriteLine(frac.Compare(1.5f, 1.5f));
            Console.WriteLine(frac.Multiply(1.5f, 1.5f));
        }
    }
}
