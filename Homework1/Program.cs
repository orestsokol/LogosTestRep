using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your mark of History subject:");
            int subjHistory = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your mark of Math subject:");
            int subjMath = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your mark of Physo subject:");
            int subjPhyso = int.Parse(Console.ReadLine());

            Console.WriteLine(" The avarage value of your subject is : {0}", (subjHistory + subjMath + subjPhyso)/3 );
        }
    }
}
