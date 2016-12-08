using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size off array:");
            int arrSize = int.Parse(Console.ReadLine());

            int[,] arr = new int[arrSize,arrSize];

            Console.WriteLine("Please fill the array with numbers:");
            int mainDiagonalSum = 0;
            int difDiagonalSum = 0;
            
            for(int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                   
                    if (i == j)
                        mainDiagonalSum += arr[i, j];
                }
            }

            int decr = arrSize-1;
            for (int i = 0; i < arrSize; i++)
            {
                for (int j = decr; j > 0; j--)
                {
                    decr--;
                    difDiagonalSum += arr[i, j];
                    break;
                }
            }

            Console.WriteLine("Array is full");

            for (int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(mainDiagonalSum);

            Console.WriteLine(difDiagonalSum);
        }

        
    }
}
