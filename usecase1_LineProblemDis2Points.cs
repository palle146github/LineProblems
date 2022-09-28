using System;

namespace Project2
{
    class lineproblem1
    {
        // Function to calculate distance
        static double distance(int x1, int y1, int x2, int y2)
        {
            // Calculating distance
            return Math.Sqrt(Math.Pow(x2 - x1, 2) +
                          Math.Pow(y2 - y1, 2));
        }

        // Driver code
        public static void Main()
        {
            Console.WriteLine("Distance between the two points is " + distance(3, 4, 4, 3));
        }
    }
}