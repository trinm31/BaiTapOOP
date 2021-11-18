using System;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 5);
            Point p2 = new Point(5, 9);

            double distance = p1.DistanceTo(p2);
            
            Console.WriteLine("Distance: {0}", distance);
        }
    }
}