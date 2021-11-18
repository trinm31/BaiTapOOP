using System;

namespace BT2
{
    public class Point
    {
        public int Ox { get; set; }
        public int Oy { get; set; }

        public Point()
        {
            
        }

        public Point(int x, int y)
        {
            this.Ox = x;
            this.Oy = y;
        }

        public double DistanceTo(Point another)
        {
            return Math.Sqrt(Math.Pow(Ox - another.Ox, 2) + Math.Pow(Oy - another.Oy, 2));
        }

        public string Display()
        {
            return $"({Ox},{Oy})";
        }

        public void Input()
        {
            Console.WriteLine("Ox = ");
            Ox = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Oy = ");
            Oy = Convert.ToInt32(Console.ReadLine());
        }
    }
}