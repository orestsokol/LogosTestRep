using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Error
{
    class Program
    {
        class SpaceNotExeption:FormatException
        {
            public SpaceNotExeption(): base("Space not found")
            {

            }
        }

        class ActionExeption : FormatException
        {
            public ActionExeption(): base("Action is not in a scope")
            {

            }
        }

        class NotAnIntExeption : FormatException
        {
            public NotAnIntExeption()
                : base("Please enter number")
            {

            }
        }


     

        static void Main(string[] args)
        {
            Console.WriteLine("Enter what you want to do");

            FileStream flStr = new FileStream("D:\\orest.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWrt = new StreamWriter(flStr);

            FileStream rdStr = new FileStream("D:\\logos.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamRd = new StreamReader(rdStr);

            while (!streamRd.EndOfStream)
            {
                string mes = streamRd.ReadLine();
                int sum=0;
                string result = "";
                try
                {
                    string[] arr = mes.Split(' ');
                    if (arr.Length < 2)
                        throw new SpaceNotExeption();
                    else
                    {
                        string symbol = arr[1];
                        switch (symbol)
                        {
                            case "+":
                                sum = int.Parse(arr[0]) + int.Parse(arr[2]);
                                break;
                            case "-":
                                sum = int.Parse(arr[0]) - int.Parse(arr[2]);
                                break;
                            case "*":
                                sum = int.Parse(arr[0]) * int.Parse(arr[2]);
                                break;
                            case "/":
                                sum = int.Parse(arr[0]) / int.Parse(arr[2]);
                                break;
                            default:
                                throw new ActionExeption();
                        }
                        result = mes + " = " + sum;
                        Console.WriteLine(result);
                      
                        streamWrt.WriteLine(result);     
                    } 
                }
                catch (Exception e)
                {
                    if (e is ActionExeption)
                    {
                        Console.WriteLine(e.Message);
                    }
                    if (e is SpaceNotExeption)
                    {
                        Console.WriteLine(e.Message);
                    }
                    if (e is FormatException)
                    {
                        NotAnIntExeption err = new NotAnIntExeption();
                        Console.WriteLine(err.Message);
                    }
                }
            }
            streamRd.Close();
            streamWrt.Close();
        }
       
    }
}
