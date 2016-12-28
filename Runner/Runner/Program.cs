using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            string yourFathersName; 
            float time;
            int distance;
            Runner[] run = new Runner[3];

            for (int i = 0; i < run.Length; i++)
            {
                Console.WriteLine("Name");
                name = Console.ReadLine();
                Console.WriteLine("SurName");
                surname = Console.ReadLine();
                Console.WriteLine("Your Fathers Name");
                yourFathersName = Console.ReadLine();
                Console.WriteLine("Time");
                time = float.Parse(Console.ReadLine());
                Console.WriteLine("Distance");
                distance = int.Parse(Console.ReadLine());
                run[i] = new Runner(name, surname, yourFathersName, time, distance);
            }

            int temp = 0;

            for (int write = 0; write < run.Length; write++)
            {
                for (int sort = 0; sort < run.Length - 1; sort++)
                {
                    if (run[sort].Distance > run[sort + 1].Distance)
                        temp = run[sort].Distance;
                    else
                        temp = run[sort + 1].Distance;
                }
            }
            Console.Write(temp);
        }


    }
}
