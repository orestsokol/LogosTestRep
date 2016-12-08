using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class HotelRoom:LivingPlace
    {
        public int numOfPlaces;
        private double pricePerPlace;

        public double PricePerPlace
        {
            get
            {
                return pricePerPlace;
            }
            set
            {
                pricePerPlace = value;
            }
        }

        public new double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public HotelRoom(int hNumOfRooms, int hArea, string hLocation, double hPrice, int hNumOfPlaces)
            : base(hNumOfRooms, hArea, hLocation, hPrice)
        {
            PricePerPlace = hPrice/hNumOfPlaces;
            numOfPlaces = hNumOfPlaces;
        }

        public new void PrintInfo()
        {
            Console.WriteLine("Number of rooms: " + numOfRooms + "\nLocation: " + location + "\nPrice: " + price + "\nNumber of Places: " + numOfPlaces + "\nPrice Per Place: " + Math.Round(pricePerPlace,0));
        }
    }
}
