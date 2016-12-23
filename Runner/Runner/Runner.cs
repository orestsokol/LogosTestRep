using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Runner
    {
        private string name;
        private string surName;
        private string yourFathersName;
        private float time;
        private int distance;

        public Runner(string rName,string rSurname,string rYourFathersName,float rTime, int rDistance)
        {
            name = rName;
            surName = rSurname;
            yourFathersName = rYourFathersName;
            time = rTime;
            distance = rDistance;
        }

        public void PrintGeneralInfo()
        {
            Console.WriteLine("Name: "+ name +"\nSurname:" + surName + "\nYour fathers Name:" + yourFathersName + "\n Time: " + time + "Distance: " + distance);
        }


    }
}
