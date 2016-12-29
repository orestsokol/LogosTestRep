

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    class Vector
    {
        public double x;
        public double y;
        public double length;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }


        public Vector(double vX, double vY)
        {
            x = vX;
            y = vY;
            double decr = Math.Pow(x, 2) + Math.Pow(y, 2);
            length = Math.Sqrt(decr);
        }

        public void PrintInfo()
        {
            Console.WriteLine("X: " + x + " Y: " + y + " Length: " + Length);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            Vector[] vec = new Vector[10];
            Console.WriteLine("Please enter x and y ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("X:");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Y:");
                y = int.Parse(Console.ReadLine());
                vec[i] = new Vector(x, y);
            }

            for (int i = 0; i < 10; i++)
            {
                vec[i].PrintInfo();
            }
            Console.WriteLine("Searching for biger then 5 cm");
            bool bigerThenFive = false; 
            for (int i = 0; i < 10; i++)
            {
                if (vec[i].length > 5)
                {
                    vec[i].PrintInfo();
                    bigerThenFive = true;
                }
            }

            if (!bigerThenFive)
                Console.WriteLine("There are no vector biger 5 sm");


        }
    }
}