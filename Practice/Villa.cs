using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Villa: LivingPlace
    {
        public int numOfBath;
        public bool hasFontan;  

        public Villa(int hNumOfRooms, int hArea, string hLocation, double hPrice, int hNumOfBath, bool hHasFontan):base(hNumOfRooms,hArea,hLocation,hPrice)
        {
            numOfBath = hNumOfBath;
            hasFontan = hHasFontan;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Number of rooms: " + numOfRooms + "\nLocation: " + location + "\nPrice: " + price + "\nNumber of Bathrooms: " + numOfBath + "\nHas fontan: " + hasFontan);
        }
    }
}
