using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();


            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double squareArea = side * side;
                Console.WriteLine("{0:f3}", squareArea);
            }
            else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double rectangleArea = side1 * side2;
                Console.WriteLine("{0:f3}", rectangleArea);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = 3.14159 * (radius * radius);
                Console.WriteLine("{0:f3}", circleArea);
            }
            else if (figure == "triangle")
            {
                double basis = double.Parse(Console.ReadLine());
                double heights = double.Parse(Console.ReadLine());
                double triangleArea = (basis * heights) / 2;
                Console.WriteLine("{0:f3}", triangleArea);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
