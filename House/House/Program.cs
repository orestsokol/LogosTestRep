using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            House newHouse = new House(3, 30000, 40);
            newHouse.PrintInfo();
        }
    }
}
