using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class LivingPlace
    {
        public int numOfRooms; 
        public string location;
        public double price;

        public int Area{get;set;}

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value - (value % 1000);
            }
        }

        public LivingPlace(int hNumOfRooms, int hArea, string hLocation, double hPrice)
        {
            numOfRooms = hNumOfRooms;
            Area = hArea;
            location = hLocation;
            Price = hPrice;
        }


    }
}
