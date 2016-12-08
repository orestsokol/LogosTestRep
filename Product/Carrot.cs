using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Carrot: Product
    {
        public Carrot(int mid, float mprice):base(mid, mprice)
        {
            this.id = mid;
            this.price = mprice;
        }
    }
}
