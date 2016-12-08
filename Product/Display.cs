using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Display: Product
    {
        public string model;
        public int width;
        public int height;
        public float price;

        public string Resolution
        {
            get
            {
                return width + "x" + height;
            }
            set
            {

            }
        }

        public Display(string mModel, int mWidth, int mHeight, float mPrice): base(9999, mPrice)
        {
            model = mModel;
            width = mWidth;
            height = mHeight;
            price = mPrice;
        }
    }
}
