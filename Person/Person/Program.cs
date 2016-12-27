using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ivan = new Person("Ivan", "Sraka", 187, 15, "male", true);

            Person galya = new Person("Galya", "Sraka");

            Person traktorina = new Person("Traktorina", "Sraka", 187);
        }
    }
}
