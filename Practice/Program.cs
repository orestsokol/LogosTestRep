using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HotelRoom newHRoom = new HotelRoom(3, 3, "Harkiv", 11111, 3);
            newHRoom.PrintInfo();
        }
    }
}
