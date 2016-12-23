using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Similar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write size of first matrix");
            int frstMatrSize = int.Parse(Console.ReadLine());
            int[,] firstMatr = new int[frstMatrSize, frstMatrSize];

            Console.WriteLine("Write size of second matrix");
            int secodMatrSize = int.Parse(Console.ReadLine());
            int[,] secMatr = new int[secodMatrSize, secodMatrSize];

            Console.WriteLine("Please fill first matrix");
            firstMatr = Fill(firstMatr, frstMatrSize);

            Console.WriteLine("Please fill second matrix");
            secMatr = Fill(secMatr, secodMatrSize);

            Console.WriteLine(SimilarMatrix(firstMatr, secMatr, frstMatrSize, secodMatrSize));

            PrintInfo(firstMatr, frstMatrSize);
            PrintInfo(secMatr, secodMatrSize);

           
        }

        static double SimilarMatrix(int[,] a, int[,] b, int aSize, int bSize)
        {
            double result = 0;
            int arrALen = a.Length;
            int arrBLen = b.Length;
            double per = 100 / arrALen;

            for (int i = 0; i < aSize && i < bSize; i++)
            {
                for (int j = 0; j < aSize && j < bSize; j++)
                {
                    if (a[i, j] == b[i, j])
                        result += per;
                }
            }
            return result;
        }

        static int[,] Fill(int[,] a, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return a;
        }

        static void PrintInfo(int[,] a,int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(a[i, j] + " "); 
                }
                Console.WriteLine();
            }
        }

    }
}
