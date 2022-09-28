using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineEqualTest
{
    class Program
    {
        static void Equalcheck(double a1, double a2, double b1, double b2, double c1,  double c2)
        {
            if (a1 / a2 == b1 / b2  && a1 / a2 == c1 / c2 )
                Console.WriteLine("The given straight lines are equal");

            else
                Console.WriteLine("The given straight lines are not equal");
        }
        static void Main(string[] args)
        {
            double a1 = 3, a2 = 6, b1 = 3, b2 = 4, c1 = 6,c2 = 3;
            Equalcheck(a1, b1, c1, a2, b2, c2);
            Console.Readonly();
        }
        
    }
}



