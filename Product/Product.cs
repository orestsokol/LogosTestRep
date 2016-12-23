using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        public string name;
        public string category;
        
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

    
        public Product(string pName, string pCategory, float pPrice = 10.99f)
        {
            name = pName;
            category = pCategory;
            Price = pPrice;
        }

        public void PrintGeneralInfo()
        {
            Console.WriteLine("Name: " + name + "\nCategory: " + category + "\nPrice" + price);
        }
     
    }
}
