using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    { 
        public string name;
        public string surname;
        public int height;
        public int age;
        public string sex;
        public bool isAlive;

        public Person(string pName, string pSurname)
        {
            name = pName;
            surname = pSurname;
        }

        public Person(string pName, string pSurname, int pHeight)
        {
            name = pName;
            surname = pSurname;
            height = pHeight;
        }

        public Person( string pName, string pSurname,int pHeight, int pAge, string pSex,bool pIsAlive)
        {
            name = pName;
            surname = pSurname;
            height = pHeight;
            age = pAge;
            sex = pSex;
            isAlive = pIsAlive;

        }
    }
}
