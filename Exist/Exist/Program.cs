using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the numbers by commas");
            string numbers = Console.ReadLine();
            string[] arrOfNumbers = numbers.Split(',');
            Console.WriteLine("Please enter number to search");
           
            int num = int.Parse(Console.ReadLine());
            int searchedIndex = IsExist(arrOfNumbers, num);
            if(searchedIndex > 0)
                Console.WriteLine("Number {0} is on {1} position", num, searchedIndex);
            else 
                Console.WriteLine("Searched number was not found");
        }

        static int IsExist(string[] a, int num)
        {
            int arrSize = a.Length;
            int i;
            bool IsExist = false;
            for (i = 0; i < arrSize; i++)
            {
                if (int.Parse(a[i]) == num)
                {
                    IsExist = true;
                    i++;
                    break;
                }
            }
            return IsExist ?  i: -1;
        }
    }
}
