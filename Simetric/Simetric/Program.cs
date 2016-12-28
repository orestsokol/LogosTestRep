//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Rextester
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Please Enter line of numbers with 0 in middle");
            Stack<string> myStack = new Stack<string>();
            int middle = 0;
            bool isSem = true;
            string mess = Console.ReadLine();
            myStack.Push(mess);
            int lenOfNum = myStack.Count;
            foreach (string str in myStack)
            {
                int lenOfStr = str.Length;
                for (int i = 0; i < lenOfStr; i++)
                {
                    if (str[i] == '0')
                    {
                        middle = i;
                        break;
                    }
                }
                int j = lenOfStr-1;
                for (int i = 0; i < middle ; i++)
                {
                    if (str[i] != str[j])
                    {
                        isSem = false;
                        break;
                    }
                    j--;
                }
            }
            Console.WriteLine(mess + " is " + isSem);
        }
    }
}