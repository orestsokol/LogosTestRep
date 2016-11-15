using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter first number:");
            int i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            int i2 = int.Parse(Console.ReadLine());
            int sum = i1 + i2;
            Console.WriteLine("Sum is :" + sum);
            int rizn = i1 - i2;
            Console.WriteLine("Rinutsya is :" + rizn);
            int dob = i1*i2;
            Console.WriteLine("Dobutok is :" + dob);

            float chas = i1 / (float)i2;
            Console.WriteLine("Chastko is :" + chas);
           
        }
    }
}
