using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AreaOfCircle
    {
        public void CircleArea()
        {
            Console.WriteLine("Enter the Radius of the circle");
            int radius = int.Parse(Console.ReadLine());
            double pi = 3.142;

            double area = pi * radius * radius;

            Console.WriteLine("Area of circle is: " + area);
        }
    }
}
