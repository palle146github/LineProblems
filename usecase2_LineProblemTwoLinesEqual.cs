using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usecase1_LineProblem_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, x3, y3, x4, y4;
            double LengthLine1, LengthLine2;
            // taking input from the user: rectangular coordinates of Line1
            Console.WriteLine("Enter x1 co-ordinate of point 1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 co-ordinate of point 1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 co-ordinate of point 2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 co-ordinate of point 2");
            y2 = Convert.ToInt32(Console.ReadLine());
            LengthLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of the Line first is = " + LengthLine1);
            // taking input from the user: rectangular coordinates of Line2
            Console.WriteLine("Enter x1 co-ordinate of point 3");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 co-ordinate of point 3");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 co-ordinate of point 4");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 co-ordinate of point 4");
            y4 = Convert.ToInt32(Console.ReadLine());
            LengthLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of the second Line is = " + LengthLine2);
            if(LengthLine1==LengthLine2)
            {
                Console.WriteLine("\nTwo lines are equal");

            }
            else
            {
                Console.WriteLine("\nTwo lines are not quale");
            }
            Console.ReadLine();
        }
    }
}
