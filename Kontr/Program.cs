using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontr
{
    class WorkString
    {
        private Stack<string> _stack;
        public Stack<string> Stack { get; set; }

        public WorkString()
        {
        }

        public string ReplaceWords(string str)
        {
            string result = "";
            string[] arr = str.Split(' ');

            _stack = new Stack<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                _stack.Push(arr[i]);
            }

            foreach (Object obj in _stack)
            {
                result += obj + "\n";
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some words");
            string text = Console.ReadLine();
            WorkString word = new WorkString();
            Console.WriteLine(word.ReplaceWords(text));
        }
    }
}
