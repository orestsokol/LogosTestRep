using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        public int id;
        private float price;

        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = (int)value + 1f - 0.01f; 
            }

            
        }

    
        public Product(int mid, float mPrice  = 10.99f)
        {
            
        }

        public void PrintGeneralInfo()
        {
            Console.WriteLine("Id is : {0}? price is: {1}", id, price);
        }
     
    }
}
