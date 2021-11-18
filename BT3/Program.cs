using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 5);

            Circle c = new Circle(p1, 5);

            Point a = new Point(5, 7);

            var result = c.GetLocationToPoint(a);
            Console.WriteLine(result);
        }
    }
}