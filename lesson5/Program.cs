using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {

          //  int arrSize = int.Parse(Console.ReadLine());


           // PrintArray(CreateNewArr(arrSize,1,1));
            //int[] arr = new int[]{1, 2, 3, 4, 5};

            //Console.WriteLine(ArraySum(arr));
            //Math.Abs(1);
            int[] arr = new int {10};

            string line = Console.ReadLine();
            string[] s = line.Split(',');
            int[] nums = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                nums[i] = int.Parse(s[i]);
            }

                GetParameters(nums);
        }

        static void GetParameters(params int[] a)
        {
            
            switch(a.Length)
            {
                case 1:
                    Console.WriteLine("Line with {0} parameters", a[0]);
                    break;
                case 2:
                    Console.WriteLine("Double line");
                    break;
                case 3:
                    Console.WriteLine("Triangle");
                    Console.WriteLine("Size1:{0}",a[0]);
                    Console.WriteLine("Size2:{0}",a[1]);
                    Console.WriteLine("Size3:{0}",a[2]);
                    break;
                case 4:
                    Console.WriteLine("Quatre");
                    Console.WriteLine("Size1:{0}",a[0]);
                    Console.WriteLine("Size2:{0}",a[1]);
                    Console.WriteLine("Size3:{0}",a[2]);
                    Console.WriteLine("Size4:{0}",a[3]);
                    break;
                default:
                    Console.WriteLine("Shit happens");
                    break;
            }

        }

        static void Replace(int[] arr, out int min,out int max )
        {

        }

        static int[] CreateNewArr(int a, int b, int c)
        {
            int[] result = new int[a];

            for(int i=0; i < a; i++)
            {
                result[i] = i;
                
            }
            return result;

        }

        static void PrintArray(int[] a)
        {
            foreach (int i in a)
            {
                System.Console.Write("{0} ", i);
            }
        }

        static int ArraySum(int[] arr)
        {
            int result = 0;
            int arrLength = arr.Length;

            for (int i = 0; i < arrLength; i++ )
            {
                result += arr[i];
            }

            return result;
        }

        static int Abs(int n)
        {
            if(n >= 0)
                return n;
            else
                return -n;
        }
    }
}
