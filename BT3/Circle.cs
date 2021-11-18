using System;
using System.Drawing;



namespace BT3
{
    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle()
        {
            Center = new Point();
        }

        public Circle(Point point)
        {
            Center = point;
        }

        public Circle(Point point, double radius) : this(point)
        {
            Radius = radius;
        }

        public void Input()
        {
            //Nhap Vao Center
            
            Console.WriteLine("Center: ");
            Center.Input();
            
            Console.WriteLine("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public string GetLocationToPoint(Point point)
        {
            double distance = Center.DistanceTo(point);
            if (distance == Radius)
            {
                return "In Cycle";
            }
            else if (distance > Radius)
            {
                return "Out cycle";
            }
            else
            {
                return "In Cycle";
            }
        }
    }
}