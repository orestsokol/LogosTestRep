using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fraction:FullNum
    {
        private int n;
        private float m;
        private float fullNum;

        public float FullNum 
        {
            get {
                return fullNum;
            }
            set {
                fullNum = value;
            }
        }

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }

        public float M
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
            }
        }

        public Fraction(int fInt = 0, float fFloat = 0):base(fInt)
        {
            n = fInt;
            m = fFloat;
        }

        public float Add(float fN, float fM)
        {
            float result = 0;
            int resultInt = 0;
            int fNPart1 = (int)fN;
            float fNPart2 = fN- fNPart1;
            int fMPart1 = (int)fM;
            float fMPart2 =fM - fMPart1;

            result = fNPart2 + fMPart2;
             if(result > 1)
             {
                 resultInt += 1;
                 result -= 1;
             }

            resultInt = fNPart1 + fMPart1;
            result += resultInt;
            return result;
        }

        public float Divide(float fN, float fM)
        {
            float result = 0;
            int resultInt = 0;
            int fNPart1 = (int)fN;
            float fNPart2 = fN - fNPart1;
            int fMPart1 = (int)fM;
            float fMPart2 = fM - fMPart1;

            result = fNPart2 / fMPart2;
            if (result >= 1)
            {
                resultInt += 1;
                result -= 1;
            }
            if (resultInt == 1)
                return fMPart1;
            else
                resultInt += fNPart1 / fMPart1;

            result += resultInt;
            return result;
        }

        public float Multiply(float fN, float fM)
        {
            float result = 0;
            int resultInt = 0;
            int fNPart1 = (int)fN;
            float fNPart2 = fN - fNPart1;
            int fMPart1 = (int)fM;
            float fMPart2 = fM - fMPart1;

            result = fNPart2 * fMPart2;
            if (result > 1)
            {
                resultInt += 1;
                result -= 1;
            }

            resultInt = fNPart1 * fMPart1;
            result += resultInt;
            return result;
        }

        public bool Compare(float fN, float fM)
        {
            bool result = false;
            if (fN > fM)
                result = true;
            else if(fM > fN)
                result = true;
            else
                result = false;

            return result;
        }

    }
}
