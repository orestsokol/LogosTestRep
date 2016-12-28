using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Runner
    {
  
        public string Name{ get; set; }
        public string SurName{ get; set; }
        public string YourFathersName{ get; set; }
        public float Time{ get; set; }
        public int Distance{ get; set; }

        public Runner(string rName,string rSurname,string rYourFathersName,float rTime, int rDistance)
        {
            Name = rName;
            SurName = rSurname;
            YourFathersName = rYourFathersName;
            Time = rTime;
            Distance = rDistance;
        }

        public void PrintGeneralInfo()
        {
            Console.WriteLine("Name: "+ Name +"\nSurname:" + SurName + "\nYour fathers Name:" + YourFathersName + "\n Time: " + Time + "Distance: " + Distance);
        }


    }
}
