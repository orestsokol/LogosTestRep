using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number per commas");
            string stringWithBals = Console.ReadLine();
            string[] arrAvgBal = stringWithBals.Split(',');
            int[] arrBal = new int[arrAvgBal.Length];
            arrBal = ParseArr(arrAvgBal);
            Student ivan = new Student("Ivan", "Dupa", "Vasilovich", arrBal);
            ivan.PrintGeneralInfo();
        }

        static int[] ParseArr(string[] a)
        {
            int arrSize = a.Length;
            int[] result = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                result[i] = int.Parse(a[i]);
            }
            return result;
        }
    }
}
