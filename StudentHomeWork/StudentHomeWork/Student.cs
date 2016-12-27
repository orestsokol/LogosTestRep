using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHomeWork
{
   

    class Student
    {
        private string name;
        private string surname;
        private string yourFathersName;
        private int[] bal;
        private float avrBal;

        public Student(string sName, string sSurname, string sYourFathersName,int[] sBal, float sAvrBal = 0 )
        {
            name = sName;
            surname = sSurname;
            yourFathersName = sYourFathersName;
            bal = sBal;
            avrBal = (sAvrBal == 0) ? CalcAvg(sBal): 0;
        }


        public float CalcAvg(int[] arr)
        {
            float result;
            int sum = 0;
            int arrSize = arr.Length;

            for(int i= 0; i < arrSize; i++)
            {
                sum += arr[i]; 
            }
            result = sum/arrSize;
            return result;
        }

        public void PrintGeneralInfo()
        {
            Console.WriteLine("Name: "+ name +"\nSurname: " + surname + "Your fathers name: " + yourFathersName + "\nAvareg bal: "+ avrBal);
        }

    }
}
