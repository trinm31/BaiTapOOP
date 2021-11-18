using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo(3, 5);
            PhanSo p2 = new PhanSo(2, 4);

            PhanSo p3 = p1.Cong(p2);
            
            Console.WriteLine($"{p1.Display()} + {p2.Display()} = {p3.Display()}");
        }
    }
}