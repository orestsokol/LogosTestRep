using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        public int numOfRooms;
        public float area;
        
        public int price;
        public int Price
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
        public float pricePerMetr;
        public float PricePerMetr
        {
             get
            {
                return pricePerMetr;
            }
            set
            {
                pricePerMetr = value;
            }
        }

        public House(int hNumOfRooms, int hPrice, float hArea)
        {
            numOfRooms = hNumOfRooms;
            price = hPrice;
            area = hArea;
            PricePerMetr = hPrice / hArea;
        }

        public void PrintInfo()
        {
            Console.WriteLine("The number of rooms is: " + numOfRooms+"\nprice is: " + price + "\nthe area is: " + area + "\nPrice per metr: "+PricePerMetr);
        }
    }
}
