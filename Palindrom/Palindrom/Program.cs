using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print word:" );
            string word = Console.ReadLine();
            bool isPolin = false;

            int wordLen = word.Length-1;
            int decr = wordLen;
            for (int i = 0; i <= wordLen; i++)
            {
                for (int j = decr; j >= 0; j--)
                {
                    if (word[i] == word[j])
                    {
                        isPolin = true;
                        decr--;
                        break;
                    }
                    else
                    {
                        isPolin = false;
                        Console.WriteLine("Word is not Palindrom");
                        return;
                    }
                }
            }
            if (isPolin)
                Console.WriteLine("Word is Palindrom");
                
        }
    }
}
