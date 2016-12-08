using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Computer: Product
    {
        public string name;
        public string proc;
        public bool touchScreen;
        public float price;
        public Display display;

        public Computer( string mname, string mproc, bool mTouchSreen, float mprice):base(2121515, mprice)
        {
            name = mname;
            proc = mproc;
            touchScreen = mTouchSreen;
            price = mprice;
            display = 
            
        }

        public override string ToString()
        {
            return "Name: " + name + "\nProc:" + proc + "\nTouchScreen" + touchScreen + "\nPrice" + price;
        }
    }
}
