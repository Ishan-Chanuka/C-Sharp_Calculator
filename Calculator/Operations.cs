using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operations
    {
        public float Sum(float num1, float num2)
        {
            float sum = num1 + num2;

            return sum;
        }

        public float Sub(float num1, float num2)
        {
            float sub = num1 - num2;

            return sub;
        }

        public float Divi(float num1, float num2)
        {
            float divi = num1 / num2;

            return divi;
        }

        public float Multi(float num1, float num2)
        {
            float multi = num1 * num2;

            return multi;
        }

        public float Rem(float num1, float num2)
        {
            float rem = num1 % num2;

            return rem;
        }
    }
}
