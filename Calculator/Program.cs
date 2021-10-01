using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 01 : ");
            float no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 02 : ");
            float no2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Opperation : [+, -, *, /, %]");
            string ope = Console.ReadLine();

            Operations oper = new Operations();

            switch (ope)
            {
                case "+":
                    Console.WriteLine("Sumation : {0}", oper.Sum(no1, no2));
                    break;

                //substraction
                
                
                //multiplication
                

                //divition
                

                //remainder
                

                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }

            Console.ReadKey();
        }
    }
}
