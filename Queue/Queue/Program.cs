using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> myQ = new Queue<string>();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("IF");
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("IF");
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("IF");

            PrintValues( myQ );

            Console.WriteLine("Queue Contains(\"IF\") = {0}",
            myQ.Contains("IF"));
        }

        public static void PrintValues( IEnumerable myCollection )  
        {
            int howMany = 0;
            foreach (Object obj in myCollection)
            {
                Console.WriteLine("{0}", obj);
                if (obj == "IF")
                    howMany++;

            }
            Console.WriteLine("Queue Contains(\"IF\") = {0} times", howMany);

        }
    }
}

