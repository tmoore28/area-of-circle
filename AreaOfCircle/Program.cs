using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.WriteLine("Enter the radius of the circle.");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("Area of the circle with radius {0} is {1}", radius, area);
        }
    }
}
