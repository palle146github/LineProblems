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
            int x1, x2, y1, y2;
            double length;
            // taking input from the user: rectangular coordinates of Line
            Console.WriteLine("Enter x1 co-ordinate of point 1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 co-ordinate of point 1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 co-ordinate of point 2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 co-ordinate of point 2");
            y2 = Convert.ToInt32(Console.ReadLine());
            length= Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of the Line is = "+length);
            Console.ReadLine();     
        }
    }
}
